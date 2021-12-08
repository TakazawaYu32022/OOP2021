using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleKakeibo
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            var value = new int[12];
            for (var i = 0; i < 12; i++)
            {
                var tb = (TextBox)Controls[$"Data{i + 1}"];
                value[i] = int.Parse(tb.Text);
            }
            //家計簿を記録した年月をファイル名にする。
            //StreamWriter file = new StreamWriter(${ date.Year.ToString() + "年" + date.Month.ToString() + "月" }, Encoding.UTF8);
            for(int i = 0; i < value.Length; i++)
            {
                //file = value[i];
            }
        }

        private void btTotal_Click(object sender, EventArgs e)
        {
            int Yosan = 0;
            int Hiyou = 0;
            int kekka = 0;
            var value = new int[12];
            try
            {
                Yosan = int.Parse(tbData1.Text);
                Hiyou = int.Parse(tbData2.Text) + int.Parse(tbData3.Text) + int.Parse(tbData4.Text) 
                            + int.Parse(tbData5.Text) + int.Parse(tbData6.Text) + int.Parse(tbData7.Text) 
                            + int.Parse(tbData8.Text) + int.Parse(tbData9.Text) + int.Parse(tbData10.Text) + int.Parse(tbData11.Text);
                kekka = Yosan - Hiyou;
                

            }
            catch(Exception)
            {
                MessageBox.Show("数字のみ入力してください。");
            }
            tbData12.Text = String.Format("{0:#,##0}", kekka);


        }

        private void Start_Load(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            lbDay.Text = dt.Year.ToString() + "年" +dt.Month.ToString() + "月";
        }
    }
}
