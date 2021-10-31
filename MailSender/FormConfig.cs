using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailSender
{
    public partial class FormConfig : Form
    {
        private static FormConfig frm;

        private FormConfig()
        {
            InitializeComponent();
        }

        public static void Open()
        {
            if (frm == null)
            {
                frm = new FormConfig();
            }
            frm.textBoxName.Text = MailConfig.Name;
            frm.textBoxFrom.Text = MailConfig.From;
            frm.textBoxServer.Text = MailConfig.Server;
            frm.textBoxPort.Text = MailConfig.Port.ToString();
            frm.textBoxUser.Text = MailConfig.User;
            frm.textBoxPassword.Text = MailConfig.Password;
            frm.ShowDialog();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            int port;
            if (!int.TryParse(textBoxPort.Text, out port))
            {
                MessageBox.Show(Message.PortNumberIsInvalid);
                return;
            }

            MailConfig.Name = textBoxName.Text;
            MailConfig.From = textBoxFrom.Text;
            MailConfig.Server = textBoxServer.Text;
            MailConfig.Port = port;
            MailConfig.User = textBoxUser.Text;
            MailConfig.Password = textBoxPassword.Text;
            MailConfig.Save();

            Hide();
        }

        private void TextBoxPort_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar != '\b' && (e.KeyChar < '0' || e.KeyChar > '9'))
            {
                e.Handled = true;
            }
        }
    }
}
