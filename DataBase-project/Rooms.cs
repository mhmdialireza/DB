using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBase_project
{
    public partial class Rooms : Form
    {
        int id;
        room room = new room();
        HospitalEntities context = new HospitalEntities();
        public Rooms()
        {
            InitializeComponent();
            reloadGrid();
        }

        private void reloadGrid()
        {
            dataGridView.DataSource = context.rooms.Select(m => new
            {
                id = m.id.ToString().Trim(),
                name = m.name.ToString().Trim(),
                description = m.description.ToString().Trim()
            }).ToList();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (checkInputs())
            {
                try
                {
                    room.name = this.IFName.Text.Trim();
                    room.description = this.ILName.Text.Trim();

                    context.rooms.Add(room);
                    context.SaveChanges();

                    MessageBox.Show("اطلاعات با موفقیت ثبت شد");

                    clean();
                    reloadGrid();
                }
                catch
                {
                    MessageBox.Show("عملیات با خطا مواجه شد");
                }
            }
        }

        private bool checkInputs()
        {
            if (this.IFName.Text == "")
            {
                MessageBox.Show("مقادیر مقابل را پر کنید");
                return false;
            }
            return true;
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (checkInputs())
            {
                var r = context.rooms.Find(id);
                r.name = this.IFName.Text.Trim();
                r.description = this.ILName.Text.Trim();

                context.SaveChanges();

                MessageBox.Show("اطلاعات با موفقیت بروزرسانی شد");

                clean();
                reloadGrid();
            }
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString().Trim());
            this.IFName.Text = dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString().Trim();
            this.ILName.Text = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString().Trim();
        }

        private void clean()
        {
            this.IFName.Text = "";
            this.ILName.Text = "";
            this.searchBox.Text = "";
        }

        private void cleanB_Click(object sender, EventArgs e)
        {
            clean();
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            var roomName = this.searchBox.Text.Trim();

            dataGridView.DataSource = context.rooms
                .Where(r => r.name.Trim().Contains(roomName))
                .Select(m => new
            {
                m.id,
                m.name,
                m.description
            }).ToList();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                var dRoom = context.rooms.Find(id);

                context.rooms.Remove(dRoom);
                context.SaveChanges();

                MessageBox.Show("اتاق با موفقیت پاک شد");
            }
            catch
            {
                MessageBox.Show("عملیات با خطا مواجه شد");
            }
        }
    }
}
