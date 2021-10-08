using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SendMail
{
    public class Settings
    {
        private static Settings instance = null;

        //送信データ設定済み
        public　static bool Ready { get; private set; } = true;

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
            if (instance == null)
            {
                instance = new Settings();

                try { 
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
                //ファイルがない場合(初回起動時)
                catch(Exception ex)
                {
                    Ready = false;//データ未設定
                }
            }
                return instance;
        }

        //送信データ登録
        public bool setSendConfig(string host,int port,string mailAddr,string pass,bool ssl)
        {
            Port = port;
            Host = host;
            MailAddr = mailAddr;
            Pass = pass;
            Ssl = ssl;

            //XMLファイルへ書き出し(シリアル化)【P302参照】
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

            Ready = true;

            return true;//登録完了
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
