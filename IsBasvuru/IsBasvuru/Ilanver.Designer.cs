
namespace IsBasvuru
{
    partial class Ilanver
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
            this.label2 = new System.Windows.Forms.Label();
            this.txttnm = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtscm = new System.Windows.Forms.TextBox();
            this.btnekl = new System.Windows.Forms.Button();
            this.btnilnvr = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmaas = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "İŞ SEÇİMİ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "İŞ TANIMI";
            // 
            // txttnm
            // 
            this.txttnm.Location = new System.Drawing.Point(83, 79);
            this.txttnm.Multiline = true;
            this.txttnm.Name = "txttnm";
            this.txttnm.Size = new System.Drawing.Size(187, 96);
            this.txttnm.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(83, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(187, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "İŞ SEÇİMİ EKLE";
            // 
            // txtscm
            // 
            this.txtscm.Location = new System.Drawing.Point(104, 52);
            this.txtscm.Name = "txtscm";
            this.txtscm.Size = new System.Drawing.Size(100, 20);
            this.txtscm.TabIndex = 3;
            // 
            // btnekl
            // 
            this.btnekl.Location = new System.Drawing.Point(210, 50);
            this.btnekl.Name = "btnekl";
            this.btnekl.Size = new System.Drawing.Size(75, 23);
            this.btnekl.TabIndex = 4;
            this.btnekl.Text = "EKLE";
            this.btnekl.UseVisualStyleBackColor = true;
            this.btnekl.Click += new System.EventHandler(this.btnekl_Click);
            // 
            // btnilnvr
            // 
            this.btnilnvr.Location = new System.Drawing.Point(94, 226);
            this.btnilnvr.Name = "btnilnvr";
            this.btnilnvr.Size = new System.Drawing.Size(142, 35);
            this.btnilnvr.TabIndex = 5;
            this.btnilnvr.Text = "İLAN VER";
            this.btnilnvr.UseVisualStyleBackColor = true;
            this.btnilnvr.Click += new System.EventHandler(this.btnilnvr_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "MAAŞ";
            // 
            // txtmaas
            // 
            this.txtmaas.Location = new System.Drawing.Point(83, 181);
            this.txtmaas.Name = "txtmaas";
            this.txtmaas.Size = new System.Drawing.Size(187, 20);
            this.txtmaas.TabIndex = 3;
            // 
            // Ilanver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 273);
            this.Controls.Add(this.btnilnvr);
            this.Controls.Add(this.btnekl);
            this.Controls.Add(this.txtmaas);
            this.Controls.Add(this.txtscm);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txttnm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Ilanver";
            this.Text = "İLAN VER";
            this.Load += new System.EventHandler(this.Ilanver_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttnm;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtscm;
        private System.Windows.Forms.Button btnekl;
        private System.Windows.Forms.Button btnilnvr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtmaas;
    }
}