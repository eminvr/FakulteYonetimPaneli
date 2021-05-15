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

    public partial class FormOgrenciEkle : Form
    {
        public static bool durum;
        


        public FormOgrenciEkle()
        {
            InitializeComponent();
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        SqlConnection baglanti = new SqlConnection(Anasayfa.sqlAdress);
        SqlConnection baglanti2 = new SqlConnection(Anasayfa.sqlAdress);

        void mukerrer()
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Ogrenciler where TCKN=@p4", baglanti);
            komut.Parameters.AddWithValue("@p4", textBoxTCKN.Text);
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
            if (textBoxSoyadi.TextLength < 1 || textBoxAdi.TextLength < 1) 
            {
                MessageBox.Show("Ad veya soyad kısmı boş bırakılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (textBoxTCKN.TextLength != 11)
            {
                MessageBox.Show("TCKN 11 haneli olmalıdır!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (textBoxTelNo.Text.Length != 11)
            {
                MessageBox.Show("Telefon numarası 11 haneli olmalıdır!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Durum bilgisi kısmı boş bırakılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Bölüm1 kısmı boş bırakılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (comboBox1.SelectedItem.ToString() == "Çap" && comboBox3.SelectedIndex == -1)
            {
                MessageBox.Show("Bölüm2 kısmı boş bırakılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                mukerrer();
                if (durum)
                {
                   
                    

                    //ÇAP SEÇİLDİYSE VERİ TABANINA EKLENECEK KODLAR
                    if (comboBox1.SelectedItem.ToString() == "Çap")
                    {
                        //BOLUM 2'Yİ EKLE
                        //OGR NO 2'Yİ EKLE
                        baglanti2.Open();
                        SqlCommand komut2 = new SqlCommand("insert into Ogrenciler (TCKN,Isim,Soyisim,OgrNo1,Bolum1,TelNo,DurumBilgisi,AldigiDers1,Bolum2,OgrNo2) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,'Matematik',@p8,@p9)", baglanti2);
                        komut2.Parameters.AddWithValue("@p1", textBoxTCKN.Text);
                        komut2.Parameters.AddWithValue("@p2", textBoxAdi.Text);
                        komut2.Parameters.AddWithValue("@p3", textBoxSoyadi.Text);
                        komut2.Parameters.AddWithValue("@p4", textBoxBolum1OgrNo.Text);
                        komut2.Parameters.AddWithValue("@p5", comboBox2.Text);
                        komut2.Parameters.AddWithValue("@p6", textBoxTelNo.Text);
                        komut2.Parameters.AddWithValue("@p7", comboBox1.Text);
                        komut2.Parameters.AddWithValue("@p8", comboBox3.Text);
                        komut2.Parameters.AddWithValue("@p9", textBoxBolum2OgrNo.Text);
                        komut2.ExecuteNonQuery();
                        baglanti2.Close();
                    }
                    else
                    {
                        baglanti.Open();
                        SqlCommand komut = new SqlCommand("insert into Ogrenciler (TCKN,Isim,Soyisim,OgrNo1,Bolum1,TelNo,DurumBilgisi,AldigiDers1) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,'Matematik')", baglanti);
                        komut.Parameters.AddWithValue("@p1", textBoxTCKN.Text);
                        komut.Parameters.AddWithValue("@p2", textBoxAdi.Text);
                        komut.Parameters.AddWithValue("@p3", textBoxSoyadi.Text);
                        komut.Parameters.AddWithValue("@p4", textBoxBolum1OgrNo.Text);
                        komut.Parameters.AddWithValue("@p5", comboBox2.Text);
                        komut.Parameters.AddWithValue("@p6", textBoxTelNo.Text);
                        komut.Parameters.AddWithValue("@p7", comboBox1.Text);
                        komut.ExecuteNonQuery();
                        baglanti.Close();
                    }
                    
                    MessageBox.Show("Kayit Eklendi");
                    textBoxAdi.Text = "";
                    textBoxSoyadi.Text = "";
                    textBoxBolum1OgrNo.Text = "";
                    textBoxTCKN.Text = "";
                    textBoxTelNo.Text = "";
                    comboBox1.Text = "Seçiniz";
                }
                else
                {
                    MessageBox.Show("Bu kayit zaten var", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void textBoxAdiSoyadi_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Anadal");
            comboBox1.Items.Add("Çap");

            comboBox2.Items.Add("B1");
            comboBox2.Items.Add("B2");
            comboBox2.Items.Add("B3");
            comboBox2.Items.Add("B4");
            comboBox2.Items.Add("B5");

            comboBox3.Items.Add("B1");
            comboBox3.Items.Add("B2");
            comboBox3.Items.Add("B3");
            comboBox3.Items.Add("B4");
            comboBox3.Items.Add("B5");

            label8.Visible = false;
            label9.Visible = false;
            comboBox3.Visible = false;
            textBoxBolum2OgrNo.Visible = false;



        }

        private void comboBox1_DropDownClosed(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Çap")
            {
                label8.Visible = true;
                label9.Visible = true;
                comboBox3.Visible = true;
                textBoxBolum2OgrNo.Visible = true;
            }
            else
            {
                label8.Visible = false;
                label9.Visible = false;
                comboBox3.Visible = false;
                textBoxBolum2OgrNo.Visible = false;
            }
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

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            OgrenciNumarasıAta(textBoxBolum1OgrNo, comboBox2);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            OgrenciNumarasıAta(textBoxBolum2OgrNo, comboBox3);
        }

        private void textBoxTCKN_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBoxTelNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
