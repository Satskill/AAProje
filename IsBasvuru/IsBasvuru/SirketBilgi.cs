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
    public partial class SirketBilgi : Form
    {
        public SirketBilgi()
        {
            InitializeComponent();
        }
        int sirketid = 0;
        SqlConnection bgl = new SqlConnection("Server=AHMET\\SQLEXPRESS;Initial Catalog=IsBasvuru;Integrated Security=True");
        private void btngr_Click(object sender, EventArgs e)
        {
            AnaEkran anaEkran = new AnaEkran();
            anaEkran.Show();
            this.Close();
        }

        private void btngncll_Click(object sender, EventArgs e)
        {
            bgl.Open();
            SqlCommand ck = new SqlCommand("UPDATE SirketBilgisi SET SirketAdi='"+txtad.Text+"',SirketAdresi='"+txtadrs.Text+"' WHERE ID='"+sirketid+"'", bgl);
            ck.ExecuteNonQuery();
            bgl.Close();
        }

        private void SirketBilgi_Load(object sender, EventArgs e)
        {
            bgl.Open();
            SqlCommand ck = new SqlCommand("SELECT S.ID,S.SirketAdi,S.SirketAdresi FROM SirketBilgisi S, IsVeren I WHERE I.ID='" + GirisFormu.ilnid + "'", bgl);
            SqlDataAdapter dtst = new SqlDataAdapter(ck);
            DataSet dt = new DataSet();
            dtst.Fill(dt);
            txtad.Text = dt.Tables[0].Rows[0][1].ToString();
            txtadrs.Text = dt.Tables[0].Rows[0][2].ToString();
            sirketid = Convert.ToInt32(dt.Tables[0].Rows[0][0]);
            bgl.Close();
        }
    }
}
