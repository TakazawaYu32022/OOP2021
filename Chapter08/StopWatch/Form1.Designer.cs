
namespace StopWatch {
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
            this.components = new System.ComponentModel.Container();
            this.btStart = new System.Windows.Forms.Button();
            this.btStop = new System.Windows.Forms.Button();
            this.lbTimerDisp = new System.Windows.Forms.Label();
            this.btReset = new System.Windows.Forms.Button();
            this.btLap = new System.Windows.Forms.Button();
            this.lbLapDisp = new System.Windows.Forms.ListBox();
            this.tmDisp = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(66, 103);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(129, 71);
            this.btStart.TabIndex = 0;
            this.btStart.Text = "スタート";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // btStop
            // 
            this.btStop.Location = new System.Drawing.Point(66, 191);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(129, 71);
            this.btStop.TabIndex = 1;
            this.btStop.Text = "ストップ";
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // lbTimerDisp
            // 
            this.lbTimerDisp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbTimerDisp.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbTimerDisp.Location = new System.Drawing.Point(66, 29);
            this.lbTimerDisp.Name = "lbTimerDisp";
            this.lbTimerDisp.Size = new System.Drawing.Size(286, 43);
            this.lbTimerDisp.TabIndex = 2;
            this.lbTimerDisp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btReset
            // 
            this.btReset.Location = new System.Drawing.Point(223, 103);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(129, 71);
            this.btReset.TabIndex = 3;
            this.btReset.Text = "リセット";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // btLap
            // 
            this.btLap.Location = new System.Drawing.Point(223, 191);
            this.btLap.Name = "btLap";
            this.btLap.Size = new System.Drawing.Size(129, 71);
            this.btLap.TabIndex = 4;
            this.btLap.Text = "ラップ";
            this.btLap.UseVisualStyleBackColor = true;
            this.btLap.Click += new System.EventHandler(this.btLap_Click);
            // 
            // lbLapDisp
            // 
            this.lbLapDisp.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbLapDisp.FormattingEnabled = true;
            this.lbLapDisp.ItemHeight = 16;
            this.lbLapDisp.Location = new System.Drawing.Point(387, 29);
            this.lbLapDisp.Name = "lbLapDisp";
            this.lbLapDisp.Size = new System.Drawing.Size(258, 244);
            this.lbLapDisp.TabIndex = 5;
            // 
            // tmDisp
            // 
            this.tmDisp.Interval = 10;
            this.tmDisp.Tick += new System.EventHandler(this.tmDisp_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 366);
            this.Controls.Add(this.lbLapDisp);
            this.Controls.Add(this.btLap);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.lbTimerDisp);
            this.Controls.Add(this.btStop);
            this.Controls.Add(this.btStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.Label lbTimerDisp;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.Button btLap;
        private System.Windows.Forms.ListBox lbLapDisp;
        private System.Windows.Forms.Timer tmDisp;
    }
}

