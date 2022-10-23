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
    public partial class Market : Form
    {
        private int Miktar { get; set; }
        private int CikanMiktar { get; set; }
        private double KdvFiyat { get; set; }
        private double IndirimUrunFiyat { get; set; }
        private double SepetTutar { get; set; }
        private double IndirimOran { get; set; }
        private double ToplamSepetTutar { get; set; }
        private double IndirimSepetTutar { get; set; }


        public Market()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlDataAdapter da;
        private void Market_Load(object sender, EventArgs e)
        {
            UrunGetir();
            SepetGetir();
        }

        public void SepetGetir()
        {
            con = new SqlConnection("Data Source=DESKTOP-IIC21FH\\SQLEXPRESS; Initial Catalog=MarketDB;Integrated Security=True");
            con.Open();
            da = new SqlDataAdapter("Select s.SepetID,u.UrunAd,u.Miktar,u.UrunFiyat,u.KdvUrunFiyat,u.IndirimliUrunFiyat,s.SepetFiyat From Sepet s inner join Urun u on u.UrunID=s.UrunID", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Sepet");
            dataGridViewSepet.DataSource = ds.Tables["Sepet"];
            con.Close();
        }
        public void UrunGetir()
        {
            con = new SqlConnection("Data Source=DESKTOP-IIC21FH\\SQLEXPRESS; Initial Catalog=MarketDB;Integrated Security=True");
            con.Open();
            da = new SqlDataAdapter("Select * From Urun ", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Urun");
            dataGridView1.DataSource = ds.Tables["Urun"];
            con.Close();
        }
        public void UrunSat()
        {
            con = new SqlConnection("Data Source=DESKTOP-IIC21FH\\SQLEXPRESS; Initial Catalog=MarketDB;Integrated Security=True;MultipleActiveResultSets=True");
            con.Open();
            SqlCommand cm = new SqlCommand("Select * From Sepet s inner join Urun u on u.UrunID=s.UrunID  where u.UrunAd='" + textBoxUrunAd.Text + "'", con);

            SqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                Miktar = (int)dr["Miktar"];
                KdvFiyat = (double)dr["KdvUrunFiyat"];
                IndirimUrunFiyat = (double)dr["IndirimliUrunFiyat"];
                if (IndirimUrunFiyat != 0)
                {
                    SepetTutar = IndirimUrunFiyat * Convert.ToDouble(textBoxUrunMiktar.Text);
                    string sorgu = "update Sepet set SepetFiyat=@sepetfiyat FROM Sepet s inner join Urun u on u.UrunID=s.UrunID where u.UrunAd='" + textBoxUrunAd.Text + "'";
                    SqlCommand cm2 = new SqlCommand(sorgu, con);
                    cm2.Parameters.AddWithValue("@sepetfiyat", SepetTutar);
                    cm2.ExecuteNonQuery();
                    CikanMiktar = Miktar - Convert.ToInt32(textBoxUrunMiktar.Text);
                    string sql = "update Urun set Miktar=@miktar from Sepet s inner join Urun u on u.UrunID=s.UrunID WHERE UrunAd='" + textBoxUrunAd.Text + "'";
                    SqlCommand cm3 = new SqlCommand(sql, con);
                    cm3.Parameters.AddWithValue("@miktar", CikanMiktar);
                    cm3.ExecuteNonQuery();

                }
                else if (IndirimUrunFiyat == 0)
                {
                    SepetTutar = KdvFiyat * Convert.ToDouble(textBoxUrunMiktar.Text);
                    string sorgu = "update Sepet set SepetFiyat=@sepetfiyat FROM Sepet s inner join Urun u on u.UrunID=s.UrunID where u.UrunAd='" + textBoxUrunAd.Text + "'";
                    SqlCommand cm2 = new SqlCommand(sorgu, con);
                    cm2.Parameters.AddWithValue("@sepetfiyat", SepetTutar);
                    cm2.ExecuteNonQuery();
                    CikanMiktar = Miktar - Convert.ToInt32(textBoxUrunMiktar.Text);
                    string sql = "update Urun set Miktar=@miktar from Sepet s inner join Urun u on u.UrunID=s.UrunID WHERE UrunAd='" + textBoxUrunAd.Text + "'";
                    SqlCommand cm3 = new SqlCommand(sql, con);
                    cm3.Parameters.AddWithValue("@miktar", CikanMiktar);
                    cm3.ExecuteNonQuery();
                }
            }


            dr.Close();
            SepetGetir();
            UrunGetir();
            con.Close();


        }

        private void btnUrunSat_Click(object sender, EventArgs e)
        {
            UrunSat();
            textBoxUrunAd.Clear();
            textBoxUrunMiktar.Clear();
        }
        public void ToplamSepetFiyatSıfırla()
        {
            con = new SqlConnection("Data Source=DESKTOP-IIC21FH\\SQLEXPRESS; Initial Catalog=MarketDB;Integrated Security=True;MultipleActiveResultSets=True");
            SepetTutar = 0;
            con.Open();
            string sql1 = "update Sepet set SepetFiyat=@sepetfiyat from Sepet";
            SqlCommand cm4 = new SqlCommand(sql1, con);
            cm4.Parameters.AddWithValue("@sepetfiyat", SepetTutar);
            cm4.ExecuteNonQuery();
            con.Close();
        }
        private void btnSepetFiyatSıfırla_Click(object sender, EventArgs e)
        {
            ToplamSepetFiyatSıfırla();
            SepetGetir();
        }



        public void ToplamSepetFiyat()
        {
            ToplamSepetTutar = 0;
            for (int i = 0; i < dataGridViewSepet.Rows.Count; ++i)
            {
                ToplamSepetTutar += Convert.ToDouble(dataGridViewSepet.Rows[i].Cells[6].Value);
            }
            textBoxtst.Text = ToplamSepetTutar.ToString() + " TL";

            if ((ToplamSepetTutar >= 500) && (ToplamSepetTutar <= 750))
            {
                IndirimOran = 5;
                IndirimSepetTutar = ToplamSepetTutar - ((ToplamSepetTutar * IndirimOran) / 100);
                textBoxiust.Text = IndirimSepetTutar.ToString();
            }
            else if ((ToplamSepetTutar > 750) && (ToplamSepetTutar <= 1000))
            {
                IndirimOran = 10;
                IndirimSepetTutar = ToplamSepetTutar - ((ToplamSepetTutar * IndirimOran) / 100);
                textBoxiust.Text = IndirimSepetTutar.ToString();
            }
            else if (ToplamSepetTutar > 1000)
            {
                IndirimOran = 15;
                IndirimSepetTutar = ToplamSepetTutar - ((ToplamSepetTutar * IndirimOran) / 100);
                textBoxiust.Text = IndirimSepetTutar.ToString();
            }
            else
            {
                textBoxiust.Text = "İndirim yapılamadı, Min=500TL";
            }
        }
        private void btnToplamSepetFiyat_Click(object sender, EventArgs e)
        {
            ToplamSepetFiyat();
        }

    }
}
