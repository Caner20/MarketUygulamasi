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
    public partial class YeniCalisanEkle : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cm;
        SqlCommandBuilder build;
        SqlDataReader dr;
        DataSet ds;
        DataSet dataset = new DataSet();

        public YeniCalisanEkle()
        {
            InitializeComponent();
        }

        private void YeniCalisanEkle_Load(object sender, EventArgs e)
        {
            kullaniciGetir();
            Güncelleme();
        }
        private void kullaniciGetir()
        {//Veritabanından çekilen kullanıcı bilgilerinin datagride eklenmesi.
            con = new SqlConnection("Data Source=DESKTOP-IIC21FH\\SQLEXPRESS; Initial Catalog=MarketDB;Integrated Security=True");
            con.Open();
            da = new SqlDataAdapter("Select * From Kullanici", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Kullanici");
            dataGridView1.DataSource = ds.Tables["Kullanici"];
            con.Close();
        }
        private void Güncelleme()
        {//Datagrid de seçilen blok için dataset oluşturulması.
            con = new SqlConnection("Data Source=DESKTOP-IIC21FH\\SQLEXPRESS; Initial Catalog=MarketDB;Integrated Security=True");
            con.Open();
            da = new SqlDataAdapter("Select * From Kullanici", con);
            da.Fill(dataset, "Kullanici");
            dataGridView1.DataSource = dataset.Tables["Kullanici"];
            con.Close();
        }

        private void kullaniciSil(int id)
        {//Datagirid de seçilen satırın id ye göre kullanıcı tablosundan silinmesi.
            string sql = "DELETE FROM Kullanici WHERE KullaniciID=@kullaniciID";
            cm = new SqlCommand(sql, con);
            cm.Parameters.AddWithValue("@kullaniciID", id);
            con.Open();
            cm.ExecuteNonQuery();
            con.Close();
        }
        private void btnekle_Click(object sender, EventArgs e)
        {//TextBox' a girilen değerlerin, Kullanıcı tablosuna eklenmesi
            string sorgu = "Insert into Kullanici (KullaniciAdi,Ad,Soyad,Sifre,Maas) values (@kullaniciAdi,@ad,@soyad,@sifre,@maas)";
            cm = new SqlCommand(sorgu, con);
            cm.Parameters.AddWithValue("@kullaniciAdi", textBoxkullaniciAdi.Text);
            cm.Parameters.AddWithValue("@ad", textBoxad.Text);
            cm.Parameters.AddWithValue("@soyad", textBoxsoyad.Text);
            cm.Parameters.AddWithValue("@sifre", textBoxsifre.Text);
            cm.Parameters.AddWithValue("@maas", textBoxmaas.Text);
            con.Open();
            cm.ExecuteNonQuery();
            con.Close();
            kullaniciGetir();
            MessageBox.Show("Ekleme İşlemi Başarılı");
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {//Oluşturduğumuz dataset için builder update fonksiyonu ile seçilen blok güncellenmesi.
            build = new SqlCommandBuilder(da);
            da.Update(dataset, "Kullanici");
            MessageBox.Show("Güncelleme Başarılı");
        }

        private void buttonsil_Click(object sender, EventArgs e)
        {//Datagrid seçilen satırın id sini alıp kullanıcısil fonksiyonunda id sine göre silinmesi.
            foreach (DataGridViewRow drow in dataGridView1.SelectedRows)  //Seçili Satırları Silme
            {
                int id = Convert.ToInt32(drow.Cells[0].Value);
                kullaniciSil(id);
            }
            kullaniciGetir();
            MessageBox.Show("Silme İşlemi Başarılı");
        }

        private void btnDon_Click(object sender, EventArgs e)
        {
            MudurEkrani form2 = new MudurEkrani();
            form2.Show();
            this.Hide();
        }
    }
}
