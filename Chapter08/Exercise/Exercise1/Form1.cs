using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btToday_Click(object sender, EventArgs e) {
            var today = DateTime.Now;

            var culture = new CultureInfo("ja-JP");
            culture.DateTimeFormat.Calendar = new JapaneseCalendar();
            var era = culture.DateTimeFormat.Calendar.GetEra(today);
            var eraName = culture.DateTimeFormat.GetEraName(era);
            var dayOfWeek = culture.DateTimeFormat.GetDayName(today.DayOfWeek);

            tbDateDisp.Text = string.Format("{0:yyyy/M/d HH:mm}", today) + "\r\n";
            tbDateDisp.Text += string.Format("{0:yyyy年M月d日 HH時mm分ss秒}", today) + "\r\n";
            tbDateDisp.Text += today.ToString("ggyy年M月d日 " + "("+dayOfWeek +")" , culture) ;
            

            //年月日だけの場合
            //tbDateDisp.Text = today.ToString("d");
        }

        private void Form1_Load(object sender, EventArgs e) {
            
            Timer tm = new Timer();
            tm.Tick += Tm_Tick;
            tm.Interval = 500;//ms
            tm.Start();
            
            tssTimeLabel.Text = DateTime.Now.ToString();
        }

        //タイマーが切れたときに呼ばれるイベントハンドラ
        private void Tm_Tick(object sender, EventArgs e) {
            tssTimeLabel.Text = DateTime.Now.ToString();
        }
    }
}
