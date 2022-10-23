namespace MarketUygulaması
{
    partial class Market
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnUrunSat = new System.Windows.Forms.Button();
            this.lblUrunAd = new System.Windows.Forms.Label();
            this.textBoxUrunAd = new System.Windows.Forms.TextBox();
            this.lblMiktar = new System.Windows.Forms.Label();
            this.textBoxUrunMiktar = new System.Windows.Forms.TextBox();
            this.dataGridViewSepet = new System.Windows.Forms.DataGridView();
            this.btnSepetFiyatSıfırla = new System.Windows.Forms.Button();
            this.lblToplamSepetFiyat = new System.Windows.Forms.Label();
            this.btnToplamSepetFiyat = new System.Windows.Forms.Button();
            this.lblIndırımSepetFiyat = new System.Windows.Forms.Label();
            this.textBoxtst = new System.Windows.Forms.TextBox();
            this.textBoxiust = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSepet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(94, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(754, 143);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnUrunSat
            // 
            this.btnUrunSat.Location = new System.Drawing.Point(263, 178);
            this.btnUrunSat.Name = "btnUrunSat";
            this.btnUrunSat.Size = new System.Drawing.Size(111, 23);
            this.btnUrunSat.TabIndex = 1;
            this.btnUrunSat.Text = "Ürün Sat";
            this.btnUrunSat.UseVisualStyleBackColor = true;
            this.btnUrunSat.Click += new System.EventHandler(this.btnUrunSat_Click);
            // 
            // lblUrunAd
            // 
            this.lblUrunAd.AutoSize = true;
            this.lblUrunAd.Location = new System.Drawing.Point(73, 183);
            this.lblUrunAd.Name = "lblUrunAd";
            this.lblUrunAd.Size = new System.Drawing.Size(49, 13);
            this.lblUrunAd.TabIndex = 2;
            this.lblUrunAd.Text = "Ürün Ad:";
            // 
            // textBoxUrunAd
            // 
            this.textBoxUrunAd.Location = new System.Drawing.Point(142, 180);
            this.textBoxUrunAd.Name = "textBoxUrunAd";
            this.textBoxUrunAd.Size = new System.Drawing.Size(100, 20);
            this.textBoxUrunAd.TabIndex = 3;
            // 
            // lblMiktar
            // 
            this.lblMiktar.AutoSize = true;
            this.lblMiktar.Location = new System.Drawing.Point(57, 212);
            this.lblMiktar.Name = "lblMiktar";
            this.lblMiktar.Size = new System.Drawing.Size(65, 13);
            this.lblMiktar.TabIndex = 4;
            this.lblMiktar.Text = "Ürün Miktar:";
            // 
            // textBoxUrunMiktar
            // 
            this.textBoxUrunMiktar.Location = new System.Drawing.Point(142, 212);
            this.textBoxUrunMiktar.Name = "textBoxUrunMiktar";
            this.textBoxUrunMiktar.Size = new System.Drawing.Size(100, 20);
            this.textBoxUrunMiktar.TabIndex = 5;
            // 
            // dataGridViewSepet
            // 
            this.dataGridViewSepet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSepet.Location = new System.Drawing.Point(94, 239);
            this.dataGridViewSepet.Name = "dataGridViewSepet";
            this.dataGridViewSepet.Size = new System.Drawing.Size(754, 125);
            this.dataGridViewSepet.TabIndex = 8;
            // 
            // btnSepetFiyatSıfırla
            // 
            this.btnSepetFiyatSıfırla.Location = new System.Drawing.Point(263, 210);
            this.btnSepetFiyatSıfırla.Name = "btnSepetFiyatSıfırla";
            this.btnSepetFiyatSıfırla.Size = new System.Drawing.Size(111, 23);
            this.btnSepetFiyatSıfırla.TabIndex = 9;
            this.btnSepetFiyatSıfırla.Text = "Sepet Fiyat Sıfırla";
            this.btnSepetFiyatSıfırla.UseVisualStyleBackColor = true;
            this.btnSepetFiyatSıfırla.Click += new System.EventHandler(this.btnSepetFiyatSıfırla_Click);
            // 
            // lblToplamSepetFiyat
            // 
            this.lblToplamSepetFiyat.AutoSize = true;
            this.lblToplamSepetFiyat.Location = new System.Drawing.Point(647, 184);
            this.lblToplamSepetFiyat.Name = "lblToplamSepetFiyat";
            this.lblToplamSepetFiyat.Size = new System.Drawing.Size(106, 13);
            this.lblToplamSepetFiyat.TabIndex = 10;
            this.lblToplamSepetFiyat.Text = "Toplam Sepet Tutarı:";
            // 
            // btnToplamSepetFiyat
            // 
            this.btnToplamSepetFiyat.Location = new System.Drawing.Point(455, 193);
            this.btnToplamSepetFiyat.Name = "btnToplamSepetFiyat";
            this.btnToplamSepetFiyat.Size = new System.Drawing.Size(134, 23);
            this.btnToplamSepetFiyat.TabIndex = 11;
            this.btnToplamSepetFiyat.Text = "Toplam Sepet Fiyat";
            this.btnToplamSepetFiyat.UseVisualStyleBackColor = true;
            this.btnToplamSepetFiyat.Click += new System.EventHandler(this.btnToplamSepetFiyat_Click);
            // 
            // lblIndırımSepetFiyat
            // 
            this.lblIndırımSepetFiyat.AutoSize = true;
            this.lblIndırımSepetFiyat.Location = new System.Drawing.Point(595, 212);
            this.lblIndırımSepetFiyat.Name = "lblIndırımSepetFiyat";
            this.lblIndırımSepetFiyat.Size = new System.Drawing.Size(158, 13);
            this.lblIndırımSepetFiyat.TabIndex = 12;
            this.lblIndırımSepetFiyat.Text = "İndirim Uygulanmış Sepet Tutarı:";
            // 
            // textBoxtst
            // 
            this.textBoxtst.Location = new System.Drawing.Point(760, 180);
            this.textBoxtst.Name = "textBoxtst";
            this.textBoxtst.Size = new System.Drawing.Size(100, 20);
            this.textBoxtst.TabIndex = 13;
            // 
            // textBoxiust
            // 
            this.textBoxiust.Location = new System.Drawing.Point(760, 209);
            this.textBoxiust.Name = "textBoxiust";
            this.textBoxiust.Size = new System.Drawing.Size(148, 20);
            this.textBoxiust.TabIndex = 14;
            // 
            // Market
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(1047, 396);
            this.Controls.Add(this.textBoxiust);
            this.Controls.Add(this.textBoxtst);
            this.Controls.Add(this.lblIndırımSepetFiyat);
            this.Controls.Add(this.btnToplamSepetFiyat);
            this.Controls.Add(this.lblToplamSepetFiyat);
            this.Controls.Add(this.btnSepetFiyatSıfırla);
            this.Controls.Add(this.dataGridViewSepet);
            this.Controls.Add(this.textBoxUrunMiktar);
            this.Controls.Add(this.lblMiktar);
            this.Controls.Add(this.textBoxUrunAd);
            this.Controls.Add(this.lblUrunAd);
            this.Controls.Add(this.btnUrunSat);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Market";
            this.Text = "Market";
            this.Load += new System.EventHandler(this.Market_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSepet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnUrunSat;
        private System.Windows.Forms.Label lblUrunAd;
        private System.Windows.Forms.TextBox textBoxUrunAd;
        private System.Windows.Forms.Label lblMiktar;
        private System.Windows.Forms.TextBox textBoxUrunMiktar;
        private System.Windows.Forms.DataGridView dataGridViewSepet;
        private System.Windows.Forms.Button btnSepetFiyatSıfırla;
        private System.Windows.Forms.Label lblToplamSepetFiyat;
        private System.Windows.Forms.Button btnToplamSepetFiyat;
        private System.Windows.Forms.Label lblIndırımSepetFiyat;
        private System.Windows.Forms.TextBox textBoxtst;
        private System.Windows.Forms.TextBox textBoxiust;
    }
}