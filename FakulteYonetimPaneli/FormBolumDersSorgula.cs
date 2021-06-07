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
    public partial class FormBolumDersSorgula : Form
    {
        SqlConnection baglanti = new SqlConnection(Anasayfa.sqlAdress);
        SqlDataAdapter da;
        string blm;
        public FormBolumDersSorgula()
        {
            InitializeComponent();
        }

        private void FormBolumDersSorgula_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add(Anasayfa.bolum1);
            comboBox1.Items.Add(Anasayfa.bolum2);
            comboBox1.Items.Add(Anasayfa.bolum3);
            comboBox1.Items.Add(Anasayfa.bolum4);
            comboBox1.Items.Add(Anasayfa.bolum5);
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                blm = comboBox1.SelectedItem.ToString();
            }
            catch (Exception)
            {

                blm = "";
            }

            baglanti = new SqlConnection(Anasayfa.sqlAdress);
            baglanti.Open();
            da = new SqlDataAdapter("SELECT * FROM Dersler where VerildigiBolum='" + blm + "'", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
    }
}
