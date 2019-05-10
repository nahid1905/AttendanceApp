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
    public partial class PositionForm : Form
    {
        DRIAttendanceEntities2 db = new DRIAttendanceEntities2();
        Position selectedPos;

        public PositionForm()
        {
            InitializeComponent();
            FillPositions();
        }

        public void FillPositions()
        {
            dgvPosition.Rows.Clear();

            List<Position> positions = db.Positions.OrderBy(o => o.Name).ToList();

            foreach (var item in positions)
            {
                dgvPosition.Rows.Add(item.Id,item.Name);
            }
            db.SaveChanges();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPosition.Text))
            {
                MessageBox.Show("Xana boşdur!!");
                return;
            }
            Position pos = new Models.Position
            {
                Name = txtPosition.Text
            };
            db.Positions.Add(pos);
            db.SaveChanges();
            MessageBox.Show("Yeni vəzifə əlavə edildi!");
            Reset();
        }

        public void Reset()
        {
            txtPosition.Text = "";

            btnUpdate.Visible = false;
            btn_del.Visible = false;
            btnOk.Visible = true;

            FillPositions();
        }

        private void dgvPosition_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dgvPosition.Rows[e.RowIndex].Cells[0].Value.ToString());
            selectedPos = db.Positions.Find(id);
            txtPosition.Text = selectedPos.Name;

            btnOk.Visible = false;
            btnUpdate.Visible = true;
            btn_del.Visible = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPosition.Text))
            {
                MessageBox.Show("Xana boş qala bilməz!!");
                return;
            }
            else
            {
                selectedPos.Name = txtPosition.Text;
                db.SaveChanges();
                FillPositions();
            }

            MessageBox.Show("Uğurla yeniləndi");
            Reset();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Silmək istəyirsiniz mi?", "Silmək", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                db.Positions.Remove(selectedPos);

                db.SaveChanges();
                MessageBox.Show("Məlumat silindi!!");
                Reset();
            }
        }
    }
}
