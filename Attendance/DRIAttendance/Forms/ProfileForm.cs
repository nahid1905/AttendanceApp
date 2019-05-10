using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DRIAttendance.Models;

namespace DRIAttendance.Forms
{
    public partial class ProfileForm : Form
    {
        DRIAttendanceEntities2 db = new DRIAttendanceEntities2();

        Admin currentAdmin;
        User currentUser;

        public ProfileForm()
        {
            InitializeComponent();
            Security();
        }

        public void Security()
        {
            currentAdmin = db.Admins.FirstOrDefault(a => a.IsOnline == true);
            currentUser = db.Users.FirstOrDefault(a => a.IsOnline == true);

            if (currentAdmin == null)
            {
                if (currentUser != null)
                {
                    groubBox.Text = currentUser.Name + " " + currentUser.Surname;
                }
            }
            else
            {
                groubBox.Text = currentAdmin.Name + " " + currentAdmin.Surname;
            }
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_oldPas.Text)||string.IsNullOrEmpty(txt_newPas.Text)||string.IsNullOrEmpty(txt_rePas.Text))
            {
                MessageBox.Show("Xanaları doldurun!");
                return;
            }
            else
            {
                // ADMİN GİRİŞİ
                if (currentAdmin!=null)
                {
                    if (txt_oldPas.Text == currentAdmin.Password)
                    {
                        if (txt_newPas.Text == txt_rePas.Text)
                        {
                            currentAdmin.Password = txt_newPas.Text;
                            db.SaveChanges();
                            MessageBox.Show("Parolunuz uğurla dəyişdirildi!");
                            txt_oldPas.Text = "";
                            txt_newPas.Text = "";
                            txt_rePas.Text = "";
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Yeni parolu düzgün təkrarlayın!!");
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mövcud parolu səhv daxil etmisiniz!!");
                        return;
                    }
                }

                // USER GİRİŞİ
                if (currentUser != null)
                {
                    if (txt_oldPas.Text == currentUser.Password)
                    {
                        if (txt_newPas.Text == txt_rePas.Text)
                        {
                            currentUser.Password = txt_newPas.Text;
                            db.SaveChanges();
                            MessageBox.Show("Parolunuz uğurla dəyişdirildi!");
                            txt_oldPas.Text = "";
                            txt_newPas.Text = "";
                            txt_rePas.Text = "";
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Yeni parolu düzgün təkrarlayın!!");
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mövcud parolu səhv daxil etmisiniz!!");
                        return;
                    }
                }
            }
        }
    }
}
