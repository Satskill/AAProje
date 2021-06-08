
namespace IsBasvuru
{
    partial class SirketBilgi
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
            this.btngr = new System.Windows.Forms.Button();
            this.txtad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtadrs = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btngncll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btngr
            // 
            this.btngr.Location = new System.Drawing.Point(12, 12);
            this.btngr.Name = "btngr";
            this.btngr.Size = new System.Drawing.Size(30, 30);
            this.btngr.TabIndex = 3;
            this.btngr.Text = "<";
            this.btngr.UseVisualStyleBackColor = true;
            this.btngr.Click += new System.EventHandler(this.btngr_Click);
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(136, 42);
            this.txtad.Multiline = true;
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(188, 51);
            this.txtad.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "ŞİRKET ADI";
            // 
            // txtadrs
            // 
            this.txtadrs.Location = new System.Drawing.Point(136, 99);
            this.txtadrs.Multiline = true;
            this.txtadrs.Name = "txtadrs";
            this.txtadrs.Size = new System.Drawing.Size(188, 78);
            this.txtadrs.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "ŞİRKET ADRESİ";
            // 
            // btngncll
            // 
            this.btngncll.Location = new System.Drawing.Point(93, 183);
            this.btngncll.Name = "btngncll";
            this.btngncll.Size = new System.Drawing.Size(160, 35);
            this.btngncll.TabIndex = 6;
            this.btngncll.Text = "GÜNCELLE";
            this.btngncll.UseVisualStyleBackColor = true;
            this.btngncll.Click += new System.EventHandler(this.btngncll_Click);
            // 
            // SirketBilgi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 230);
            this.Controls.Add(this.btngncll);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtadrs);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.btngr);
            this.Name = "SirketBilgi";
            this.Text = "SirketBilgi";
            this.Load += new System.EventHandler(this.SirketBilgi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btngr;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtadrs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btngncll;
    }
}