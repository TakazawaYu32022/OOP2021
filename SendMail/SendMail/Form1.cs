using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace SendMail
{
    public partial class Form1 : Form
    {
        //設定画面
        ConfigForm configform = new ConfigForm();
        //設定情報
        private Settings s = Settings.getInstance();
        public Form1()
        {
            InitializeComponent();
        }

        private void btSend_Click(object sender, EventArgs e)
        {
            try
            {
                //メール送信のためのインスタンスを生成
                MailMessage mailMessage = new MailMessage();
                //差出人アドレス
                mailMessage.From = new MailAddress(s.MailAddr);
                //宛先（To）
                mailMessage.To.Add(tbTo.Text);
                //Cc
                //mailMessage.CC.Add(tbCc.Text);
                //Bcc
                //mailMessage.Bcc.Add(tbBcc.Text);
                //件名（タイトル）
                if(tbCc.Text != "")
                {
                    mailMessage.CC.Add(tbCc.Text);
                    if(tbBcc.Text != "")
                    {
                        mailMessage.Bcc.Add(tbBcc.Text);
                    }
                }
                mailMessage.Subject = tbTitle.Text;
                //本文
                mailMessage.Body = tbMessage.Text;

                //SMTPを使ってメールを送信する
                SmtpClient smtpClient = new SmtpClient();
                //メール送信のための認証情報を設定（ユーザー名、パスワード）
                smtpClient.Credentials
                    = new NetworkCredential(s.MailAddr, s.Pass);
                smtpClient.Host = s.Host;
                smtpClient.Port = s.Port;
                smtpClient.EnableSsl = s.Ssl;

                //送信完了時に呼ばれるイベントハンドラの登録
                smtpClient.SendCompleted += SmtpClient_SendCompleted;
                string userState = "SendMail";
                smtpClient.SendAsync(mailMessage, userState);

                /*smtpClient.Send(mailMessage);

                MessageBox.Show("送信完了");*/
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SmtpClient_SendCompleted(object sender,AsyncCompletedEventArgs e)
        {
            if(e.Error != null)
            {
                MessageBox.Show(e.Error.Message);
            }
            else
            {
                MessageBox.Show("送信完了");
            }
        }

        private void btConfig_Click(object sender, EventArgs e)
        {
            configform.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(@"mailsetting.xml"))
            {
                using (var reader = XmlReader.Create("mailsetting.xml"))
                {
                    var serializer = new DataContractSerializer(typeof(Settings));
                    var set = serializer.ReadObject(reader) as Settings;
                    s.Port = set.Port;
                    s.Host = set.Host;
                    s.MailAddr = set.MailAddr;
                    s.Pass = set.Pass;
                    s.Ssl = set.Ssl;
                }
            }
            else
            {
                configform.ShowDialog();
            }

        }
    }
}
