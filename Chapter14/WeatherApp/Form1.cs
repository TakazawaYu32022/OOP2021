using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WeatherApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            int areacode = 0;
            if(cbArea.Text == "前橋")
            {
                areacode = 4210;
            }else if(cbArea.Text == "みなかみ")
            {
                areacode = 4220;
            }else if(cbArea.Text == "宇都宮")
            {
                areacode = 4110;
            }else if(cbArea.Text == "水戸")
            {
                areacode = 4010;
            }
            var results = GetWeatherReportFromYahoo(areacode);
            foreach (var s in results)
            {
                RSSreader.Text += s;
            }
            
            Console.ReadLine();//入力待ち
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
            };
        }
    }
}
