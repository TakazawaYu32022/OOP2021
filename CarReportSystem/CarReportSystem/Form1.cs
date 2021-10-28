using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarReportSystem {
    public partial class fmMain : Form {
        BindingList<CarReport> listCarReport = new BindingList<CarReport>();
        public fmMain() {
            InitializeComponent();
            //dgvRegistData.DataSource = listCarReport;
        }

        private void btExit_Click(object sender, EventArgs e) {
            Application.Exit();//アプリケーション終了
        }
        //画像を開くボタン
        private void btPictureOpen_Click(object sender, EventArgs e) {
            if (ofdPictureOpen.ShowDialog() == DialogResult.OK) {
                pbPicture.Image = Image.FromFile(ofdPictureOpen.FileName);
            }
        }
        //画像削除ボタン
        private void btPictureDelete_Click(object sender, EventArgs e) {
            pbPicture.Image = null;
        }
        //追加ボタン
        private void btDataAdd_Click(object sender, EventArgs e) {
            if (cbAuthor.Text == "" || cbCarName.Text == "") {
                MessageBox.Show("すべての項目を入力してください", "エラー", MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            CarReport carReport = new CarReport {
                Date = dtpDate.Value,
                Author = cbAuthor.Text,
                Maker =selectedGroup(),
                CarName = cbCarName.Text,
                Report = tbReport.Text,
                Picture = pbPicture.Image

            };
            listCarReport.Add(carReport);//1レコード追加

            //コンボボックスの履歴機能
            setCbAuthor(cbAuthor.Text);
            setCbCarName(cbCarName.Text);
        }
        //選択されているメーカーの列挙型を返す
        private CarReport.MakerGroup selectedGroup() {
            foreach(var rb in gbMaker.Controls) {

                if (((RadioButton)rb).Checked) {
                    return (CarReport.MakerGroup)int.Parse(((string)((RadioButton)rb).Tag));
                }
            }
            return CarReport.MakerGroup.その他;

            
        }

        //コンボボックスに記録者をセットする
        private void setCbAuthor(string author) {
            if (!cbAuthor.Items.Contains(author)) {
                cbAuthor.Items.Add(author);
            }

        }
        //コンボボックスに車名をセットする
        private void setCbCarName(string carname) {
            if (!cbCarName.Items.Contains(carname)) {
                cbCarName.Items.Add(carname);
            }
        }



        private void gbMaker_Enter(object sender, EventArgs e) {

        }

        private void rbOther_CheckedChanged(object sender, EventArgs e) {

        }

        private void dgvRegistData_CellClick(object sender, DataGridViewCellEventArgs e) {
            if(e.RowIndex == -1) return; //何も入力していないときの例外処理

            CarReport selectedCar = listCarReport[e.RowIndex];
            dtpDate.Value = selectedCar.Date;
            cbAuthor.Text = selectedCar.Author;
            setMakerRadioButton(selectedCar);
            cbCarName.Text = selectedCar.CarName;
            tbReport.Text = selectedCar.Report;
            pbPicture.Image = selectedCar.Picture;

        }

        private void setMakerRadioButton(CarReport selectedCar) {
            switch (selectedCar.Maker) {
                case CarReport.MakerGroup.トヨタ:
                    rbToyota.Checked = true;
                    break;
                case CarReport.MakerGroup.日産:
                    rbNissan.Checked = true;
                    break;
                case CarReport.MakerGroup.ホンダ:
                    rbHonda.Checked = true;
                    break;
                case CarReport.MakerGroup.スバル:
                    rbSubaru.Checked = true;
                    break;
                case CarReport.MakerGroup.外国車:
                    rbImport.Checked = true;
                    break;
                case CarReport.MakerGroup.その他:
                    rbOther.Checked = true;
                    break;
                default:
                    break;
            }
        }

        private void btDataDelete_Click(object sender, EventArgs e) {
            //listCarReport.RemoveAt(dgvRegistData.CurrentRow.Index);
        }

        private void btDataCorrect_Click(object sender, EventArgs e) {
            //listCarReport[dgvRegistData.CurrentRow.Index].UpDate(dtpDate.Value,cbAuthor.Text,selectedGroup(),cbCarName.Text,tbReport.Text,pbPicture.Image);
            //dgvRegistData.Refresh();//コントロールの強制再描画
        }

        //更新ボタンイベント処理
        private void btUpdate_Click(object sender, EventArgs e){
            if (carReportDataGridView.CurrentRow == null) return;
            carReportDataGridView.CurrentRow.Cells[1].Value = dtpDate.Value;//日付
            carReportDataGridView.CurrentRow.Cells[2].Value = cbAuthor.Text;//記録者
            carReportDataGridView.CurrentRow.Cells[3].Value = selectedGroup().ToString();//メーカー
            carReportDataGridView.CurrentRow.Cells[4].Value = cbCarName.Text;//車名
            carReportDataGridView.CurrentRow.Cells[5].Value = tbReport.Text;//レポート
            carReportDataGridView.CurrentRow.Cells[6].Value = ImageToByteArray(pbPicture.Image);//画像


            //データベースへ反映
            this.Validate();
            this.carReportBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202106DataSet);

#if false
            if(sfdFileSave.ShowDialog()== DialogResult.OK){
                try{
                    //バイナリ形式で、シリアル化
                    BinaryFormatter bf = new BinaryFormatter();

                    using (FileStream fs = File.Open(sfdFileSave.FileName, FileMode.Create)){
                        bf.Serialize(fs, listCarReport);
                    }
                }
                catch(Exception ex){
                    MessageBox.Show(ex.Message);
                }

            }
#endif
        }

        private void btConnect_Click(object sender, EventArgs e){
            // TODO: このコード行はデータを 'infosys202106DataSet.CarReport' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.carReportTableAdapter.Fill(this.infosys202106DataSet.CarReport);

#if false

            if (ofdFileOpen.ShowDialog() == DialogResult.OK){
                try{
                    //逆バイナリ形式で、逆シリアル化
                    var bf = new BinaryFormatter();

                    using (FileStream fs = File.Open(ofdFileOpen.FileName, FileMode.Open, FileAccess.Read)){
                        //逆シリアル化して読み込む
                        listCarReport = (BindingList<CarReport>)bf.Deserialize(fs);
                        dgvRegistData.DataSource = null;
                        dgvRegistData.DataSource = listCarReport;
                    }
                }
                catch(Exception ex){
                    MessageBox.Show(ex.Message);
                }
                
                //読み込んだデータを各コンボボックスに登録する
                foreach(var item in listCarReport){
                    setCbAuthor(item.Author);
                    setCbCarName(item.CarName);

                }
                /*for(int i=0; i < dgvRegistData.RowCount; i++){
                    setCbAuthor(dgvRegistData.Rows[i].Cells[1].Value.ToString());
                    setCbCarName(dgvRegistData.Rows[i].Cells[3].Value.ToString());
                }*/
            }
#endif
        }

        private void fmMain_Load(object sender, EventArgs e){
           
            //dgvRegistData.Columns[5].Visible = false;
        }

        private void carReportBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.carReportBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202106DataSet);

        }

        private void carReportDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (carReportDataGridView.CurrentRow == null) return;
            try
            {
                cbAuthor.Text = carReportDataGridView.CurrentRow.Cells[2].Value.ToString();//記録者
                //メーカー(文字列 → 列挙型)
                setMakerRadioButton((CarReport.MakerGroup)Enum.Parse(typeof(CarReport.MakerGroup),carReportDataGridView.CurrentRow.Cells[3].Value.ToString()));
                cbCarName.Text = carReportDataGridView.CurrentRow.Cells[4].Value.ToString();//車名
                tbReport.Text = carReportDataGridView.CurrentRow.Cells[5].Value.ToString();//レポート
                pbPicture.Image = ByteArrayToImage((byte[])carReportDataGridView.CurrentRow.Cells[6].Value);//画像
            }
            catch (Exception)
            {
                pbPicture.Image = null;
            }
            dtpDate.Value = (DateTime)carReportDataGridView.CurrentRow.Cells[1].Value;//日付
            
            
            
        }

        // バイト配列をImageオブジェクトに変換
        public static Image ByteArrayToImage(byte[] b)
        {
            ImageConverter imgconv = new ImageConverter();
            Image img = (Image)imgconv.ConvertFrom(b);
            return img;
        }
        // Imageオブジェクトをバイト配列に変換
        public static byte[] ImageToByteArray(Image img)
        {
            ImageConverter imgconv = new ImageConverter();
            byte[] b = (byte[])imgconv.ConvertTo(img, typeof(byte[]));
            return b;
        }

    }
}
