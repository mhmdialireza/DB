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
    public partial class medical_Recordes : Form
    {
        int id;
        HospitalEntities context = new HospitalEntities();
        public medical_Recordes()
        {
            InitializeComponent();

            reloadGrid();

            var pIds = context.patients.Select(p => p.id).ToList();
            pIds.ForEach(id => comboBox.Items.Add(id));
            pIds.ForEach(id => comboBox1.Items.Add(id));
        }

        private bool checkInputs()
        {
            if (
                this.IFName.Text.Trim() == "" ||
                string.IsNullOrEmpty(this.comboBox.Text))
            {
                MessageBox.Show("مقادیر مقابل را پر کنید");
                return false;
            }
            return true;
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void patientsBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void operations_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (checkInputs())
            {
                var mr = new medical_records();

                mr.name = this.IFName.Text.Trim();
                mr.description = this.IDC.Text.Trim();
                mr.infection_date = this.dateTimePicker1.Value;
                if (!this.checkBox1.Checked)
                    mr.recovery_date = this.dateTimePicker2.Value;

                mr.patient_id = Convert.ToInt64(this.comboBox.Text.Trim());

                context.medical_records.Add(mr);
                context.SaveChanges();

                string message2 = "اطلاعات با موفقیت ثبت شد";
                MessageBox.Show(message2);

                reloadGrid();
            }
        }

        private void reloadGrid()
        {
            dataGridView.DataSource = context.medical_records.Select(m => new
            {
                m.id,
                name = m.name.Trim(),
                description = m.description.Trim(),
                infection_date = m.infection_date.ToString().Trim(),
                recovery_date = m.recovery_date.ToString().Trim(),
                patient_id = m.patient_id.ToString().Trim()
            }).ToList();
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            this.IFName.Text = dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            this.IDC.Text = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            this.comboBox.Text = dataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();

        }

        private void cleanB_Click(object sender, EventArgs e)
        {
            clean();

            reloadGrid();
        }

        private void clean()
        {
            this.IDC.Text = "";
            this.IFName.Text = "";
            this.checkBox1.Checked = false;
            this.searchBox.Text = "";
            this.comboBox.SelectedIndex = -1;
            this.comboBox.SelectedItem = "";
            this.comboBox1.SelectedIndex = -1;
            this.comboBox1.SelectedItem = "";
        }
        private void update_Click(object sender, EventArgs e)
        {
            if (checkInputs())
            {
                var mr = context.medical_records.Find(id);

                mr.name = this.IFName.Text;
                mr.description = this.IDC.Text;
                mr.infection_date = this.dateTimePicker1.Value;
                if (!this.checkBox1.Checked)
                    mr.recovery_date = this.dateTimePicker2.Value;

                mr.patient_id = Convert.ToInt64(this.comboBox.Text);

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
                    var up = context.medical_records.Find(id);
                    context.medical_records.Remove(up);
                    context.SaveChanges();
                    MessageBox.Show("سابقه مورد نظر با موفقیت حذف شد");

                    reloadGrid();
                }
                catch
                {
                    MessageBox.Show("بیمار دارای وقت ویزیت و یا سوابق پزشکی است ، شما قادر به حذف آن نیستید.");
                }

                clean();
            }
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.comboBox1.Text))
            {
                var fPatients = context.medical_records.Where(p =>
                    p.id.ToString().Contains(searchBox.Text) ||
                    p.name.Contains(searchBox.Text) ||
                    p.description.Contains(searchBox.Text) ||
                    p.patient_id.ToString().Contains(searchBox.Text)
                );

                dataGridView.DataSource = fPatients.Select(m => new
                {
                    m.id,
                    m.name,
                    m.description,
                    m.infection_date,
                    m.recovery_date,
                    m.patient_id
                }).ToList();
            }
            else
            {
                var fPatients = context.medical_records.Where(p =>
                    (p.id.ToString().Contains(searchBox.Text) ||
                    p.name.Contains(searchBox.Text) ||
                    p.description.Contains(searchBox.Text)) &&
                    p.patient_id.ToString().Contains(comboBox1.Text)
                );

                dataGridView.DataSource = fPatients.Select(m => new
                {
                    m.id,
                    m.name,
                    m.description,
                    m.infection_date,
                    m.recovery_date,
                    m.patient_id
                }).ToList();
            }


        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (searchBox.Text == "")
            {
                var fPatients = context.medical_records.Where(p =>
                    p.patient_id.ToString().Contains(comboBox1.Text)
                );

                dataGridView.DataSource = fPatients.Select(m => new
                {
                    m.id,
                    m.name,
                    m.description,
                    m.infection_date,
                    m.recovery_date,
                    m.patient_id
                }).ToList();
            }
            else
            {
                var fPatients = context.medical_records.Where(p =>
                    (p.id.ToString().Contains(searchBox.Text) ||
                    p.name.Contains(searchBox.Text) ||
                    p.description.Contains(searchBox.Text)) &&
                    p.patient_id.ToString().Contains(comboBox1.Text)
                );

                dataGridView.DataSource = fPatients.Select(m => new
                {
                    m.id,
                    m.name,
                    m.description,
                    m.infection_date,
                    m.recovery_date,
                    m.patient_id
                }).ToList();
            }
        }
    }
}
