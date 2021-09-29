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

namespace Exercise2 {
    public partial class Form1 : Form {
        string inputPath = "";//変換元ファイル（読み込むファイル）
        string outputPath = "";//変換先ファイル

        public Form1() {
            InitializeComponent();
        }

        //変換元のファイルを指定
        private void btOpen_Click(object sender, EventArgs e) {
            if (ofdOpenFile.ShowDialog() == DialogResult.OK) {
                inputPath = ofdOpenFile.FileName;
            }

        }

        //変換したファイルの保存先を指定
        private void btChangeFile_Click(object sender, EventArgs e) {
            if(sfdSaveFile.ShowDialog() == DialogResult.OK) {
                outputPath = sfdSaveFile.FileName;
            }
        }

        //行番号を追加する処理
        private void btChange_Click(object sender, EventArgs e) {
            var lines = File.ReadLines(inputPath).Select((s, ix) => String.Format("{0,4}:{1}", ix + 1, s)).ToArray();
            File.WriteAllLines(outputPath, lines);
        }

        private void btJoin1_Click(object sender, EventArgs e) {
            if (ofdOpenFile.ShowDialog() == DialogResult.OK) {
                inputPath = ofdOpenFile.FileName;
            }
        }

        private void btJoin2_Click(object sender, EventArgs e) {
            if (sfdSaveFile.ShowDialog() == DialogResult.OK) {
                outputPath = sfdSaveFile.FileName;
                var lines = new[] { inputPath };
                File.WriteAllLines(outputPath, lines);

            }
        }
    }
}
