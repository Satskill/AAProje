
namespace IsBasvuru
{
    partial class AnaEkran
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
            this.cmbktgr = new System.Windows.Forms.ComboBox();
            this.cmbtr = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.srktlst = new System.Windows.Forms.CheckedListBox();
            this.btnprfl = new System.Windows.Forms.Button();
            this.btncv = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbktgr
            // 
            this.cmbktgr.FormattingEnabled = true;
            this.cmbktgr.Items.AddRange(new object[] {
            "Maas",
            "IsSecimi",
            "Isim",
            "HEPSİ"});
            this.cmbktgr.Location = new System.Drawing.Point(106, 12);
            this.cmbktgr.Name = "cmbktgr";
            this.cmbktgr.Size = new System.Drawing.Size(121, 21);
            this.cmbktgr.TabIndex = 0;
            // 
            // cmbtr
            // 
            this.cmbtr.FormattingEnabled = true;
            this.cmbtr.Location = new System.Drawing.Point(106, 39);
            this.cmbtr.Name = "cmbtr";
            this.cmbtr.Size = new System.Drawing.Size(121, 21);
            this.cmbtr.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "KATEGORİ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "İŞ TÜRÜ";
            // 
            // srktlst
            // 
            this.srktlst.FormattingEnabled = true;
            this.srktlst.Location = new System.Drawing.Point(15, 79);
            this.srktlst.Name = "srktlst";
            this.srktlst.Size = new System.Drawing.Size(413, 199);
            this.srktlst.TabIndex = 2;
            this.srktlst.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.srktlst_ItemCheck);
            this.srktlst.MouseHover += new System.EventHandler(this.srktlst_MouseHover);
            // 
            // btnprfl
            // 
            this.btnprfl.Location = new System.Drawing.Point(293, 9);
            this.btnprfl.Name = "btnprfl";
            this.btnprfl.Size = new System.Drawing.Size(135, 23);
            this.btnprfl.TabIndex = 3;
            this.btnprfl.Text = "PROFİLİM";
            this.btnprfl.UseVisualStyleBackColor = true;
            this.btnprfl.Click += new System.EventHandler(this.btnprfl_Click);
            // 
            // btncv
            // 
            this.btncv.Location = new System.Drawing.Point(293, 38);
            this.btncv.Name = "btncv";
            this.btncv.Size = new System.Drawing.Size(135, 23);
            this.btncv.TabIndex = 3;
            this.btncv.Text = "CV/BİLGİLERİM";
            this.btncv.UseVisualStyleBackColor = true;
            this.btncv.Click += new System.EventHandler(this.button1_Click);
            // 
            // AnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 335);
            this.Controls.Add(this.btncv);
            this.Controls.Add(this.btnprfl);
            this.Controls.Add(this.srktlst);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbtr);
            this.Controls.Add(this.cmbktgr);
            this.Name = "AnaEkran";
            this.Text = "AnaEkran";
            this.Load += new System.EventHandler(this.AnaEkran_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbktgr;
        private System.Windows.Forms.ComboBox cmbtr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox srktlst;
        private System.Windows.Forms.Button btnprfl;
        private System.Windows.Forms.Button btncv;
    }
}