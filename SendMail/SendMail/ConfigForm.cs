using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace SendMail
{
    public partial class ConfigForm : Form
    {
        private Settings s = Settings.getInstance();
        public ConfigForm()
        {
            InitializeComponent();
        }

        private void ConfigForm_Load(object sender, EventArgs e)
        {
            tbHost.Text = s.Host;
            tbPort.Text = s.Port.ToString();
            tbUserName.Text = s.MailAddr;
            tbPass.Text = s.Pass;
            cbSsl.Checked = s.Ssl;
            tbSender.Text = s.MailAddr;
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            //Settingオブジェクトに入力データを渡して登録を行う
            //s.setSendConfig(tbHost.Text, int.Parse(tbPort.Text), tbUserName.Text, tbPass.Text, cbSsl.Checked);
            //SettingRegist();
            btApply_Click(sender, e);//適用ボタンの処理を呼び出し。
            this.Close();
            
        }


        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btApply_Click(object sender, EventArgs e)
        {
            //Settingオブジェクトに入力データを渡して登録を行う
            s.setSendConfig(tbHost.Text, int.Parse(tbPort.Text), tbUserName.Text, tbPass.Text, cbSsl.Checked);
        }

        private void btDefault_Click(object sender, EventArgs e)
        {
            
            tbHost.Text = s.sHost();//ホスト名
            tbPort.Text = s.sPort();//ポート
            tbUserName.Text = s.sMailAddr();//ユーザー名
            tbPass.Text = s.sPass();//パスワード
            cbSsl.Checked = s.cbSsl();//SSL
            tbSender.Text = s.sMailAddr();//送信元
            
        }
    }
}
