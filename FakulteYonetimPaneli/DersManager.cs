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
    class DersManager
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;

        public DataTable DersGetir(string gelecekler)
        {
            baglanti = new SqlConnection(Anasayfa.sqlAdress);
            baglanti.Open();
            da = new SqlDataAdapter("SELECT " + gelecekler + " FROM Dersler", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);           
            baglanti.Close();
            return tablo;
        }

        public DataTable DersSorgula(TextBox textBox, string sorgu, string gelecekler)
        {
            baglanti = new SqlConnection(Anasayfa.sqlAdress);
            baglanti.Open();
            komut = new SqlCommand("SELECT " + gelecekler + " FROM Dersler WHERE " + sorgu + " LIKE '%" + textBox.Text + "%'", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            baglanti.Close();
            return tablo;
        }

        public void DersKoduAta(ComboBox comboBox, TextBox textBoxSınıf, TextBox textBoxKod)
        {
            

            if (comboBox.Text == Anasayfa.bolum1)
            {
                textBoxKod.Text = "B1" + textBoxSınıf.Text;
            }

            else if (comboBox.Text == Anasayfa.bolum2)
            {
                textBoxKod.Text = "B2" + textBoxSınıf.Text;
            }

            else if (comboBox.Text == Anasayfa.bolum3)
            {
                textBoxKod.Text = "B3" + textBoxSınıf.Text;
            }

            else if (comboBox.Text == Anasayfa.bolum4)
            {
                textBoxKod.Text = "B4" + textBoxSınıf.Text;
            }

            else if (comboBox.Text == Anasayfa.bolum5)
            {
                textBoxKod.Text = "B5" + textBoxSınıf.Text;
            }

            else
            {
                textBoxKod.Clear();
            }

        }
    }
}
