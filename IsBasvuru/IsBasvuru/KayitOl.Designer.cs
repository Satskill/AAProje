
namespace IsBasvuru
{
    partial class KayitOl
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnkytol = new System.Windows.Forms.Button();
            this.txtsfr = new System.Windows.Forms.TextBox();
            this.txtml = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Şifre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "E-Mail";
            // 
            // btnkytol
            // 
            this.btnkytol.Location = new System.Drawing.Point(96, 142);
            this.btnkytol.Name = "btnkytol";
            this.btnkytol.Size = new System.Drawing.Size(100, 35);
            this.btnkytol.TabIndex = 6;
            this.btnkytol.Text = "KAYIT OL";
            this.btnkytol.UseVisualStyleBackColor = true;
            this.btnkytol.Click += new System.EventHandler(this.btnkytol_Click);
            // 
            // txtsfr
            // 
            this.txtsfr.Location = new System.Drawing.Point(86, 73);
            this.txtsfr.Name = "txtsfr";
            this.txtsfr.Size = new System.Drawing.Size(161, 20);
            this.txtsfr.TabIndex = 4;
            // 
            // txtml
            // 
            this.txtml.Location = new System.Drawing.Point(86, 36);
            this.txtml.Name = "txtml";
            this.txtml.Size = new System.Drawing.Size(161, 20);
            this.txtml.TabIndex = 5;
            // 
            // KayitOl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 212);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnkytol);
            this.Controls.Add(this.txtsfr);
            this.Controls.Add(this.txtml);
            this.Name = "KayitOl";
            this.Text = "KayitOl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnkytol;
        private System.Windows.Forms.TextBox txtsfr;
        private System.Windows.Forms.TextBox txtml;
    }
}