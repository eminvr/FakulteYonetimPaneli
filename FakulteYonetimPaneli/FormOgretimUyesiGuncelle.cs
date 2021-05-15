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
    public partial class FormOgretimUyesiGuncelle : Form
    {
        public FormOgretimUyesiGuncelle()
        {
            InitializeComponent();
        }

        private void FormOgretimUyesiGuncelle_Load(object sender, EventArgs e)
        {
            comboBoxBolum.Items.Add("B1");
            comboBoxBolum.Items.Add("B2");
            comboBoxBolum.Items.Add("B3");
            comboBoxBolum.Items.Add("B4");
            comboBoxBolum.Items.Add("B5");
        }

        private void textBoxTCKN_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string mesaj = "Seçili öğretim üyesinin verilerini güncellemek istediğinize emin misiniz?";
            string title = "Uyarı";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(mesaj, title, buttons);
            if (result == DialogResult.Yes)
            {
                //Evete basılırsa yapılacak işlemler

                MessageBox.Show($"{textBoxAdi.Text} {textBoxSoyadi.Text} adlı öğretim üyesi silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    textBoxAdi.Clear();
                    textBoxSoyadi.Clear();
                    textBoxSicil.Clear();
                    comboBoxBolum.SelectedIndex = -1;
                }



            }
            else
            {
                //Hayıra basılırsa yapılacak işlemler
            }
        }
    }
}
