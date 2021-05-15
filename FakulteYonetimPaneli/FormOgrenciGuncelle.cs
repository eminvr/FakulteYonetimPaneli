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
    public partial class FormOgrenciGuncelle : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlCommand komut2;
        SqlDataAdapter da;
        public static string guncellenenIsim;
        public static string guncellenenSoyisim;
        public FormOgrenciGuncelle()
        {
            InitializeComponent();
        }

        void OgrenciGetir()
        {
            baglanti = new SqlConnection(@"Data Source = DESKTOP-VK83I53; Initial Catalog = Aydin; User ID = deneme; Password = 123456");
            baglanti.Open();
            da = new SqlDataAdapter("select TCKN,Isim,Soyisim,Bolum1 OkuduguBolum,OgrNo1 OgrenciNumarasi,Bolum2 OkuduguBolum2,OgrNo2 OgrenciNumarasi2,TelNo,DurumBilgisi from Ogrenciler", baglanti);
            DataTable tablo = new DataTable();
            baglanti.Close();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            OgrenciGetir();

            comboBoxDurum.Items.Add("Anadal");
            comboBoxDurum.Items.Add("Çap");

            comboBoxBolum.Items.Add("B1");
            comboBoxBolum.Items.Add("B2");
            comboBoxBolum.Items.Add("B3");
            comboBoxBolum.Items.Add("B4");
            comboBoxBolum.Items.Add("B5");

            label12.Visible = false;
            label13.Visible = false;
            comboBoxBolum.Visible = false;
            textBoxOgrNo.Visible = false;


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxDurum.SelectedIndex == 1)
            {
                label12.Visible = true;
                label13.Visible = true;
                comboBoxBolum.Visible = true;
                textBoxOgrNo.Visible = true;

            }
            else
            {
                label12.Visible = false;
                label13.Visible = false;
                comboBoxBolum.Visible = false;
                textBoxOgrNo.Visible = false;

            }
            if (comboBoxBolum.SelectedIndex != -1)
            {
                OgrenciNumarasıAta(textBoxOgrNo, comboBoxBolum);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {

            string mesaj = "Bu öğrencinin verilerini güncellemek istediğinize emin misiniz?";
            string title = "Uyarı";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(mesaj, title, buttons);
            if (result == DialogResult.Yes)
            {
                //Evete basılırsa yapılacak işlemler
                if (comboBoxDurum.SelectedItem.ToString() == "Anadal")
                {

                    string sorgu = "Update Ogrenciler set Isim=@Isim, Soyisim=@Soyisim, TCKN=@TCKN, TelNo=@TelNo, DurumBilgisi=@Durumbilgisi where TCKN=@TCKN";
                    string sorgu2 = "UPDATE Ogrenciler SET OgrNo2 = NULL, Bolum2 = NULL WHERE TCKN=@TCKN";
                    komut = new SqlCommand(sorgu, baglanti);
                    komut2 = new SqlCommand(sorgu2, baglanti);
                    komut.Parameters.AddWithValue("@Isim", textBoxAdi.Text);
                    komut.Parameters.AddWithValue("@Soyisim", textBoxSoyadi.Text);
                    komut.Parameters.AddWithValue("@TCKN", textBoxTCKN2.Text);
                    komut.Parameters.AddWithValue("@TelNo", textBoxTelNo.Text);
                    komut.Parameters.AddWithValue("@DurumBilgisi", comboBoxDurum.SelectedItem.ToString());
                    komut2.Parameters.AddWithValue("@TCKN", textBoxTCKN2.Text);
                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    komut2.ExecuteNonQuery();
                    baglanti.Close();
                    OgrenciGetir();
                    textBoxAdi.Clear();
                    textBoxSoyadi.Clear();
                    textBoxTCKN2.Clear();
                    textBoxTelNo.Clear();
                    textBoxOgrNo.Clear();
                    comboBoxDurum.SelectedIndex = -1;
                    comboBoxBolum.SelectedIndex = -1;
                    MessageBox.Show($"{guncellenenIsim} {guncellenenSoyisim} adlı öğrenci güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {


                    if (dataGridView1.CurrentRow.Cells[3].Value.ToString() == comboBoxBolum.SelectedItem.ToString())
                    {
                        MessageBox.Show("Anadal bölümü ile Çap bölümü aynı olamaz! ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        string sorgu = "Update Ogrenciler set Isim=@Isim, Soyisim=@Soyisim, TCKN=@TCKN, TelNo=@TelNo, DurumBilgisi=@Durumbilgisi, Bolum2=@Bolum2, OgrNo2=@OgrNo2 where TCKN=@TCKN";
                        komut = new SqlCommand(sorgu, baglanti);
                        komut.Parameters.AddWithValue("@Isim", textBoxAdi.Text);
                        komut.Parameters.AddWithValue("@Soyisim", textBoxSoyadi.Text);
                        komut.Parameters.AddWithValue("@TCKN", textBoxTCKN2.Text);
                        komut.Parameters.AddWithValue("@TelNo", textBoxTelNo.Text);
                        komut.Parameters.AddWithValue("@DurumBilgisi", comboBoxDurum.SelectedItem.ToString());
                        komut.Parameters.AddWithValue("@Bolum2", comboBoxBolum.SelectedItem.ToString());
                        komut.Parameters.AddWithValue("@OgrNo2", textBoxOgrNo.Text);
                        baglanti.Open();
                        komut.ExecuteNonQuery();
                        baglanti.Close();
                        OgrenciGetir();
                        textBoxAdi.Clear();
                        textBoxSoyadi.Clear();
                        textBoxTCKN2.Clear();
                        textBoxTelNo.Clear();
                        textBoxOgrNo.Clear();
                        comboBoxDurum.SelectedIndex = -1;
                        comboBoxBolum.SelectedIndex = -1;
                        MessageBox.Show($"{guncellenenIsim} {guncellenenSoyisim} adlı öğrenci güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }

                }

            }
            else
            {
                //Hayıra basılırsa yapılacak işlemler
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            komut = new SqlCommand("select TCKN,Isim,Soyisim,Bolum1 OkuduguBolum,OgrNo1 OgrenciNumarasi,Bolum2 OkuduguBolum2,OgrNo2 OgrenciNumarasi2,TelNo,DurumBilgisi  from Ogrenciler where Isim like '%" + textBoxAd.Text + "%'", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void textBoxSoyad_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            komut = new SqlCommand("select TCKN,Isim,Soyisim,Bolum1 OkuduguBolum,OgrNo1 OgrenciNumarasi,Bolum2 OkuduguBolum2,OgrNo2 OgrenciNumarasi2,TelNo,DurumBilgisi from Ogrenciler where Soyisim like '%" + textBoxSoyad.Text + "%'", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void textBoxTCKN_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            komut = new SqlCommand("select TCKN,Isim,Soyisim,Bolum1 OkuduguBolum,OgrNo1 OgrenciNumarasi,Bolum2 OkuduguBolum2,OgrNo2 OgrenciNumarasi2,TelNo,DurumBilgisi from Ogrenciler where TCKN like '%" + textBoxTCKN.Text + "%'", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBoxTCKN2.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxSoyadi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBoxTelNo.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            guncellenenIsim = textBoxAdi.Text;
            guncellenenSoyisim = textBoxSoyadi.Text;



            if (dataGridView1.CurrentRow.Cells[8].Value.ToString() == "Anadal")
            {
                comboBoxDurum.SelectedItem = "Anadal";
            }
            if (dataGridView1.CurrentRow.Cells[8].Value.ToString() == "Çap")
            {
                comboBoxDurum.SelectedItem = "Çap";
                comboBoxBolum.SelectedItem = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                textBoxOgrNo.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

            }


            //comboBoxBolum = dataGridView1.CurrentRow.Cells[1].Value;
            //comboBoxDurum = dataGridView1.CurrentRow.Cells[1].Value;
        }
        public void OgrenciNumarasıAta(TextBox textBox, ComboBox comboBox)
        {
            textBox.Clear();
            Random random = new Random();
            int sayi;
            if (comboBox.SelectedItem.ToString() == "B1")
            {
                sayi = random.Next(10000000, 99999999);
                textBox.Text = "1" + sayi;

            }

            else if (comboBox.SelectedItem.ToString() == "B2")
            {
                sayi = random.Next(10000000, 99999999);
                textBox.Text = "2" + sayi;
            }

            else if (comboBox.SelectedItem.ToString() == "B3")
            {
                sayi = random.Next(10000000, 99999999);
                textBox.Text = "3" + sayi;
            }

            else if (comboBox.SelectedItem.ToString() == "B4")
            {
                sayi = random.Next(10000000, 99999999);
                textBox.Text = "4" + sayi;
            }

            else if (comboBox.SelectedItem.ToString() == "B5")
            {
                sayi = random.Next(10000000, 99999999);
                textBox.Text = "5" + sayi;
            }

            else
            {

                textBox.Clear();
            }
        }
    }
}
