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
    public partial class Dogrulama : Form
    {
        int[] tc = new int[11];
        Int64 kimlikno;
        SqlConnection bgl = new SqlConnection("Server=AHMET\\SQLEXPRESS;Initial Catalog=IsBasvuru;Integrated Security=True");
        public Dogrulama()
        {
            InitializeComponent();
        }

        private void btndgrl_Click(object sender, EventArgs e)
        {
            /*kimlikno = Convert.ToInt64(txttc.Text);
            Int64 bolen = 10000000000;
            int tektop, cifttop, sonuc;
            for (int i = 0; i < 11; i++) 
            {
                tc[i] = Convert.ToInt32(kimlikno % bolen);
                kimlikno = kimlikno - (bolen * tc[i]);
                bolen = bolen / 10;
            }
            tektop = tc[0] + tc[2] + tc[4] + tc[6] + tc[8];
            cifttop = tc[1] + tc[3] + tc[5] + tc[7];
            tektop *= 7;
            sonuc = tektop - cifttop;
            while (sonuc < 10) 
            {
                sonuc = sonuc % 10;
            }
            if (sonuc == tc[9]) 
            {
                sonuc = tc[0] + tc[2] + tc[4] + tc[6] + tc[8] + tc[1] + tc[3] + tc[5] + tc[7] + tc[9];
                if (sonuc % 10 == tc[10])
                {*/
                    bgl.Open();
                    try
                    {
                        if (txtad.Text != null && txtsyd.Text != null && txtadrs.Text != null && txtsrkt.Text != null)
                        {
                            SqlCommand ck = new SqlCommand("INSERT INTO SirketBilgisi (SirketAdi,SirketAdresi) VALUES ('"+txtsrkt.Text+"','"+txtadrs.Text+"')", bgl);
                            ck.ExecuteNonQuery();
                            SqlCommand ck1 = new SqlCommand("SELECT TOP 1 ID FROM SirketBilgisi ORDER BY ID DESC", bgl);
                            SqlDataAdapter dtst = new SqlDataAdapter(ck1);
                            DataSet dt = new DataSet();
                            dtst.Fill(dt);
                            SqlCommand ck2 = new SqlCommand("INSERT INTO IsVeren (Sirket,Adi,Soyadi,TC) VALUES ('" + dt.Tables[0].Rows[0][0] + "','" + txtad.Text + "','" + txtsyd.Text + "','" + txttc.Text + "')", bgl);
                            ck2.ExecuteNonQuery();
                            MessageBox.Show("Bilgileriniz girilmiştir.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            MessageBox.Show("Boş alan bırakılmamalıdır.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch
                    {
                        MessageBox.Show("TC Kimlik No zaten mevcut.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    bgl.Close();
               /* }
                else
                    MessageBox.Show("T.C Kimlik No hatalı!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("T.C Kimlik No hatalı!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Information);
       */ }
    }
}
