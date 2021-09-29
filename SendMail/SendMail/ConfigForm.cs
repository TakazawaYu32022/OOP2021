using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SendMail
{
    public partial class ConfigForm : Form
    {
        Settings s = new Settings();
        public ConfigForm()
        {
            InitializeComponent();
        }

        private void ConfigForm_Load(object sender, EventArgs e)
        {

        }

        private void btOk_Click(object sender, EventArgs e)
        {
            s.Port = tbPort.Text.Length;
            s.Host = tbHost.Text;
            s.MailAddr = tbUserName.Text;
            this.DialogResult = DialogResult.OK;
        }

        private void btDefault_Click(object sender, EventArgs e)
        {
            
            tbHost.Text = s.sHost();
            tbPort.Text = s.sPort();
            tbUserName.Text = s.sMailAddr();
            tbPass.Text = s.sPass();
            
        }
    }
}
