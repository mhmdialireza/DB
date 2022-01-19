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
    public partial class Visits : Form
    {
        List<string> l1 = new List<string>();
        List<string> l2 = new List<string>();
        List<string> l3 = new List<string>();

        int dci;

        string fDay;
        DateTime visitDatetime;
        bool date = true, d = true, t = true;

        HospitalEntities context = new HospitalEntities();

        List<doctor> comboDoctors = (new HospitalEntities()).doctors.ToList();
        List<patient> comboPa = (new HospitalEntities()).patients.ToList();
        public Visits()
        {
            InitializeComponent();


            comboDoctors = context.doctors.ToList();
            comboPa.ForEach(cp => this.pCombo.Items.Add(
                cp.first_name.Trim() + " " + cp.last_name.Trim()));

        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            if (date)
                MessageBox.Show("ابتدا تاریخ را تایید کنید");
        }

        private void tCombo_Click(object sender, EventArgs e)
        {
            if (d)
                MessageBox.Show("ابتدا پزشک را مشخص کنید");
        }

        private void convertDay(string enDay)
        {
            switch (enDay)
            {
                case "Saturday":
                    fDay = "شنبه";
                    break;
                case "Sunday":
                    fDay = "يکشنبه";
                    break;
                case "Monday":
                    fDay = "دوشنبه";
                    break;
                case "Tuesday":
                    fDay = "سه شنبه";
                    break;
                case "Wednesday":
                    fDay = "چهار شنبه";
                    break;
                case "Thursday":
                    fDay = "پنج شنبه";
                    break;
                case "Friday":
                    fDay = "جمعه";
                    break;
            }
        }

        private void submit_Click(object sender, EventArgs e)
        {
            this.dCombo.Items.Clear();

            visitDatetime = DateTime.Parse(this.monthCalendar1.SelectionStart.ToShortDateString());
            convertDay(visitDatetime.DayOfWeek.ToString().Trim());

            var sooc = context.schedule_of_on_call
                .Where(s => s.day == fDay)
                .Select(s => s.id).ToList();

            var pivotDS = context.doctor_schedule
                .Where(ds => sooc.Contains(ds.schedule_id))
                .Select(ds => ds.doctor_id).ToList();

            comboDoctors = context.doctors.Where(d => pivotDS.Contains(d.id)).ToList();

            comboDoctors.
                ForEach(cd => this.dCombo.Items.Add(
                    cd.first_name.Trim() + " " + cd.last_name.Trim()
                    ));

            date = false;
        }

        private void update_Click(object sender, EventArgs e)
        {
            int index = this.dCombo.SelectedIndex;
            var inputDate = this.monthCalendar1.SelectionStart.ToShortDateString();
            visitDatetime = DateTime.Parse(inputDate);

            var dayName = visitDatetime.DayOfWeek.ToString();

            switch (dayName)
            {
                case "Saturday":
                    fDay = "شنبه";
                    break;
                case "Sunday":
                    fDay = "يکشنبه";
                    break;
                case "Monday":
                    fDay = "دوشنبه";
                    break;
                case "Tuesday":
                    fDay = "سه شنبه";
                    break;
                case "Wednesday":
                    fDay = "چهار شنبه";
                    break;
                case "Thursday":
                    fDay = "پنج شنبه";
                    break;
                case "Friday":
                    fDay = "جمعه";
                    break;
            }

            var sooc = context.schedule_of_on_call
                .Where(s => s.day == fDay)
                .Select(s => s.id).ToList();

            var nSoocId = context.doctors.Where(d => sooc.Contains(d.id)).ToArray()[index].id;

            var dId = context.doctor_schedule
                .Where(ds => sooc.Contains(ds.schedule_id))
                .Where(ds => ds.doctor_id == nSoocId).Select(q => q.doctor_id);

            var sId = context.doctor_schedule
                .Where(ds => sooc.Contains(ds.schedule_id))
                .Where(ds => ds.doctor_id == nSoocId).Select(q => q.schedule_id);


            dci = Convert.ToInt32(sId.FirstOrDefault());

            var shift = context.schedule_of_on_call.SingleOrDefault(s => s.id == sId.FirstOrDefault()).shift;


            var a = context.visits.ToList();
            var b = a.Where(q =>
                                q.date.Year == this.monthCalendar1.SelectionRange.Start.Year &&
                                q.date.Month == this.monthCalendar1.SelectionRange.Start.Month &&
                                q.date.Day == this.monthCalendar1.SelectionRange.Start.Day
                ).ToList();

            List<visit> lastVisits;
            var myTime1 = new DateTime(2019, 11, 20, 7, 0, 0);
            var myTime2 = new DateTime(2019, 11, 20, 14, 0, 0);
            var myTime3 = new DateTime(2019, 11, 20, 20, 0, 0);
            var myTime4 = new DateTime(2019, 11, 20, 23, 59, 59);

            if (shift == 1)
                fillComboTime1(b.Where(bb => bb.date.Hour >= myTime1.Hour && bb.date.Hour < myTime2.Hour).ToList());
            else if (shift == 2)
                fillComboTime2(b.Where(bb => bb.date.Hour >= myTime2.Hour && bb.date.Hour < myTime3.Hour).ToList());
            else
                fillComboTime3(b.Where(bb => bb.date.Hour >= myTime3.Hour && bb.date.Hour <= myTime4.Hour).ToList());

            d = false;
        }

        private void fillComboTime1(List<visit> lastVisits)
        {
            lastVisits.ForEach(lv => l1.Add(lv.date.Hour.ToString() + lv.date.Minute.ToString()));

            if (!l1.Contains("70"))
                this.tCombo.Items.Add("07:00");

            if (!l1.Contains("730"))
                this.tCombo.Items.Add("07:30");

            if (!l1.Contains("80"))
                this.tCombo.Items.Add("08:00");

            if (!l1.Contains("830"))
                this.tCombo.Items.Add("08:30");

            if (!l1.Contains("90"))
                this.tCombo.Items.Add("09:00");

            if (!l1.Contains("930"))
                this.tCombo.Items.Add("09:30");

            if (!l1.Contains("100"))
                this.tCombo.Items.Add("10:00");

            if (!l1.Contains("1030"))
                this.tCombo.Items.Add("10:30");

            if (!l1.Contains("110"))
                this.tCombo.Items.Add("11:00");

            if (!l1.Contains("1130"))
                this.tCombo.Items.Add("11:30");

            if (!l1.Contains("120"))
                this.tCombo.Items.Add("12:00");

            if (!l1.Contains("1230"))
                this.tCombo.Items.Add("12:30");

            if (!l1.Contains("130"))
                this.tCombo.Items.Add("13:00");

            if (!l1.Contains("1330"))
                this.tCombo.Items.Add("13:30");
        }
        private void fillComboTime2(List<visit> lastVisits)
        {
            lastVisits.ForEach(lv => l2.Add(lv.date.Hour.ToString() + lv.date.Minute.ToString()));

            if (!l2.Contains("140"))
                this.tCombo.Items.Add("14:00");

            if (!l2.Contains("1430"))
                this.tCombo.Items.Add("14:30");

            if (!l2.Contains("150"))
                this.tCombo.Items.Add("15:00");

            if (!l2.Contains("1530"))
                this.tCombo.Items.Add("15:30");

            if (!l2.Contains("160"))
                this.tCombo.Items.Add("16:00");

            if (!l2.Contains("1630"))
                this.tCombo.Items.Add("16:30");

            if (!l2.Contains("170"))
                this.tCombo.Items.Add("17:00");

            if (!l2.Contains("1730"))
                this.tCombo.Items.Add("17:30");

            if (!l2.Contains("180"))
                this.tCombo.Items.Add("18:00");

            if (!l2.Contains("1830"))
                this.tCombo.Items.Add("18:30");

            if (!l2.Contains("190"))
                this.tCombo.Items.Add("19:00");

            if (!l2.Contains("1930"))
                this.tCombo.Items.Add("19:30");
        }
        private void fillComboTime3(List<visit> lastVisits)
        {
            lastVisits.ForEach(lv => l2.Add(lv.date.Hour.ToString() + lv.date.Minute.ToString()));

            if (!l3.Contains("200"))
                this.tCombo.Items.Add("20:00");

            if (!l3.Contains("2030"))
                this.tCombo.Items.Add("20:30");

            if (!l3.Contains("210"))
                this.tCombo.Items.Add("21:00");

            if (!l3.Contains("2130"))
                this.tCombo.Items.Add("21:30");

            if (!l3.Contains("220"))
                this.tCombo.Items.Add("22:00");

            if (!l3.Contains("2230"))
                this.tCombo.Items.Add("22:30");

            if (!l3.Contains("230"))
                this.tCombo.Items.Add("23:00");

            if (!l3.Contains("2330"))
                this.tCombo.Items.Add("23:30");
        }
        private void tCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (this.pCombo.SelectedIndex == -1)
                MessageBox.Show("بیمار را انتخاب کنید");
            else
            {
                visit v = new visit();

                v.doctor_schedule_id = dci;
                v.patient_id = Convert.ToInt32(context.patients.ToArray()[this.pCombo.SelectedIndex].id);
                v.date = new DateTime(
                        this.monthCalendar1.SelectionRange.Start.Year,
                        this.monthCalendar1.SelectionRange.Start.Month,
                        this.monthCalendar1.SelectionRange.Start.Day,
                        Convert.ToInt32(this.tCombo.SelectedItem.ToString().Split(':')[0]),
                        Convert.ToInt32(this.tCombo.SelectedItem.ToString().Split(':')[1]),
                        0
                    );

                context.visits.Add(v);
                context.SaveChanges();
            }

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void cleanB_Click(object sender, EventArgs e)
        {
            Clean();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private bool inArray(List<int> numbers, int number)
        {
            for (int i = 0; i < numbers.Count; i++)
                if (numbers[i] == number)
                    return true;
            return false;
        }

        private void Clean()
        {
            this.dCombo.SelectedIndex = -1;
            this.dCombo.SelectedItem = "";

            this.pCombo.SelectedIndex = -1;
            this.pCombo.SelectedItem = "";

            this.tCombo.SelectedIndex = -1;
            this.tCombo.SelectedItem = "";

            this.searchBox.Text = "";

            date = true;
            d = true;
            t = true;
        }
    }

}
