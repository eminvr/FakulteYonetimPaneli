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
    public partial class FormBolumOgrenciDersEkle : Form
    {
        OgrenciManager ogrenciManager = new OgrenciManager();
        SqlConnection baglanti;
        SqlCommand komut;
        public FormBolumOgrenciDersEkle()
        {
            InitializeComponent();
        }

        private void FormOgrenciDersEkle_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ogrenciManager.OgrenciGetir("TCKN,Isim,Soyisim,Bolum1,OgrNo1,Bolum2,OgrNo2,DurumBilgisi,AldigiDers1,AldigiDers2,AldigiDers3,AldigiDers4,AldigiDers5");
        }

        private void textBoxDersAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBoxDersKodu_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBoxOgrenciNo_TextChanged(object sender, EventArgs e)
        {
            baglanti = new SqlConnection(Anasayfa.sqlAdress);
            baglanti.Open();
            komut = new SqlCommand("SELECT TCKN,Isim,Soyisim,Bolum1,OgrNo1,Bolum2,OgrNo2,DurumBilgisi,AldigiDers1,AldigiDers2,AldigiDers3,AldigiDers4,AldigiDers5 FROM Ogrenciler WHERE OgrNo1 LIKE '%" + textBoxOgrenciNo.Text + "%' or OgrNo2 LIKE '%" + textBoxOgrenciNo.Text + "%'", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void textBoxTCKN_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ogrenciManager.ogrenciSorgula(textBoxTCKN, "TCKN", "TCKN,Isim,Soyisim,Bolum1,OgrNo1,Bolum2,OgrNo2,DurumBilgisi,AldigiDers1,AldigiDers2,AldigiDers3,AldigiDers4,AldigiDers5");

        }

        private void textBoxAdi_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ogrenciManager.ogrenciSorgula(textBoxAdi, "Isim", "TCKN,Isim,Soyisim,Bolum1,OgrNo1,Bolum2,OgrNo2,DurumBilgisi,AldigiDers1,AldigiDers2,AldigiDers3,AldigiDers4,AldigiDers5");

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow.Cells[7].Value.ToString() == "Anadal")
            {
                comboBox1.Items.Clear();
                comboBox2.Items.Clear();
                comboBox3.Items.Clear();
                comboBox4.Items.Clear();
                string blm = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                baglanti = new SqlConnection(Anasayfa.sqlAdress);
                baglanti.Open();
                komut = new SqlCommand("select * from Dersler where VerildigiBolum='" + blm + "'", baglanti);
                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                    comboBox1.Items.Add(read["DersAdi"]);
                    comboBox2.Items.Add(read["DersAdi"]);
                    comboBox3.Items.Add(read["DersAdi"]);
                    comboBox4.Items.Add(read["DersAdi"]);
                }
                baglanti.Close();
            }

            if (dataGridView1.CurrentRow.Cells[7].Value.ToString() == "Çap")
            {
                comboBox1.Items.Clear();
                comboBox2.Items.Clear();
                comboBox3.Items.Clear();
                comboBox4.Items.Clear();
                string blm = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                string blm2 = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                baglanti = new SqlConnection(Anasayfa.sqlAdress);
                baglanti.Open();
                komut = new SqlCommand("select * from Dersler where VerildigiBolum='" + blm + "' or VerildigiBolum='" + blm2 + "'", baglanti);
                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                    comboBox1.Items.Add(read["DersAdi"]);
                    comboBox2.Items.Add(read["DersAdi"]);
                    comboBox3.Items.Add(read["DersAdi"]);
                    comboBox4.Items.Add(read["DersAdi"]);
                }
                baglanti.Close();
            }

            comboBox1.SelectedItem = dataGridView1.CurrentRow.Cells[9].Value;
            comboBox2.SelectedItem = dataGridView1.CurrentRow.Cells[10].Value;
            comboBox3.SelectedItem = dataGridView1.CurrentRow.Cells[11].Value;
            comboBox4.SelectedItem = dataGridView1.CurrentRow.Cells[12].Value;

        }

        private void btnOgrenciyiEkle_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1 && comboBox2.SelectedIndex == -1 && comboBox3.SelectedIndex == -1 && comboBox4.SelectedIndex == -1)
            {
                MessageBox.Show("Hiç ders seçmediniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (comboBox1.SelectedIndex != -1 && (comboBox1.Text == comboBox2.Text || comboBox1.Text == comboBox3.Text || comboBox1.Text == comboBox4.Text))
            {

                MessageBox.Show("Seçilen dersler aynı olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            else if (comboBox2.SelectedIndex != -1 && (comboBox2.Text == comboBox3.Text || comboBox2.Text == comboBox4.Text))
            {
                MessageBox.Show("Seçilen dersler aynı olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (comboBox3.SelectedIndex != -1 && comboBox3.Text == comboBox4.Text)
            {
                MessageBox.Show("Seçilen dersler aynı olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            else
            {
                MessageBox.Show("Seçilen dersler eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string sorgu = "Update Ogrenciler set AldigiDers2=@AldigiDers2, AldigiDers3=@AldigiDers3, AldigiDers4=@AldigiDers4, AldigiDers5=@AldigiDers5 where TCKN=@TCKN";
                komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@AldigiDers2", comboBox1.Text);
                komut.Parameters.AddWithValue("@AldigiDers3", comboBox2.Text);
                komut.Parameters.AddWithValue("@AldigiDers4", comboBox3.Text);
                komut.Parameters.AddWithValue("@AldigiDers5", comboBox4.Text);
                komut.Parameters.AddWithValue("@TCKN", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                dataGridView1.DataSource = ogrenciManager.ogrenciSorgula(textBoxAdi, "Isim", "TCKN,Isim,Soyisim,Bolum1,OgrNo1,Bolum2,OgrNo2,DurumBilgisi,AldigiDers1,AldigiDers2,AldigiDers3,AldigiDers4,AldigiDers5");
            }
           
        }
    }
}
