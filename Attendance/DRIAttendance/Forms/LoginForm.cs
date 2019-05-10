using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DRIAttendance.Forms;
using DRIAttendance.Models;

namespace DRIAttendance.Forms
{
    public partial class LoginForm : Form
    {
        public DRIAttendanceEntities2 db = new DRIAttendanceEntities2();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text)||string.IsNullOrEmpty(txt_surname.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("İnputları doldurun!");
                return;
            }

            Admin lgnAdmin = db.Admins.FirstOrDefault(a => a.Name == txtName.Text && a.Surname == txt_surname.Text);

            User lgnUser = db.Users.FirstOrDefault(u => u.Name == txtName.Text && u.Surname == txt_surname.Text);


            if (lgnAdmin==null && lgnUser == null)
            {
                MessageBox.Show("İstifadəçi tapılmadı");
                return;
            }
            if (lgnUser != null && lgnAdmin == null)
            {
                if (txtPassword.Text != lgnUser.Password)
                {
                    MessageBox.Show("Şifrə yalnışdır!");
                    return;
                }
                lgnUser.IsOnline = true;
                db.SaveChanges();
            }
            if (lgnUser == null && lgnAdmin != null)
            {
                if (txtPassword.Text != lgnAdmin.Password)
                {
                    MessageBox.Show("Şifrə yalnışdır!");
                    return;
                }
                lgnAdmin.IsOnline = true;
                db.SaveChanges();
            }

            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();

            registerForm.ShowDialog();
        }
    }
}
