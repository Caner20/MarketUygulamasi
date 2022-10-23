namespace MarketUygulaması
{
    partial class MYRDIndirim
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
            this.lblUrunAdi = new System.Windows.Forms.Label();
            this.textBoxUrunAdi = new System.Windows.Forms.TextBox();
            this.textBoxYüzde = new System.Windows.Forms.TextBox();
            this.lblyüzde = new System.Windows.Forms.Label();
            this.btnIndirimYap = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(54, 166);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(745, 187);
            this.dataGridView1.TabIndex = 0;
            // 
            // lblUrunAdi
            // 
            this.lblUrunAdi.AutoSize = true;
            this.lblUrunAdi.Location = new System.Drawing.Point(152, 33);
            this.lblUrunAdi.Name = "lblUrunAdi";
            this.lblUrunAdi.Size = new System.Drawing.Size(49, 13);
            this.lblUrunAdi.TabIndex = 1;
            this.lblUrunAdi.Text = "Ürün Ad:";
            // 
            // textBoxUrunAdi
            // 
            this.textBoxUrunAdi.Location = new System.Drawing.Point(234, 30);
            this.textBoxUrunAdi.Name = "textBoxUrunAdi";
            this.textBoxUrunAdi.Size = new System.Drawing.Size(100, 20);
            this.textBoxUrunAdi.TabIndex = 3;
            // 
            // textBoxYüzde
            // 
            this.textBoxYüzde.Location = new System.Drawing.Point(234, 60);
            this.textBoxYüzde.Name = "textBoxYüzde";
            this.textBoxYüzde.Size = new System.Drawing.Size(100, 20);
            this.textBoxYüzde.TabIndex = 4;
            // 
            // lblyüzde
            // 
            this.lblyüzde.AutoSize = true;
            this.lblyüzde.Location = new System.Drawing.Point(123, 63);
            this.lblyüzde.Name = "lblyüzde";
            this.lblyüzde.Size = new System.Drawing.Size(80, 13);
            this.lblyüzde.TabIndex = 5;
            this.lblyüzde.Text = "İndirim Yüzdesi:";
            // 
            // btnIndirimYap
            // 
            this.btnIndirimYap.Location = new System.Drawing.Point(234, 95);
            this.btnIndirimYap.Name = "btnIndirimYap";
            this.btnIndirimYap.Size = new System.Drawing.Size(100, 23);
            this.btnIndirimYap.TabIndex = 6;
            this.btnIndirimYap.Text = "İndirim Yap";
            this.btnIndirimYap.UseVisualStyleBackColor = true;
            this.btnIndirimYap.Click += new System.EventHandler(this.btnIndirimYap_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(723, 22);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(75, 23);
            this.btnGeri.TabIndex = 7;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // MYRDIndirim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(893, 374);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnIndirimYap);
            this.Controls.Add(this.lblyüzde);
            this.Controls.Add(this.textBoxYüzde);
            this.Controls.Add(this.textBoxUrunAdi);
            this.Controls.Add(this.lblUrunAdi);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MYRDIndirim";
            this.Text = "Fiyat İndirim";
            this.Load += new System.EventHandler(this.MYRDIndirim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblUrunAdi;
        private System.Windows.Forms.TextBox textBoxUrunAdi;
        private System.Windows.Forms.TextBox textBoxYüzde;
        private System.Windows.Forms.Label lblyüzde;
        private System.Windows.Forms.Button btnIndirimYap;
        private System.Windows.Forms.Button btnGeri;
    }
}