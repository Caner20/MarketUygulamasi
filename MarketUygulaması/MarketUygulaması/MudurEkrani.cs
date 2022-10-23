using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketUygulaması
{
    public partial class MudurEkrani : Form
    {
        public MudurEkrani()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnyenicalisanekle_Click(object sender, EventArgs e)
        {
            YeniCalisanEkle yeniCalisanEkle = new YeniCalisanEkle();
            yeniCalisanEkle.Show();
            this.Hide();
        }

        private void btnurunekle_Click(object sender, EventArgs e)
        {
            UrunListele urunekle = new UrunListele();
            urunekle.Show();
        }


        private void btncalisanMaasGüncelle_Click(object sender, EventArgs e)
        {
            MaasDegistir maasDegistir = new MaasDegistir();
            maasDegistir.Show();
            this.Hide();
        }

        private void btnindirimYap_Click(object sender, EventArgs e)
        {
            MudurIndirim fiyatIndirim = new MudurIndirim();
            fiyatIndirim.Show();
            this.Hide();
        }

        private void btnMarket_Click(object sender, EventArgs e)
        {
            Market market = new Market();
            market.Show();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            GirisEkrani form1 = new GirisEkrani();
            form1.Show();
            this.Hide();
        }
    }
}
