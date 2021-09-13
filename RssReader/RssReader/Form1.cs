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
using System.Xml;
using System.Xml.Linq;

namespace RssReader
{
    public partial class Form1 : Form
    {
        IEnumerable<ItemData> items = null;
        //List<string> link = new List<string>();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            setRssTitle(tbUrl.Text);
            
        }

        private void setRssTitle(string uri)
        {

            using (var wc = new WebClient())
            {
                wc.Headers.Add("Content-type", "charset=UTF-8");
                var stream = wc.OpenRead(uri);
                XDocument xdoc = XDocument.Load(stream);
                items = xdoc.Root.Descendants("item").Select(x => new ItemData
                {
                    Title = (string)x.Element("title"),
                    Link = (string)x.Element("link"),
                    PubDate = (DateTime)x.Element("pubDate"),
                    Description = (string)x.Element("description")
                });
                foreach (var item in items)
                {
                    lbTitles.Items.Add(item.Title);
                    //link.Add(item.Link);

                    /*lbTitles.Items.Add(item.Element("title").Value);
                    link.Add(item.Element("link").Value);*/

                }
            }
            

        }

        private void lbTitles_Click(object sender, EventArgs e)
        {
            /*string link = (items.ToArray())[lbTitles.SelectedIndex].Link;
            wbBrowser.Url = new Uri(link);*/
            label2.Text += "更新日:";
            label2.Text += (items.ToArray())[lbTitles.SelectedIndex].PubDate;
            label2.Text += "\n概要\n";
            label2.Text += (items.ToArray())[lbTitles.SelectedIndex].Description;

        }

        private void btDisplay_Click(object sender, EventArgs e)
        {
            string link = (items.ToArray())[lbTitles.SelectedIndex].Link;
            var wbForm = new Form2();
            wbForm.wbBrowser.Url = new Uri(link);
            wbForm.Show();
            
        }

    }
}
