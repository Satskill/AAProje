
namespace IsBasvuru
{
    partial class Dogrulama
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
            this.txttc = new System.Windows.Forms.TextBox();
            this.btndgrl = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsrkt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtadrs = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtsyd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "T.C KİMLİK NO";
            // 
            // txttc
            // 
            this.txttc.Location = new System.Drawing.Point(105, 64);
            this.txttc.Name = "txttc";
            this.txttc.Size = new System.Drawing.Size(149, 20);
            this.txttc.TabIndex = 1;
            // 
            // btndgrl
            // 
            this.btndgrl.Location = new System.Drawing.Point(72, 209);
            this.btndgrl.Name = "btndgrl";
            this.btndgrl.Size = new System.Drawing.Size(126, 34);
            this.btndgrl.TabIndex = 2;
            this.btndgrl.Text = "DOĞRULA";
            this.btndgrl.UseVisualStyleBackColor = true;
            this.btndgrl.Click += new System.EventHandler(this.btndgrl_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "ŞİRKET ADI";
            // 
            // txtsrkt
            // 
            this.txtsrkt.Location = new System.Drawing.Point(105, 90);
            this.txtsrkt.Multiline = true;
            this.txtsrkt.Name = "txtsrkt";
            this.txtsrkt.Size = new System.Drawing.Size(149, 38);
            this.txtsrkt.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "ŞİRKET ADRESİ";
            // 
            // txtadrs
            // 
            this.txtadrs.Location = new System.Drawing.Point(105, 134);
            this.txtadrs.Multiline = true;
            this.txtadrs.Name = "txtadrs";
            this.txtadrs.Size = new System.Drawing.Size(149, 67);
            this.txtadrs.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "AD";
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(105, 12);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(149, 20);
            this.txtad.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "SOYAD";
            // 
            // txtsyd
            // 
            this.txtsyd.Location = new System.Drawing.Point(105, 38);
            this.txtsyd.Name = "txtsyd";
            this.txtsyd.Size = new System.Drawing.Size(149, 20);
            this.txtsyd.TabIndex = 1;
            // 
            // Dogrulama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 255);
            this.Controls.Add(this.btndgrl);
            this.Controls.Add(this.txtadrs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtsrkt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtsyd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txttc);
            this.Controls.Add(this.label1);
            this.Name = "Dogrulama";
            this.Text = "Dogrulama";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttc;
        private System.Windows.Forms.Button btndgrl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtsrkt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtadrs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtsyd;
    }
}