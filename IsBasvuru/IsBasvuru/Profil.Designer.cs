
namespace IsBasvuru
{
    partial class Profil
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
            this.txteml = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsfr = new System.Windows.Forms.TextBox();
            this.btnkydt = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btngr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "E-Mail";
            // 
            // txteml
            // 
            this.txteml.Location = new System.Drawing.Point(63, 50);
            this.txteml.Name = "txteml";
            this.txteml.Size = new System.Drawing.Size(168, 20);
            this.txteml.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Şifre";
            // 
            // txtsfr
            // 
            this.txtsfr.Location = new System.Drawing.Point(63, 93);
            this.txtsfr.Name = "txtsfr";
            this.txtsfr.Size = new System.Drawing.Size(168, 20);
            this.txtsfr.TabIndex = 1;
            // 
            // btnkydt
            // 
            this.btnkydt.Location = new System.Drawing.Point(85, 137);
            this.btnkydt.Name = "btnkydt";
            this.btnkydt.Size = new System.Drawing.Size(113, 31);
            this.btnkydt.TabIndex = 2;
            this.btnkydt.Text = "KAYDET";
            this.btnkydt.UseVisualStyleBackColor = true;
            this.btnkydt.Click += new System.EventHandler(this.btnkydt_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(129, 74);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(77, 13);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Şirket Bilgilerim";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btngr
            // 
            this.btngr.Location = new System.Drawing.Point(12, 9);
            this.btngr.Name = "btngr";
            this.btngr.Size = new System.Drawing.Size(30, 30);
            this.btngr.TabIndex = 4;
            this.btngr.Text = "<";
            this.btngr.UseVisualStyleBackColor = true;
            this.btngr.Click += new System.EventHandler(this.btngr_Click);
            // 
            // Profil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 187);
            this.Controls.Add(this.btngr);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnkydt);
            this.Controls.Add(this.txtsfr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txteml);
            this.Controls.Add(this.label1);
            this.Name = "Profil";
            this.Text = "Profilim";
            this.Load += new System.EventHandler(this.Profil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txteml;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtsfr;
        private System.Windows.Forms.Button btnkydt;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btngr;
    }
}