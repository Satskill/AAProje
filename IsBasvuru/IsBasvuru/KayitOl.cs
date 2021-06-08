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
    public partial class KayitOl : Form
    {
        public KayitOl()
        {
            InitializeComponent();
        }
        SqlConnection bgl = new SqlConnection("Server=AHMET\\SQLEXPRESS;Initial Catalog=IsBasvuru;Integrated Security=True");
        private void btnkytol_Click(object sender, EventArgs e)
        {
            bgl.Open();
            try
            {
                SqlCommand ck = new SqlCommand("INSERT INTO Kullanicilar (Email,Sifre,KullaniciTipi) VALUES ('" + txtml.Text + "','" + txtsfr.Text + "','S')", bgl);
                ck.ExecuteNonQuery();
                MessageBox.Show("Kaydınız oluşturuldu!", "Tebrikler!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AnaEkran anaEkran = new AnaEkran();
                anaEkran.Show();
                GirisFormu.eml = txtml.Text;
                GirisFormu.sfr = txtsfr.Text;
                this.Close();
            }
            catch
            {
                MessageBox.Show("Kullanıcı E-Mail'i mevcut!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            bgl.Close();
        }
    }
}
