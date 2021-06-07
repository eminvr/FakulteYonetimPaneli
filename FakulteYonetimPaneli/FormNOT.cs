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
    public partial class FormNOT : Form
    {
        SqlConnection baglanti = new SqlConnection(Anasayfa.sqlAdress);
        SqlConnection baglanti2 = new SqlConnection(Anasayfa.sqlAdress);
        SqlCommand komut;
        SqlCommand komut2;

        bool butonKontrol = false;

        public FormNOT()
        {
            InitializeComponent();
        }

        private void FormNOT_Load(object sender, EventArgs e)
        {
            comboBoxDers.Items.Add("Ders1");
        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            //SQL kaydetme
            if (butonKontrol)
            {

                if (comboBoxDers.SelectedIndex == -1)
                {
                    MessageBox.Show("Ders seçimi yapmadınız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else if (textBoxVize.TextLength < 1)
                {
                    MessageBox.Show("Vize notunu girmediniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else if (textBoxFinal.TextLength < 1)
                {
                    MessageBox.Show("Final notunu girmediniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else
                {

                    //EĞER KAYDEDİLİRSE GERÇEKLEŞCEK KODLAR (SQL KODLARI)
                    if (comboBoxDers.SelectedIndex==0)
                    {
                        string sorgu = "Update Ogrenciler set VizeNotu1=@Vize, FinalNotu1=@Final, Ortalama1=@Ortalama Where OgrNo1='" + textBoxOgrNo.Text + "' or OgrNo2='" + textBoxOgrNo.Text + "'";
                        komut = new SqlCommand(sorgu, baglanti);
                        komut.Parameters.AddWithValue("@Vize", Convert.ToInt32(textBoxVize.Text));
                        komut.Parameters.AddWithValue("@Final", Convert.ToInt32(textBoxFinal.Text));
                        komut.Parameters.AddWithValue("@Ortalama", Convert.ToDouble(textBoxOrtalama.Text));
                        baglanti.Open();
                        komut.ExecuteNonQuery();
                        baglanti.Close();
                    }
                    if (comboBoxDers.SelectedIndex == 1)
                    {
                        string sorgu = "Update Ogrenciler set VizeNotu2=@Vize, FinalNotu2=@Final, Ortalama2=@Ortalama Where OgrNo1='" + textBoxOgrNo.Text + "' or OgrNo2='" + textBoxOgrNo.Text + "'";
                        komut = new SqlCommand(sorgu, baglanti);
                        komut.Parameters.AddWithValue("@Vize", Convert.ToInt32(textBoxVize.Text));
                        komut.Parameters.AddWithValue("@Final", Convert.ToInt32(textBoxFinal.Text));
                        komut.Parameters.AddWithValue("@Ortalama", Convert.ToDouble(textBoxOrtalama.Text));
                        baglanti.Open();
                        komut.ExecuteNonQuery();
                        baglanti.Close();
                    }
                    if (comboBoxDers.SelectedIndex == 2)
                    {
                        string sorgu = "Update Ogrenciler set VizeNotu3=@Vize, FinalNotu3=@Final, Ortalama3=@Ortalama Where OgrNo1='" + textBoxOgrNo.Text + "' or OgrNo2='" + textBoxOgrNo.Text + "'";
                        komut = new SqlCommand(sorgu, baglanti);
                        komut.Parameters.AddWithValue("@Vize", Convert.ToInt32(textBoxVize.Text));
                        komut.Parameters.AddWithValue("@Final", Convert.ToInt32(textBoxFinal.Text));
                        komut.Parameters.AddWithValue("@Ortalama", Convert.ToDouble(textBoxOrtalama.Text));
                        baglanti.Open();
                        komut.ExecuteNonQuery();
                        baglanti.Close();
                    }
                    if (comboBoxDers.SelectedIndex == 3)
                    {
                        string sorgu = "Update Ogrenciler set VizeNotu4=@Vize, FinalNotu4=@Final, Ortalama4=@Ortalama Where OgrNo1='" + textBoxOgrNo.Text + "' or OgrNo2='" + textBoxOgrNo.Text + "'";
                        komut = new SqlCommand(sorgu, baglanti);
                        komut.Parameters.AddWithValue("@Vize", Convert.ToInt32(textBoxVize.Text));
                        komut.Parameters.AddWithValue("@Final", Convert.ToInt32(textBoxFinal.Text));
                        komut.Parameters.AddWithValue("@Ortalama", Convert.ToDouble(textBoxOrtalama.Text));
                        baglanti.Open();
                        komut.ExecuteNonQuery();
                        baglanti.Close();
                    }
                    if (comboBoxDers.SelectedIndex == 4)
                    {
                        string sorgu = "Update Ogrenciler set VizeNotu5=@Vize, FinalNotu5=@Final, Ortalama5=@Ortalama Where OgrNo1='" + textBoxOgrNo.Text + "' or OgrNo2='" + textBoxOgrNo.Text + "'";
                        komut = new SqlCommand(sorgu, baglanti);
                        komut.Parameters.AddWithValue("@Vize", Convert.ToInt32(textBoxVize.Text));
                        komut.Parameters.AddWithValue("@Final", Convert.ToInt32(textBoxFinal.Text));
                        komut.Parameters.AddWithValue("@Ortalama", Convert.ToDouble(textBoxOrtalama.Text));
                        baglanti.Open();
                        komut.ExecuteNonQuery();
                        baglanti.Close();
                    }


                    buttonKaydet.Text = "Hesapla";
                    MessageBox.Show("Kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    comboBoxDers.SelectedIndex = -1;
                    textBoxFinal.Clear();
                    textBoxVize.Clear();
                    textBoxOrtalama.Clear();
                    butonKontrol = !butonKontrol;
                }

            }

            //NOT HESAPLAMA
            else
            {

                if (textBoxVize.TextLength < 1)
                {
                    MessageBox.Show("Vize notunu girmediniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else if (textBoxFinal.TextLength < 1)
                {
                    MessageBox.Show("Final notunu girmediniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else
                {

                    int vizeNotu = Convert.ToInt32(textBoxVize.Text);
                    int finalNotu = Convert.ToInt32(textBoxFinal.Text);

                    double ortalama = (vizeNotu * 0.4) + (finalNotu * 0.6);
                    textBoxOrtalama.Text = ortalama.ToString();                    
                    buttonKaydet.Text = "Kaydet";
                    butonKontrol = !butonKontrol;
                }
            }
        }

        private void buttonAra_Click(object sender, EventArgs e)
        {
            if (textBoxOgrNo.TextLength != 9)
            {
                MessageBox.Show("Öğrenci numarasını eksik girdiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                //Listeleme Kodları
                string sorgu = "Select Isim,Soyisim,TelNo from Ogrenciler where OgrNo1='"+textBoxOgrNo.Text+"' or OgrNo2='"+ textBoxOgrNo.Text+"'";
                komut = new SqlCommand(sorgu, baglanti);
                baglanti.Open();
                komut.ExecuteNonQuery();
                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                    textBoxAd.Text=(read["Isim"]).ToString();
                    textBoxSoyad.Text=(read["Soyisim"]).ToString();
                    textBoxTelNo.Text=(read["TelNo"]).ToString();
                }
                baglanti.Close();

                comboBoxDers.Items.Clear();
                string sorgu2 = "Select * from Ogrenciler where OgrNo1='" + textBoxOgrNo.Text + "' or OgrNo2='" + textBoxOgrNo.Text + "'";
                komut2 = new SqlCommand(sorgu2, baglanti2);
                baglanti2.Open();
                komut2.ExecuteNonQuery();
                SqlDataReader read2 = komut2.ExecuteReader();
                while (read2.Read())
                {
                    comboBoxDers.Items.Add(read2["AldigiDers1"]);
                    if (read2["AldigiDers2"].ToString().Length > 2)
                    {
                        comboBoxDers.Items.Add(read2["AldigiDers2"]);
                    }
                    if (read2["AldigiDers3"].ToString().Length > 2)
                    {
                        comboBoxDers.Items.Add(read2["AldigiDers3"]);
                    }
                    if (read2["AldigiDers4"].ToString().Length > 2)
                    {
                        comboBoxDers.Items.Add(read2["AldigiDers4"]);
                    }
                    if (read2["AldigiDers5"].ToString().Length > 2)
                    {
                        comboBoxDers.Items.Add(read2["AldigiDers5"]);
                    }               
                }                            
                baglanti.Close();
            }
        }

        private void textBoxOgrNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBoxFinal_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBoxVize_KeyPress(object sender, KeyPressEventArgs e)
        {
            //e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
