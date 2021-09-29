using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendMail
{
    public class Settings
    {
        public int Port { get; set; }//ポート番号
        public string Host { get; set; }//ホスト名
        public string MailAddr { get; set; }//メールアドレス
        public string Pass { get; set; }//パスワード
        public bool Ssl { get; set; }//SSL

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
            return "OjsInfosys2019";//パスワード
        }
    }
}
