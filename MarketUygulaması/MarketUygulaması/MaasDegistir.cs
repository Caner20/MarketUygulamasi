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
    public partial class MaasDegistir : Form
    {
        public MaasDegistir()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlDataAdapter da;
        private void MaasDegistir_Load(object sender, EventArgs e)
        {
            KullaniciGetir();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            MudurEkrani form2 = new MudurEkrani();
            form2.Show();
            this.Hide();
        }

        public void KullaniciGetir()
        {//Veritabanından çekilen kullanıcı bilgilerinin datagride eklenmesi.
            con = new SqlConnection("Data Source=DESKTOP-IIC21FH\\SQLEXPRESS; Initial Catalog=MarketDB;Integrated Security=True");
            con.Open();
            da = new SqlDataAdapter("Select * From Kullanici", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Kullanici");
            dataGridView1.DataSource = ds.Tables["Kullanici"];
            con.Close();
        }

        public void MaasDegis()
        {//TextBox' a girilen Ad bilgisine göre Kullanıcı tablosu kontrolü.
            con = new SqlConnection("Data Source=DESKTOP-IIC21FH\\SQLEXPRESS; Initial Catalog=MarketDB;Integrated Security=True;MultipleActiveResultSets=True");
            con.Open();
            SqlCommand cm = new SqlCommand("select * from Kullanici where Ad='"+textBoxAd.Text+"'", con);

            SqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {//TextBox'a girilmiş Ad bilgisine göre, TextBox' tan girilmiş Maaş bilgisine göre güncellenmesi.
                string sorgu = "update Kullanici set Maas=@maas where Ad='"+textBoxAd.Text+"'";
                SqlCommand cm2 = new SqlCommand(sorgu, con);
                cm2.Parameters.AddWithValue("@maas", textBoxMaas.Text);
                cm2.ExecuteNonQuery();
            }
            dr.Close();
            KullaniciGetir();
            con.Close();
        }

        private void btnMaasDegis_Click(object sender, EventArgs e)
        {
            MaasDegis();
            textBoxAd.Clear();
            textBoxMaas.Clear();
        }
    }
}
