using KantanKakeibo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleKakeibo
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            Start start = new Start();
            start.ShowDialog();
        }

        private void btComparison_Click(object sender, EventArgs e)
        {
            Comparison comparison = new Comparison();
            comparison.ShowDialog();
        }

        private void btStatistics_Click(object sender, EventArgs e)
        {
            Statistics statistics = new Statistics();
            statistics.ShowDialog();
        }
    }
}
