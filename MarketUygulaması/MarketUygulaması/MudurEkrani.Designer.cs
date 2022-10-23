namespace MarketUygulaması
{
    partial class MudurEkrani
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
            this.btnyenicalisanekle = new System.Windows.Forms.Button();
            this.btnurunekle = new System.Windows.Forms.Button();
            this.btncalisanMaasGüncelle = new System.Windows.Forms.Button();
            this.btnindirimYap = new System.Windows.Forms.Button();
            this.btnMarket = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnyenicalisanekle
            // 
            this.btnyenicalisanekle.BackColor = System.Drawing.Color.Transparent;
            this.btnyenicalisanekle.ForeColor = System.Drawing.Color.Black;
            this.btnyenicalisanekle.Location = new System.Drawing.Point(49, 78);
            this.btnyenicalisanekle.Name = "btnyenicalisanekle";
            this.btnyenicalisanekle.Size = new System.Drawing.Size(109, 76);
            this.btnyenicalisanekle.TabIndex = 0;
            this.btnyenicalisanekle.Text = "Yeni Çalışan Ekle";
            this.btnyenicalisanekle.UseVisualStyleBackColor = false;
            this.btnyenicalisanekle.Click += new System.EventHandler(this.btnyenicalisanekle_Click);
            // 
            // btnurunekle
            // 
            this.btnurunekle.Location = new System.Drawing.Point(359, 78);
            this.btnurunekle.Name = "btnurunekle";
            this.btnurunekle.Size = new System.Drawing.Size(109, 76);
            this.btnurunekle.TabIndex = 1;
            this.btnurunekle.Text = "Ürünler";
            this.btnurunekle.UseVisualStyleBackColor = true;
            this.btnurunekle.Click += new System.EventHandler(this.btnurunekle_Click);
            // 
            // btncalisanMaasGüncelle
            // 
            this.btncalisanMaasGüncelle.Location = new System.Drawing.Point(204, 78);
            this.btncalisanMaasGüncelle.Name = "btncalisanMaasGüncelle";
            this.btncalisanMaasGüncelle.Size = new System.Drawing.Size(109, 76);
            this.btncalisanMaasGüncelle.TabIndex = 3;
            this.btncalisanMaasGüncelle.Text = "Çalışan Maaş Güncelle";
            this.btncalisanMaasGüncelle.UseVisualStyleBackColor = true;
            this.btncalisanMaasGüncelle.Click += new System.EventHandler(this.btncalisanMaasGüncelle_Click);
            // 
            // btnindirimYap
            // 
            this.btnindirimYap.Location = new System.Drawing.Point(514, 78);
            this.btnindirimYap.Name = "btnindirimYap";
            this.btnindirimYap.Size = new System.Drawing.Size(109, 76);
            this.btnindirimYap.TabIndex = 4;
            this.btnindirimYap.Text = "İndirim Yap";
            this.btnindirimYap.UseVisualStyleBackColor = true;
            this.btnindirimYap.Click += new System.EventHandler(this.btnindirimYap_Click);
            // 
            // btnMarket
            // 
            this.btnMarket.Location = new System.Drawing.Point(668, 78);
            this.btnMarket.Name = "btnMarket";
            this.btnMarket.Size = new System.Drawing.Size(109, 76);
            this.btnMarket.TabIndex = 5;
            this.btnMarket.Text = "Market";
            this.btnMarket.UseVisualStyleBackColor = true;
            this.btnMarket.Click += new System.EventHandler(this.btnMarket_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(777, 22);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(75, 23);
            this.btnCikis.TabIndex = 6;
            this.btnCikis.Text = "Çıkış Yap";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // MudurEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(875, 257);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnMarket);
            this.Controls.Add(this.btnindirimYap);
            this.Controls.Add(this.btncalisanMaasGüncelle);
            this.Controls.Add(this.btnurunekle);
            this.Controls.Add(this.btnyenicalisanekle);
            this.Name = "MudurEkrani";
            this.Text = "Müdür Ekranı";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnyenicalisanekle;
        private System.Windows.Forms.Button btnurunekle;
        private System.Windows.Forms.Button btncalisanMaasGüncelle;
        private System.Windows.Forms.Button btnindirimYap;
        private System.Windows.Forms.Button btnMarket;
        private System.Windows.Forms.Button btnCikis;
    }
}