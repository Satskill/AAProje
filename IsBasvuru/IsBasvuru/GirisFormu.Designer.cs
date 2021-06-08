
namespace IsBasvuru
{
    partial class GirisFormu
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
            this.txtml = new System.Windows.Forms.TextBox();
            this.txtsfr = new System.Windows.Forms.TextBox();
            this.btngrsyp = new System.Windows.Forms.Button();
            this.btnkytol = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblsfrmunttm = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtml
            // 
            this.txtml.Location = new System.Drawing.Point(80, 39);
            this.txtml.Name = "txtml";
            this.txtml.Size = new System.Drawing.Size(161, 20);
            this.txtml.TabIndex = 0;
            // 
            // txtsfr
            // 
            this.txtsfr.Location = new System.Drawing.Point(80, 76);
            this.txtsfr.Name = "txtsfr";
            this.txtsfr.Size = new System.Drawing.Size(161, 20);
            this.txtsfr.TabIndex = 0;
            // 
            // btngrsyp
            // 
            this.btngrsyp.Location = new System.Drawing.Point(95, 150);
            this.btngrsyp.Name = "btngrsyp";
            this.btngrsyp.Size = new System.Drawing.Size(100, 35);
            this.btngrsyp.TabIndex = 1;
            this.btngrsyp.Text = "GİRİŞ YAP";
            this.btngrsyp.UseVisualStyleBackColor = true;
            this.btngrsyp.Click += new System.EventHandler(this.btngrsyp_Click);
            // 
            // btnkytol
            // 
            this.btnkytol.Location = new System.Drawing.Point(95, 191);
            this.btnkytol.Name = "btnkytol";
            this.btnkytol.Size = new System.Drawing.Size(100, 35);
            this.btnkytol.TabIndex = 1;
            this.btnkytol.Text = "KAYIT OL";
            this.btnkytol.UseVisualStyleBackColor = true;
            this.btnkytol.Click += new System.EventHandler(this.btnkytol_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "E-Mail";
            // 
            // lblsfrmunttm
            // 
            this.lblsfrmunttm.AutoSize = true;
            this.lblsfrmunttm.Location = new System.Drawing.Point(153, 99);
            this.lblsfrmunttm.Name = "lblsfrmunttm";
            this.lblsfrmunttm.Size = new System.Drawing.Size(81, 13);
            this.lblsfrmunttm.TabIndex = 3;
            this.lblsfrmunttm.TabStop = true;
            this.lblsfrmunttm.Text = "Şifremi Unuttum";
            this.lblsfrmunttm.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblsfrmunttm_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifre";
            // 
            // GirisFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 258);
            this.Controls.Add(this.lblsfrmunttm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnkytol);
            this.Controls.Add(this.btngrsyp);
            this.Controls.Add(this.txtsfr);
            this.Controls.Add(this.txtml);
            this.Name = "GirisFormu";
            this.Text = "GİRİŞ";
            this.Load += new System.EventHandler(this.GirisFormu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtml;
        private System.Windows.Forms.TextBox txtsfr;
        private System.Windows.Forms.Button btngrsyp;
        private System.Windows.Forms.Button btnkytol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lblsfrmunttm;
        private System.Windows.Forms.Label label2;
    }
}

