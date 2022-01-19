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
                this.IFName.Text.Trim() == "" ||
                this.ILName.Text.Trim() == "" ||
                this.IMNumber.Text.Trim() == "" ||
                this.INCode.Text.Trim() == "" ||
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
                try
                {
                    doctor.first_name = this.IFName.Text.Trim();
                    doctor.last_name = this.ILName.Text.Trim();
                    doctor.mobile_number = this.IMNumber.Text.Trim();
                    doctor.national_code = this.INCode.Text.Trim();
                    doctor.date_of_birth = this.dateTimePicker1.Value;
                    doctor.room_id = Int32.Parse(this.comboBox1.SelectedItem.ToString());

                    context.doctors.Add(doctor);
                    context.SaveChanges();

                    MessageBox.Show("اطلاعات با موفقیت ثبت شد");

                    clean();
                    reloadGrid();
                }
                catch { MessageBox.Show("عملیات با خطا مواجه شد"); }
            }
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString().Trim());
            this.IFName.Text = dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString().Trim();
            this.ILName.Text = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString().Trim();
            this.IMNumber.Text = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString().Trim();
            this.INCode.Text = dataGridView.Rows[e.RowIndex].Cells[4].Value.ToString().Trim();
            this.comboBox1.SelectedItem = dataGridView.Rows[e.RowIndex].Cells[6].Value.ToString().Trim();


            var roomIds = context.rooms.Select(p => p.id).ToList();
            int selectedIndex = -1;
            for (int i = 0; i < roomIds.Count(); i++)
                if (dataGridView.Rows[e.RowIndex].Cells[6].Value.ToString().Trim() == roomIds[i].ToString().Trim())
                    selectedIndex = i;

            this.comboBox1.SelectedIndex = selectedIndex;
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (checkInputs())
            {
                var d = context.doctors.Find(id);
                d.first_name = this.IFName.Text.Trim();
                d.last_name = this.ILName.Text.Trim();
                d.mobile_number = this.IMNumber.Text.Trim();
                d.national_code = this.INCode.Text.Trim();
                d.date_of_birth = this.dateTimePicker1.Value;
                d.room_id = Int32.Parse(this.comboBox1.SelectedItem.ToString());

                context.SaveChanges();

                MessageBox.Show("اطلاعات با موفقیت بروزرسانی شد");

                clean();
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
                    clean();
                }
                catch
                {
                    MessageBox.Show("دکتر دارای تایم ویزیت است ،‌شما قادر به حذف آن نیستید");
                }
            }
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            var fD = context.doctors.Where(d =>
                d.id.ToString().Contains(searchBox.Text.Trim()) ||
                d.first_name.Contains(searchBox.Text.Trim()) ||
                d.last_name.Contains(searchBox.Text.Trim()) ||
                d.national_code.Contains(searchBox.Text.Trim()) ||
                d.mobile_number.Contains(searchBox.Text.Trim()) ||
                d.room_id.ToString().Contains(searchBox.Text.Trim())
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
