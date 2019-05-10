using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using DRIAttendance.Models;

namespace DRIAttendance.Forms
{
    public partial class MailForm : Form
    {
        DRIAttendanceEntities2 db = new DRIAttendanceEntities2();
        Mail mail = new Mail();

        public MailForm()
        {
            InitializeComponent();
        }

        private void MailForm_Load(object sender, EventArgs e)
        {
            mail = db.Mails.First();

            txtFrom.Text = mail.From;
            txtTo.Text = mail.To;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            mail = db.Mails.First();

            if (string.IsNullOrEmpty(txtFrom.Text)||string.IsNullOrEmpty(txtTo.Text)||string.IsNullOrEmpty(txt_password.Text))
            {
                MessageBox.Show("Xanalar boş qala bilməz!");
                return;
            }
            mail.From = txtFrom.Text;
            mail.To = txtTo.Text;
            mail.Password = txt_password.Text;
            db.SaveChanges();
            MessageBox.Show("Dəyişikliklər saxlanıldı!!");
        }
    }
}
