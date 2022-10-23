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
    public partial class CalisanEkrani : Form
    {
        public CalisanEkrani()
        {
            InitializeComponent();
        }

        private void btnurunler_Click(object sender, EventArgs e)
        {
            CalisanUrunGoster urungoster = new CalisanUrunGoster();
            urungoster.Show();
            this.Hide();
        }

        private void btnMarket_Click(object sender, EventArgs e)
        {
            Market market = new Market();
            market.Show();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            GirisEkrani form1 =  new GirisEkrani();
            form1.Show();
            this.Hide();
        }
    }
}
