
namespace MailSender
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonBrowseTemplate = new System.Windows.Forms.Button();
            this.buttonBrowseCSV = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSend = new System.Windows.Forms.Button();
            this.textBoxTemplate = new System.Windows.Forms.TextBox();
            this.textBoxCSV = new System.Windows.Forms.TextBox();
            this.openFileDialogTemplate = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialogCSV = new System.Windows.Forms.OpenFileDialog();
            this.textBoxSubject = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonConfig = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxFrom = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonBrowseTemplate
            // 
            this.buttonBrowseTemplate.Location = new System.Drawing.Point(320, 196);
            this.buttonBrowseTemplate.Name = "buttonBrowseTemplate";
            this.buttonBrowseTemplate.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowseTemplate.TabIndex = 5;
            this.buttonBrowseTemplate.Text = "開く...";
            this.buttonBrowseTemplate.UseVisualStyleBackColor = true;
            this.buttonBrowseTemplate.Click += new System.EventHandler(this.ButtonBrowseTemplate_Click);
            // 
            // buttonBrowseCSV
            // 
            this.buttonBrowseCSV.Location = new System.Drawing.Point(320, 250);
            this.buttonBrowseCSV.Name = "buttonBrowseCSV";
            this.buttonBrowseCSV.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowseCSV.TabIndex = 7;
            this.buttonBrowseCSV.Text = "開く...";
            this.buttonBrowseCSV.UseVisualStyleBackColor = true;
            this.buttonBrowseCSV.Click += new System.EventHandler(this.ButtonBrowseCSV_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 15);
            this.label1.TabIndex = 100;
            this.label1.Text = "テンプレートファイル";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 100;
            this.label2.Text = "CSVファイル";
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(320, 302);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(75, 23);
            this.buttonSend.TabIndex = 9;
            this.buttonSend.Text = "送信(&S)";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.ButtonSend_Click);
            // 
            // textBoxTemplate
            // 
            this.textBoxTemplate.Location = new System.Drawing.Point(12, 196);
            this.textBoxTemplate.MaxLength = 1023;
            this.textBoxTemplate.Name = "textBoxTemplate";
            this.textBoxTemplate.Size = new System.Drawing.Size(302, 23);
            this.textBoxTemplate.TabIndex = 4;
            // 
            // textBoxCSV
            // 
            this.textBoxCSV.Location = new System.Drawing.Point(12, 250);
            this.textBoxCSV.MaxLength = 1023;
            this.textBoxCSV.Name = "textBoxCSV";
            this.textBoxCSV.Size = new System.Drawing.Size(302, 23);
            this.textBoxCSV.TabIndex = 6;
            // 
            // openFileDialogTemplate
            // 
            this.openFileDialogTemplate.Filter = "テキストファイル|*txt|すべてのファイル|*.*";
            // 
            // openFileDialogCSV
            // 
            this.openFileDialogCSV.Filter = "CSVファイル|*csv|すべてのファイル|*.*";
            // 
            // textBoxSubject
            // 
            this.textBoxSubject.Location = new System.Drawing.Point(12, 142);
            this.textBoxSubject.MaxLength = 255;
            this.textBoxSubject.Name = "textBoxSubject";
            this.textBoxSubject.Size = new System.Drawing.Size(302, 23);
            this.textBoxSubject.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 100;
            this.label3.Text = "タイトル";
            // 
            // buttonConfig
            // 
            this.buttonConfig.Location = new System.Drawing.Point(239, 302);
            this.buttonConfig.Name = "buttonConfig";
            this.buttonConfig.Size = new System.Drawing.Size(75, 23);
            this.buttonConfig.TabIndex = 8;
            this.buttonConfig.Text = "設定...";
            this.buttonConfig.UseVisualStyleBackColor = true;
            this.buttonConfig.Click += new System.EventHandler(this.buttonConfig_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 100;
            this.label4.Text = "差出人名";
            // 
            // textBoxName
            // 
            this.textBoxName.Enabled = false;
            this.textBoxName.Location = new System.Drawing.Point(12, 34);
            this.textBoxName.MaxLength = 255;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(302, 23);
            this.textBoxName.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 15);
            this.label5.TabIndex = 100;
            this.label5.Text = "差出人アドレス";
            // 
            // textBoxFrom
            // 
            this.textBoxFrom.Enabled = false;
            this.textBoxFrom.Location = new System.Drawing.Point(12, 88);
            this.textBoxFrom.MaxLength = 255;
            this.textBoxFrom.Name = "textBoxFrom";
            this.textBoxFrom.Size = new System.Drawing.Size(302, 23);
            this.textBoxFrom.TabIndex = 2;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar,
            this.toolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 355);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(407, 22);
            this.statusStrip1.TabIndex = 101;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar
            // 
            this.toolStripProgressBar.Name = "toolStripProgressBar";
            this.toolStripProgressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(122, 17);
            this.toolStripStatusLabel.Text = "これが見えたらおかしいよ";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 377);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxFrom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonConfig);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxSubject);
            this.Controls.Add(this.textBoxCSV);
            this.Controls.Add(this.textBoxTemplate);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBrowseCSV);
            this.Controls.Add(this.buttonBrowseTemplate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "メール送信ツール";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBrowseTemplate;
        private System.Windows.Forms.Button buttonBrowseCSV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.TextBox textBoxTemplate;
        private System.Windows.Forms.TextBox textBoxCSV;
        private System.Windows.Forms.OpenFileDialog openFileDialogTemplate;
        private System.Windows.Forms.OpenFileDialog openFileDialogCSV;
        private System.Windows.Forms.TextBox textBoxSubject;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonConfig;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxFrom;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
    }
}

