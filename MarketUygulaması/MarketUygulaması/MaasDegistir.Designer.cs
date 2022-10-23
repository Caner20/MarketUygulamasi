namespace MarketUygulaması
{
    partial class MaasDegistir
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
            this.lblMaas = new System.Windows.Forms.Label();
            this.textBoxMaas = new System.Windows.Forms.TextBox();
            this.btnGeri = new System.Windows.Forms.Button();
            this.lblAd = new System.Windows.Forms.Label();
            this.textBoxAd = new System.Windows.Forms.TextBox();
            this.btnMaasDegis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 136);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(658, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // lblMaas
            // 
            this.lblMaas.AutoSize = true;
            this.lblMaas.Location = new System.Drawing.Point(110, 49);
            this.lblMaas.Name = "lblMaas";
            this.lblMaas.Size = new System.Drawing.Size(36, 13);
            this.lblMaas.TabIndex = 1;
            this.lblMaas.Text = "Maaş:";
            // 
            // textBoxMaas
            // 
            this.textBoxMaas.Location = new System.Drawing.Point(166, 46);
            this.textBoxMaas.Name = "textBoxMaas";
            this.textBoxMaas.Size = new System.Drawing.Size(100, 20);
            this.textBoxMaas.TabIndex = 2;
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(699, 21);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(75, 23);
            this.btnGeri.TabIndex = 3;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(86, 24);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(60, 13);
            this.lblAd.TabIndex = 4;
            this.lblAd.Text = "Çalışan Ad:";
            // 
            // textBoxAd
            // 
            this.textBoxAd.Location = new System.Drawing.Point(166, 21);
            this.textBoxAd.Name = "textBoxAd";
            this.textBoxAd.Size = new System.Drawing.Size(100, 20);
            this.textBoxAd.TabIndex = 5;
            // 
            // btnMaasDegis
            // 
            this.btnMaasDegis.Location = new System.Drawing.Point(166, 89);
            this.btnMaasDegis.Name = "btnMaasDegis";
            this.btnMaasDegis.Size = new System.Drawing.Size(100, 23);
            this.btnMaasDegis.TabIndex = 6;
            this.btnMaasDegis.Text = "Maaş Değiştir";
            this.btnMaasDegis.UseVisualStyleBackColor = true;
            this.btnMaasDegis.Click += new System.EventHandler(this.btnMaasDegis_Click);
            // 
            // MaasDegistir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(798, 353);
            this.Controls.Add(this.btnMaasDegis);
            this.Controls.Add(this.textBoxAd);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.textBoxMaas);
            this.Controls.Add(this.lblMaas);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MaasDegistir";
            this.Text = "Çalışan Maaş Değiştir";
            this.Load += new System.EventHandler(this.MaasDegistir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblMaas;
        private System.Windows.Forms.TextBox textBoxMaas;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.TextBox textBoxAd;
        private System.Windows.Forms.Button btnMaasDegis;
    }
}