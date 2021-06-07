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
    public partial class FormOgretimUyesiGuncelle : Form
    {
        OgretimUyesiManager ogretimUyesiManager = new OgretimUyesiManager();

        SqlConnection baglanti;
        SqlCommand komut2;
        SqlCommand komut;
        public static string guncellenenIsim;
        public static string guncellenenSoyisim;

        public FormOgretimUyesiGuncelle()
        {
            
            InitializeComponent();
        }


        private void FormOgretimUyesiGuncelle_Load(object sender, EventArgs e)
        {
            baglanti = new SqlConnection(Anasayfa.sqlAdress);
            dataGridView1.DataSource = ogretimUyesiManager.OgretimUyesiGetir("*");

            comboBoxBolum.Items.Add(Anasayfa.bolum1);
            comboBoxBolum.Items.Add(Anasayfa.bolum2);
            comboBoxBolum.Items.Add(Anasayfa.bolum3);
            comboBoxBolum.Items.Add(Anasayfa.bolum4);
            comboBoxBolum.Items.Add(Anasayfa.bolum5);

            
        }


        private void textBoxTCKN_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }


        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == comboBox2.SelectedItem)
            {
                MessageBox.Show("Ders 1 ve ders 2 aynı olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (textBoxAdi.TextLength < 1 || textBoxSoyadi.TextLength < 1)
            {
                MessageBox.Show("Ad veya soyad kısmı boş olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                string mesaj = "Seçili öğretim üyesinin verilerini güncellemek istediğinize emin misiniz?";
                string title = "Uyarı";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(mesaj, title, buttons);

                if (result == DialogResult.Yes)
                {
                    //Evete basılırsa yapılacak işlemler

                    MessageBox.Show($"{guncellenenIsim} {guncellenenSoyisim} adlı ogretimGorevlisi güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    string sorgu2 = "Update OgretimGorevlileri set SicilNo=@SicilNo, Isim=@Isim, Soyisim=@Soyisim, DersVerdigiBolum=@DersVerdigiBolum, VerdigiDersler1=@VerdigiDersler1, VerdigiDersler2=@VerdigiDersler2 where SicilNo=@SicilNo";
                    komut2 = new SqlCommand(sorgu2, baglanti);
                    komut2.Parameters.AddWithValue("@Isim", textBoxAdi.Text);
                    komut2.Parameters.AddWithValue("@Soyisim", textBoxSoyadi.Text);
                    komut2.Parameters.AddWithValue("@DersVerdigiBolum", comboBoxBolum.SelectedItem.ToString());
                    komut2.Parameters.AddWithValue("@SicilNo", textBoxSicilNo.Text);
                    komut2.Parameters.AddWithValue("@VerdigiDersler1", comboBox1.SelectedItem.ToString());

                    if (comboBox2.SelectedIndex != -1)
                    {
                        komut2.Parameters.AddWithValue("@VerdigiDersler2", comboBox2.SelectedItem.ToString());
                    }

                    else
                    {
                        komut2.Parameters.AddWithValue("@VerdigiDersler2", "");
                    }

                    baglanti.Open();
                    komut2.ExecuteNonQuery();
                    baglanti.Close();
                    dataGridView1.DataSource = ogretimUyesiManager.OgretimUyesiGetir("*");

                }

                else
                {
                    //Hayıra basılırsa yapılacak işlemler
                }
            }
        }


        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBoxSicilNo.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxSoyadi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            comboBoxBolum.SelectedItem = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            comboBox1.SelectedItem = dataGridView1.CurrentRow.Cells[4].Value.ToString();

            if (dataGridView1.CurrentRow.Cells[5].Value.ToString() == "" || dataGridView1.CurrentRow.Cells[5].Value.ToString() == null)
            {
                comboBox2.SelectedIndex = -1;
            }

            else
            {
                comboBox2.SelectedItem = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            }

            guncellenenIsim = textBoxAdi.Text;
            guncellenenSoyisim = textBoxSoyadi.Text;
        }


        private void textBoxAd_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ogretimUyesiManager.OgretimUyesiSorgula(textBoxAd, "Isim","*");
        }


        private void textBoxSoyad_TextChanged(object sender, EventArgs e)
        {          
            dataGridView1.DataSource = ogretimUyesiManager.OgretimUyesiSorgula(textBoxSoyad, "Soyisim", "*");
        }


        private void textBoxSicil_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ogretimUyesiManager.OgretimUyesiSorgula(textBoxSicil, "SicilNo", "*");
        }

        private void comboBoxBolum_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxBolum.SelectedItem.ToString() == dataGridView1.CurrentRow.Cells[3].Value.ToString())
            {
                textBoxSicilNo.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            }

            else
            {
                ogretimUyesiManager.SicilNoAta(comboBoxBolum,textBoxSicilNo);
            }

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
