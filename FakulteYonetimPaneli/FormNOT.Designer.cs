
namespace FakulteYonetimPaneli
{
    partial class FormNOT
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
            this.labelOgrNo = new System.Windows.Forms.Label();
            this.labelAd = new System.Windows.Forms.Label();
            this.labelTelNo = new System.Windows.Forms.Label();
            this.labelSoyad = new System.Windows.Forms.Label();
            this.textBoxOgrNo = new System.Windows.Forms.TextBox();
            this.textBoxAd = new System.Windows.Forms.TextBox();
            this.textBoxSoyad = new System.Windows.Forms.TextBox();
            this.textBoxTelNo = new System.Windows.Forms.TextBox();
            this.labelDers = new System.Windows.Forms.Label();
            this.comboBoxDers = new System.Windows.Forms.ComboBox();
            this.buttonAra = new System.Windows.Forms.Button();
            this.labelVize = new System.Windows.Forms.Label();
            this.labelFinal = new System.Windows.Forms.Label();
            this.textBoxVize = new System.Windows.Forms.TextBox();
            this.textBoxFinal = new System.Windows.Forms.TextBox();
            this.textBoxOrtalama = new System.Windows.Forms.TextBox();
            this.labelOrt = new System.Windows.Forms.Label();
            this.buttonKaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelOgrNo
            // 
            this.labelOgrNo.AutoSize = true;
            this.labelOgrNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.labelOgrNo.Location = new System.Drawing.Point(12, 57);
            this.labelOgrNo.Name = "labelOgrNo";
            this.labelOgrNo.Size = new System.Drawing.Size(85, 13);
            this.labelOgrNo.TabIndex = 5;
            this.labelOgrNo.Text = "Öğrenci Numası:";
            // 
            // labelAd
            // 
            this.labelAd.AutoSize = true;
            this.labelAd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.labelAd.Location = new System.Drawing.Point(12, 88);
            this.labelAd.Name = "labelAd";
            this.labelAd.Size = new System.Drawing.Size(79, 13);
            this.labelAd.TabIndex = 6;
            this.labelAd.Text = "Öğrencinin Adı:";
            // 
            // labelTelNo
            // 
            this.labelTelNo.AutoSize = true;
            this.labelTelNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.labelTelNo.Location = new System.Drawing.Point(12, 151);
            this.labelTelNo.Name = "labelTelNo";
            this.labelTelNo.Size = new System.Drawing.Size(93, 13);
            this.labelTelNo.TabIndex = 8;
            this.labelTelNo.Text = "Telefon Numarası:";
            // 
            // labelSoyad
            // 
            this.labelSoyad.AutoSize = true;
            this.labelSoyad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.labelSoyad.Location = new System.Drawing.Point(12, 120);
            this.labelSoyad.Name = "labelSoyad";
            this.labelSoyad.Size = new System.Drawing.Size(96, 13);
            this.labelSoyad.TabIndex = 7;
            this.labelSoyad.Text = "Öğrencinin Soyadı:";
            // 
            // textBoxOgrNo
            // 
            this.textBoxOgrNo.Location = new System.Drawing.Point(116, 54);
            this.textBoxOgrNo.MaxLength = 9;
            this.textBoxOgrNo.Name = "textBoxOgrNo";
            this.textBoxOgrNo.Size = new System.Drawing.Size(113, 20);
            this.textBoxOgrNo.TabIndex = 9;
            this.textBoxOgrNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxOgrNo_KeyPress);
            // 
            // textBoxAd
            // 
            this.textBoxAd.Location = new System.Drawing.Point(116, 85);
            this.textBoxAd.Name = "textBoxAd";
            this.textBoxAd.ReadOnly = true;
            this.textBoxAd.Size = new System.Drawing.Size(113, 20);
            this.textBoxAd.TabIndex = 9;
            // 
            // textBoxSoyad
            // 
            this.textBoxSoyad.Location = new System.Drawing.Point(116, 117);
            this.textBoxSoyad.Name = "textBoxSoyad";
            this.textBoxSoyad.ReadOnly = true;
            this.textBoxSoyad.Size = new System.Drawing.Size(113, 20);
            this.textBoxSoyad.TabIndex = 9;
            // 
            // textBoxTelNo
            // 
            this.textBoxTelNo.Location = new System.Drawing.Point(116, 148);
            this.textBoxTelNo.Name = "textBoxTelNo";
            this.textBoxTelNo.ReadOnly = true;
            this.textBoxTelNo.Size = new System.Drawing.Size(113, 20);
            this.textBoxTelNo.TabIndex = 9;
            // 
            // labelDers
            // 
            this.labelDers.AutoSize = true;
            this.labelDers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.labelDers.Location = new System.Drawing.Point(377, 57);
            this.labelDers.Name = "labelDers";
            this.labelDers.Size = new System.Drawing.Size(125, 13);
            this.labelDers.TabIndex = 10;
            this.labelDers.Text = "Öğrencinin Aldığı Dersler:";
            // 
            // comboBoxDers
            // 
            this.comboBoxDers.FormattingEnabled = true;
            this.comboBoxDers.Location = new System.Drawing.Point(508, 54);
            this.comboBoxDers.Name = "comboBoxDers";
            this.comboBoxDers.Size = new System.Drawing.Size(150, 21);
            this.comboBoxDers.TabIndex = 11;
            // 
            // buttonAra
            // 
            this.buttonAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.09346F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonAra.Location = new System.Drawing.Point(15, 181);
            this.buttonAra.Name = "buttonAra";
            this.buttonAra.Size = new System.Drawing.Size(214, 43);
            this.buttonAra.TabIndex = 12;
            this.buttonAra.Text = "Ara";
            this.buttonAra.UseVisualStyleBackColor = true;
            this.buttonAra.Click += new System.EventHandler(this.buttonAra_Click);
            // 
            // labelVize
            // 
            this.labelVize.AutoSize = true;
            this.labelVize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.labelVize.Location = new System.Drawing.Point(377, 92);
            this.labelVize.Name = "labelVize";
            this.labelVize.Size = new System.Drawing.Size(60, 13);
            this.labelVize.TabIndex = 13;
            this.labelVize.Text = "Vize Puanı:";
            // 
            // labelFinal
            // 
            this.labelFinal.AutoSize = true;
            this.labelFinal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.labelFinal.Location = new System.Drawing.Point(377, 120);
            this.labelFinal.Name = "labelFinal";
            this.labelFinal.Size = new System.Drawing.Size(62, 13);
            this.labelFinal.TabIndex = 14;
            this.labelFinal.Text = "Final Puanı:";
            // 
            // textBoxVize
            // 
            this.textBoxVize.Location = new System.Drawing.Point(508, 85);
            this.textBoxVize.MaxLength = 9;
            this.textBoxVize.Name = "textBoxVize";
            this.textBoxVize.Size = new System.Drawing.Size(150, 20);
            this.textBoxVize.TabIndex = 15;
            this.textBoxVize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVize_KeyPress);
            // 
            // textBoxFinal
            // 
            this.textBoxFinal.Location = new System.Drawing.Point(508, 117);
            this.textBoxFinal.MaxLength = 9;
            this.textBoxFinal.Name = "textBoxFinal";
            this.textBoxFinal.Size = new System.Drawing.Size(150, 20);
            this.textBoxFinal.TabIndex = 16;
            this.textBoxFinal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFinal_KeyPress);
            // 
            // textBoxOrtalama
            // 
            this.textBoxOrtalama.Location = new System.Drawing.Point(508, 148);
            this.textBoxOrtalama.MaxLength = 9;
            this.textBoxOrtalama.Name = "textBoxOrtalama";
            this.textBoxOrtalama.ReadOnly = true;
            this.textBoxOrtalama.Size = new System.Drawing.Size(150, 20);
            this.textBoxOrtalama.TabIndex = 18;
            // 
            // labelOrt
            // 
            this.labelOrt.AutoSize = true;
            this.labelOrt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.labelOrt.Location = new System.Drawing.Point(377, 151);
            this.labelOrt.Name = "labelOrt";
            this.labelOrt.Size = new System.Drawing.Size(52, 13);
            this.labelOrt.TabIndex = 17;
            this.labelOrt.Text = "Ortalama:";
            // 
            // buttonKaydet
            // 
            this.buttonKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.09346F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonKaydet.Location = new System.Drawing.Point(380, 181);
            this.buttonKaydet.Name = "buttonKaydet";
            this.buttonKaydet.Size = new System.Drawing.Size(278, 43);
            this.buttonKaydet.TabIndex = 19;
            this.buttonKaydet.Text = "Hesapla";
            this.buttonKaydet.UseVisualStyleBackColor = true;
            this.buttonKaydet.Click += new System.EventHandler(this.buttonKaydet_Click);
            // 
            // FormNOT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(876, 516);
            this.Controls.Add(this.buttonKaydet);
            this.Controls.Add(this.textBoxOrtalama);
            this.Controls.Add(this.labelOrt);
            this.Controls.Add(this.textBoxFinal);
            this.Controls.Add(this.textBoxVize);
            this.Controls.Add(this.labelFinal);
            this.Controls.Add(this.labelVize);
            this.Controls.Add(this.buttonAra);
            this.Controls.Add(this.comboBoxDers);
            this.Controls.Add(this.labelDers);
            this.Controls.Add(this.textBoxTelNo);
            this.Controls.Add(this.textBoxSoyad);
            this.Controls.Add(this.textBoxAd);
            this.Controls.Add(this.textBoxOgrNo);
            this.Controls.Add(this.labelTelNo);
            this.Controls.Add(this.labelSoyad);
            this.Controls.Add(this.labelAd);
            this.Controls.Add(this.labelOgrNo);
            this.Name = "FormNOT";
            this.Text = "FormNOT";
            this.Load += new System.EventHandler(this.FormNOT_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelOgrNo;
        private System.Windows.Forms.Label labelAd;
        private System.Windows.Forms.Label labelTelNo;
        private System.Windows.Forms.Label labelSoyad;
        private System.Windows.Forms.TextBox textBoxOgrNo;
        private System.Windows.Forms.TextBox textBoxAd;
        private System.Windows.Forms.TextBox textBoxSoyad;
        private System.Windows.Forms.TextBox textBoxTelNo;
        private System.Windows.Forms.Label labelDers;
        private System.Windows.Forms.ComboBox comboBoxDers;
        private System.Windows.Forms.Button buttonAra;
        private System.Windows.Forms.Label labelVize;
        private System.Windows.Forms.Label labelFinal;
        private System.Windows.Forms.TextBox textBoxVize;
        private System.Windows.Forms.TextBox textBoxFinal;
        private System.Windows.Forms.TextBox textBoxOrtalama;
        private System.Windows.Forms.Label labelOrt;
        private System.Windows.Forms.Button buttonKaydet;
    }
}