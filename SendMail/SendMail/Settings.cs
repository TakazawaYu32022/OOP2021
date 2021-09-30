﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        private Settings(){}

        //インスタンスの取得
        public static Settings getInstance()
        {
            if(instance == null)
            {
                instance = new Settings();
            }
            return instance;
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
            return "Infosys2019";//パスワード
        }
        public bool cbSsl()
        {
            return true;
        }
    }
}
