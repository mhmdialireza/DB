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
                m.id,
                m.name,
                m.description
            }).ToList();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (checkInputs())
            {
                room.name = this.IFName.Text;
                room.description = this.ILName.Text;

                context.rooms.Add(room);
                context.SaveChanges();

                MessageBox.Show("اطلاعات با موفقیت ثبت شد");

                clean();
                reloadGrid();
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
                r.name = this.IFName.Text;
                r.description = this.ILName.Text;

                context.SaveChanges();

                MessageBox.Show("اطلاعات با موفقیت بروزرسانی شد");

                clean();
                reloadGrid();
            }
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            this.IFName.Text = dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            this.ILName.Text = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void clean()
        {
            this.IFName.Text = "";
            this.ILName.Text = "";
        }
    }
}
