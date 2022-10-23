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
    public partial class MudurIndirim : Form
    {
        private int UrunFiyat { get; set; }
        private double IndiriUrunFiyat { get; set; }
        public MudurIndirim()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlDataAdapter da;
        private void FiyatIndirim_Load(object sender, EventArgs e)
        {
            UrunGetir();
        }

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

        public void IndirimYap()
        {
            con = new SqlConnection("Data Source=DESKTOP-IIC21FH\\SQLEXPRESS; Initial Catalog=MarketDB;Integrated Security=True;MultipleActiveResultSets=True");
            con.Open();
            SqlCommand cm = new SqlCommand("select * from Urun where UrunAd='"+textBoxUrunAdi.Text+"'", con);

            SqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                UrunFiyat = (int)dr["UrunFiyat"];
                IndiriUrunFiyat = UrunFiyat - ((UrunFiyat * Convert.ToDouble(textBoxYuzde.Text)) / 100);
                string sorgu = "update Urun set IndirimliUrunFiyat=@indirimliUrunFiyat where UrunAd='" + textBoxUrunAdi.Text + "'";
                SqlCommand cm2 = new SqlCommand(sorgu, con);
                cm2.Parameters.AddWithValue("@indirimliUrunFiyat", IndiriUrunFiyat);
                cm2.ExecuteNonQuery();
            }
            dr.Close();
            UrunGetir();
            con.Close();
        }

        private void btnindirim_Click(object sender, EventArgs e)
        {
            IndirimYap();
            textBoxYuzde.Clear();
            textBoxUrunAdi.Clear();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            MudurEkrani form2 = new MudurEkrani();
            form2.Show();
            this.Hide();
        }
    }
}
