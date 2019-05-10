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
    public partial class RegisterForm : Form
    {
        public DRIAttendanceEntities2 db = new DRIAttendanceEntities2();

        public RegisterForm()
        {
            InitializeComponent();
            FillCmb();
        }

        public void FillCmb()
        {
            List<Position> pos = db.Positions.ToList();

            foreach (Position item in pos)
            {
                cmbPosition.Items.Add(item.Name);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text)||string.IsNullOrEmpty(txtSurname.Text)||string.IsNullOrEmpty(cmbPosition.Text) || string.IsNullOrEmpty(txt_password.Text) || string.IsNullOrEmpty(txt_repassword.Text))
            {
                MessageBox.Show("Boş sahələri doldurun!!");
                return;
            }

            if (txt_password.Text != txt_repassword.Text)
            {
                MessageBox.Show("Daxil etdiyiniz parollar uyğunlaşmır!");
                return;
            }

            int posId = db.Positions.First(p=>p.Name == cmbPosition.Text).Id;

            User user = new User()
            {
                Name = txtName.Text,
                Surname = txtSurname.Text,
                PositionId = posId,
                Password = txt_password.Text
            };

            db.Users.Add(user);
            db.SaveChanges();
            MessageBox.Show("Yeni istifadəçi əlavə edildi!");

            txtName.Text = "";
            txtSurname.Text = "";
            cmbPosition.Text = "";
            txt_password.Text = "";
            txt_repassword.Text = "";
        }
    }
}
