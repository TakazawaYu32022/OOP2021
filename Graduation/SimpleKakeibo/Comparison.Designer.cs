
namespace KantanKakeibo
{
    partial class Comparison
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dtpData1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpData2 = new System.Windows.Forms.DateTimePicker();
            this.btChoice = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(17, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(460, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "比較するデータを選んでください。";
            // 
            // dtpData1
            // 
            this.dtpData1.CustomFormat = "yyyy/MM";
            this.dtpData1.Font = new System.Drawing.Font("HGS創英角ﾎﾟｯﾌﾟ体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dtpData1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpData1.Location = new System.Drawing.Point(12, 123);
            this.dtpData1.Name = "dtpData1";
            this.dtpData1.Size = new System.Drawing.Size(141, 26);
            this.dtpData1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(205, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "と";
            // 
            // dtpData2
            // 
            this.dtpData2.CustomFormat = "yyyy/MM";
            this.dtpData2.Font = new System.Drawing.Font("HGS創英角ﾎﾟｯﾌﾟ体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dtpData2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpData2.Location = new System.Drawing.Point(283, 123);
            this.dtpData2.Name = "dtpData2";
            this.dtpData2.Size = new System.Drawing.Size(141, 26);
            this.dtpData2.TabIndex = 1;
            // 
            // btChoice
            // 
            this.btChoice.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btChoice.Location = new System.Drawing.Point(260, 230);
            this.btChoice.Name = "btChoice";
            this.btChoice.Size = new System.Drawing.Size(98, 43);
            this.btChoice.TabIndex = 3;
            this.btChoice.Text = "決定";
            this.btChoice.UseVisualStyleBackColor = true;
            this.btChoice.Click += new System.EventHandler(this.btChoice_Click);
            // 
            // btCancel
            // 
            this.btCancel.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btCancel.Location = new System.Drawing.Point(364, 230);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(98, 43);
            this.btCancel.TabIndex = 3;
            this.btCancel.Text = "キャンセル";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // Comparison
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 284);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btChoice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpData2);
            this.Controls.Add(this.dtpData1);
            this.Controls.Add(this.label1);
            this.Name = "Comparison";
            this.Text = "Comparison";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpData1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpData2;
        private System.Windows.Forms.Button btChoice;
        private System.Windows.Forms.Button btCancel;
    }
}