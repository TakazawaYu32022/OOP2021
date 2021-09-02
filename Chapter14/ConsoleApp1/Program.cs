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
            //DownloadString();
            //DownloadFileAsync();
            var results = GetWeatherReportFromYahoo(4610);
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
