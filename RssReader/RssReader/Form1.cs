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
            XmlTextReader reader = new XmlTextReader(tbUrl.Text);
            var wc = new WebClient();
            wc.Headers.Add("Content-type", "charset=UTF-8");
            var uriString = string.Format(@"reader",uri);
            var url = new Uri(uriString);
            var stream = wc.OpenRead(url);
            XDocument xdoc = XDocument.Load(stream);
            var nodes = xdoc.Root.Descendants("title");
            foreach(var node in nodes)
            {
                lbTitles.Text += node;
            }
        }
    }
}
