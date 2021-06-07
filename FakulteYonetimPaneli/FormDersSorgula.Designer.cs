
namespace FakulteYonetimPaneli
{
    partial class FormDersSorgula
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
            this.textBoxDersiVerenOgretimUyesi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxDersSinifi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDersKodu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDersAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxDersiVerenOgretimUyesi
            // 
            this.textBoxDersiVerenOgretimUyesi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.textBoxDersiVerenOgretimUyesi.Location = new System.Drawing.Point(764, 55);
            this.textBoxDersiVerenOgretimUyesi.MaxLength = 11;
            this.textBoxDersiVerenOgretimUyesi.Name = "textBoxDersiVerenOgretimUyesi";
            this.textBoxDersiVerenOgretimUyesi.Size = new System.Drawing.Size(100, 20);
            this.textBoxDersiVerenOgretimUyesi.TabIndex = 13;
            this.textBoxDersiVerenOgretimUyesi.TextChanged += new System.EventHandler(this.textBoxDersiVerenOgretimUyesi_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label5.Location = new System.Drawing.Point(625, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Dersi Veren Öğretim Üyesi:";
            // 
            // textBoxDersSinifi
            // 
            this.textBoxDersSinifi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.textBoxDersSinifi.Location = new System.Drawing.Point(485, 55);
            this.textBoxDersSinifi.MaxLength = 11;
            this.textBoxDersSinifi.Name = "textBoxDersSinifi";
            this.textBoxDersSinifi.Size = new System.Drawing.Size(100, 20);
            this.textBoxDersSinifi.TabIndex = 14;
            this.textBoxDersSinifi.TextChanged += new System.EventHandler(this.textBoxDersSinifi_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label4.Location = new System.Drawing.Point(422, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Ders Sınıfı:";
            // 
            // textBoxDersKodu
            // 
            this.textBoxDersKodu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.textBoxDersKodu.Location = new System.Drawing.Point(278, 55);
            this.textBoxDersKodu.MaxLength = 30;
            this.textBoxDersKodu.Name = "textBoxDersKodu";
            this.textBoxDersKodu.Size = new System.Drawing.Size(100, 20);
            this.textBoxDersKodu.TabIndex = 15;
            this.textBoxDersKodu.TextChanged += new System.EventHandler(this.textBoxDersKodu_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label3.Location = new System.Drawing.Point(212, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Ders Kodu:";
            // 
            // textBoxDersAdi
            // 
            this.textBoxDersAdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.textBoxDersAdi.Location = new System.Drawing.Point(68, 55);
            this.textBoxDersAdi.MaxLength = 50;
            this.textBoxDersAdi.Name = "textBoxDersAdi";
            this.textBoxDersAdi.Size = new System.Drawing.Size(100, 20);
            this.textBoxDersAdi.TabIndex = 9;
            this.textBoxDersAdi.TextChanged += new System.EventHandler(this.textBoxDersAdi_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ders Adı:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 46;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(852, 397);
            this.dataGridView1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.11215F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ders Sorgula";
            // 
            // FormDersSorgula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(876, 516);
            this.Controls.Add(this.textBoxDersiVerenOgretimUyesi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxDersSinifi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxDersKodu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxDersAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "FormDersSorgula";
            this.Text = "FormDersSorgula";
            this.Load += new System.EventHandler(this.FormDersSorgula_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDersiVerenOgretimUyesi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxDersSinifi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxDersKodu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDersAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
    }
}