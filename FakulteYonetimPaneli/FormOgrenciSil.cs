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

    public partial class FormOgrenciSil : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;
        public FormOgrenciSil()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        void OgrenciGetir()
        {
            baglanti = new SqlConnection(Anasayfa.sqlAdress);
            baglanti.Open();
            da = new SqlDataAdapter("select TCKN,Isim,Soyisim from Ogrenciler", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            string mesaj = "Bu öğrenciyi silmek istediğinize emin misiniz?";
            string title = "";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(mesaj, title, buttons);
            if (result == DialogResult.Yes)
            {
                string sorgu = "Delete from Ogrenciler where TCKN=@TCKN";
                komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@TCKN", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                OgrenciGetir();
                textBoxAd.Clear();
                textBoxSoyad.Clear();
                textBoxTCKN.Clear();
            }
            else
            {
                //Hayıra basılırsa yapılacak işlemler
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            OgrenciGetir();
        }



        private void buttonAdAra_Click(object sender, EventArgs e)
        {
            //baglanti.Open();
            //komut = new SqlCommand("select TCKN,Isim,Soyisim from Ogrenciler where Isim like '%" + textBoxAd.Text + "%'", baglanti);
            //SqlDataAdapter da = new SqlDataAdapter(komut);
            //DataTable tablo = new DataTable();
            //da.Fill(tablo);
            //dataGridView1.DataSource = tablo;
            //baglanti.Close();
        }

        private void textBoxAd_TextChanged(object sender, EventArgs e)
        {
            //baglanti.Open();
            //komut = new SqlCommand("select TCKN,Isim,Soyisim from Ogrenciler where Isim like '%" + textBoxAd.Text + "%'", baglanti);
            //SqlDataAdapter da = new SqlDataAdapter(komut);
            //DataTable tablo = new DataTable();
            //da.Fill(tablo);
            //dataGridView1.DataSource = tablo;
            //baglanti.Close();
        }

        private void textBoxSoyad_TextChanged(object sender, EventArgs e)
        {
            //baglanti.Open();
            //komut = new SqlCommand("select TCKN,Isim,Soyisim from Ogrenciler where Soyisim like '%" + textBoxSoyad.Text + "%'", baglanti);
            //SqlDataAdapter da = new SqlDataAdapter(komut);
            //DataTable tablo = new DataTable();
            //da.Fill(tablo);
            //dataGridView1.DataSource = tablo;
            //baglanti.Close();
        }

        private void textBoxTCKN_TextChanged(object sender, EventArgs e)
        {
            //baglanti.Open();
            //komut = new SqlCommand("select TCKN,Isim,Soyisim from Ogrenciler where TCKN like '%" + textBoxTCKN.Text + "%'", baglanti);
            //SqlDataAdapter da = new SqlDataAdapter(komut);
            //DataTable tablo = new DataTable();
            //da.Fill(tablo);
            //dataGridView1.DataSource = tablo;
            //baglanti.Close();
        }

        private void textBoxTCKN_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBoxAd_TextChanged_1(object sender, EventArgs e)
        {
            baglanti.Open();
            komut = new SqlCommand("select TCKN,Isim,Soyisim from Ogrenciler where Isim like '%" + textBoxAd.Text + "%'", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void textBoxSoyad_TextChanged_1(object sender, EventArgs e)
        {
            baglanti.Open();
            komut = new SqlCommand("select TCKN,Isim,Soyisim from Ogrenciler where Soyisim like '%" + textBoxSoyad.Text + "%'", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void textBoxTCKN_TextChanged_1(object sender, EventArgs e)
        {
            baglanti.Open();
            komut = new SqlCommand("select TCKN,Isim,Soyisim from Ogrenciler where TCKN like '%" + textBoxTCKN.Text + "%'", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
    }
}

