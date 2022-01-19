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
    public partial class SetDoctorsShift : Form
    {
        int id;
        int doctorId;
        HospitalEntities context = new HospitalEntities();
        public SetDoctorsShift()
        {
            InitializeComponent();

            context.doctors.ToList().ForEach(
                d => this.dCombo.Items.Add(
                    d.first_name.Trim() + " " + d.last_name.Trim()));


        }

        private void SetDoctorsShift_Load(object sender, EventArgs e)
        {

        }

        private void selectDate_Click(object sender, EventArgs e)
        {
            var doctorComboIndex = this.dCombo.SelectedIndex;
            this.doctorId = Convert.ToInt32(context.doctors.ToList()[doctorComboIndex].id);

            var pivot = context.doctor_schedule
                            .Where(ds => ds.doctor_id == doctorId)
                            .Select(ds => ds.schedule_of_on_call)
                            .Select(p => new { id = p.id });

            this.dataGridView.DataSource = pivot;
        }

        private void update_Click(object sender, EventArgs e)
        {

        }
    }
}
