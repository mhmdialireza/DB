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
    public partial class Doctors : Form
    {
        int id;
        doctor doctor = new doctor();
        HospitalEntities context = new HospitalEntities();
        public Doctors()
        {
            InitializeComponent();
            DateTime now = DateTime.Now;
            string s = now.DayOfWeek.ToString();
            this.IFName.Text = s;
            var pIds = context.rooms.Select(p => p.id).ToList();
            pIds.ForEach(id => comboBox1.Items.Add(id));

            reloadGrid();
        }

        private void reloadGrid()
        {
            dataGridView.DataSource = context.doctors.Select(D => new
            {
                D.id,
                D.first_name,
                D.last_name,
                D.national_code,
                D.mobile_number,
                D.date_of_birth,
                D.room_id
            }).ToList();
        }

        private bool checkInputs()
        {
            if (
                this.IFName.Text == "" ||
                this.ILName.Text == "" ||
                this.IMNumber.Text == "" ||
                this.INCode.Text == "" ||
                this.comboBox1.SelectedIndex == -1
                )
            {
                MessageBox.Show("مقادیر مقابل را پر کنید");
                return false;
            }
            return true;
        }

        private void clean()
        {
            this.IFName.Text = "";
            this.ILName.Text = "";
            this.IMNumber.Text = "";
            this.INCode.Text = "";

            this.comboBox1.SelectedIndex = -1;
            this.comboBox1.SelectedItem = "";

            this.searchBox.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (checkInputs())
            {
                doctor.first_name = this.IFName.Text;
                doctor.last_name = this.ILName.Text;
                doctor.mobile_number = this.IMNumber.Text;
                doctor.national_code = this.INCode.Text;
                doctor.date_of_birth = this.dateTimePicker1.Value;
                doctor.room_id = Int32.Parse(this.comboBox1.SelectedItem.ToString());

                context.doctors.Add(doctor);
                context.SaveChanges();

                MessageBox.Show("اطلاعات با موفقیت ثبت شد");

                reloadGrid();
            }
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            this.IFName.Text = dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            this.ILName.Text = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            this.IMNumber.Text = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            this.INCode.Text = dataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
            this.comboBox1.SelectedItem = dataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
    

            var roomIds = context.rooms.Select(p => p.id).ToList();
            int selectedIndex = -1;
            for (int i = 0; i < roomIds.Count(); i++)
                if (dataGridView.Rows[e.RowIndex].Cells[6].Value.ToString() == roomIds[i].ToString())
                    selectedIndex = i;

            this.comboBox1.SelectedIndex = selectedIndex;
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (checkInputs())
            {
                var d = context.doctors.Find(id);
                d.first_name = this.IFName.Text;
                d.last_name = this.ILName.Text;
                d.mobile_number = this.IMNumber.Text;
                d.national_code = this.INCode.Text;
                d.date_of_birth = this.dateTimePicker1.Value;
                d.room_id = Int32.Parse(this.comboBox1.SelectedItem.ToString());

                context.SaveChanges();

                MessageBox.Show("اطلاعات با موفقیت بروزرسانی شد");

                reloadGrid();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (checkInputs())
            {
                try
                {
                    var d = context.doctors.Find(id);
                    context.doctors.Remove(d);
                    context.SaveChanges();
                    MessageBox.Show("پزشک مورد نظر با موفقیت حذف شد");

                    reloadGrid();
                }
                catch
                {
                    MessageBox.Show("خطا");
                }
            }
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            var fD = context.doctors.Where(d =>
                d.id.ToString().Contains(searchBox.Text) ||
                d.first_name.Contains(searchBox.Text) ||
                d.last_name.Contains(searchBox.Text) ||
                d.national_code.Contains(searchBox.Text) ||
                d.national_code.Contains(searchBox.Text) ||
                d.room_id.ToString().Contains(searchBox.Text)
            ).Select(D => new
            {
                D.id,
                D.first_name,
                D.last_name,
                D.national_code,
                D.mobile_number,
                D.date_of_birth,
                D.room_id
            });



            dataGridView.DataSource = fD.ToList();
        }

        private void cleanB_Click(object sender, EventArgs e)
        {
            clean();
            reloadGrid();
        }
    }
}
