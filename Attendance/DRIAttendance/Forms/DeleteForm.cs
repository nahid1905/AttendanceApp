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
    public partial class DeleteForm : Form
    {
        DRIAttendanceEntities2 db = new DRIAttendanceEntities2();

        public Position selectedPosition;
        User currentUser;
        Admin currentAdmin;

        public DeleteForm()
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

        // Vezifeye esasen user adlarinin getirilmesi
        public void FillUsers()
        {
            cmbName.Items.Clear();

            currentUser = db.Users.FirstOrDefault(u => u.IsOnline == true);
            currentAdmin = db.Admins.FirstOrDefault(a => a.IsOnline == true);
            selectedPosition = db.Positions.FirstOrDefault(p => p.Name == cmbPosition.Text);

            if (currentUser!=null)
            {
                // User girishi ucun

                List<User> Users = db.Users.Where(u => u.PositionId == selectedPosition.Id && u.Id != currentUser.Id).ToList();
                foreach (var item in Users)
                {
                    cmbName.Items.Add(item.Name + " " + item.Surname);
                }
            }
            else
            {
                // Admin girishi ucunz

                List<User> Users = db.Users.Where(u => u.PositionId == selectedPosition.Id).ToList();
                foreach (var item in Users)
                {
                    cmbName.Items.Add(item.Name + " " + item.Surname);
                }
            }
        }

        private void cmbPosition_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            FillUsers();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbPosition.Text)||string.IsNullOrEmpty(cmbName.Text))
            {
                MessageBox.Show("Xanaları doldurun!!");
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Əminsiniz?", "Silmək", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string[] parts = cmbName.Text.Split(' ');
                string usrName = parts[0];
                string usrSurname = parts[1];
                User delUser = db.Users.First(u => u.Name == usrName && u.Surname == usrSurname);
                db.Users.Remove(delUser);
                db.SaveChanges();
                MessageBox.Show("İstifadəçi uğurla silindi!!");
                cmbPosition.Text = "";
                cmbName.Text = "";
            }
        }
    }
}
