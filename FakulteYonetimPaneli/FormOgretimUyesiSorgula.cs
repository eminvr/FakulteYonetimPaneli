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


namespace FakulteYonetimPaneli
{
    public partial class FormOgretimUyesiSorgula : Form
    {
        OgretimUyesiManager ogretimUyesiManager = new OgretimUyesiManager();

        SqlConnection baglanti;
        SqlCommand komut;
        
        
        public FormOgretimUyesiSorgula()
        {
            InitializeComponent();
        }


        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }


        private void FormOgretimUyesiSorgula_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ogretimUyesiManager.OgretimUyesiGetir("*");
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {         
            dataGridView1.DataSource = ogretimUyesiManager.OgretimUyesiSorgula(textBoxAd,"Isim","*");
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //SOYAD        
            dataGridView1.DataSource = ogretimUyesiManager.OgretimUyesiSorgula(textBoxSoyad, "Soyisim", "*");
        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        { 
            //Sicil No
            dataGridView1.DataSource = ogretimUyesiManager.OgretimUyesiSorgula(textBoxSicil, "SicilNo", "*");
        }


        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //Ders
            baglanti = new SqlConnection(Anasayfa.sqlAdress);
            baglanti.Open();
            komut = new SqlCommand("select * from OgretimGorevlileri where VerdigiDersler1 like '%" + textBoxDers.Text + "%' or  VerdigiDersler2 like '%" + textBoxDers.Text + "%'", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();           
        }
    }
}
