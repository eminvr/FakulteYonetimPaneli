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
    class OgretimUyesiManager
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;


        public DataTable OgretimUyesiGetir(string gelecekler)
        {
            baglanti = new SqlConnection(Anasayfa.sqlAdress);
            baglanti.Open();
            da = new SqlDataAdapter("SELECT " + gelecekler + " FROM OgretimGorevlileri", baglanti);
            DataTable tablo = new DataTable();
            baglanti.Close();
            da.Fill(tablo);
            baglanti.Close();
            return tablo;
        }

        public DataTable OgretimUyesiSorgula(TextBox textBox, string sorgu, string gelecekler)
        {
            baglanti = new SqlConnection(Anasayfa.sqlAdress);
            baglanti.Open();
            komut = new SqlCommand("select " + gelecekler + " from OgretimGorevlileri where " + sorgu + " like '%" + textBox.Text + "%'", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            baglanti.Close();
            return tablo;
        }

        public void SicilNoAta(ComboBox comboBox, TextBox textBox)
        {
            Random random = new Random();
            int sicil;

            if (comboBox.SelectedIndex == 0)
            {
                sicil = random.Next(100, 999);
                textBox.Text = "1" + sicil;
            }

            else if (comboBox.SelectedIndex == 1)
            {
                sicil = random.Next(100, 999);
                textBox.Text = "2" + sicil;
            }

            else if (comboBox.SelectedIndex == 2)
            {
                sicil = random.Next(100, 999);
                textBox.Text = "3" + sicil;
            }

            else if (comboBox.SelectedIndex == 3)
            {
                sicil = random.Next(100, 999);
                textBox.Text = "4" + sicil;
            }

            else if (comboBox.SelectedIndex == 4)
            {
                sicil = random.Next(100, 999);
                textBox.Text = "5" + sicil;
            }

            else
            {
                textBox.Clear();
            }
        }
    }
}
