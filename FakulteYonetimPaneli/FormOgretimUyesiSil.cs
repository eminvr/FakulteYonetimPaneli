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
    public partial class FormOgretimUyesiSil : Form
    {
        OgretimUyesiManager ogretimUyesiManager = new OgretimUyesiManager();

        SqlConnection baglanti;
        SqlCommand komut;

        public FormOgretimUyesiSil()
        {
            InitializeComponent();
        }

    
        private void textBoxTCKN_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }


        private void button2_Click(object sender, EventArgs e)
        {
            string mesaj = "Bu öğretim üyesini silmek istediğinize emin misiniz?";
            string title = "Uyarı";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(mesaj, title, buttons);

            if (result == DialogResult.Yes)
            {
                //EVET basılırsa yapılacak işlemler              
                string sorgu = "Delete from OgretimGorevlileri where SicilNo=@SicilNo";
                komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@SicilNo", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                dataGridView1.DataSource = ogretimUyesiManager.OgretimUyesiGetir("SicilNo,Isim,Soyisim,DersVerdigiBolum,VerdigiDersler1 VerdiğiDers1,VerdigiDersler2 VerdiğiDers2");
                MessageBox.Show("Öğretim üyesi silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxAd.Clear();
                textBoxSoyad.Clear();
                textBoxSicil.Clear();
            }

            else
            {
                //Hayıra basılırsa yapılacak işlemler
            }
        }


        private void textBoxAd_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ogretimUyesiManager.OgretimUyesiSorgula(textBoxAd, "Isim", "*");
        }


        private void textBoxSoyad_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ogretimUyesiManager.OgretimUyesiSorgula(textBoxSoyad,"Soyisim","*");
        }


        private void textBoxSicil_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ogretimUyesiManager.OgretimUyesiSorgula(textBoxSicil, "SicilNo", "*");
        }


        private void FormOgretimUyesiSil_Load(object sender, EventArgs e)
        {
            baglanti = new SqlConnection(Anasayfa.sqlAdress);
            dataGridView1.DataSource = ogretimUyesiManager.OgretimUyesiGetir("SicilNo,Isim,Soyisim,DersVerdigiBolum,VerdigiDersler1 VerdiğiDers1,VerdigiDersler2 VerdiğiDers2");
        }
    }
}
