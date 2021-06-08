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
    public partial class AnaEkran : Form
    {
        public AnaEkran()
        {
            InitializeComponent();
        }
        string mail;
        public static char tip;
        SqlConnection bgl = new SqlConnection("Server=AHMET\\SQLEXPRESS;Initial Catalog=IsBasvuru;Integrated Security=True");
        private void AnaEkran_Load(object sender, EventArgs e)
        {
            mail = GirisFormu.eml;
            bgl.Open();
            SqlCommand ck = new SqlCommand("SELECT * FROM Kullanicilar WHERE Email='" + mail + "'", bgl);
            SqlDataAdapter dtst = new SqlDataAdapter(ck);
            DataSet dt = new DataSet();
            dtst.Fill(dt);
            SqlCommand ck2 = new SqlCommand("SELECT * FROM IsSecimi", bgl);
            SqlDataAdapter dtst2 = new SqlDataAdapter(ck2);
            DataSet dt2 = new DataSet();
            dtst2.Fill(dt2);
            for (int i = 0; i < dt2.Tables[0].Rows.Count; i++)
            {
                cmbtr.Items.Add(dt2.Tables[0].Rows[i][1]);
            }
            if (dt.Tables[0].Rows[0][2].ToString() == "B")
            {
                tip = 'B';
                btnilnvr.Enabled = false;
                btipi();
            }
            else if (dt.Tables[0].Rows[0][2].ToString() == "I")
            {
                tip = 'I';
                btnbsvr.Enabled = false;
                linkLabel1.Visible = false;
                linkLabel1.Enabled = false;
                itipi();
            }
            else if (dt.Tables[0].Rows[0][2].ToString() == "S")
            {
                tip = 'S';
                btnbsvr.Enabled = false;
                btnilnvr.Enabled = false;
            }
            else 
            {
                tip = 'A';
            }
            bgl.Close();
        }

        private void btipi() 
        {
            bgl.Open();
            srktlst.Items.Clear();
            SqlCommand ck2 = new SqlCommand("SELECT SB.SirketAdi , SB.SirketAdresi , IsSecimi.IsSecimi , I.Maas , I.IsTanimi FROM SirketBilgisi SB, IsSecimi IsSecimi, IsVeren IV, Ilan I WHERE IV.Sirket = SB.ID AND I.IsVeren = IV.ID AND IsSecimi.ID = I.IsSecimi", bgl);
            SqlDataAdapter dtst2 = new SqlDataAdapter(ck2);
            DataSet dt2 = new DataSet();
            dtst2.Fill(dt2);
            for (int i = 0; i < dt2.Tables[0].Rows.Count; i++)
            {
                srktlst.Items.Add(dt2.Tables[0].Rows[i][0] + " " + dt2.Tables[0].Rows[i][1] + " " + dt2.Tables[0].Rows[i][2] + " " + dt2.Tables[0].Rows[i][3] + " " + dt2.Tables[0].Rows[i][4]);
            }
            bgl.Close();
        }
        private void btipifiltre()
        {
            bgl.Open();
            srktlst.Items.Clear();
            SqlCommand ck2;
            if (cmbktgr.SelectedIndex == 3)
            {
                ck2 = new SqlCommand("SELECT SB.SirketAdi , SB.SirketAdresi , IsSecimi.IsSecimi , I.Maas , I.IsTanimi FROM SirketBilgisi SB, IsSecimi IsSecimi, IsVeren IV, Ilan I WHERE IV.Sirket = SB.ID AND I.IsVeren = IV.ID AND IsSecimi.ID = I.IsSecimi AND IsSecimi.IsSecimi = '" + cmbtr.SelectedItem + "' ORDER BY '" + cmbktgr.SelectedItem + "'", bgl);
            }
            else 
            {
                ck2 = new SqlCommand("SELECT SB.SirketAdi , SB.SirketAdresi , IsSecimi.IsSecimi , I.Maas , I.IsTanimi FROM SirketBilgisi SB, IsSecimi IsSecimi, IsVeren IV, Ilan I WHERE IV.Sirket = SB.ID AND I.IsVeren = IV.ID AND IsSecimi.ID = I.IsSecimi AND IsSecimi.IsSecimi = '" + cmbtr.SelectedItem + "'", bgl);
            }
            SqlDataAdapter dtst2 = new SqlDataAdapter(ck2);
            DataSet dt2 = new DataSet();
            dtst2.Fill(dt2);
            for (int i = 0; i < dt2.Tables[0].Rows.Count; i++)
            {
                srktlst.Items.Add(dt2.Tables[0].Rows[i][0] + " " + dt2.Tables[0].Rows[i][1] + " " + dt2.Tables[0].Rows[i][2] + " " + dt2.Tables[0].Rows[i][3] + " " + dt2.Tables[0].Rows[i][4]);
            }
            bgl.Close();
        }
        private void itipi()
        {
            bgl.Open();
            srktlst.Items.Clear();
            SqlCommand ck2 = new SqlCommand("SELECT Ad,Soyad,IsSecimi FROM Basvuran", bgl);
            SqlDataAdapter dtst2 = new SqlDataAdapter(ck2);
            DataSet dt2 = new DataSet();
            dtst2.Fill(dt2);
            for (int i = 0; i < dt2.Tables[0].Rows.Count; i++)
            {
                srktlst.Items.Add(dt2.Tables[0].Rows[i][0] + " " + dt2.Tables[0].Rows[i][1] + " " + dt2.Tables[0].Rows[i][2]);
            }
            bgl.Close();
        }
        private void itipifiltre()
        {
            bgl.Open();
            SqlCommand ck2;
            srktlst.Items.Clear();
            if (cmbktgr.SelectedIndex == 3)
            {
                ck2 = new SqlCommand("SELECT Ad,Soyad,IsSecimi FROM Basvuran WHERE IsSecimi='" + cmbtr.SelectedItem + "'", bgl);
            }
            else
            {
                ck2 = new SqlCommand("SELECT Ad,Soyad,IsSecimi FROM Basvuran WHERE IsSecimi='" + cmbtr.SelectedItem + "' ORDER BY '" + cmbktgr.SelectedItem + "'", bgl);
            }
            SqlDataAdapter dtst2 = new SqlDataAdapter(ck2);
            DataSet dt2 = new DataSet();
            dtst2.Fill(dt2);
            for (int i = 0; i < dt2.Tables[0].Rows.Count; i++)
            {
                srktlst.Items.Add(dt2.Tables[0].Rows[i][0] + " " + dt2.Tables[0].Rows[i][1] + " " + dt2.Tables[0].Rows[i][2]);
            }
            bgl.Close();
        }
        private void btnprfl_Click(object sender, EventArgs e)
        {
            Profil profil = new Profil();
            profil.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CvBilgi cvBilgi = new CvBilgi();
            cvBilgi.Show();
            this.Close();
        }

        private void btnilnvr_MouseHover(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            if (btnilnvr.Enabled == false)
                t.Show("İlan izni için doğrulama gerekli", this);
        }

        private void btnbsvr_MouseHover(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            if (btnbsvr.Enabled == false)
                t.Show("Başvuru için CV doldurmanız gerekmektedir", this);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (tip == 'B' || tip == 'S')
            {
                Dogrulama dogrulama = new Dogrulama();
                dogrulama.Show();
                this.Close();
            }
            else if (tip == 'A')
            {
                if (linkLabel1.Text == "DOĞRULAMA")
                    linkLabel1.Text = "PROFİL TÜRÜ";
                if (btnbsvr.Text == "ONAYLA")
                {
                    btnbsvr.Text = "BAŞVUR";
                    btipi();
                }
                else
                {
                    btnbsvr.Text = "ONAYLA";
                    itipi();
                }
            }
        }

        private void linkLabel1_MouseHover(object sender, EventArgs e)
        {
            if (tip == 'A')
            {
                ToolTip t = new ToolTip();
                t.Show("Başvuran yada ilan veren profilleriniz arası geçişi sağlar", this);
            }
        }

        private void srktlst_MouseHover(object sender, EventArgs e)
        {
            if (tip == 'I')
            {
                ToolTip t = new ToolTip();
                t.Show("Başvuru onayı için seçim yapmanız gereklidir", this);
            }
        }

        private void srktlst_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (tip == 'I')
            {
                btnbsvr.Enabled = true;
                btnbsvr.Text = "ONAYLA";
            }
            else
                btnbsvr.Text = btnbsvr.Text;
        }

        private void btnilnvr_Click(object sender, EventArgs e)
        {
            Ilanver ilanver = new Ilanver();
            ilanver.Show();
            this.Close();
        }

        private void btnbsvr_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnbsvr.Text == "BAŞVUR")
                {

                }
                else 
                {

                }
            }
            catch 
            {

            }
        }
    }
}
