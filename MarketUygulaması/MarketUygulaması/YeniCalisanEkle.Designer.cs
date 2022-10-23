namespace MarketUygulaması
{
    partial class YeniCalisanEkle
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
            this.lblkullaniciadi = new System.Windows.Forms.Label();
            this.lblsifre = new System.Windows.Forms.Label();
            this.lblad = new System.Windows.Forms.Label();
            this.lblsoyad = new System.Windows.Forms.Label();
            this.lblmaas = new System.Windows.Forms.Label();
            this.textBoxkullaniciAdi = new System.Windows.Forms.TextBox();
            this.textBoxsifre = new System.Windows.Forms.TextBox();
            this.textBoxad = new System.Windows.Forms.TextBox();
            this.textBoxsoyad = new System.Windows.Forms.TextBox();
            this.textBoxmaas = new System.Windows.Forms.TextBox();
            this.btnekle = new System.Windows.Forms.Button();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.buttonsil = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblkullaniciadi
            // 
            this.lblkullaniciadi.AutoSize = true;
            this.lblkullaniciadi.Location = new System.Drawing.Point(46, 45);
            this.lblkullaniciadi.Name = "lblkullaniciadi";
            this.lblkullaniciadi.Size = new System.Drawing.Size(65, 13);
            this.lblkullaniciadi.TabIndex = 0;
            this.lblkullaniciadi.Text = "Kullanıcı Ad:";
            // 
            // lblsifre
            // 
            this.lblsifre.AutoSize = true;
            this.lblsifre.Location = new System.Drawing.Point(69, 77);
            this.lblsifre.Name = "lblsifre";
            this.lblsifre.Size = new System.Drawing.Size(40, 13);
            this.lblsifre.TabIndex = 1;
            this.lblsifre.Text = "Parola:";
            // 
            // lblad
            // 
            this.lblad.AutoSize = true;
            this.lblad.Location = new System.Drawing.Point(283, 45);
            this.lblad.Name = "lblad";
            this.lblad.Size = new System.Drawing.Size(23, 13);
            this.lblad.TabIndex = 2;
            this.lblad.Text = "Ad:";
            // 
            // lblsoyad
            // 
            this.lblsoyad.AutoSize = true;
            this.lblsoyad.Location = new System.Drawing.Point(266, 77);
            this.lblsoyad.Name = "lblsoyad";
            this.lblsoyad.Size = new System.Drawing.Size(40, 13);
            this.lblsoyad.TabIndex = 3;
            this.lblsoyad.Text = "Soyad:";
            // 
            // lblmaas
            // 
            this.lblmaas.AutoSize = true;
            this.lblmaas.Location = new System.Drawing.Point(438, 62);
            this.lblmaas.Name = "lblmaas";
            this.lblmaas.Size = new System.Drawing.Size(36, 13);
            this.lblmaas.TabIndex = 4;
            this.lblmaas.Text = "Maaş:";
            // 
            // textBoxkullaniciAdi
            // 
            this.textBoxkullaniciAdi.Location = new System.Drawing.Point(117, 42);
            this.textBoxkullaniciAdi.Name = "textBoxkullaniciAdi";
            this.textBoxkullaniciAdi.Size = new System.Drawing.Size(100, 20);
            this.textBoxkullaniciAdi.TabIndex = 5;
            // 
            // textBoxsifre
            // 
            this.textBoxsifre.Location = new System.Drawing.Point(117, 74);
            this.textBoxsifre.Name = "textBoxsifre";
            this.textBoxsifre.Size = new System.Drawing.Size(100, 20);
            this.textBoxsifre.TabIndex = 6;
            // 
            // textBoxad
            // 
            this.textBoxad.Location = new System.Drawing.Point(312, 42);
            this.textBoxad.Name = "textBoxad";
            this.textBoxad.Size = new System.Drawing.Size(100, 20);
            this.textBoxad.TabIndex = 7;
            // 
            // textBoxsoyad
            // 
            this.textBoxsoyad.Location = new System.Drawing.Point(312, 74);
            this.textBoxsoyad.Name = "textBoxsoyad";
            this.textBoxsoyad.Size = new System.Drawing.Size(100, 20);
            this.textBoxsoyad.TabIndex = 8;
            // 
            // textBoxmaas
            // 
            this.textBoxmaas.Location = new System.Drawing.Point(485, 59);
            this.textBoxmaas.Name = "textBoxmaas";
            this.textBoxmaas.Size = new System.Drawing.Size(100, 20);
            this.textBoxmaas.TabIndex = 9;
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(195, 145);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(111, 23);
            this.btnekle.TabIndex = 10;
            this.btnekle.Text = "Çalışan Ekle";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Location = new System.Drawing.Point(348, 145);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(111, 23);
            this.btnGüncelle.TabIndex = 11;
            this.btnGüncelle.Text = "Çalışan Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = true;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // buttonsil
            // 
            this.buttonsil.Location = new System.Drawing.Point(507, 145);
            this.buttonsil.Name = "buttonsil";
            this.buttonsil.Size = new System.Drawing.Size(111, 23);
            this.buttonsil.TabIndex = 12;
            this.buttonsil.Text = "Çalışan Sil";
            this.buttonsil.UseVisualStyleBackColor = true;
            this.buttonsil.Click += new System.EventHandler(this.buttonsil_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(86, 185);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(640, 150);
            this.dataGridView1.TabIndex = 13;
            // 
            // btnDon
            // 
            this.btnDon.Location = new System.Drawing.Point(693, 22);
            this.btnDon.Name = "btnDon";
            this.btnDon.Size = new System.Drawing.Size(75, 23);
            this.btnDon.TabIndex = 14;
            this.btnDon.Text = "Geri Dön";
            this.btnDon.UseVisualStyleBackColor = true;
            this.btnDon.Click += new System.EventHandler(this.btnDon_Click);
            // 
            // YeniCalisanEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDon);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonsil);
            this.Controls.Add(this.btnGüncelle);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.textBoxmaas);
            this.Controls.Add(this.textBoxsoyad);
            this.Controls.Add(this.textBoxad);
            this.Controls.Add(this.textBoxsifre);
            this.Controls.Add(this.textBoxkullaniciAdi);
            this.Controls.Add(this.lblmaas);
            this.Controls.Add(this.lblsoyad);
            this.Controls.Add(this.lblad);
            this.Controls.Add(this.lblsifre);
            this.Controls.Add(this.lblkullaniciadi);
            this.Name = "YeniCalisanEkle";
            this.Text = "Çalışan Ekle";
            this.Load += new System.EventHandler(this.YeniCalisanEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblkullaniciadi;
        private System.Windows.Forms.Label lblsifre;
        private System.Windows.Forms.Label lblad;
        private System.Windows.Forms.Label lblsoyad;
        private System.Windows.Forms.Label lblmaas;
        private System.Windows.Forms.TextBox textBoxkullaniciAdi;
        private System.Windows.Forms.TextBox textBoxsifre;
        private System.Windows.Forms.TextBox textBoxad;
        private System.Windows.Forms.TextBox textBoxsoyad;
        private System.Windows.Forms.TextBox textBoxmaas;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.Button buttonsil;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDon;
    }
}