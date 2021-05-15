using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FakulteYonetimPaneli
{
    public partial class FormOgretimUyesiEkle : Form
    {
        public FormOgretimUyesiEkle()
        {
            InitializeComponent();
        }

        public void SicilNoAta()
        {
            Random random = new Random();
            int sicil;

            if (comboBoxBolum.SelectedItem.ToString() == "B1")
            {
                sicil = random.Next(100, 999);
                textBoxSicilNo.Text = "1" + sicil;
            }

            else if (comboBoxBolum.SelectedItem.ToString() == "B2")
            {
                sicil = random.Next(100, 999);
                textBoxSicilNo.Text = "2" + sicil;
            }

            else if (comboBoxBolum.SelectedItem.ToString() == "B3")
            {
                sicil = random.Next(100, 999);
                textBoxSicilNo.Text = "3" + sicil;
            }

            else if (comboBoxBolum.SelectedItem.ToString() == "B4")
            {
                sicil = random.Next(100, 999);
                textBoxSicilNo.Text = "4" + sicil;
            }

            else if (comboBoxBolum.SelectedItem.ToString() == "B5")
            {
                sicil = random.Next(100, 999);
                textBoxSicilNo.Text = "5" + sicil;
            }

            else
            {
                textBoxSicilNo.Clear();
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (textBoxAd.TextLength < 1 || textBoxSoyad.TextLength < 1)
            {
                MessageBox.Show("Ad veya soyad kısmı boş bırakılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (comboBoxBolum.SelectedIndex == -1)
            {
                MessageBox.Show("Bölüm kısmı boş bırakılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Ders 1 kısmı boş bırakılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                //SQL VB KODLAR
            }
        }

        private void FormOgretimUyesiEkle_Load(object sender, EventArgs e)
        {
            comboBoxBolum.Items.Add("B1");
            comboBoxBolum.Items.Add("B2");
            comboBoxBolum.Items.Add("B3");
            comboBoxBolum.Items.Add("B4");
            comboBoxBolum.Items.Add("B5");

            comboBox1.Items.Add("Ders1");
            comboBox1.Items.Add("Ders2");
        }

        private void comboBoxBolum_SelectedIndexChanged(object sender, EventArgs e)
        {
            SicilNoAta();
        }
    }
}
