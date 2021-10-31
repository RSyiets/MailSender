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
    public partial class FormConfirm : Form
    {
        private static FormConfirm frm;

        private DialogResult result;

        public FormConfirm()
        {
            InitializeComponent();
        }

        public static DialogResult Open(string subject, string text)
        {
            if (frm == null)
            {
                frm = new FormConfirm();
            }

            frm.result = DialogResult.Cancel;
            frm.textBoxMain.Text = text;
            if (subject == "")
            {
                frm.labelSubject.Text = Message.SubjectIsNotInput;
                frm.labelSubject.ForeColor = Color.Red;
            }
            else
            {
                frm.labelSubject.Text = subject;
                frm.labelSubject.ForeColor = Color.Black;
            }

            frm.ShowDialog();

            return frm.result;
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            result = DialogResult.OK;
            Close();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
