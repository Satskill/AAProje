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
    public partial class Ilanver : Form
    {
        public Ilanver()
        {
            InitializeComponent();
        }
        SqlConnection bgl = new SqlConnection("Server=AHMET\\SQLEXPRESS;Initial Catalog=IsBasvuru;Integrated Security=True");
        private void Ilanver_Load(object sender, EventArgs e)
        {
            bgl.Open();
            SqlCommand ck = new SqlCommand("SELECT IsSecimi FROM IsSecimi", bgl);
            SqlDataAdapter dtst = new SqlDataAdapter(ck);
            DataSet dt = new DataSet();
            dtst.Fill(dt);
            for (int i = 0; i < dt.Tables[0].Rows.Count; i++) 
            {
                comboBox1.Items.Add(dt.Tables[0].Rows[i][0]);
            }
            bgl.Close();
        }

        private void btnekl_Click(object sender, EventArgs e)
        {
            bgl.Open();
            SqlCommand ck1 = new SqlCommand("INSERT INTO IsSecimi (IsSecimi) VALUES ('" + txtscm.Text + "')", bgl);
            ck1.ExecuteNonQuery();
            SqlCommand ck = new SqlCommand("SELECT IsSecimi FROM IsSecimi", bgl);
            SqlDataAdapter dtst = new SqlDataAdapter(ck);
            DataSet dt = new DataSet();
            dtst.Fill(dt);
            for (int i = 0; i < dt.Tables[0].Rows.Count; i++)
            {
                comboBox1.Items.Add(dt.Tables[0].Rows[i][0]);
            }
            bgl.Close();
        }

        private void btnilnvr_Click(object sender, EventArgs e)
        {
            try
            {
                bgl.Open();
                SqlCommand ck1 = new SqlCommand("INSERT INTO Ilan (IsVeren,IsSecimi,IsTanimi,Maas) VALUES ('" + GirisFormu.ilnid + "','"+comboBox1.SelectedIndex+1+"','"+txttnm.Text+"','"+txtmaas.Text+"')", bgl);
                ck1.ExecuteNonQuery();
                bgl.Close();
            }
            catch 
            {
                MessageBox.Show("Bütün alanlar doldurulmalıdır!", "Bilgilendirme!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
