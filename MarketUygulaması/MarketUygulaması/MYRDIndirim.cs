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
    public partial class MYRDIndirim : Form
    {
        private int UrunFiyat { get; set; }
        private double IndirimUrunFiyat { get; set; }
        public MYRDIndirim()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlDataAdapter da;
        public void UrunGetir()
        {
            con = new SqlConnection("Data Source=DESKTOP-IIC21FH\\SQLEXPRESS; Initial Catalog=MarketDB;Integrated Security=True");
            con.Open();
            da = new SqlDataAdapter("Select * From Urun", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Urun");
            dataGridView1.DataSource = ds.Tables["Urun"];
            con.Close();
        }
        private void btnIndirimYap_Click(object sender, EventArgs e)
        {
            IndirimYap();
            textBoxYüzde.Clear();
            textBoxUrunAdi.Clear();
        }

        private void MYRDIndirim_Load(object sender, EventArgs e)
        {
            UrunGetir();
        }

        public void IndirimYap()
        {
                con = new SqlConnection("Data Source=DESKTOP-IIC21FH\\SQLEXPRESS; Initial Catalog=MarketDB;Integrated Security=True;MultipleActiveResultSets=True");
                con.Open();
                SqlCommand cm = new SqlCommand("select * from Urun where UrunAd='" + textBoxUrunAdi.Text + "'", con);

                SqlDataReader dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    UrunFiyat = (int)dr["UrunFiyat"];
                    if (Convert.ToUInt32(textBoxYüzde.Text) <= 20)
                    {
                        IndirimUrunFiyat = UrunFiyat - ((UrunFiyat * Convert.ToDouble(textBoxYüzde.Text)) / 100);
                        string sorgu = "update Urun set IndirimliUrunFiyat=@indirimliUrunFiyat where UrunAd='" + textBoxUrunAdi.Text + "'";
                        SqlCommand cm2 = new SqlCommand(sorgu, con);
                        cm2.Parameters.AddWithValue("@indirimliUrunFiyat", IndirimUrunFiyat);
                        cm2.ExecuteNonQuery();
                    }
                    else
                    {
                        MessageBox.Show("İndirim Yapma Hakkınız %20' ye kadardır...!");
                    }
                }
                dr.Close();
                UrunGetir();
                con.Close();
            
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            MudurYardimciEkrani form3 = new MudurYardimciEkrani();
            form3.Show();
            this.Hide();
        }
    }
}
