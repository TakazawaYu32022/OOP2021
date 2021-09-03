using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Section04
{
    class Program
    {

        static void Main(string[] args)
        {
            new Program();
        }

        public Program()
        {
            int areacode = 0;
            Console.WriteLine("地域コードを入力");
            Console.WriteLine("1.前橋");
            Console.WriteLine("2.みなかみ");
            Console.WriteLine("3.宇都宮");
            Console.WriteLine("4.水戸");
            Console.WriteLine("9.その他(直接入力)");
            areacode = int.Parse(Console.ReadLine());
            if (areacode == 1)
            {
                areacode = 4210;//前橋
            } else if(areacode == 2)
            {
                areacode = 4220;//みなかみ
            }else if(areacode == 3)
            {
                areacode = 4110;//宇都宮
            }else if(areacode == 4)
            {
                areacode = 4010;//水戸
            }else if(areacode == 9)
            {
                Console.WriteLine("直接地域コードを入力");//その他
                areacode = int.Parse(Console.ReadLine());
            }
            
            //DownloadString();
            //DownloadFileAsync();
            var results = GetWeatherReportFromYahoo(areacode);
            foreach(var s in results)
            {
                Console.WriteLine(s);
            }
            Console.ReadLine();//入力待ち
        }

        public void DownloadString()
        {
            var wc = new WebClient();
            wc.Encoding = Encoding.UTF8;//UTF8でEncodingされているのを読み込む
            var html = wc.DownloadString("https://yahoo.co.jp/");
            Console.WriteLine(html);
        }

        private void DownloadFileAsync()
        {
            var wc = new WebClient();
            var url = new Uri(@"C:\Users\yt32022\Pictures\IMG_0283.JPG");
            var filename = @"C:\Temp\example.JPG";//34行の拡張子と合わせる(JPGならJPG,ZipならZip
            wc.DownloadProgressChanged += wc_DownloadProgressChanged;
            wc.DownloadFileCompleted += wc_DownloadFileCompleted;
            wc.DownloadFileAsync(url, filename);
            Console.ReadLine();//アプリケーションが終了しないようにする
        }

        static void wc_DownloadProgressChanged(object sender,
                            DownloadProgressChangedEventArgs e)
        {
            Console.WriteLine("{0}% {1}/{2}", e.ProgressPercentage,
                              e.BytesReceived, e.TotalBytesToReceive);
        }

        static void wc_DownloadFileCompleted(object sender,
                            System.ComponentModel.AsyncCompletedEventArgs e)
        {
            Console.WriteLine("ダウンロード完了");
        }

        //リスト14.18(ストリーム(Youtubeのライブ配信のように読み込みながら)してダウンロード)
        public void OpenReadSample()
        {
            var wc = new WebClient();
            using(var stream = wc.OpenRead(@"https://yahoo.co.jp/"))
            using(var sr = new StreamReader(stream, Encoding.UTF8))
            {
               string html = sr.ReadToEnd();
               Console.WriteLine(html);
            }
        }
        private static IEnumerable<string> GetWeatherReportFromYahoo(int cityCode)
        {
            using (var wc = new WebClient())
            {
                wc.Headers.Add("Content-type", "charset=UTF-8");
                var uriString = string.Format(
                    @"http://rss.weather.yahoo.co.jp/rss/days/{0}.xml", cityCode);
                var url = new Uri(uriString);
                var stream = wc.OpenRead(url);

                XDocument xdoc = XDocument.Load(stream);
                var nodes = xdoc.Root.Descendants("title");
                foreach (var node in nodes)
                {
                    string s = Regex.Replace(node.Value, "【|】| - Yahoo!天気・災害", "");//Replaceは置き換え。【|】を空白に置き換えてる。
                    yield return s;
                }
            }
        }
    }
}
