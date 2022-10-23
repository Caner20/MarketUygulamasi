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
    public partial class UrunListele : Form
    {
        SqlConnection con;
        SqlDataAdapter da1;
        SqlCommand cm;
        SqlCommandBuilder build1;
        SqlDataReader dr;
        DataSet ds;
        DataSet dataset1 = new DataSet();
        public UrunListele()
        {
            InitializeComponent();
        }

        private void UrunListele_Load(object sender, EventArgs e)
        {
            yeniUrun();
            urunGüncelle();
        }

        public void yeniUrun()
        {
            con = new SqlConnection("Data Source=DESKTOP-IIC21FH\\SQLEXPRESS; Initial Catalog=MarketDB;Integrated Security=True");
            con.Open();
            da1 = new SqlDataAdapter("Select * From Urun", con);
            DataSet ds = new DataSet();
            da1.Fill(ds, "Urun");
            dataGridView1.DataSource = ds.Tables["Urun"];
            con.Close();
        }

        private void urunSil(int urunid)
        {
            string sorgu2 = "DELETE FROM Urun WHERE UrunID=@urunID";
            cm = new SqlCommand(sorgu2, con);
            cm.Parameters.AddWithValue("@urunID", urunid);
            con.Open();
            cm.ExecuteNonQuery();
            con.Close();
        }

        private void urunGüncelle()
        {
            con = new SqlConnection("Data Source=DESKTOP-IIC21FH\\SQLEXPRESS; Initial Catalog=MarketDB;Integrated Security=True");
            con.Open();
            da1 = new SqlDataAdapter("Select * From Urun", con);
            da1.Fill(dataset1, "Urun");
            dataGridView1.DataSource = dataset1.Tables["Urun"];
            con.Close();


        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBoxurunadi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxmiktar.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBoxurunFiyat.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

        }

        private void btnurunekle_Click(object sender, EventArgs e)
        {
            string sorgu1 = "Insert into Urun (UrunAd,Miktar,UrunFiyat,KategoriID) values (@urunad,@miktar,@urunfiyat,@kategoriID)";
            cm = new SqlCommand(sorgu1, con);
            cm.Parameters.AddWithValue("@urunad", textBoxurunadi.Text);
            cm.Parameters.AddWithValue("@miktar", textBoxmiktar.Text);
            cm.Parameters.AddWithValue("@urunfiyat", textBoxurunFiyat.Text);
            cm.Parameters.AddWithValue("@kategoriID", textBoxKategoriID.Text);

            con.Open();
            cm.ExecuteNonQuery();

            Kategori1 kategori1 = new Kategori1();
            kategori1.KdvHesap();

            Kategori2 kategori2 = new Kategori2();
            kategori2.KdvHesap();

            Kategori3 kategori3 = new Kategori3();
            kategori3.KdvHesap();

            Kategori4 kategori4 = new Kategori4();
            kategori4.KdvHesap();

            Kategori5 kategori5 = new Kategori5();
            kategori5.KdvHesap();
            con.Close();
            yeniUrun();

            textBoxurunadi.Clear();
            textBoxmiktar.Clear();
            textBoxurunFiyat.Clear();
            textBoxKategoriID.Clear();

            MessageBox.Show("Ekleme İşlemi Başarılı");
        }

        private void btnurunsil_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in dataGridView1.SelectedRows) // Seçili Olan Satırı Sil
            {
                int urunid = Convert.ToInt32(drow.Cells[0].Value);
                urunSil(urunid);
            }
            yeniUrun();
            MessageBox.Show("Silme İşlemi Başarılı");
        }

        private void btnurunguncelle_Click(object sender, EventArgs e)
        {
            build1 = new SqlCommandBuilder(da1);
            da1.Update(dataset1, "Urun");
            MessageBox.Show("Güncelleme İşlemi Başarılı");
        }

    }
}
