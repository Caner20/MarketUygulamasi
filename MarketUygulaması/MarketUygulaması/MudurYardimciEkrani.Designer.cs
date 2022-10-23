namespace MarketUygulaması
{
    partial class MudurYardimciEkrani
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
            this.btncalisanlar = new System.Windows.Forms.Button();
            this.btnUrunler = new System.Windows.Forms.Button();
            this.btnIndirimYap = new System.Windows.Forms.Button();
            this.btnMarket = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btncalisanlar
            // 
            this.btncalisanlar.Location = new System.Drawing.Point(75, 51);
            this.btncalisanlar.Name = "btncalisanlar";
            this.btncalisanlar.Size = new System.Drawing.Size(110, 78);
            this.btncalisanlar.TabIndex = 0;
            this.btncalisanlar.Text = "Çalışanlar";
            this.btncalisanlar.UseVisualStyleBackColor = true;
            this.btncalisanlar.Click += new System.EventHandler(this.btncalisanlar_Click);
            // 
            // btnUrunler
            // 
            this.btnUrunler.Location = new System.Drawing.Point(229, 51);
            this.btnUrunler.Name = "btnUrunler";
            this.btnUrunler.Size = new System.Drawing.Size(110, 78);
            this.btnUrunler.TabIndex = 1;
            this.btnUrunler.Text = "Ürünler";
            this.btnUrunler.UseVisualStyleBackColor = true;
            this.btnUrunler.Click += new System.EventHandler(this.btnUrunler_Click);
            // 
            // btnIndirimYap
            // 
            this.btnIndirimYap.Location = new System.Drawing.Point(384, 51);
            this.btnIndirimYap.Name = "btnIndirimYap";
            this.btnIndirimYap.Size = new System.Drawing.Size(110, 78);
            this.btnIndirimYap.TabIndex = 2;
            this.btnIndirimYap.Text = "İndirim Yap";
            this.btnIndirimYap.UseVisualStyleBackColor = true;
            this.btnIndirimYap.Click += new System.EventHandler(this.btnIndirimYap_Click);
            // 
            // btnMarket
            // 
            this.btnMarket.Location = new System.Drawing.Point(549, 51);
            this.btnMarket.Name = "btnMarket";
            this.btnMarket.Size = new System.Drawing.Size(110, 78);
            this.btnMarket.TabIndex = 3;
            this.btnMarket.Text = "Market";
            this.btnMarket.UseVisualStyleBackColor = true;
            this.btnMarket.Click += new System.EventHandler(this.btnMarket_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(698, 12);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(75, 23);
            this.btnCikis.TabIndex = 4;
            this.btnCikis.Text = "Çıkış Yap";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // MudurYardimciEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(826, 203);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnMarket);
            this.Controls.Add(this.btnIndirimYap);
            this.Controls.Add(this.btnUrunler);
            this.Controls.Add(this.btncalisanlar);
            this.Name = "MudurYardimciEkrani";
            this.Text = "Müdür Yardımcısı Ekranı";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btncalisanlar;
        private System.Windows.Forms.Button btnUrunler;
        private System.Windows.Forms.Button btnIndirimYap;
        private System.Windows.Forms.Button btnMarket;
        private System.Windows.Forms.Button btnCikis;
    }
}