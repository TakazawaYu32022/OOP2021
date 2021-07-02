using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btAction_Click(object sender, EventArgs e) {
            //nudはキャストする(int)
            var today = new DateTime((int)nudYear.Value, (int)nudMonth.Value, (int)nudDay.Value);
            //var today = DateTime.Today;
            DayOfWeek dayOfWeek = today.DayOfWeek;

            string dow = "";

            switch (dayOfWeek) {
                case DayOfWeek.Sunday:
                    dow = "日曜日";
                    break;
                case DayOfWeek.Monday:
                    dow = "月曜日";
                    break;
                case DayOfWeek.Tuesday:
                    dow = "火曜日";
                    break;
                case DayOfWeek.Wednesday:
                    dow = "水曜日";
                    break;
                case DayOfWeek.Thursday:
                    dow = "木曜日";
                    break;
                case DayOfWeek.Friday:
                    dow = "金曜日";
                    break;
                case DayOfWeek.Saturday:
                    dow = "土曜日";
                    break;
                default:
                    break;
            }
            tbOutput.Text = "今日は" + dow + "です";

            var isLeapYear = DateTime.IsLeapYear((int)nudYear.Value);
            if (isLeapYear) {
                tbLeapYear.Text = "閏年です";
            } else { 
                tbLeapYear.Text = "閏年ではありません";
            }

            var td = DateTime.Today;
            var birthday = new DateTime((int)nudYear.Value, (int)nudMonth.Value, (int)nudDay.Value);
            TimeSpan diff = td.Date - birthday.Date;
            tbTotalDay.Text =  "生まれてから" + diff.Days + "日経過";


            //tbOutput.Text = DateTime.Today.DayOfYear.ToString();
        }
    }
}
