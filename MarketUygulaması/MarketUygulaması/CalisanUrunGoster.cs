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
    public partial class CalisanUrunGoster : Form
    {
        SqlConnection con;
        SqlDataAdapter da1;
        SqlCommand cm;
        DataSet ds;
        public CalisanUrunGoster()
        {
            InitializeComponent();
        }

        private void UrunGoster_Load(object sender, EventArgs e)
        {
            urunGoster();
        }

        public void urunGoster()
        {
            con = new SqlConnection("Data Source=DESKTOP-IIC21FH\\SQLEXPRESS; Initial Catalog=MarketDB;Integrated Security=True");
            con.Open();
            da1 = new SqlDataAdapter("Select * From Urun", con);
            DataSet ds = new DataSet();
            da1.Fill(ds, "Urun");
            dataGridView1.DataSource = ds.Tables["Urun"];
            con.Close();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            CalisanEkrani form4 = new CalisanEkrani();
            form4.Show();
            this.Hide();
        }
    }
}
