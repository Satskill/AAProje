using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace IsBasvuru
{
    public partial class Profil : Form
    {
        public Profil()
        {
            InitializeComponent();
        }
        char tip;
        SqlConnection bgl = new SqlConnection("Server=AHMET\\SQLEXPRESS;Initial Catalog=IsBasvuru;Integrated Security=True");
        private void Profil_Load(object sender, EventArgs e)
        {
            tip = AnaEkran.tip;
            if (tip == 'B')
            {
                linkLabel1.Visible = false;
                linkLabel1.Enabled = false;
            }
            txteml.Text = GirisFormu.eml;
            txtsfr.Text = GirisFormu.sfr;
        }

        private void btnkydt_Click(object sender, EventArgs e)
        {
            bgl.Open();
            try
            {
                if (txteml.Text != null && txtsfr.Text != null)
                {
                    SqlCommand ck = new SqlCommand("UPDATE Kullanicilar SET Email='" + txteml.Text + "',Sifre='" + txtsfr.Text + "' WHERE Email='" + GirisFormu.eml + "'", bgl);
                    ck.ExecuteNonQuery();
                    MessageBox.Show("Bilgileriniz güncellenmiştir.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("İki alanda doldurulmalıdır.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                MessageBox.Show("E-Mail zaten mevcut.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            bgl.Close();
        }

        private void btngr_Click(object sender, EventArgs e)
        {
            AnaEkran anaEkran = new AnaEkran();
            anaEkran.Show();
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SirketBilgi sirketBilgi = new SirketBilgi();
            sirketBilgi.Show();
            this.Close();
        }
    }
}
