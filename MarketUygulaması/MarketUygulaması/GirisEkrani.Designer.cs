namespace MarketUygulaması
{
    partial class GirisEkrani
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
            this.lblparola = new System.Windows.Forms.Label();
            this.textBoxkullaniciAd = new System.Windows.Forms.TextBox();
            this.textBoxParola = new System.Windows.Forms.TextBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblkullaniciadi
            // 
            this.lblkullaniciadi.AutoSize = true;
            this.lblkullaniciadi.Location = new System.Drawing.Point(106, 64);
            this.lblkullaniciadi.Name = "lblkullaniciadi";
            this.lblkullaniciadi.Size = new System.Drawing.Size(67, 13);
            this.lblkullaniciadi.TabIndex = 0;
            this.lblkullaniciadi.Text = "Kullanıcı Adı:";
            // 
            // lblparola
            // 
            this.lblparola.AutoSize = true;
            this.lblparola.Location = new System.Drawing.Point(133, 111);
            this.lblparola.Name = "lblparola";
            this.lblparola.Size = new System.Drawing.Size(40, 13);
            this.lblparola.TabIndex = 1;
            this.lblparola.Text = "Parola:";
            // 
            // textBoxkullaniciAd
            // 
            this.textBoxkullaniciAd.Location = new System.Drawing.Point(198, 61);
            this.textBoxkullaniciAd.Name = "textBoxkullaniciAd";
            this.textBoxkullaniciAd.Size = new System.Drawing.Size(100, 20);
            this.textBoxkullaniciAd.TabIndex = 2;
            // 
            // textBoxParola
            // 
            this.textBoxParola.Location = new System.Drawing.Point(198, 108);
            this.textBoxParola.Name = "textBoxParola";
            this.textBoxParola.PasswordChar = '*';
            this.textBoxParola.Size = new System.Drawing.Size(100, 20);
            this.textBoxParola.TabIndex = 3;
            // 
            // btnGiris
            // 
            this.btnGiris.Location = new System.Drawing.Point(168, 158);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(75, 23);
            this.btnGiris.TabIndex = 4;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // GirisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(457, 266);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.textBoxParola);
            this.Controls.Add(this.textBoxkullaniciAd);
            this.Controls.Add(this.lblparola);
            this.Controls.Add(this.lblkullaniciadi);
            this.Name = "GirisEkrani";
            this.Text = "Giriş Ekranı";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblkullaniciadi;
        private System.Windows.Forms.Label lblparola;
        private System.Windows.Forms.TextBox textBoxkullaniciAd;
        private System.Windows.Forms.TextBox textBoxParola;
        private System.Windows.Forms.Button btnGiris;
    }
}

