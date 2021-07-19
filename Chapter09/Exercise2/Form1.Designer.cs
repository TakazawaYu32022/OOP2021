
namespace Exercise2 {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.btOpen = new System.Windows.Forms.Button();
            this.ofdOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.btChange = new System.Windows.Forms.Button();
            this.btChangeFile = new System.Windows.Forms.Button();
            this.sfdSaveFile = new System.Windows.Forms.SaveFileDialog();
            this.btJoin1 = new System.Windows.Forms.Button();
            this.btJoin2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btOpen
            // 
            this.btOpen.Location = new System.Drawing.Point(25, 25);
            this.btOpen.Name = "btOpen";
            this.btOpen.Size = new System.Drawing.Size(80, 42);
            this.btOpen.TabIndex = 0;
            this.btOpen.Text = "9-2開く...";
            this.btOpen.UseVisualStyleBackColor = true;
            this.btOpen.Click += new System.EventHandler(this.btOpen_Click);
            // 
            // ofdOpenFile
            // 
            this.ofdOpenFile.FileName = "openFileDialog1";
            // 
            // btChange
            // 
            this.btChange.Location = new System.Drawing.Point(25, 164);
            this.btChange.Name = "btChange";
            this.btChange.Size = new System.Drawing.Size(80, 42);
            this.btChange.TabIndex = 1;
            this.btChange.Text = "行番号追加";
            this.btChange.UseVisualStyleBackColor = true;
            this.btChange.Click += new System.EventHandler(this.btChange_Click);
            // 
            // btChangeFile
            // 
            this.btChangeFile.Location = new System.Drawing.Point(25, 90);
            this.btChangeFile.Name = "btChangeFile";
            this.btChangeFile.Size = new System.Drawing.Size(80, 42);
            this.btChangeFile.TabIndex = 2;
            this.btChangeFile.Text = "変換先";
            this.btChangeFile.UseVisualStyleBackColor = true;
            this.btChangeFile.Click += new System.EventHandler(this.btChangeFile_Click);
            // 
            // btJoin1
            // 
            this.btJoin1.Location = new System.Drawing.Point(200, 25);
            this.btJoin1.Name = "btJoin1";
            this.btJoin1.Size = new System.Drawing.Size(80, 42);
            this.btJoin1.TabIndex = 3;
            this.btJoin1.Text = "9-3開く...";
            this.btJoin1.UseVisualStyleBackColor = true;
            this.btJoin1.Click += new System.EventHandler(this.btJoin1_Click);
            // 
            // btJoin2
            // 
            this.btJoin2.Location = new System.Drawing.Point(201, 90);
            this.btJoin2.Name = "btJoin2";
            this.btJoin2.Size = new System.Drawing.Size(79, 41);
            this.btJoin2.TabIndex = 4;
            this.btJoin2.Text = "追加...";
            this.btJoin2.UseVisualStyleBackColor = true;
            this.btJoin2.Click += new System.EventHandler(this.btJoin2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btJoin2);
            this.Controls.Add(this.btJoin1);
            this.Controls.Add(this.btChangeFile);
            this.Controls.Add(this.btChange);
            this.Controls.Add(this.btOpen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btOpen;
        private System.Windows.Forms.OpenFileDialog ofdOpenFile;
        private System.Windows.Forms.Button btChange;
        private System.Windows.Forms.Button btChangeFile;
        private System.Windows.Forms.SaveFileDialog sfdSaveFile;
        private System.Windows.Forms.Button btJoin1;
        private System.Windows.Forms.Button btJoin2;
    }
}

