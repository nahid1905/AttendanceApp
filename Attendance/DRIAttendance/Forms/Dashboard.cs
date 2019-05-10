using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DRIAttendance.Models;
using DRIAttendance.Forms;

namespace DRIAttendance
{
    public partial class Dashboard : Form
    {
        DRIAttendanceEntities2 db = new DRIAttendanceEntities2();

        public Position selectedPosition;
        Admin currentAdmin;
        User currentUser;
        Mail mail = new Mail();

        public Dashboard()
        {
            InitializeComponent();
            FillPosition();
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
                    // USER GİRİŞİ
                    // BEZİ BUTTONLAR GÖRÜNMÜR 
                    currentUser = db.Users.First(u => u.IsOnline == true);
                    btn_settings.Visible = false;
                    btn_position.Visible = false;
                }
                else
                {
                    return;
                }
            }
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

            selectedPosition = db.Positions.FirstOrDefault(p => p.Name == cmbPosition.Text);

            List<User> Users = db.Users.Where(u => u.PositionId == selectedPosition.Id).ToList();

            foreach (var item in Users)
            {
                cmbName.Items.Add(item.Name + " " + item.Surname);
            }
        }

        private void cmbPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillUsers();
        }

        // datalari liste doldurmaq
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbPosition.Text)||string.IsNullOrEmpty(cmbName.Text) || string.IsNullOrEmpty(cmbAttendance.Text))
            {
                MessageBox.Show("İnputları düzgün doldurun.");
                return;
            }

            if (cmbAttendance.Text=="Bəli")
            {
                Davamiyyət.Items.Add("*" + " " + cmbPosition.Text + " " + cmbName.Text + " " + DateTime.Now.ToString("hh:mm"));
            }
            if (cmbAttendance.Text == "Xeyr")
            {
                Davamiyyət.Items.Add("*" + " " + cmbPosition.Text + " " + cmbName.Text + " " + "İştirak etməyib");
            }

            Reset();
        }

        public void Reset()
        {
            cmbPosition.Text = "";
            cmbName.Text = "";
            cmbAttendance.Text = "";
        }

        // Emailin gonderilmesi 
        private void btnSend_Click_1(object sender, EventArgs e)
        {
            try
            {
                mail = db.Mails.First();
                MailMessage mm = new MailMessage(mail.From, mail.To);
                mm.Subject = "Davamiyyət";

                // For Mail's body
                string sendText = null;

                foreach (string item in Davamiyyət.Items)
                {
                    sendText = sendText + "\r\n" + item;
                }
                if (string.IsNullOrEmpty(sendText))
                {
                    MessageBox.Show("Davamiyyət siyahısını doldurun");
                    return;
                }
                mm.Body = sendText;
                mm.IsBodyHtml = false;

                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;

                NetworkCredential nc = new NetworkCredential(mail.From, mail.Password);
                smtp.UseDefaultCredentials = true;
                smtp.Credentials = nc;
                smtp.Send(mm);

                MessageBox.Show("Mesaj uğurla göndərildi!");

                Davamiyyət.Items.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Email addresslərini və maili göndərənin parolunun düzgünlüyünü bir daha nəzərdən keçirin");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Users userForm = new Users();

            userForm.ShowDialog();
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (currentAdmin!=null)
            {
                currentAdmin.IsOnline = null;
                db.SaveChanges();
            }
            if (currentUser!=null)
            {
                currentUser.IsOnline = null;
                db.SaveChanges();
            }

            Application.Exit();
        }

        private void btn_profile_Click(object sender, EventArgs e)
        {
            ProfileForm profForm = new ProfileForm();
            profForm.ShowDialog();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DeleteForm delForm = new DeleteForm();
            delForm.ShowDialog();
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            MailForm mailForm = new MailForm();
            mailForm.ShowDialog();
        }

        private void btn_position_Click(object sender, EventArgs e)
        {
            PositionForm positionForm = new PositionForm();
            positionForm.ShowDialog();
        }
    }
}
