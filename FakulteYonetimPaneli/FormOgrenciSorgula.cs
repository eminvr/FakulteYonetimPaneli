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
    public partial class FormOgrenciSorgula : Form
    {
        OgrenciManager ogrenciManager = new OgrenciManager();


        public FormOgrenciSorgula()
        {
            InitializeComponent();
        }


        private void Form5_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ogrenciManager.OgrenciGetir("TCKN,Isim,Soyisim,Bolum1 OkuduguBolum,OgrNo1 OgrenciNumarasi," +
                "Bolum2 OkuduguBolum2,OgrNo2 OgrenciNumarasi2,TelNo,DurumBilgisi,AldigiDers1,AldigiDers2,AldigiDers3,AldigiDers4,AldigiDers5");
        }



        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //TCKN          
            dataGridView1.DataSource = ogrenciManager.ogrenciSorgula(textBoxTCKN, "TCKN", "TCKN,Isim,Soyisim,Bolum1 OkuduguBolum,OgrNo1 OgrenciNumarasi," +
                "Bolum2 OkuduguBolum2,OgrNo2 OgrenciNumarasi2,TelNo,DurumBilgisi,AldigiDers1,AldigiDers2,AldigiDers3,AldigiDers4,AldigiDers5");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //ISIM
            dataGridView1.DataSource = ogrenciManager.ogrenciSorgula(textBoxAd, "Isim", "TCKN,Isim,Soyisim,Bolum1 OkuduguBolum,OgrNo1 OgrenciNumarasi," +
                "Bolum2 OkuduguBolum2,OgrNo2 OgrenciNumarasi2,TelNo,DurumBilgisi,AldigiDers1,AldigiDers2,AldigiDers3,AldigiDers4,AldigiDers5");
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //SOYAD
            dataGridView1.DataSource = ogrenciManager.ogrenciSorgula(textBoxSoyad, "Soyisim", "TCKN,Isim,Soyisim,Bolum1 OkuduguBolum,OgrNo1 OgrenciNumarasi," +
                 "Bolum2 OkuduguBolum2,OgrNo2 OgrenciNumarasi2,TelNo,DurumBilgisi,AldigiDers1,AldigiDers2,AldigiDers3,AldigiDers4,AldigiDers5");
        }


        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //TELNO
            dataGridView1.DataSource = ogrenciManager.ogrenciSorgula(textBoxTelNo, "TelNo", "TCKN,Isim,Soyisim,Bolum1 OkuduguBolum,OgrNo1 OgrenciNumarasi," +
                "Bolum2 OkuduguBolum2,OgrNo2 OgrenciNumarasi2,TelNo,DurumBilgisi,AldigiDers1,AldigiDers2,AldigiDers3,AldigiDers4,AldigiDers5");
        }


        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }


        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
