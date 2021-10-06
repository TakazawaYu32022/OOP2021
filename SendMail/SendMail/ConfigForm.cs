﻿using System;
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

        }

        private void btOk_Click(object sender, EventArgs e)
        {
            SettingRegist();
            //シリアル化
            var xws = new XmlWriterSettings
            {
                Encoding = new System.Text.UTF8Encoding(false),
                Indent = true,
                IndentChars = "   ",
            };

            using (var writer = XmlWriter.Create("mailsetting.xml", xws))
            {
                var serializer = new DataContractSerializer(s.GetType());
                serializer.WriteObject(writer, s);
            }
                this.Close();
        }

        private void SettingRegist()
        {
            s.Port = int.Parse(tbPort.Text);
            s.Host = tbHost.Text;
            s.MailAddr = tbUserName.Text;
            s.Pass = tbPass.Text;
            s.Ssl = cbSsl.Checked;
            
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btApply_Click(object sender, EventArgs e)
        {
            SettingRegist();//送信データ登録
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
