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
    public partial class CvBilgi : Form
    {
        public CvBilgi()
        {
            InitializeComponent();
        }
        SqlConnection bgl = new SqlConnection("Server=AHMET\\SQLEXPRESS;Initial Catalog=IsBasvuru;Integrated Security=True");
        private void btngr_Click(object sender, EventArgs e)
        {
            AnaEkran anaEkran = new AnaEkran();
            anaEkran.Show();
            this.Close();
        }
        int varolus = 0;
        int egitimid;
        private void CvBilgi_Load(object sender, EventArgs e)
        {
            bgl.Open();
            try
            {
                SqlCommand ck = new SqlCommand("SELECT * FROM Basvuran WHERE ID='" + GirisFormu.bsvrid + "'", bgl);
                SqlDataAdapter dtst = new SqlDataAdapter(ck);
                DataSet dt = new DataSet();
                dtst.Fill(dt);
                txtad.Text = dt.Tables[0].Rows[0][1].ToString();
                txtsyd.Text = dt.Tables[0].Rows[0][2].ToString();
                txtaskr.Text = dt.Tables[0].Rows[0][5].ToString();
                dateTimePicker2.Value = Convert.ToDateTime(dt.Tables[0].Rows[0][6]);
                txtdl.Text = dt.Tables[0].Rows[0][11].ToString();
                txtsrtfksmnr.Text = dt.Tables[0].Rows[0][12].ToString();
                txtrfrns.Text = dt.Tables[0].Rows[0][13].ToString();
                txtlgaln.Text = dt.Tables[0].Rows[0][14].ToString();
                txtdnym.Text = dt.Tables[0].Rows[0][8].ToString();
                cmbcnsyt.SelectedItem = dt.Tables[0].Rows[0][4].ToString();
                
                SqlCommand ck1 = new SqlCommand("SELECT * FROM Egitim WHERE ID='" + Convert.ToInt32(dt.Tables[0].Rows[0][10]) + "'", bgl);
                SqlDataAdapter dtst1 = new SqlDataAdapter(ck1);
                DataSet dt1 = new DataSet();
                dtst1.Fill(dt1);
                egitimid = Convert.ToInt32(dt1.Tables[0].Rows[0][0]);
                txtlkokl.Text = dt1.Tables[0].Rows[0][1].ToString();
                txtrtokl.Text = dt1.Tables[0].Rows[0][2].ToString();
                txtls.Text = dt1.Tables[0].Rows[0][3].ToString();
                txtnvrst.Text = dt1.Tables[0].Rows[0][4].ToString();
                
                SqlCommand ck2 = new SqlCommand("SELECT I.IlceAdi,S.Isim FROM Sehir S, Ilceler I WHERE I.SehirKodu = S.Kod AND I.ID='" + Convert.ToInt32(dt.Tables[0].Rows[0][7]) + "'", bgl);
                SqlDataAdapter dtst2 = new SqlDataAdapter(ck2);
                DataSet dt2 = new DataSet();
                dtst2.Fill(dt2);
                for (int i = 0; i < 81; i++) 
                {
                    cmbshr.Items.Add(dt2.Tables[0].Rows[i][1].ToString());
                }
                cmbshr.SelectedItem = dt2.Tables[0].Rows[0][1].ToString();
                cmblc.SelectedItem = dt2.Tables[0].Rows[0][0].ToString();
                
                SqlCommand ck3 = new SqlCommand("SELECT * FROM IsSecimi WHERE ID='" + Convert.ToInt32(dt.Tables[0].Rows[0][15]) + "'", bgl);
                SqlDataAdapter dtst3 = new SqlDataAdapter(ck3);
                DataSet dt3 = new DataSet();
                dtst3.Fill(dt3);
                for (int i = 0; i < dt3.Tables[0].Rows.Count; i++)
                {
                    cmbscm.Items.Add(dt3.Tables[0].Rows[i][1].ToString());
                }
                cmbscm.SelectedItem = dt3.Tables[0].Rows[0][1];
                maskedTextBox1.Text = dt.Tables[0].Rows[0][9].ToString();
                dateTimePicker1.Value = Convert.ToDateTime(dt.Tables[0].Rows[0][9]);
                /*dateTimePicker1.Enabled = false;
                dateTimePicker1.Visible = false;
                label3.Text = "YAŞI        " + (DateTime.Now - Convert.ToDateTime(dt.Tables[0].Rows[0][9])).ToString();*/
                varolus = 1;
            }
            catch 
            {
                MessageBox.Show("Yeni giriş!", "Hoşgeldin!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SqlCommand ck3 = new SqlCommand("SELECT * FROM IsSecimi", bgl);
                SqlDataAdapter dtst3 = new SqlDataAdapter(ck3);
                DataSet dt3 = new DataSet();
                dtst3.Fill(dt3);
                for (int i = 0; i < dt3.Tables[0].Rows.Count; i++)
                {
                    cmbscm.Items.Add(dt3.Tables[0].Rows[i][1].ToString());
                }
                SqlCommand ck2 = new SqlCommand("SELECT * FROM Sehir", bgl);
                SqlDataAdapter dtst2 = new SqlDataAdapter(ck2);
                DataSet dt2 = new DataSet();
                dtst2.Fill(dt2);
                for (int i = 0; i < 81; i++)
                {
                    cmbshr.Items.Add(dt2.Tables[0].Rows[i][1].ToString());
                }
            }   
            bgl.Close();
        }

        private void btnkydt_Click(object sender, EventArgs e)
        {
            bgl.Open();
            SqlCommand ck2 = new SqlCommand("SELECT I.ID FROM Sehir S, Ilceler I WHERE I.SehirKodu = '"+cmbshr.SelectedIndex+1+"' AND I.IlceAdi = '" + cmblc.SelectedItem + "'", bgl);
            SqlDataAdapter dtst2 = new SqlDataAdapter(ck2);
            DataSet dt2 = new DataSet();
            dtst2.Fill(dt2);
            SqlCommand ck3 = new SqlCommand("SELECT ID FROM IsSecimi WHERE ID ='" + cmbscm.SelectedIndex+1 + "'", bgl);
            SqlDataAdapter dtst3 = new SqlDataAdapter(ck3);
            DataSet dt3 = new DataSet();
            dtst3.Fill(dt3);
            if (varolus == 1)
            { 
                SqlCommand ck = new SqlCommand("UPDATE Basvuran SET Ad='"+txtad.Text+ "',Soyad='" + txtsyd.Text + "',DogumTarihi='" + dateTimePicker1.Value.ToString("yyyy/MM/dd") + "',Cinsiyet='" + cmbcnsyt.SelectedItem + "',AskeriDurum='" + txtaskr.Text + "',TecilTarihi='" + dateTimePicker2.Value.ToString("yyyy/MM/dd") + "',Ilce='" + cmblc.SelectedItem + "',Deneyim='" + txtdnym.Text + "',Telefon='" + maskedTextBox1.Text + "',Egitim='" + egitimid + "',Dil='" + txtdl.Text + "',SertifikaSeminer='" + txtsrtfksmnr.Text + "',Referans='" + txtrfrns.Text + "',IlgiAlanlari='" + txtlgaln.Text + "',IsSecimi='" + cmbscm.SelectedItem + "' WHERE ID='" + GirisFormu.bsvrid + "'", bgl);
                ck.ExecuteNonQuery();
            }
            else 
            {
                SqlCommand ck1 = new SqlCommand("SELECT TOP 1 ID FROM Egitim ORDER BY ID DESC", bgl);
                SqlDataAdapter dtst1 = new SqlDataAdapter(ck1);
                DataSet dt1 = new DataSet();
                dtst1.Fill(dt1);
                SqlCommand ck = new SqlCommand("INSERT INTO  Basvuran (Ad,Soyad,DogumTarihi,Cinsiyet,AskeriDurum,TecilTarihi,Ilce,Deneyim,Telefon,Egitim,Dil,SertifikaSeminer,Referans,IlgiAlanlari,IsSecimi) VALUES ('" + txtad.Text + "','" + txtsyd.Text + "','" + dateTimePicker1.Value.ToString("yyyy/MM/dd") + "','" + cmbcnsyt.SelectedItem + "','" + txtaskr.Text + "','" + dateTimePicker2.Value.ToString("yyyy/MM/dd") + "','" + cmblc.SelectedItem + "','" + txtdnym.Text + "','" + maskedTextBox1.Text + "','" + 1 + "','" + txtdl.Text + "','" + txtsrtfksmnr.Text + "','" + txtrfrns.Text + "','" + txtlgaln.Text + "','" + (cmbscm.SelectedIndex + 1) + "')", bgl);
                ck.ExecuteNonQuery();
            }
            bgl.Close();
            MessageBox.Show("Kaydetme işlemi başarılı!", "Tebrikler", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cmbshr_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmblc.Items.Clear();
            SqlCommand ck2 = new SqlCommand("SELECT IlceAdi FROM Ilceler WHERE SehirKodu ='" + (cmbshr.SelectedIndex + 1) + "'", bgl);
            SqlDataAdapter dtst2 = new SqlDataAdapter(ck2);
            DataSet dt2 = new DataSet();
            dtst2.Fill(dt2);
            for (int i = 0; i < dt2.Tables[0].Rows.Count; i++)
            {
                cmblc.Items.Add(dt2.Tables[0].Rows[i][0].ToString());
            }
        }
    }
}
