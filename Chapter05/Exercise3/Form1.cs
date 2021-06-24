using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise3 {
    public partial class Form1 : Form {
        //コンストラクタ
        public Form1() {
            //先にコンストラクタが呼ばれる
            InitializeComponent();
        }
        //フォームがロードされるとき、一回だけ実行される
        private void Form1_Load(object sender, EventArgs e) {
            inputStrText.Text = "Jackdaws love my big sphinx of quartz";

        }

        private void Button5_3_1_Click(object sender, EventArgs e) {
            var count = inputStrText.Text.Count(c => c == ' ');
            TextBoxSpaceCount.Text = count.ToString();
        }

        private void Button5_3_2_Click(object sender, EventArgs e) {
            var target = inputStrText.Text;
            var replaced = target.Replace("big", "small");
            TextBoxWordChange.Text = replaced;

        }

        private void Button5_3_3_Click(object sender, EventArgs e) {
            //文字列を空白で分割し、itemsに格納する
            string[] items = inputStrText.Text.Split(' ');
            //itemsの中にある単語を数える
            var count = items.Count();
            TextBoxWordCount.Text = count.ToString();
        }

        private void Button5_3_4_Click(object sender, EventArgs e) {
            var Words = inputStrText.Text.Split(' ').Where(s => s.Length <= 4);
            foreach(var word in Words) {
                TextBoxWordCount4.Text += word + " ";
            }

            
        }

        private void Button5_3_5_Click(object sender, EventArgs e) {
            string[] items = inputStrText.Text.Split(' ');
            var joinword = new StringBuilder();
            foreach(var word in items) {
                joinword.Append(word + " ");
            }
            TextBoxJoinWord.Text = joinword.ToString();

        }

        private void Button5_4_Click(object sender, EventArgs e) {
            var target = "Novelist=谷崎潤一郎;BestWork=春琴抄;Born=1886";
            var value = "BestWork=";
        }
    }
}
