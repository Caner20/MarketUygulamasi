namespace MarketUygulaması
{
    partial class UrunListele
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
            this.lblurunadi = new System.Windows.Forms.Label();
            this.lblmiktar = new System.Windows.Forms.Label();
            this.lblfiyat = new System.Windows.Forms.Label();
            this.textBoxurunadi = new System.Windows.Forms.TextBox();
            this.textBoxmiktar = new System.Windows.Forms.TextBox();
            this.textBoxurunFiyat = new System.Windows.Forms.TextBox();
            this.btnurunekle = new System.Windows.Forms.Button();
            this.btnurunsil = new System.Windows.Forms.Button();
            this.btnurunguncelle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblkategoriID = new System.Windows.Forms.Label();
            this.textBoxKategoriID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblurunadi
            // 
            this.lblurunadi.AutoSize = true;
            this.lblurunadi.Location = new System.Drawing.Point(96, 25);
            this.lblurunadi.Name = "lblurunadi";
            this.lblurunadi.Size = new System.Drawing.Size(49, 13);
            this.lblurunadi.TabIndex = 0;
            this.lblurunadi.Text = "Ürün Ad:";
            // 
            // lblmiktar
            // 
            this.lblmiktar.AutoSize = true;
            this.lblmiktar.Location = new System.Drawing.Point(104, 57);
            this.lblmiktar.Name = "lblmiktar";
            this.lblmiktar.Size = new System.Drawing.Size(39, 13);
            this.lblmiktar.TabIndex = 1;
            this.lblmiktar.Text = "Miktar:";
            // 
            // lblfiyat
            // 
            this.lblfiyat.AutoSize = true;
            this.lblfiyat.Location = new System.Drawing.Point(87, 92);
            this.lblfiyat.Name = "lblfiyat";
            this.lblfiyat.Size = new System.Drawing.Size(58, 13);
            this.lblfiyat.TabIndex = 2;
            this.lblfiyat.Text = "Ürün Fiyat:";
            // 
            // textBoxurunadi
            // 
            this.textBoxurunadi.Location = new System.Drawing.Point(151, 22);
            this.textBoxurunadi.Name = "textBoxurunadi";
            this.textBoxurunadi.Size = new System.Drawing.Size(100, 20);
            this.textBoxurunadi.TabIndex = 3;
            // 
            // textBoxmiktar
            // 
            this.textBoxmiktar.Location = new System.Drawing.Point(151, 57);
            this.textBoxmiktar.Name = "textBoxmiktar";
            this.textBoxmiktar.Size = new System.Drawing.Size(100, 20);
            this.textBoxmiktar.TabIndex = 4;
            // 
            // textBoxurunFiyat
            // 
            this.textBoxurunFiyat.Location = new System.Drawing.Point(151, 89);
            this.textBoxurunFiyat.Name = "textBoxurunFiyat";
            this.textBoxurunFiyat.Size = new System.Drawing.Size(100, 20);
            this.textBoxurunFiyat.TabIndex = 5;
            // 
            // btnurunekle
            // 
            this.btnurunekle.Location = new System.Drawing.Point(337, 25);
            this.btnurunekle.Name = "btnurunekle";
            this.btnurunekle.Size = new System.Drawing.Size(108, 23);
            this.btnurunekle.TabIndex = 6;
            this.btnurunekle.Text = "Ürün Ekle";
            this.btnurunekle.UseVisualStyleBackColor = true;
            this.btnurunekle.Click += new System.EventHandler(this.btnurunekle_Click);
            // 
            // btnurunsil
            // 
            this.btnurunsil.Location = new System.Drawing.Point(337, 71);
            this.btnurunsil.Name = "btnurunsil";
            this.btnurunsil.Size = new System.Drawing.Size(108, 23);
            this.btnurunsil.TabIndex = 7;
            this.btnurunsil.Text = "Ürün Sil";
            this.btnurunsil.UseVisualStyleBackColor = true;
            this.btnurunsil.Click += new System.EventHandler(this.btnurunsil_Click);
            // 
            // btnurunguncelle
            // 
            this.btnurunguncelle.Location = new System.Drawing.Point(337, 113);
            this.btnurunguncelle.Name = "btnurunguncelle";
            this.btnurunguncelle.Size = new System.Drawing.Size(108, 23);
            this.btnurunguncelle.TabIndex = 8;
            this.btnurunguncelle.Text = "Ürün Güncelle";
            this.btnurunguncelle.UseVisualStyleBackColor = true;
            this.btnurunguncelle.Click += new System.EventHandler(this.btnurunguncelle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(46, 169);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(743, 181);
            this.dataGridView1.TabIndex = 9;
            // 
            // lblkategoriID
            // 
            this.lblkategoriID.AutoSize = true;
            this.lblkategoriID.Location = new System.Drawing.Point(80, 123);
            this.lblkategoriID.Name = "lblkategoriID";
            this.lblkategoriID.Size = new System.Drawing.Size(63, 13);
            this.lblkategoriID.TabIndex = 10;
            this.lblkategoriID.Text = "Kategori ID:";
            // 
            // textBoxKategoriID
            // 
            this.textBoxKategoriID.Location = new System.Drawing.Point(151, 120);
            this.textBoxKategoriID.Name = "textBoxKategoriID";
            this.textBoxKategoriID.Size = new System.Drawing.Size(100, 20);
            this.textBoxKategoriID.TabIndex = 11;
            // 
            // UrunListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(846, 417);
            this.Controls.Add(this.textBoxKategoriID);
            this.Controls.Add(this.lblkategoriID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnurunguncelle);
            this.Controls.Add(this.btnurunsil);
            this.Controls.Add(this.btnurunekle);
            this.Controls.Add(this.textBoxurunFiyat);
            this.Controls.Add(this.textBoxmiktar);
            this.Controls.Add(this.textBoxurunadi);
            this.Controls.Add(this.lblfiyat);
            this.Controls.Add(this.lblmiktar);
            this.Controls.Add(this.lblurunadi);
            this.Name = "UrunListele";
            this.Text = "Ürün Listesi";
            this.Load += new System.EventHandler(this.UrunListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblurunadi;
        private System.Windows.Forms.Label lblmiktar;
        private System.Windows.Forms.Label lblfiyat;
        private System.Windows.Forms.TextBox textBoxurunadi;
        private System.Windows.Forms.TextBox textBoxmiktar;
        private System.Windows.Forms.TextBox textBoxurunFiyat;
        private System.Windows.Forms.Button btnurunekle;
        private System.Windows.Forms.Button btnurunsil;
        private System.Windows.Forms.Button btnurunguncelle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblkategoriID;
        private System.Windows.Forms.TextBox textBoxKategoriID;
    }
}