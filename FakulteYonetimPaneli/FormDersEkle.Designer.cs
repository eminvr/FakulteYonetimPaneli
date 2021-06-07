
namespace FakulteYonetimPaneli
{
    partial class FormDersEkle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxKredi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxOgretimUyeleri = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxKodu = new System.Windows.Forms.TextBox();
            this.btnOgrenciyiEkle = new System.Windows.Forms.Button();
            this.textBoxAdi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxVerildigiBolum = new System.Windows.Forms.ComboBox();
            this.textBoxVerildigiSinif = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.11215F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.label10.Location = new System.Drawing.Point(12, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 24);
            this.label10.TabIndex = 44;
            this.label10.Text = "Ders Ekle";
            // 
            // textBoxKredi
            // 
            this.textBoxKredi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.textBoxKredi.Location = new System.Drawing.Point(149, 318);
            this.textBoxKredi.MaxLength = 9;
            this.textBoxKredi.Name = "textBoxKredi";
            this.textBoxKredi.Size = new System.Drawing.Size(150, 20);
            this.textBoxKredi.TabIndex = 42;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label9.Location = new System.Drawing.Point(13, 321);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 41;
            this.label9.Text = "Dersin Kredisi*:";
            // 
            // comboBoxOgretimUyeleri
            // 
            this.comboBoxOgretimUyeleri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.comboBoxOgretimUyeleri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOgretimUyeleri.FormattingEnabled = true;
            this.comboBoxOgretimUyeleri.Location = new System.Drawing.Point(150, 269);
            this.comboBoxOgretimUyeleri.MaxDropDownItems = 2;
            this.comboBoxOgretimUyeleri.Name = "comboBoxOgretimUyeleri";
            this.comboBoxOgretimUyeleri.Size = new System.Drawing.Size(150, 21);
            this.comboBoxOgretimUyeleri.TabIndex = 30;
            this.comboBoxOgretimUyeleri.SelectedIndexChanged += new System.EventHandler(this.comboBoxOgretimUyeleri_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label6.Location = new System.Drawing.Point(13, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "Ders Kodu:";
            // 
            // textBoxKodu
            // 
            this.textBoxKodu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.textBoxKodu.Location = new System.Drawing.Point(149, 220);
            this.textBoxKodu.MaxLength = 4;
            this.textBoxKodu.Name = "textBoxKodu";
            this.textBoxKodu.ReadOnly = true;
            this.textBoxKodu.Size = new System.Drawing.Size(150, 20);
            this.textBoxKodu.TabIndex = 26;
            // 
            // btnOgrenciyiEkle
            // 
            this.btnOgrenciyiEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnOgrenciyiEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOgrenciyiEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.09346F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOgrenciyiEkle.Location = new System.Drawing.Point(16, 364);
            this.btnOgrenciyiEkle.Name = "btnOgrenciyiEkle";
            this.btnOgrenciyiEkle.Size = new System.Drawing.Size(283, 58);
            this.btnOgrenciyiEkle.TabIndex = 36;
            this.btnOgrenciyiEkle.Text = "Kaydet";
            this.btnOgrenciyiEkle.UseVisualStyleBackColor = false;
            this.btnOgrenciyiEkle.Click += new System.EventHandler(this.btnOgrenciyiEkle_Click);
            // 
            // textBoxAdi
            // 
            this.textBoxAdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.textBoxAdi.Location = new System.Drawing.Point(149, 82);
            this.textBoxAdi.MaxLength = 50;
            this.textBoxAdi.Name = "textBoxAdi";
            this.textBoxAdi.Size = new System.Drawing.Size(150, 20);
            this.textBoxAdi.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label5.Location = new System.Drawing.Point(13, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Dersin Verildiği Sınıf*:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label3.Location = new System.Drawing.Point(13, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Dersin Verildiği Bölüm*:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label2.Location = new System.Drawing.Point(13, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Dersi Veren Öğretim Üyesi*:\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label1.Location = new System.Drawing.Point(13, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Ders Adı*:";
            // 
            // comboBoxVerildigiBolum
            // 
            this.comboBoxVerildigiBolum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.comboBoxVerildigiBolum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVerildigiBolum.FormattingEnabled = true;
            this.comboBoxVerildigiBolum.Location = new System.Drawing.Point(149, 127);
            this.comboBoxVerildigiBolum.MaxDropDownItems = 2;
            this.comboBoxVerildigiBolum.Name = "comboBoxVerildigiBolum";
            this.comboBoxVerildigiBolum.Size = new System.Drawing.Size(150, 21);
            this.comboBoxVerildigiBolum.TabIndex = 45;
            this.comboBoxVerildigiBolum.SelectedIndexChanged += new System.EventHandler(this.comboBoxVerildigiBolum_SelectedIndexChanged);
            // 
            // textBoxVerildigiSinif
            // 
            this.textBoxVerildigiSinif.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.textBoxVerildigiSinif.Location = new System.Drawing.Point(149, 174);
            this.textBoxVerildigiSinif.MaxLength = 2;
            this.textBoxVerildigiSinif.Name = "textBoxVerildigiSinif";
            this.textBoxVerildigiSinif.Size = new System.Drawing.Size(150, 20);
            this.textBoxVerildigiSinif.TabIndex = 46;
            this.textBoxVerildigiSinif.TextChanged += new System.EventHandler(this.textBoxVerildigiSinif_TextChanged);
            this.textBoxVerildigiSinif.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVerildigiSinif_KeyPress);
            // 
            // FormDersEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(876, 516);
            this.Controls.Add(this.textBoxVerildigiSinif);
            this.Controls.Add(this.comboBoxVerildigiBolum);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxKredi);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBoxOgretimUyeleri);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxKodu);
            this.Controls.Add(this.btnOgrenciyiEkle);
            this.Controls.Add(this.textBoxAdi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormDersEkle";
            this.Text = "FormDersEkle";
            this.Load += new System.EventHandler(this.FormDersEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxKredi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxOgretimUyeleri;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxKodu;
        private System.Windows.Forms.Button btnOgrenciyiEkle;
        private System.Windows.Forms.TextBox textBoxAdi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxVerildigiBolum;
        private System.Windows.Forms.TextBox textBoxVerildigiSinif;
    }
}