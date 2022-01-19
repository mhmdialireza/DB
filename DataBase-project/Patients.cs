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
    public partial class Patients : Form
    {
        int id;
        patient patient = new patient();
        HospitalEntities context = new HospitalEntities();
        public Patients()
        {
            InitializeComponent();
            reloadGrid();
        }
        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }
        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Patients_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'final_hospitalDataSet.patients' table. You can move, or remove it, as needed.
            this.patientsTableAdapter.Fill(this.final_hospitalDataSet.patients);

        }
        private void button7_Click(object sender, EventArgs e)
        {
            this.IFName.Clear();
            this.ILName.Clear();
            this.IMNumber.Clear();
            this.INCode.Clear();

            this.searchBox.Clear();

            reloadGrid();
        }
        private void submit_Click(object sender, EventArgs e)
        {
            if (checkInputs())
            {
                patient.first_name = this.IFName.Text;
                patient.last_name = this.ILName.Text;
                patient.mobile_number = this.IMNumber.Text;
                patient.national_code = this.INCode.Text;
                patient.date_of_birth = this.dateTimePicker1.Value;

                context.patients.Add(patient);
                context.SaveChanges();

                MessageBox.Show("اطلاعات با موفقیت ثبت شد");

                reloadGrid();
            }
        }
        private void update_Click(object sender, EventArgs e)
        {
            if (checkInputs())
            {
                var up = context.patients.Find(id);
                up.first_name = this.IFName.Text;
                up.last_name = this.ILName.Text;
                up.mobile_number = this.IMNumber.Text;
                up.national_code = this.INCode.Text;
                up.date_of_birth = this.dateTimePicker1.Value;

                context.SaveChanges();

                MessageBox.Show("اطلاعات با موفقیت بروزرسانی شد");

                reloadGrid();
            }
        }
        private void delete(object sender, EventArgs e)
        {
            if (checkInputs())
            {
                try
                {
                    var up = context.rooms.Find(id);
                    context.rooms.Remove(up);
                    context.SaveChanges();
                    MessageBox.Show("اتاق مورد نظر با موفقیت حذف شد");

                    reloadGrid();
                }
                catch
                {
                    MessageBox.Show("بیمار دارای وقت ویزیت و یا سوابق پزشکی است ، شما قادر به حذف آن نیستید.");
                }
            }
        }
        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            this.IFName.Text = dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            this.ILName.Text = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            this.IMNumber.Text = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            this.INCode.Text = dataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();

            //this.dateTimePicker1 = DateTime.Parse();
            //var x = dataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
            //String s1 = dataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
            //var dt = DateTime.Parse(s1);
            //this.dateTimePicker1 = dt;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void reloadGrid()
        {
            dataGridView.DataSource = context.patients.ToList();
        }

        private bool checkInputs()
        {
            if (
                this.IFName.Text == "" ||
                this.ILName.Text == "" ||
                this.IMNumber.Text == "" ||
                this.INCode.Text == ""
                )
            {
                MessageBox.Show("مقادیر مقابل را پر کنید");
                return false;
            }
            return true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var fPatients = context.patients.Where(p =>
                p.id.ToString().Contains(searchBox.Text) ||
                p.first_name.Contains(searchBox.Text) ||
                p.last_name.Contains(searchBox.Text) ||
                p.national_code.Contains(searchBox.Text) ||
                p.mobile_number.Contains(searchBox.Text)
            );

            dataGridView.DataSource = fPatients.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (new medical_Recordes()).Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
