
namespace IsBasvuru
{
    partial class SifremiUnuttum
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
            this.btnsfrynl = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtml = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnsfrynl
            // 
            this.btnsfrynl.Location = new System.Drawing.Point(75, 120);
            this.btnsfrynl.Name = "btnsfrynl";
            this.btnsfrynl.Size = new System.Drawing.Size(95, 32);
            this.btnsfrynl.TabIndex = 0;
            this.btnsfrynl.Text = "ŞİFRE YENİLE";
            this.btnsfrynl.UseVisualStyleBackColor = true;
            this.btnsfrynl.Click += new System.EventHandler(this.btnsfrynl_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "E-Mail";
            // 
            // txtml
            // 
            this.txtml.Location = new System.Drawing.Point(75, 44);
            this.txtml.Name = "txtml";
            this.txtml.Size = new System.Drawing.Size(147, 20);
            this.txtml.TabIndex = 2;
            // 
            // SifremiUnuttum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 203);
            this.Controls.Add(this.txtml);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsfrynl);
            this.Name = "SifremiUnuttum";
            this.Text = "Şifre Yenileme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsfrynl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtml;
    }
}