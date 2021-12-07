using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        }

        private void btTotal_Click(object sender, EventArgs e)
        {
            int Yosan = 0;
            int Hiyou = 0;
            int kekka = 0;
            try
            {
                Yosan = int.Parse(tbYosan.Text);
                Hiyou = int.Parse(tbYatin.Text) + int.Parse(tbKounetu.Text) + int.Parse(tbTuusin.Text) 
                            + int.Parse(tbSyokuhi.Text) + int.Parse(tbIryou.Text) + int.Parse(tbZappi.Text) 
                            + int.Parse(tbKoutuu.Text) + int.Parse(tbKyouiku.Text) + int.Parse(tbTokubetu.Text) + int.Parse(tbTyokin.Text);
                kekka = Yosan - Hiyou;
                tbGoukei.Text = kekka.ToString();//３桁カンマプログラムする

            }
            catch(Exception)
            {
                MessageBox.Show("数字のみ入力してください。");
            }
            

        }
    }
}
