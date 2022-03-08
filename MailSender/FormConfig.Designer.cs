
namespace MailSender
{
    partial class FormConfig
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxServer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxFrom = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.checkBoxDomainCheck = new System.Windows.Forms.CheckBox();
            this.dataGridViewDomain = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDomain)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(360, 322);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(94, 31);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "キャンセル";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(260, 322);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(94, 31);
            this.buttonOK.TabIndex = 6;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 100;
            this.label1.Text = "SMTPサーバー";
            // 
            // textBoxServer
            // 
            this.textBoxServer.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.textBoxServer.Location = new System.Drawing.Point(113, 80);
            this.textBoxServer.MaxLength = 255;
            this.textBoxServer.Name = "textBoxServer";
            this.textBoxServer.Size = new System.Drawing.Size(298, 23);
            this.textBoxServer.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 100;
            this.label2.Text = "ポート番号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 100;
            this.label3.Text = "ユーザー名";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 100;
            this.label4.Text = "パスワード";
            // 
            // textBoxPort
            // 
            this.textBoxPort.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.textBoxPort.Location = new System.Drawing.Point(113, 109);
            this.textBoxPort.MaxLength = 5;
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(298, 23);
            this.textBoxPort.TabIndex = 3;
            this.textBoxPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxPort_KeyPress);
            // 
            // textBoxUser
            // 
            this.textBoxUser.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.textBoxUser.Location = new System.Drawing.Point(113, 138);
            this.textBoxUser.MaxLength = 255;
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(298, 23);
            this.textBoxUser.TabIndex = 4;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.textBoxPassword.Location = new System.Drawing.Point(113, 167);
            this.textBoxPassword.MaxLength = 255;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(298, 23);
            this.textBoxPassword.TabIndex = 5;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 15);
            this.label5.TabIndex = 100;
            this.label5.Text = "差出人アドレス";
            // 
            // textBoxFrom
            // 
            this.textBoxFrom.Location = new System.Drawing.Point(113, 49);
            this.textBoxFrom.MaxLength = 255;
            this.textBoxFrom.Name = "textBoxFrom";
            this.textBoxFrom.Size = new System.Drawing.Size(298, 23);
            this.textBoxFrom.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 15);
            this.label6.TabIndex = 100;
            this.label6.Text = "差出人名";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(113, 20);
            this.textBoxName.MaxLength = 255;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(298, 23);
            this.textBoxName.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(446, 276);
            this.tabControl1.TabIndex = 101;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBoxName);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textBoxFrom);
            this.tabPage1.Controls.Add(this.textBoxServer);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.textBoxPassword);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.textBoxUser);
            this.tabPage1.Controls.Add(this.textBoxPort);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(438, 248);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "全般";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.checkBoxDomainCheck);
            this.tabPage2.Controls.Add(this.dataGridViewDomain);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(438, 248);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ドメイン";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // checkBoxDomainCheck
            // 
            this.checkBoxDomainCheck.AutoSize = true;
            this.checkBoxDomainCheck.Location = new System.Drawing.Point(8, 11);
            this.checkBoxDomainCheck.Name = "checkBoxDomainCheck";
            this.checkBoxDomainCheck.Size = new System.Drawing.Size(330, 19);
            this.checkBoxDomainCheck.TabIndex = 0;
            this.checkBoxDomainCheck.Text = "登録されていないドメインにメールを送信するとき、警告を表示する";
            this.checkBoxDomainCheck.UseVisualStyleBackColor = true;
            this.checkBoxDomainCheck.CheckedChanged += new System.EventHandler(this.CheckBoxDomainCheck_CheckedChanged);
            // 
            // dataGridViewDomain
            // 
            this.dataGridViewDomain.AllowUserToResizeRows = false;
            this.dataGridViewDomain.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewDomain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDomain.Location = new System.Drawing.Point(6, 36);
            this.dataGridViewDomain.Name = "dataGridViewDomain";
            this.dataGridViewDomain.RowHeadersVisible = false;
            this.dataGridViewDomain.RowHeadersWidth = 40;
            this.dataGridViewDomain.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewDomain.RowTemplate.Height = 25;
            this.dataGridViewDomain.Size = new System.Drawing.Size(426, 206);
            this.dataGridViewDomain.TabIndex = 1;
            // 
            // FormConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 393);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormConfig";
            this.Text = "設定";
            this.Load += new System.EventHandler(this.FormConfig_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDomain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxServer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxFrom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridViewDomain;
        private System.Windows.Forms.CheckBox checkBoxDomainCheck;
    }
}