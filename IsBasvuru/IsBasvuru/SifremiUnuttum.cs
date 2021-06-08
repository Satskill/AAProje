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
    public partial class SifremiUnuttum : Form
    {
        public SifremiUnuttum()
        {
            InitializeComponent();
        }
        SqlConnection bgl = new SqlConnection("Server=AHMET\\SQLEXPRESS;Initial Catalog=IsBasvuru;Integrated Security=True");
        private void btnsfrynl_Click(object sender, EventArgs e)
        {
            bgl.Open();
            try
            {
                SqlCommand ck = new SqlCommand("UPDATE Kullanicilar SET Sifre='1234' WHERE Email='" + txtml.Text + "'", bgl);
                ck.ExecuteNonQuery();
                MessageBox.Show("Şifreniz 1234 olarak güncellendi.","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch 
            {
                MessageBox.Show("E-Mail bulunamadı..", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            bgl.Close();
        }
    }
}
