using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MailSender {
    public partial class FormMain : Form
    {
        private readonly string logfile = "log.txt";
        private readonly object countLock = new();
        private int count;
        private int total;


        public FormMain()
        {
            InitializeComponent();
            Logger.Init(logfile);
            comboBoxSubject.Items.AddRange(History.GetSubjects().Reverse().ToArray());
            textBoxName.Text = MailConfig.Name;
            textBoxFrom.Text = MailConfig.From;
            toolStripStatusLabel.Text = "";
        }

        private void ButtonBrowseTemplate_Click(object sender, EventArgs e)
        {
            var result = openFileDialogTemplate.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBoxTemplate.Text = openFileDialogTemplate.FileName;
            }
        }

        private void ButtonBrowseCSV_Click(object sender, EventArgs e)
        {
            var result = openFileDialogCSV.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBoxCSV.Text = openFileDialogCSV.FileName;
            }
        }

        private void buttonConfig_Click(object sender, EventArgs e)
        {
            FormConfig.Open();
            textBoxName.Text = MailConfig.Name;
            textBoxFrom.Text = MailConfig.From;
            UpdateHistory("");
        }

        private void ButtonSend_Click(object sender, EventArgs e)
        {
            if (textBoxTemplate.Text == "")
            {
                MessageBox.Show(Message.PleaseSpecifyTemplateFile);
                return;
            }
            if (textBoxCSV.Text == "")
            {
                MessageBox.Show(Message.PleaseSpecifyCSVFile);
                return;
            }

            // ファイル読み込み
            var template = ReadTemplate();
            if (template == null)
            {
                MessageBox.Show(string.Format(Message.V0DoesNotExist, textBoxTemplate.Text));
                return;
            }

            var csv = ReadCSV();
            if (csv == null)
            {
                MessageBox.Show(string.Format(Message.V0DoesNotExist, textBoxCSV.Text));
                return;
            }

            if (csv.RowCount <= 1)
            {
                MessageBox.Show(Message.CSVFileIsInvalid);
                return;
            }

            //ドメインチェック
            if (!CheckDomains(csv)) {
                return;
            }

            // 確認ダイアログ表示
            var result = OpenConfirmDialog(csv, comboBoxSubject.Text, template);
            if ( result == DialogResult.Cancel)
            {
                return;
            }

            // メール送信処理
            SendMail(csv, template);

            // タイトルの履歴を更新
            UpdateHistory(comboBoxSubject.Text);
        }

        // メールアドレスからドメインのみを抽出する
        private string ExtractDomain(string address) {
            var s = address.Split('@');
            return s[s.Length - 1];
        }

        private bool CheckDomains(CSVData csv) {
            if (!MailConfig.DomainCheck) {
                return true;
            }

            var range = Enumerable.Range(1, csv.RowCount - 1);
            var builder = new StringBuilder(Message.UnregisteredDomainsContained);
            var check = false;
            foreach(var i in range) {
                var to = csv.GetElement(i, 0);
                var domain = ExtractDomain(to);
                if (MailConfig.DomainList.Contains(domain)) {
                    continue;
                }
                check = true;
                builder.Append("\n");
                builder.Append(to);
            }

            if (!check) {
                return true;
            }

            var result = MessageBox.Show(builder.ToString(), "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            return result == DialogResult.OK;
        }

        private string ReadTemplate()
        {
            if (!File.Exists(textBoxTemplate.Text))
            {
                return null;
            }
            using (var sr = new StreamReader(textBoxTemplate.Text))
            {
                return sr.ReadToEnd();
            }
        }

        private CSVData ReadCSV()
        {
            if (!File.Exists(textBoxCSV.Text))
            {
                return null;
            }
            var cr = new CSVReader();
            return cr.ReadCSV(textBoxCSV.Text);
        }

        private DialogResult OpenConfirmDialog(CSVData csv, string subject, string template) {
            var text = template;
            var sub = subject;
            var range = Enumerable.Range(1, csv.ColCount - 1);
            foreach (var c in range) {
                var args = csv.GetRowRange(1, 1);
                text = string.Format(text, args.ToArray());
                subject = string.Format(subject, args.ToArray());
            }

            return FormConfirm.Open(sub, text);
        }

        private void SendMail(CSVData csv, string template) {
            total = csv.RowCount - 1;
            count = 0;
            var rrange = Enumerable.Range(1, csv.RowCount - 1);

            Invoke((Action)(() => {
                toolStripStatusLabel.Text = string.Format(Message.MailSending0SlashV0, total);
                toolStripProgressBar.Maximum = total;
                Update();
            }));

            foreach (var r in rrange) {
                var to = csv.GetElement(r, 0);
                if (to == "") {
                    continue;
                }

                var temp = template;
                var subject = comboBoxSubject.Text;
                var crange = Enumerable.Range(1, csv.ColCount - 1);
                foreach (var c in crange) {
                    var args = csv.GetRowRange(r, 1);
                    temp = string.Format(temp, args.ToArray());
                    subject = string.Format(subject, args.ToArray());
                }
                SendMailAsync(
                    MailConfig.Name, // 差出人名
                    MailConfig.From, // 差出人アドレス
                    to, // 送信先アドレス
                    subject, // タイトル
                    temp // 本文
                    );
            }
        }

        private async void SendMailAsync(string name, string from, string to, string subject, string text)
        {
            try
            {
                // MimeMessageを作り、宛先やタイトルなどを設定する
                var message = new MimeKit.MimeMessage();
                message.From.Add(new MimeKit.MailboxAddress(name, from));
                message.To.Add(new MimeKit.MailboxAddress("", to));
                message.Subject = subject;

                // 本文
                var textPart = new MimeKit.TextPart(MimeKit.Text.TextFormat.Plain);
                textPart.Text = text;

                // MimeMessageを完成させる
                message.Body = textPart;

                if (!Option.Dryrun) {
                    // SMTPサーバに接続してメールを送信する
                    using (var client = new MailKit.Net.Smtp.SmtpClient()) {
                        await client.ConnectAsync(MailConfig.Server, MailConfig.Port);
                        await client.AuthenticateAsync(MailConfig.User, MailConfig.Password); // SMTPサーバがユーザー認証を必要としない場合は不要
                        await client.SendAsync(message);
                        await client.DisconnectAsync(true);


                    }
                }
                Logger.Info(string.Format(Message.SentEmailToV0, to));
            }
            catch (Exception)
            {
                Logger.Error(string.Format(Message.FailedToSendEmailToV0, to));
            }

            lock (countLock)
            {
                count++;
                Invoke((Action)(() =>
                {
                    if (count == total)
                    {
                        toolStripStatusLabel.Text = Message.Complete;
                    }
                    else
                    {
                        toolStripStatusLabel.Text = string.Format(Message.MailSendingV0SlashV1, count, total);
                    }
                    toolStripProgressBar.Value = count;
                    Update();
                }));
            }
        }

        private void UpdateHistory(string subject) {
            History.UpdateSubjects(subject);
            History.Save();

            comboBoxSubject.Items.Clear();
            comboBoxSubject.Items.AddRange(History.GetSubjects().Reverse().ToArray());
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Logger.Close();
        }
    }
}
