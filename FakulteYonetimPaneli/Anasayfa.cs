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
    public partial class Anasayfa : Form
    {
        public static Button[] butonlar = new Button[16];
        public Anasayfa()
        {
            InitializeComponent();
            customizeDesign();
        }
        private void customizeDesign()
        {
            panelOgrenciSubMenu.Visible = false;
            panelOgretimSubMenu.Visible = false;
            panelBolumSubMenu.Visible = false;
            panelDersSubMenu.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelOgrenciSubMenu.Visible == true)
            {
                panelOgrenciSubMenu.Visible = false;
            }
            if (panelOgretimSubMenu.Visible == true)
            {
                panelOgretimSubMenu.Visible = false;
            }
            if (panelBolumSubMenu.Visible == true)
            {
                panelBolumSubMenu.Visible = false;
            }
            if (panelDersSubMenu.Visible == true)
            {
                panelDersSubMenu.Visible = false;
            }              
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }
       
        private void btnOgrenciIslemleri_Click(object sender, EventArgs e)
        {
            
            showSubMenu(panelOgrenciSubMenu);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            butonSıfırla();
            butonRenklendir(button2);
            openChildForm(new FormOgrenciEkle());
            //kodlar..

            //hideSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            butonSıfırla();
            butonRenklendir(button3);
            openChildForm(new FormOgrenciSil());
            //kodlar..
            //hideSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //kodlar..

            butonSıfırla();
            butonRenklendir(button4);
            openChildForm(new FormOgrenciGuncelle());
            //hideSubMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //kodlar..
            butonSıfırla();
            butonRenklendir(button5);
            openChildForm(new FormOgrenciSorgula());
            //hideSubMenu();
        }

        private void btnOgretimUyesiIslemleri_Click(object sender, EventArgs e)
        {
            
            showSubMenu(panelOgretimSubMenu);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //kodlar..
            butonSıfırla();
            butonRenklendir(button9);
            openChildForm(new FormOgretimUyesiEkle());
            //hideSubMenu();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //kodlar..
            butonSıfırla();
            butonRenklendir(button8);
            openChildForm(new FormOgretimUyesiSil());
            //hideSubMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //kodlar..
            butonSıfırla();
            butonRenklendir(button7);
            openChildForm(new FormOgretimUyesiGuncelle());
            //hideSubMenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //kodlar..
            butonSıfırla();
            butonRenklendir(button6);
            openChildForm(new FormOgretimUyesiSorgula());
            //hideSubMenu();
        }

        private void btnBolumIslemleri_Click(object sender, EventArgs e)
        {
            
            showSubMenu(panelBolumSubMenu);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //kodlar..
            butonSıfırla();
            butonRenklendir(button13);
            //hideSubMenu();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //kodlar..
            butonSıfırla();
            butonRenklendir(button12);
            //hideSubMenu();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //kodlar..
            butonSıfırla();
            butonRenklendir(button11);
 
            //hideSubMenu();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //kodlar..
            butonSıfırla();
            butonRenklendir(button10);
            //hideSubMenu();
        }

        private void btnDersIslemleri_Click(object sender, EventArgs e)
        {
            
            showSubMenu(panelDersSubMenu);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            //kodlar..
            butonSıfırla();
            butonRenklendir(button17);
            openChildForm(new FormDersEkle());
            //hideSubMenu();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            //kodlar..
            butonSıfırla();
            butonRenklendir(button16);
            openChildForm(new FormDersSil());
            //hideSubMenu();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            butonSıfırla();
            butonRenklendir(button15);
            openChildForm(new FormDersGuncelle());
            //hideSubMenu();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //kodlar..
            butonSıfırla();
            butonRenklendir(button14);
            openChildForm(new FormDersSorgula());
            //hideSubMenu();
        }

        private void btnNotIslemleri_Click(object sender, EventArgs e)
        {
            //kodlar..
            butonSıfırla();
            openChildForm(new FormNOT());
            hideSubMenu();
        }

        private void btnHakkinda_Click(object sender, EventArgs e)
        {
            //kodlar..
            butonSıfırla();
            hideSubMenu();
        }

        private Form activeForm = null;
        private void openChildForm(Form childFrom)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childFrom;
            childFrom.TopLevel = false;
            childFrom.FormBorderStyle = FormBorderStyle.None;
            childFrom.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childFrom);
            panelChildForm.Tag = childFrom;
            childFrom.BringToFront();
            childFrom.Show();
        }

        

        private void Anasayfa_Load(object sender, EventArgs e)
        {
            
            butonlar[0] = button2;
            butonlar[1] = button3;
            butonlar[2] = button4;
            butonlar[3] = button5;
            butonlar[4] = button6;
            butonlar[5] = button7;
            butonlar[6] = button8;
            butonlar[7] = button9;
            butonlar[8] = button10;
            butonlar[9] = button11;
            butonlar[10] = button12;
            butonlar[11] = button13;
            butonlar[12] = button14;
            butonlar[13] = button15;
            butonlar[14] = button16;
            butonlar[15] = button17;
            
            

        }

        public void butonSıfırla()
        {


            for (int i = 0; i < 16; i++)
            {
                butonlar[i].BackColor = Color.FromArgb(57, 62, 70);
                butonlar[i].ForeColor = Color.FromArgb(238, 238, 238);
            }
        }

        public void butonRenklendir(Button button)
        {
            button.BackColor = Color.FromArgb(0, 173, 181);
            button.ForeColor = Color.Black;
        }
    }
}
