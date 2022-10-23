namespace MarketUygulaması
{
    partial class CalisanEkrani
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
            this.btnurunler = new System.Windows.Forms.Button();
            this.btnMarket = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnurunler
            // 
            this.btnurunler.Location = new System.Drawing.Point(82, 54);
            this.btnurunler.Name = "btnurunler";
            this.btnurunler.Size = new System.Drawing.Size(118, 76);
            this.btnurunler.TabIndex = 0;
            this.btnurunler.Text = "Ürünler";
            this.btnurunler.UseVisualStyleBackColor = true;
            this.btnurunler.Click += new System.EventHandler(this.btnurunler_Click);
            // 
            // btnMarket
            // 
            this.btnMarket.Location = new System.Drawing.Point(253, 54);
            this.btnMarket.Name = "btnMarket";
            this.btnMarket.Size = new System.Drawing.Size(118, 76);
            this.btnMarket.TabIndex = 1;
            this.btnMarket.Text = "Market";
            this.btnMarket.UseVisualStyleBackColor = true;
            this.btnMarket.Click += new System.EventHandler(this.btnMarket_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(412, 26);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(75, 23);
            this.btnCikis.TabIndex = 2;
            this.btnCikis.Text = "Çıkış Yap";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // CalisanEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(538, 181);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnMarket);
            this.Controls.Add(this.btnurunler);
            this.Name = "CalisanEkrani";
            this.Text = "Çalışan";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnurunler;
        private System.Windows.Forms.Button btnMarket;
        private System.Windows.Forms.Button btnCikis;
    }
}