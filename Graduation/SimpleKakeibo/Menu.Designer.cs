
namespace SimpleKakeibo
{
    partial class Menu
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btStart = new System.Windows.Forms.Button();
            this.btComparison = new System.Windows.Forms.Button();
            this.btStatistics = new System.Windows.Forms.Button();
            this.btEnd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(181, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "簡単家計簿";
            // 
            // btStart
            // 
            this.btStart.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btStart.Location = new System.Drawing.Point(75, 166);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(110, 64);
            this.btStart.TabIndex = 1;
            this.btStart.Text = "始める";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // btComparison
            // 
            this.btComparison.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btComparison.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btComparison.Location = new System.Drawing.Point(75, 266);
            this.btComparison.Name = "btComparison";
            this.btComparison.Size = new System.Drawing.Size(110, 64);
            this.btComparison.TabIndex = 1;
            this.btComparison.Text = "比較する";
            this.btComparison.UseVisualStyleBackColor = true;
            this.btComparison.Click += new System.EventHandler(this.btComparison_Click);
            // 
            // btStatistics
            // 
            this.btStatistics.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btStatistics.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btStatistics.Location = new System.Drawing.Point(346, 166);
            this.btStatistics.Name = "btStatistics";
            this.btStatistics.Size = new System.Drawing.Size(110, 64);
            this.btStatistics.TabIndex = 1;
            this.btStatistics.Text = "統計";
            this.btStatistics.UseVisualStyleBackColor = true;
            this.btStatistics.Click += new System.EventHandler(this.btStatistics_Click);
            // 
            // btEnd
            // 
            this.btEnd.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btEnd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btEnd.Location = new System.Drawing.Point(346, 266);
            this.btEnd.Name = "btEnd";
            this.btEnd.Size = new System.Drawing.Size(110, 64);
            this.btEnd.TabIndex = 1;
            this.btEnd.Text = "終了";
            this.btEnd.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 342);
            this.Controls.Add(this.btEnd);
            this.Controls.Add(this.btStatistics);
            this.Controls.Add(this.btComparison);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.label1);
            this.Name = "Menu";
            this.Text = "簡単家計簿";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Button btComparison;
        private System.Windows.Forms.Button btStatistics;
        private System.Windows.Forms.Button btEnd;
    }
}

