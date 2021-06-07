using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FakulteYonetimPaneli
{
    public partial class FormDersSorgula : Form
    {
        DersManager dersManager = new DersManager();

        SqlConnection baglanti;
        SqlCommand komut;

        public FormDersSorgula()
        {
            InitializeComponent();
        }


        private void textBoxDersAdi_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            komut = new SqlCommand("select * from Dersler where DersAdi like '%" + textBoxDersAdi.Text + "%'", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }


        private void textBoxDersKodu_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dersManager.DersSorgula(textBoxDersKodu, "Derskodu", "*");
        }


        private void textBoxDersSinifi_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dersManager.DersSorgula(textBoxDersSinifi, "VerildigiSinif", "*");
        }


        private void textBoxDersiVerenOgretimUyesi_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dersManager.DersSorgula(textBoxDersiVerenOgretimUyesi, "DersiVeren", "*");
        }


        private void FormDersSorgula_Load(object sender, EventArgs e)
        {
            baglanti = new SqlConnection(Anasayfa.sqlAdress);
            dataGridView1.DataSource = dersManager.DersGetir("*");
        }
    }
}
