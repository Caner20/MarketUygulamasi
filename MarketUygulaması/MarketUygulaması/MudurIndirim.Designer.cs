namespace MarketUygulaması
{
    partial class MudurIndirim
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxYuzde = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxUrunAdi = new System.Windows.Forms.TextBox();
            this.btnindirim = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(74, 144);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(739, 213);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "İndirim Yüzdesi:";
            // 
            // textBoxYuzde
            // 
            this.textBoxYuzde.Location = new System.Drawing.Point(240, 57);
            this.textBoxYuzde.Name = "textBoxYuzde";
            this.textBoxYuzde.Size = new System.Drawing.Size(100, 20);
            this.textBoxYuzde.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ürün Ad:";
            // 
            // textBoxUrunAdi
            // 
            this.textBoxUrunAdi.Location = new System.Drawing.Point(240, 28);
            this.textBoxUrunAdi.Name = "textBoxUrunAdi";
            this.textBoxUrunAdi.Size = new System.Drawing.Size(100, 20);
            this.textBoxUrunAdi.TabIndex = 4;
            // 
            // btnindirim
            // 
            this.btnindirim.Location = new System.Drawing.Point(240, 93);
            this.btnindirim.Name = "btnindirim";
            this.btnindirim.Size = new System.Drawing.Size(100, 23);
            this.btnindirim.TabIndex = 5;
            this.btnindirim.Text = "İndirim Yap";
            this.btnindirim.UseVisualStyleBackColor = true;
            this.btnindirim.Click += new System.EventHandler(this.btnindirim_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(826, 31);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(75, 23);
            this.btnGeri.TabIndex = 6;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // MudurIndirim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(938, 381);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnindirim);
            this.Controls.Add(this.textBoxUrunAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxYuzde);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MudurIndirim";
            this.Text = "Fiyat İndirim";
            this.Load += new System.EventHandler(this.FiyatIndirim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxYuzde;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxUrunAdi;
        private System.Windows.Forms.Button btnindirim;
        private System.Windows.Forms.Button btnGeri;
    }
}