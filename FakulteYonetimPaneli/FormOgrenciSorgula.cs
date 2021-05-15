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
    public partial class FormOgrenciSorgula : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;
        void OgrenciGetir()
        {
            baglanti = new SqlConnection(Anasayfa.sqlAdress);
            baglanti.Open();
            da = new SqlDataAdapter("select TCKN,Isim,Soyisim,Bolum1 OkuduguBolum,OgrNo1 OgrenciNumarasi,Bolum2 OkuduguBolum2,OgrNo2 OgrenciNumarasi2,TelNo,DurumBilgisi,AldigiDers1,AldigiDers2,AldigiDers3,AldigiDers4,AldigiDers5 from Ogrenciler", baglanti);
            DataTable tablo = new DataTable();
            baglanti.Close();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();

        }

        public FormOgrenciSorgula()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            OgrenciGetir();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //TCKN
            baglanti.Open();
            komut = new SqlCommand("select TCKN,Isim,Soyisim,Bolum1 OkuduguBolum,OgrNo1 OgrenciNumarasi,Bolum2 OkuduguBolum2,OgrNo2 OgrenciNumarasi2,TelNo,DurumBilgisi,AldigiDers1,AldigiDers2,AldigiDers3,AldigiDers4,AldigiDers5 from Ogrenciler where TCKN like '%" + textBoxTCKN.Text + "%'", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //ISIM
            baglanti.Open();
            komut = new SqlCommand("select TCKN,Isim,Soyisim,Bolum1 OkuduguBolum,OgrNo1 OgrenciNumarasi,Bolum2 OkuduguBolum2,OgrNo2 OgrenciNumarasi2,TelNo,DurumBilgisi,AldigiDers1,AldigiDers2,AldigiDers3,AldigiDers4,AldigiDers5 from Ogrenciler where Isim like '%" + textBoxAd.Text + "%'", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //SOYAD
            baglanti.Open();
            komut = new SqlCommand("select TCKN,Isim,Soyisim,Bolum1 OkuduguBolum,OgrNo1 OgrenciNumarasi,Bolum2 OkuduguBolum2,OgrNo2 OgrenciNumarasi2,TelNo,DurumBilgisi,AldigiDers1,AldigiDers2,AldigiDers3,AldigiDers4,AldigiDers5 from Ogrenciler where Soyisim like '%" + textBoxSoyad.Text + "%'", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //TELNO
            baglanti.Open();
            komut = new SqlCommand("select TCKN,Isim,Soyisim,Bolum1 OkuduguBolum,OgrNo1 OgrenciNumarasi,Bolum2 OkuduguBolum2,OgrNo2 OgrenciNumarasi2,TelNo,DurumBilgisi,AldigiDers1,AldigiDers2,AldigiDers3,AldigiDers4,AldigiDers5 from Ogrenciler where TelNo like '%" + textBoxTelNo.Text + "%'", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
