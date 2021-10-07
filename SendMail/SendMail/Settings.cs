using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SendMail
{
    public class Settings
    {
        private static Settings instance = null;

        public int Port { get; set; }//ポート番号
        public string Host { get; set; }//ホスト名
        public string MailAddr { get; set; }//メールアドレス
        public string Pass { get; set; }//パスワード
        public bool Ssl { get; set; }//SSL

        //コンストラクタ
        private Settings(){


        }

        //インスタンスの取得
        public static Settings getInstance()
        {
            if(instance == null)
            {
                instance = new Settings();
            }
            return instance;

            if (File.Exists(@"mailsetting.xml"))
            {
                //XMLファイルを読み込み(逆シリアル化)【P303参照】
                using (var reader = XmlReader.Create("mailsetting.xml"))
                {
                    var serializer = new DataContractSerializer(typeof(Settings));
                    var set = serializer.ReadObject(reader) as Settings;
                    instance.Port = set.Port;
                    instance.Host = set.Host;
                    instance.MailAddr = set.MailAddr;
                    instance.Pass = set.Pass;
                    instance.Ssl = set.Ssl;
                }
            }
            /*else
            {
                Form1.configform.ShowDialog();
            }*/
            return instance;
        }

        //送信データ登録
        public void setSendConfig(string host,int port,string mailAddr,string pass,bool ssl)
        {
            Port = port;
            Host = host;
            MailAddr = mailAddr;
            Pass = pass;
            Ssl = ssl;

            //XMLファイルへ書き出し(シリアル化)
            var xws = new XmlWriterSettings
            {
                Encoding = new System.Text.UTF8Encoding(false),
                Indent = true,
                IndentChars = "   ",
            };

            using (var writer = XmlWriter.Create("mailsetting.xml", xws))
            {
                var serializer = new DataContractSerializer(this.GetType());
                serializer.WriteObject(writer, this);
            }
        }

        //初期値
        public string sHost()
        {
            return "smtp.gmail.com";//ホスト名
        }
        public string sPort()
        {
            return 587.ToString();//ポート
        }
        public string sMailAddr()
        {
            return "ojsinfosys01@gmail.com";//メールアドレス
        }
        public string sPass()
        {
            return "Infosys2021";//パスワード
        }
        public bool cbSsl()
        {
            return true;
        }
    }
}
