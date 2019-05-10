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
    public partial class Users : Form
    {
        DRIAttendanceEntities2 db = new DRIAttendanceEntities2();

        public Users()
        {
            InitializeComponent();
            FillPosition();
        }

        public void FillPosition()
        {
            List<Position> positions = db.Positions.OrderBy(p => p.Name).ToList();

            foreach (var item in positions)
            {
                cmbPosition.Items.Add(item.Name);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text)||string.IsNullOrEmpty(txtSurname.Text)||string.IsNullOrEmpty(cmbPosition.Text)||string.IsNullOrEmpty(txt_password.Text)||string.IsNullOrEmpty(txt_repassword.Text))
            {
                MessageBox.Show("İnputları doldurun");
                return;
            }

            if (txt_password.Text != txt_repassword.Text)
            {
                MessageBox.Show("Daxil etdiyiniz parollar uyğunlaşmır!!");
                return;
            }

            Position pstn = db.Positions.First(p => p.Name == cmbPosition.Text);


            User user = new User
            {
                Name = txtName.Text,
                Surname = txtSurname.Text,
                PositionId = pstn.Id,
                Password = txt_password.Text
            };

            db.Users.Add(user);

            db.SaveChanges();

            MessageBox.Show("Yeni işçi əlavə edildi.");

            txtName.Text = "";
            txtSurname.Text = "";
            cmbPosition.Text = "";
            txt_password.Text = "";
            txt_repassword.Text = "";
        }
    }
}
