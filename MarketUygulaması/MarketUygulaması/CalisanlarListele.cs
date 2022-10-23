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
    public partial class CalisanlarListele : Form
    {
        public CalisanlarListele()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-IIC21FH\\SQLEXPRESS; Initial Catalog=MarketDB;Integrated Security=True");
        SqlDataAdapter da;
        private void CalisanlarListele_Load(object sender, EventArgs e)
        {
            kullaniciGetir();
        }

        private void kullaniciGetir()
        {
            con.Open();
            da = new SqlDataAdapter("Select * From Kullanici", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Kullanici");
            dataGridView1.DataSource = ds.Tables["Kullanici"];
            dataGridView1.Rows.RemoveAt(0);
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
