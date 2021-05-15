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
    public partial class FormOgretimUyesiSil : Form
    {
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
            string mesaj = "Bu öğretim görevlisini silmek istediğinize emin misiniz?";
            string title = "Uyarı";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(mesaj, title, buttons);
            if (result == DialogResult.Yes)
            {
                //EVET basılırsa yapılacak işlemler              
                textBoxAd.Clear();
                textBoxSoyad.Clear();
                textBoxSicil.Clear();
            }
            else
            {
                //Hayıra basılırsa yapılacak işlemler
            }
        }
    }
}
