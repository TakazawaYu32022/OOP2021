
namespace RssReader
{
    partial class Form2
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
            this.wbBrowser = new System.Windows.Forms.WebBrowser();
            this.btBack = new System.Windows.Forms.Button();
            this.btGo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // wbBrowser
            // 
            this.wbBrowser.Location = new System.Drawing.Point(-2, 106);
            this.wbBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbBrowser.Name = "wbBrowser";
            this.wbBrowser.ScriptErrorsSuppressed = true;
            this.wbBrowser.Size = new System.Drawing.Size(800, 525);
            this.wbBrowser.TabIndex = 0;
            // 
            // btBack
            // 
            this.btBack.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btBack.Location = new System.Drawing.Point(12, 53);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(75, 47);
            this.btBack.TabIndex = 1;
            this.btBack.Text = "戻る";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // btGo
            // 
            this.btGo.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btGo.Location = new System.Drawing.Point(120, 53);
            this.btGo.Name = "btGo";
            this.btGo.Size = new System.Drawing.Size(75, 47);
            this.btGo.TabIndex = 2;
            this.btGo.Text = "進む";
            this.btGo.UseVisualStyleBackColor = true;
            this.btGo.Click += new System.EventHandler(this.btGo_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 643);
            this.Controls.Add(this.btGo);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.wbBrowser);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Button btGo;
        public System.Windows.Forms.WebBrowser wbBrowser;
    }
}