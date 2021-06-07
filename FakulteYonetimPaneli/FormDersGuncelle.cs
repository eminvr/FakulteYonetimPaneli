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
    public partial class FormDersGuncelle : Form
    {
        SqlConnection baglanti = new SqlConnection(Anasayfa.sqlAdress);
        DersManager dersManager = new DersManager();
        SqlCommand komut;

        public FormDersGuncelle()
        {
            InitializeComponent();
        }

        private void FormDersGuncelle_Load(object sender, EventArgs e)
        {
            baglanti = new SqlConnection(Anasayfa.sqlAdress);
           
            dataGridView1.DataSource = dersManager.DersGetir("*");
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string mesaj = "Bu öğrencinin verilerini güncellemek istediğinize emin misiniz?";
            string title = "Uyarı";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(mesaj, title, buttons, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                //Evete basılırsa yapılacak işlemler

                //MessageBox.Show($"{guncellenenIsim} {guncellenenSoyisim} adlı öğrenci güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string sorgu = "Update Dersler set DersAdi=@DersAdi, DersiVeren=@DersiVeren, Kredi=@Kredi where DersKodu=@DersKodu";               
                komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@DersKodu", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                komut.Parameters.AddWithValue("@DersAdi", textBoxAdi.Text);
                komut.Parameters.AddWithValue("@DersiVeren", comboBoxOgretimUyeleri.Text);                          
                komut.Parameters.AddWithValue("@Kredi", textBoxKredi.Text);
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                dataGridView1.DataSource = dersManager.DersGetir("*");
                textBoxAdi.Clear();
 

            }

            else
            {
                //Hayıra basılırsa yapılacak işlemler
            }
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            comboBoxOgretimUyeleri.Items.Clear();                     
            string blm = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            baglanti = new SqlConnection(Anasayfa.sqlAdress);
            baglanti.Open();            
            komut = new SqlCommand("select Isim from OgretimGorevlileri where DersVerdigiBolum='" + blm + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboBoxOgretimUyeleri.Items.Add(read["Isim"]);
            }
            baglanti.Close();
            textBoxAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            comboBoxOgretimUyeleri.SelectedItem = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBoxKredi.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();

        }

        private void comboBoxOgretimUyeleri_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
