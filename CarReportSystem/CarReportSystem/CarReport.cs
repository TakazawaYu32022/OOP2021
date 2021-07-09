using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarReportSystem {
     public class CarReport {
        public DateTime Date { get; set; }      //日付
        public string Author { get; set; }     //記録者
        public MakerGroup Maker { get; set; } //メーカー
        public string CarName { get; set; }  //車名
        public string Report { get; set; }  //レポート
        public Image Picture { get; set; } //画像

        //引数付コンストラクタ
       /* public CarReport(DateTime date,string auther,MakerGroup maker,string carname,string report,Image picure){
            this.Date = date;
            this.Auther = auther;
            this.Maker = maker;
            this.CarName = carname;
            this.Report = report;
            this.Picture = picure;
        }*/


        //メーカー
        public enum MakerGroup {
            トヨタ,
            日産,
            ホンダ,
            スバル,
            外国車,
            その他,
        }
    }


}
