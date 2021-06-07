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
    public partial class FormDersEkle : Form
    {
        SqlConnection baglanti = new SqlConnection(Anasayfa.sqlAdress);
        SqlCommand komut;

        DersManager dersManager = new DersManager();

        public static bool durum;

        public FormDersEkle()
        {
            InitializeComponent();
        }

        void mukerrer()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Dersler where DersKodu=@DersKodu", baglanti);
            komut.Parameters.AddWithValue("@DersKodu", textBoxKodu.Text);
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

        private void btnOgrenciyiEkle_Click(object sender, EventArgs e)
        {
            if (textBoxAdi.TextLength < 1)
            {
                MessageBox.Show("Ders adını girmediniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (comboBoxVerildigiBolum.SelectedIndex == -1)
            {
                MessageBox.Show("Bölüm seçmediniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (textBoxVerildigiSinif.TextLength != 2)
            {
                MessageBox.Show("Sınıf bilgisini hatalı girdiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (comboBoxOgretimUyeleri.SelectedIndex == -1)
            {
                MessageBox.Show("Öğretim üyesi seçmediniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (textBoxKredi.TextLength < 1)
            {
                MessageBox.Show("Ders kredisi girmediniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
            else
            {


                mukerrer();

                if (durum)
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("insert into Dersler (DersKodu,DersAdi,DersiVeren,VerildigiBolum,VerildigiSinif,Kredi) values (@DersKodu,@DersAdi,@DersiVeren,@VerildigiBolum,@VerildigiSinif,@Kredi)", baglanti);
                    komut.Parameters.AddWithValue("@DersKodu", textBoxKodu.Text);
                    komut.Parameters.AddWithValue("@DersAdi", textBoxAdi.Text);
                    komut.Parameters.AddWithValue("@DersiVeren", comboBoxOgretimUyeleri.Text);
                    komut.Parameters.AddWithValue("@VerildigiBolum", comboBoxVerildigiBolum.Text);
                    komut.Parameters.AddWithValue("@VerildigiSinif", textBoxVerildigiSinif.Text);
                    komut.Parameters.AddWithValue("@Kredi", textBoxKredi.Text);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Ders kaydı eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                else
                {
                    MessageBox.Show("Bu ders kodu zaten var!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FormDersEkle_Load(object sender, EventArgs e)
        {
            comboBoxVerildigiBolum.Items.Add(Anasayfa.bolum1);
            comboBoxVerildigiBolum.Items.Add(Anasayfa.bolum2);
            comboBoxVerildigiBolum.Items.Add(Anasayfa.bolum3);
            comboBoxVerildigiBolum.Items.Add(Anasayfa.bolum4);
            comboBoxVerildigiBolum.Items.Add(Anasayfa.bolum5);

            comboBoxOgretimUyeleri.Items.Add("Sonra Atanacak...");
        }

        private void comboBoxVerildigiBolum_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxOgretimUyeleri.Items.Clear();
            comboBoxOgretimUyeleri.Items.Add("Sonra Atanacak...");
            string blm = comboBoxVerildigiBolum.Text;
            baglanti = new SqlConnection(Anasayfa.sqlAdress);
            baglanti.Open();
            komut = new SqlCommand("select * from OgretimGorevlileri where DersVerdigiBolum='" + blm + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboBoxOgretimUyeleri.Items.Add(read["Isim"]);
            }
            baglanti.Close();

            dersManager.DersKoduAta(comboBoxVerildigiBolum, textBoxVerildigiSinif, textBoxKodu);
        }

        private void textBoxVerildigiSinif_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void comboBoxOgretimUyeleri_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxVerildigiSinif_TextChanged(object sender, EventArgs e)
        {
            dersManager.DersKoduAta(comboBoxVerildigiBolum, textBoxVerildigiSinif, textBoxKodu);
        }
    }
}

