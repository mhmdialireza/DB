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
    public partial class SearchVisit : Form
    {
        HospitalEntities context = new HospitalEntities();
        public SearchVisit()
        {
            InitializeComponent();

            var allData = context.visits.ToList().Select(t => new
            {
                id = t.id,
                patient = t.patient.first_name.Trim() + " " + t.patient.last_name.Trim(),
                doctor = t.doctor_schedule.doctor.first_name.Trim() + " " + t.doctor_schedule.doctor.last_name.Trim(),
                date = t.date.Year.ToString() + '/' + t.date.Month.ToString() + '/' + t.date.Day.ToString(),
                time = t.date.Hour.ToString() + ':' + t.date.Minute.ToString()
            }).ToList();

            dataGridView1.DataSource = allData.ToList();

            context.doctors.ToList().ForEach(
                d => this.dCombo.Items.Add(
                    d.first_name.Trim() + " " + d.last_name.Trim()));

            context.patients.ToList().ForEach(
                p => this.pCombo.Items.Add(
                    p.first_name.Trim() + " " + p.last_name.Trim()));
        }

        private void SearchVisit_Load(object sender, EventArgs e)
        {
            this.visitsTableAdapter.Fill(this.final_hospitalDataSet1.visits);
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.patientsTableAdapter.Fill(this.final_hospitalDataSet.patients);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = this.dCombo.SelectedIndex;

            if (index != -1)
            {
                var index2 = this.pCombo.SelectedIndex;

                var doctor = context.doctors.ToList()[index];

                if (index2 == -1)
                {
                    var allData = context.visits.ToList()
                    .Where(t => t.doctor_schedule.doctor.id == doctor.id)
                    .Select(t => new
                    {
                        id = t.id,
                        patient = t.patient.first_name.Trim() + " " + t.patient.last_name.Trim(),
                        doctor = t.doctor_schedule.doctor.first_name.Trim() + " " + t.doctor_schedule.doctor.last_name.Trim(),
                        date = t.date.Year.ToString() + '/' + t.date.Month.ToString() + '/' + t.date.Day.ToString(),
                        time = t.date.Hour.ToString() + ':' + t.date.Minute.ToString()
                    }).ToList();

                    dataGridView1.DataSource = allData.ToList();
                }
                else
                {
                    var patient = context.patients.ToList()[index2];

                    var allData = context.visits.ToList()
                    .Where(t => t.patient.id == patient.id)
                    .Where(t => t.doctor_schedule.doctor.id == doctor.id)
                    .Select(t => new
                    {
                        id = t.id,
                        patient = t.patient.first_name.Trim() + " " + t.patient.last_name.Trim(),
                        doctor = t.doctor_schedule.doctor.first_name.Trim() + " " + t.doctor_schedule.doctor.last_name.Trim(),
                        date = t.date.Year.ToString() + '/' + t.date.Month.ToString() + '/' + t.date.Day.ToString(),
                        time = t.date.Hour.ToString() + ':' + t.date.Minute.ToString()
                    }).ToList();

                    dataGridView1.DataSource = allData.ToList();
                }
            }
        }

        private void pCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = this.pCombo.SelectedIndex;
            var index2 = this.dCombo.SelectedIndex;
            if (index != -1)
            {

                var patient = context.patients.ToList()[index];

                if (index2 == -1)
                {
                    var allData = context.visits.ToList()
                    .Where(t => t.patient.id == patient.id)
                    .Select(t => new
                    {
                        id = t.id,
                        patient = t.patient.first_name.Trim() + " " + t.patient.last_name.Trim(),
                        doctor = t.doctor_schedule.doctor.first_name.Trim() + " " + t.doctor_schedule.doctor.last_name.Trim(),
                        date = t.date.Year.ToString() + '/' + t.date.Month.ToString() + '/' + t.date.Day.ToString(),
                        time = t.date.Hour.ToString() + ':' + t.date.Minute.ToString()
                    }).ToList();

                    dataGridView1.DataSource = allData.ToList();
                }
                else
                {
                    var doctor = context.doctors.ToList()[index2];

                    var allData = context.visits.ToList()
                    .Where(t => t.patient.id == patient.id)
                    .Where(t => t.doctor_schedule.doctor.id == doctor.id)
                    .Select(t => new
                    {
                        id = t.id,
                        patient = t.patient.first_name.Trim() + " " + t.patient.last_name.Trim(),
                        doctor = t.doctor_schedule.doctor.first_name.Trim() + " " + t.doctor_schedule.doctor.last_name.Trim(),
                        date = t.date.Year.ToString() + '/' + t.date.Month.ToString() + '/' + t.date.Day.ToString(),
                        time = t.date.Hour.ToString() + ':' + t.date.Minute.ToString()
                    }).ToList();

                    dataGridView1.DataSource = allData.ToList();
                }
            }

        }

        private void cleanB_Click(object sender, EventArgs e)
        {
            this.dCombo.SelectedIndex = -1;
            this.dCombo.SelectedItem = "";

            this.pCombo.SelectedIndex = -1;
            this.pCombo.SelectedItem = "";

            var allData = context.visits.ToList()
                .Select(t => new
                {
                    id = t.id,
                    patient = t.patient.first_name.Trim() + " " + t.patient.last_name.Trim(),
                    doctor = t.doctor_schedule.doctor.first_name.Trim() + " " + t.doctor_schedule.doctor.last_name.Trim(),
                    date = t.date.Year.ToString() + '/' + t.date.Month.ToString() + '/' + t.date.Day.ToString(),
                    time = t.date.Hour.ToString() + ':' + t.date.Minute.ToString()
                }).ToList();

            dataGridView1.DataSource = allData.ToList();
        }

        private void tCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var intputDate = this.dCombo.Text.Trim();

            var allData = context.visits.ToList()
                .Where(v =>
                    v.date.Year.ToString().Trim() + '/' +
                    v.date.Month.ToString().Trim() + '/' +
                    v.date.Day.ToString().Trim() + '/' ==
                    intputDate
                ).Select(t => new
                {
                    id = t.id,
                    patient = t.patient.first_name.Trim() + " " + t.patient.last_name.Trim(),
                    doctor = t.doctor_schedule.doctor.first_name.Trim() + " " + t.doctor_schedule.doctor.last_name.Trim(),
                    date = t.date.Year.ToString() + '/' + t.date.Month.ToString() + '/' + t.date.Day.ToString(),
                    time = t.date.Hour.ToString() + ':' + t.date.Minute.ToString()
                }).ToList();

            dataGridView1.DataSource = allData.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.dCombo.SelectedIndex = -1;
            this.dCombo.SelectedItem = "";

            this.pCombo.SelectedIndex = -1;
            this.pCombo.SelectedItem = "";

            var year = this.monthCalendar1.SelectionStart.Year;
            var month = this.monthCalendar1.SelectionStart.Month;
            var day = this.monthCalendar1.SelectionStart.Day;
            var serachTime = new DateTime(year, month, day, 0, 0, 0);

            var allData = context.visits.ToList()
                .Where(v =>
                    (new DateTime(v.date.Year, v.date.Month, v.date.Day, 0, 0, 0))
                    .CompareTo(serachTime) == 0
                ).Select(t => new
                {
                    id = t.id,
                    patient = t.patient.first_name.Trim() + " " + t.patient.last_name.Trim(),
                    doctor = t.doctor_schedule.doctor.first_name.Trim() + " " + t.doctor_schedule.doctor.last_name.Trim(),
                    date = t.date.Year.ToString() + '/' + t.date.Month.ToString() + '/' + t.date.Day.ToString(),
                    time = t.date.Hour.ToString() + ':' + t.date.Minute.ToString()
                }).ToList();

            dataGridView1.DataSource = allData.ToList();
        }
    }
}
