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
                try
                {
                    patient.first_name = this.IFName.Text.Trim();
                    patient.last_name = this.ILName.Text.Trim();
                    patient.mobile_number = this.IMNumber.Text.Trim();
                    patient.national_code = this.INCode.Text.Trim();
                    patient.date_of_birth = this.dateTimePicker1.Value;

                    context.patients.Add(patient);
                    context.SaveChanges();

                    MessageBox.Show("اطلاعات با موفقیت ثبت شد");

                    reloadGrid();
                }
                catch
                {
                    MessageBox.Show("عملیات با خطا مواجه شد");
                }
            }
        }
        private void update_Click(object sender, EventArgs e)
        {
            if (checkInputs())
            {
                try
                {
                    var up = context.patients.Find(id);
                    up.first_name = this.IFName.Text.Trim();
                    up.last_name = this.ILName.Text.Trim();
                    up.mobile_number = this.IMNumber.Text.Trim();
                    up.national_code = this.INCode.Text.Trim();
                    up.date_of_birth = this.dateTimePicker1.Value;

                    context.SaveChanges();

                    MessageBox.Show("اطلاعات با موفقیت بروزرسانی شد");

                    reloadGrid();
                }
                catch
                {
                    MessageBox.Show("عملیات با خطا مواجه شد");
                }
            }
        }
        private void delete(object sender, EventArgs e)
        {
            if (checkInputs())
            {
                try
                {
                    var up = context.patients.Find(id);
                    context.patients.Remove(up);
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
            id = int.Parse(dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString().Trim());
            this.IFName.Text = dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString().Trim();
            this.ILName.Text = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString().Trim();
            this.IMNumber.Text = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString().Trim();
            this.INCode.Text = dataGridView.Rows[e.RowIndex].Cells[4].Value.ToString().Trim();
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
                this.IFName.Text.Trim() == "" ||
                this.ILName.Text.Trim() == "" ||
                this.IMNumber.Text.Trim() == "" ||
                this.INCode.Text.Trim() == ""
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
                p.id.ToString().Contains(searchBox.Text.Trim()) ||
                p.first_name.Contains(searchBox.Text.Trim()) ||
                p.last_name.Contains(searchBox.Text.Trim()) ||
                p.national_code.Contains(searchBox.Text.Trim()) ||
                p.mobile_number.Contains(searchBox.Text.Trim())
            );

            dataGridView.DataSource = fPatients.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (new medical_Recordes()).Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            (new Visits()).Show();
        }
    }
}
