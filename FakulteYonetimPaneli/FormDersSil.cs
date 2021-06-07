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
    public partial class FormDersSil : Form
    {
        DersManager dersManager = new DersManager();
        
        SqlConnection baglanti = new SqlConnection(Anasayfa.sqlAdress);
        SqlCommand komut;

        public FormDersSil()
        {
            InitializeComponent();
        }

  
        private void textBoxDersKodu_TextChanged(object sender, EventArgs e)
        {        
            dataGridView1.DataSource = dersManager.DersSorgula(textBoxDersKodu, "DersKodu", "DersKodu,DersAdi,DersiVeren");
        }


        private void textBoxDers_TextChanged(object sender, EventArgs e)
        {         
            dataGridView1.DataSource = dersManager.DersSorgula(textBoxDers, "DersAdi", "DersKodu,DersAdi,DersiVeren");
        }


        private void textBoxDersiVeren_TextChanged(object sender, EventArgs e)
        {
            //Dersi veren        
            dataGridView1.DataSource = dersManager.DersSorgula(textBoxDersiVeren, "DersiVeren", "DersKodu,DersAdi,DersiVeren");
        }


        private void FormDersSil_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dersManager.DersGetir("DersKodu,DersAdi,DersiVeren");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            komut = new SqlCommand("Delete From Dersler where DersKodu=@DersKodu", baglanti);
            komut.Parameters.AddWithValue("@DersKodu", dataGridView1.CurrentRow.Cells[0].Value.ToString());
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            dataGridView1.DataSource = dersManager.DersGetir("DersKodu,DersAdi,DersiVeren");
            MessageBox.Show("Ders silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
