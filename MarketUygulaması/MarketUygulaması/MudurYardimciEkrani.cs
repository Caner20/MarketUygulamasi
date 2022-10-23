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
    public partial class MudurYardimciEkrani : Form
    {
        
        public MudurYardimciEkrani()
        {
            InitializeComponent();
        }

        private void btncalisanlar_Click(object sender, EventArgs e)
        {
            CalisanlarListele c1 = new CalisanlarListele();
            c1.Show();
            this.Hide();
        }

        private void btnUrunler_Click(object sender, EventArgs e)
        {
            UrunListele u1 = new UrunListele();
            u1.Show();
        }

        private void btnIndirimYap_Click(object sender, EventArgs e)
        {
            MYRDIndirim mYRDIndirim = new MYRDIndirim();
            mYRDIndirim.Show();
            this.Hide();
        }

        private void btnMarket_Click(object sender, EventArgs e)
        {
            Market market = new Market();
            market.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            GirisEkrani form1 = new GirisEkrani();
            form1.Show();
            this.Hide();
        }
    }
}
