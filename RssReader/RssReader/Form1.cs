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
        List<string> link = new List<string>();
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

            var wc = new WebClient();
            wc.Headers.Add("Content-type", "charset=UTF-8");
            var uriString = string.Format(uri);
            var url = new Uri(uriString);
            var stream = wc.OpenRead(url);
            XDocument xdoc = XDocument.Load(stream);
            var nodes = xdoc.Root.Descendants("title");
            foreach(var node in nodes)
            {
                string s = Regex.Replace(node.Value, "Yahoo!ニュース・トピックス - 国内| - ", "");
                lbTitles.Items.Add(s);
            }
            foreach(var a in nodes)
            {
                link = lbTitles.SelectedIndex;
                wbBrowser.Url = ;
            }
            

        }

        private void lbTitles_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }
    }
}
