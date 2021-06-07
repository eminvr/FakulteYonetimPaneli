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
    public partial class FormOgretimUyesiEkle : Form
    {
        OgretimUyesiManager ogretimUyesiManager = new OgretimUyesiManager();

        SqlConnection baglanti = new SqlConnection(Anasayfa.sqlAdress);
        SqlConnection baglanti2 = new SqlConnection(Anasayfa.sqlAdress);
        SqlCommand komut;

        public static bool durum;

        public FormOgretimUyesiEkle()
        {
            InitializeComponent();
        }

      
        void mukerrer()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from OgretimGorevlileri where SicilNo=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", textBoxSicilNo.Text);
            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read())
            {
                durum = false;
            }

            else
            {
                durum = true;
            }

            baglanti.Close();
        }


        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (textBoxAd.TextLength < 1 || textBoxSoyad.TextLength < 1)
            {
                MessageBox.Show("Ad veya soyad kısmı boş bırakılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (comboBoxBolum.SelectedIndex == -1)
            {
                MessageBox.Show("Bölüm kısmı boş bırakılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Ders 1 kısmı boş bırakılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (comboBox1.SelectedItem == comboBox2.SelectedItem)
            {
                MessageBox.Show("Ders 1 ve ders 2 aynı olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {   
                //SQL VB KODLAR
                mukerrer();

                if (durum)
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("insert into OgretimGorevlileri (SicilNo,Isim,Soyisim,DersVerdigiBolum,VerdigiDersler1,VerdigiDersler2) values (@p4,@p1,@p2,@p3,@p5,@p6)", baglanti);
                    komut.Parameters.AddWithValue("@p1", textBoxAd.Text);
                    komut.Parameters.AddWithValue("@p2", textBoxSoyad.Text);
                    komut.Parameters.AddWithValue("@p3", comboBoxBolum.Text);
                    komut.Parameters.AddWithValue("@p4", textBoxSicilNo.Text);
                    komut.Parameters.AddWithValue("@p5", comboBox1.Text);
                    komut.Parameters.AddWithValue("@p6", comboBox2.Text);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show($"{textBoxAd.Text} {textBoxSoyad.Text} adlı ögretim üyesi eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxAd.Clear();
                    textBoxSoyad.Clear();
                    textBoxSicilNo.Clear();
                    //comboBoxBolum.SelectedIndex = -1;
                    comboBox1.SelectedIndex = -1;
                    comboBox2.SelectedIndex = -1;
                }

                else
                {
                    MessageBox.Show("Bu ögretim üyesi zaten var!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        
        private void FormOgretimUyesiEkle_Load(object sender, EventArgs e)
        {
            comboBoxBolum.Items.Add(Anasayfa.bolum1);
            comboBoxBolum.Items.Add(Anasayfa.bolum2);
            comboBoxBolum.Items.Add(Anasayfa.bolum3);
            comboBoxBolum.Items.Add(Anasayfa.bolum4);
            comboBoxBolum.Items.Add(Anasayfa.bolum5);
         

            
                           
        }


        private void comboBoxBolum_SelectedIndexChanged(object sender, EventArgs e)
        {
            ogretimUyesiManager.SicilNoAta(comboBoxBolum,textBoxSicilNo);
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            string blm = comboBoxBolum.Text;
            baglanti = new SqlConnection(Anasayfa.sqlAdress);
            baglanti.Open();
            komut = new SqlCommand("select * from Dersler where VerildigiBolum='" + blm + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {              
                comboBox1.Items.Add(read["DersAdi"]);
                comboBox2.Items.Add(read["DersAdi"]);
            }
            baglanti.Close();
        }
    }
}
