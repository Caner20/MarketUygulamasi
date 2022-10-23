using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketUygulaması
{
    public partial class GirisEkrani : Form
    {
        public GirisEkrani()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cm;
        SqlDataReader dr;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        void kullaniciKontrol()
        {
            //TextBox' tan girilen Kullanıcı Ad ve Parola bilgilerine göre veritabanı kontrolü.
            con = new SqlConnection("Data Source=DESKTOP-IIC21FH\\SQLEXPRESS; Initial Catalog=MarketDB;Integrated Security=True");
            cm = new SqlCommand("Select * From Kullanici where KullaniciAdi='" + textBoxkullaniciAd.Text + "' and Sifre='" + textBoxParola.Text + "'", con);
            con.Open();
            dr = cm.ExecuteReader();

            if (dr.Read())
            {
                if ((textBoxkullaniciAd.Text == "mudur") && (textBoxParola.Text == "mudur1"))
                {//Girilen değerler mudure uyuyor ise mudur formu açılması.
                    MudurEkrani f2 = new MudurEkrani();
                    f2.Show();
                    this.Hide();

                }
                else if ((textBoxkullaniciAd.Text == "muduryrd") && (textBoxParola.Text == "muduryrd1"))
                {//Girilen değerler mudur yardımcısına uyuyor ise mudur yardımcısı formu açılması.
                    MudurYardimciEkrani f3 = new MudurYardimciEkrani();
                    f3.Show();
                    this.Hide();
                }
                else
                {//Girilen değerler çalışan bilgilerine uyuyor ise çalışan formu açılması.
                    CalisanEkrani f4 = new CalisanEkrani();
                    f4.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Kullanici Bilgilerini Kontrol Ediniz");

            }
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            kullaniciKontrol();
            textBoxkullaniciAd.Clear();
            textBoxParola.Clear();
        }
    }
}
