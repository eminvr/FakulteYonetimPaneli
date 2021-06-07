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
    class OgrenciManager
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;

        public DataTable OgrenciGetir(string gelecekler)
        {
            baglanti = new SqlConnection(Anasayfa.sqlAdress);
            baglanti.Open();
            da = new SqlDataAdapter("SELECT " + gelecekler + " FROM Ogrenciler", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            baglanti.Close();
            return tablo;
        }


        public DataTable ogrenciSorgula(TextBox textBox, string sorgu, string gelecekler)
        {
            baglanti = new SqlConnection(Anasayfa.sqlAdress);
            baglanti.Open();
            komut = new SqlCommand("SELECT " + gelecekler +" FROM Ogrenciler WHERE " + sorgu + " LIKE '%" + textBox.Text + "%'", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            baglanti.Close();
            return tablo;
        }

        public void OgrenciNumarasıAta(TextBox textBox, ComboBox comboBox)
        {
            textBox.Clear();
            Random random = new Random();
            int sayi;

            if (comboBox.SelectedIndex == 0)
            {
                sayi = random.Next(10000000, 99999999);
                textBox.Text = "1" + sayi;
            }

            else if (comboBox.SelectedIndex == 1)
            {
                sayi = random.Next(10000000, 99999999);
                textBox.Text = "2" + sayi;
            }

            else if (comboBox.SelectedIndex == 2)
            {
                sayi = random.Next(10000000, 99999999);
                textBox.Text = "3" + sayi;
            }

            else if (comboBox.SelectedIndex == 3)
            {
                sayi = random.Next(10000000, 99999999);
                textBox.Text = "4" + sayi;
            }

            else if (comboBox.SelectedIndex == 4)
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
