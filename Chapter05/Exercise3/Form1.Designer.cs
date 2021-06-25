
namespace Exercise3 {
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
            this.label1 = new System.Windows.Forms.Label();
            this.inputStrText = new System.Windows.Forms.TextBox();
            this.Button5_3_1 = new System.Windows.Forms.Button();
            this.TextBoxSpaceCount = new System.Windows.Forms.TextBox();
            this.Button5_3_2 = new System.Windows.Forms.Button();
            this.TextBoxWordChange = new System.Windows.Forms.TextBox();
            this.Button5_3_3 = new System.Windows.Forms.Button();
            this.TextBoxWordCount = new System.Windows.Forms.TextBox();
            this.Button5_3_4 = new System.Windows.Forms.Button();
            this.TextBoxWordCount4 = new System.Windows.Forms.TextBox();
            this.Button5_3_5 = new System.Windows.Forms.Button();
            this.TextBoxJoinWord = new System.Windows.Forms.TextBox();
            this.Button5_4 = new System.Windows.Forms.Button();
            this.outputStrData = new System.Windows.Forms.TextBox();
            this.inputStrData = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(70, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "問題5.3";
            // 
            // inputStrText
            // 
            this.inputStrText.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.inputStrText.Location = new System.Drawing.Point(75, 110);
            this.inputStrText.Name = "inputStrText";
            this.inputStrText.Size = new System.Drawing.Size(637, 28);
            this.inputStrText.TabIndex = 1;
            // 
            // Button5_3_1
            // 
            this.Button5_3_1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Button5_3_1.Location = new System.Drawing.Point(75, 173);
            this.Button5_3_1.Name = "Button5_3_1";
            this.Button5_3_1.Size = new System.Drawing.Size(62, 55);
            this.Button5_3_1.TabIndex = 2;
            this.Button5_3_1.Text = "問題5.3.1";
            this.Button5_3_1.UseVisualStyleBackColor = true;
            this.Button5_3_1.Click += new System.EventHandler(this.Button5_3_1_Click);
            // 
            // TextBoxSpaceCount
            // 
            this.TextBoxSpaceCount.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TextBoxSpaceCount.Location = new System.Drawing.Point(177, 194);
            this.TextBoxSpaceCount.Name = "TextBoxSpaceCount";
            this.TextBoxSpaceCount.Size = new System.Drawing.Size(187, 34);
            this.TextBoxSpaceCount.TabIndex = 3;
            // 
            // Button5_3_2
            // 
            this.Button5_3_2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Button5_3_2.Location = new System.Drawing.Point(34, 255);
            this.Button5_3_2.Name = "Button5_3_2";
            this.Button5_3_2.Size = new System.Drawing.Size(103, 55);
            this.Button5_3_2.TabIndex = 2;
            this.Button5_3_2.Text = "big → small";
            this.Button5_3_2.UseVisualStyleBackColor = true;
            this.Button5_3_2.Click += new System.EventHandler(this.Button5_3_2_Click);
            // 
            // TextBoxWordChange
            // 
            this.TextBoxWordChange.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TextBoxWordChange.Location = new System.Drawing.Point(177, 276);
            this.TextBoxWordChange.Name = "TextBoxWordChange";
            this.TextBoxWordChange.Size = new System.Drawing.Size(535, 34);
            this.TextBoxWordChange.TabIndex = 3;
            // 
            // Button5_3_3
            // 
            this.Button5_3_3.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Button5_3_3.Location = new System.Drawing.Point(34, 352);
            this.Button5_3_3.Name = "Button5_3_3";
            this.Button5_3_3.Size = new System.Drawing.Size(103, 54);
            this.Button5_3_3.TabIndex = 4;
            this.Button5_3_3.Text = "count word";
            this.Button5_3_3.UseVisualStyleBackColor = true;
            this.Button5_3_3.Click += new System.EventHandler(this.Button5_3_3_Click);
            // 
            // TextBoxWordCount
            // 
            this.TextBoxWordCount.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TextBoxWordCount.Location = new System.Drawing.Point(177, 372);
            this.TextBoxWordCount.Name = "TextBoxWordCount";
            this.TextBoxWordCount.Size = new System.Drawing.Size(535, 34);
            this.TextBoxWordCount.TabIndex = 5;
            // 
            // Button5_3_4
            // 
            this.Button5_3_4.Location = new System.Drawing.Point(34, 466);
            this.Button5_3_4.Name = "Button5_3_4";
            this.Button5_3_4.Size = new System.Drawing.Size(103, 47);
            this.Button5_3_4.TabIndex = 6;
            this.Button5_3_4.Text = "４文字以下を列挙";
            this.Button5_3_4.UseVisualStyleBackColor = true;
            this.Button5_3_4.Click += new System.EventHandler(this.Button5_3_4_Click);
            // 
            // TextBoxWordCount4
            // 
            this.TextBoxWordCount4.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TextBoxWordCount4.Location = new System.Drawing.Point(177, 479);
            this.TextBoxWordCount4.Name = "TextBoxWordCount4";
            this.TextBoxWordCount4.Size = new System.Drawing.Size(534, 34);
            this.TextBoxWordCount4.TabIndex = 7;
            // 
            // Button5_3_5
            // 
            this.Button5_3_5.Location = new System.Drawing.Point(34, 569);
            this.Button5_3_5.Name = "Button5_3_5";
            this.Button5_3_5.Size = new System.Drawing.Size(87, 33);
            this.Button5_3_5.TabIndex = 8;
            this.Button5_3_5.Text = "連結";
            this.Button5_3_5.UseVisualStyleBackColor = true;
            this.Button5_3_5.Click += new System.EventHandler(this.Button5_3_5_Click);
            // 
            // TextBoxJoinWord
            // 
            this.TextBoxJoinWord.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TextBoxJoinWord.Location = new System.Drawing.Point(175, 569);
            this.TextBoxJoinWord.Name = "TextBoxJoinWord";
            this.TextBoxJoinWord.Size = new System.Drawing.Size(536, 34);
            this.TextBoxJoinWord.TabIndex = 9;
            // 
            // Button5_4
            // 
            this.Button5_4.Location = new System.Drawing.Point(34, 674);
            this.Button5_4.Name = "Button5_4";
            this.Button5_4.Size = new System.Drawing.Size(87, 39);
            this.Button5_4.TabIndex = 10;
            this.Button5_4.Text = "問題5_4";
            this.Button5_4.UseVisualStyleBackColor = true;
            this.Button5_4.Click += new System.EventHandler(this.Button5_4_Click);
            // 
            // outputStrData
            // 
            this.outputStrData.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.outputStrData.Location = new System.Drawing.Point(173, 724);
            this.outputStrData.Multiline = true;
            this.outputStrData.Name = "outputStrData";
            this.outputStrData.Size = new System.Drawing.Size(539, 142);
            this.outputStrData.TabIndex = 11;
            // 
            // inputStrData
            // 
            this.inputStrData.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.inputStrData.Location = new System.Drawing.Point(173, 684);
            this.inputStrData.Name = "inputStrData";
            this.inputStrData.Size = new System.Drawing.Size(538, 34);
            this.inputStrData.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 900);
            this.Controls.Add(this.inputStrData);
            this.Controls.Add(this.outputStrData);
            this.Controls.Add(this.Button5_4);
            this.Controls.Add(this.TextBoxJoinWord);
            this.Controls.Add(this.Button5_3_5);
            this.Controls.Add(this.TextBoxWordCount4);
            this.Controls.Add(this.Button5_3_4);
            this.Controls.Add(this.TextBoxWordCount);
            this.Controls.Add(this.Button5_3_3);
            this.Controls.Add(this.TextBoxWordChange);
            this.Controls.Add(this.TextBoxSpaceCount);
            this.Controls.Add(this.Button5_3_2);
            this.Controls.Add(this.Button5_3_1);
            this.Controls.Add(this.inputStrText);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputStrText;
        private System.Windows.Forms.Button Button5_3_1;
        private System.Windows.Forms.TextBox TextBoxSpaceCount;
        private System.Windows.Forms.Button Button5_3_2;
        private System.Windows.Forms.TextBox TextBoxWordChange;
        private System.Windows.Forms.Button Button5_3_3;
        private System.Windows.Forms.TextBox TextBoxWordCount;
        private System.Windows.Forms.Button Button5_3_4;
        private System.Windows.Forms.TextBox TextBoxWordCount4;
        private System.Windows.Forms.Button Button5_3_5;
        private System.Windows.Forms.TextBox TextBoxJoinWord;
        private System.Windows.Forms.Button Button5_4;
        private System.Windows.Forms.TextBox outputStrData;
        private System.Windows.Forms.TextBox inputStrData;
    }
}

