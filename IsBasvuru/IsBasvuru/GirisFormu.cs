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
    public partial class GirisFormu : Form
    {
        public GirisFormu()
        {
            InitializeComponent();
        }
        public static string eml;
        public static string sfr;
        public static int bsvrid = 0;
        public static int ilnid = 0;
        SqlConnection bgl = new SqlConnection("Server=AHMET\\SQLEXPRESS;Initial Catalog=IsBasvuru;Integrated Security=True");
        private void GirisFormu_Load(object sender, EventArgs e)
        {

        }

        private void lblsfrmunttm_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SifremiUnuttum sifremiUnuttum = new SifremiUnuttum();
            sifremiUnuttum.Show();
            this.Hide();
        }

        private void btnkytol_Click(object sender, EventArgs e)
        {
            KayitOl kayitOl = new KayitOl();
            kayitOl.Show();
            this.Hide();
        }

        private void btngrsyp_Click(object sender, EventArgs e)
        {
            bgl.Open();
            SqlCommand ck = new SqlCommand("SELECT * FROM Kullanicilar WHERE Email='"+txtml.Text+"'",bgl);
            SqlDataAdapter dtst = new SqlDataAdapter(ck);
            DataSet dt = new DataSet();
            dtst.Fill(dt);
            if (txtml.Text == dt.Tables[0].Rows[0][0].ToString() && txtsfr.Text == dt.Tables[0].Rows[0][1].ToString())
            {
                eml = txtml.Text;
                sfr = txtsfr.Text;
                try
                {
                    bsvrid = Convert.ToInt32(dt.Tables[0].Rows[0][3].ToString());
                    ilnid = Convert.ToInt32(dt.Tables[0].Rows[0][4].ToString());
                }
                catch 
                {
                    bsvrid = 0;
                    ilnid = 0;
                }
                AnaEkran anaEkran = new AnaEkran();
                anaEkran.Show();
                this.Hide(); 
            }
            else
                MessageBox.Show("E-Mail yada Şifre hatalı!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bgl.Close();
        }
    }
}
