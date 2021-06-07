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

    public partial class FormOgrenciSil : Form
    {

        OgrenciManager ogrenciManager = new OgrenciManager();

        SqlConnection baglanti;
        SqlCommand komut;      


        public FormOgrenciSil()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            string mesaj = "Bu öğrenciyi silmek istediğinize emin misiniz?";
            string title = "Uyarı";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(mesaj, title, buttons, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                string sorgu = "Delete from Ogrenciler where TCKN=@TCKN";
                komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@TCKN", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                dataGridView1.DataSource = ogrenciManager.OgrenciGetir("TCKN,Isim,Soyisim");
                textBoxAd.Clear();
                textBoxSoyad.Clear();
                textBoxTCKN.Clear();
                MessageBox.Show("Öğrenci silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                //Hayıra basılırsa yapılacak işlemler
            }
        }


        private void Form3_Load(object sender, EventArgs e)
        {
            baglanti = new SqlConnection(Anasayfa.sqlAdress);
            dataGridView1.DataSource = ogrenciManager.OgrenciGetir("TCKN, Isim, Soyisim");         
        }


        private void textBoxTCKN_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }


        private void textBoxAd_TextChanged_1(object sender, EventArgs e)
        {
            //Isim
            dataGridView1.DataSource = ogrenciManager.ogrenciSorgula(textBoxAd, "Isim", "TCKN,Isim,Soyisim");
        }


        private void textBoxSoyad_TextChanged_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ogrenciManager.ogrenciSorgula(textBoxSoyad, "Soyisim", "TCKN,Isim,Soyisim");
        }


        private void textBoxTCKN_TextChanged_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ogrenciManager.ogrenciSorgula(textBoxTCKN, "TCKN", "TCKN,Isim,Soyisim");
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
