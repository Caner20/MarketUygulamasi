using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketUygulaması
{

    public abstract class Kategori
    {
        public int UrunID { get; set; }

        public int KategoriID { get; set; }
        public string KategoriAd { get; set; }
        public double KdvOran { get; set; }
        public int UrunFiyat { get; set; }
        public double KdvUrunFiyat { get; set; }
        public abstract void KdvHesap();

    }
    public class Kategori1 : Kategori
    {

        public override void KdvHesap()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-IIC21FH\\SQLEXPRESS; Initial Catalog=MarketDB;Integrated Security=True;MultipleActiveResultSets=True");
            con.Open();
            SqlCommand cm = new SqlCommand("select * from Kategori k inner join Urun u on k.KategoriID=u.KategoriID where k.KategoriID=1", con);

            SqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                KategoriID = (int)dr["KategoriID"];
                KategoriAd = dr["KategoriAd"].ToString();
                UrunFiyat = (int)dr["UrunFiyat"];
                KdvOran = (double)dr["KDV"];
                KdvUrunFiyat = (UrunFiyat * KdvOran) + UrunFiyat;
                string sorgu = "update Urun set KdvUrunFiyat=@kdvurunfiyat where KategoriID='" + KategoriID + "'";
                SqlCommand cm2 = new SqlCommand(sorgu, con);
                cm2.Parameters.AddWithValue("@kdvurunfiyat", KdvUrunFiyat);
                cm2.ExecuteNonQuery();
            }
            dr.Close();
            con.Close();

        }
    }
    public class Kategori2 : Kategori
    {

        public override void KdvHesap()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-IIC21FH\\SQLEXPRESS; Initial Catalog=MarketDB;Integrated Security=True;MultipleActiveResultSets=True");
            con.Open();
            SqlCommand cm = new SqlCommand("select * from Kategori k inner join Urun u on k.KategoriID=u.KategoriID where k.KategoriID=2", con);

            SqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                KategoriID = (int)dr["KategoriID"];
                UrunID = (int)dr["UrunID"];
                KategoriAd = dr["KategoriAd"].ToString();
                UrunFiyat = (int)dr["UrunFiyat"];
                KdvOran = (double)dr["KDV"];
                KdvUrunFiyat = (UrunFiyat * KdvOran) + UrunFiyat;
                string sorgu = "update Urun set KdvUrunFiyat=@kdvurunfiyat where KategoriID='" + KategoriID + "' and UrunID='" + UrunID + "'";
                SqlCommand cm2 = new SqlCommand(sorgu, con);
                cm2.Parameters.AddWithValue("@kdvurunfiyat", KdvUrunFiyat);
                cm2.ExecuteNonQuery();
            }
            dr.Close();
            con.Close();

        }
    }
    public class Kategori3 : Kategori
    {

        public override void KdvHesap()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-IIC21FH\\SQLEXPRESS; Initial Catalog=MarketDB;Integrated Security=True;MultipleActiveResultSets=True");
            con.Open();
            SqlCommand cm = new SqlCommand("select * from Kategori k inner join Urun u on k.KategoriID=u.KategoriID where k.KategoriID=3", con);

            SqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                KategoriID = (int)dr["KategoriID"];
                UrunID = (int)dr["UrunID"];
                KategoriAd = dr["KategoriAd"].ToString();
                UrunFiyat = (int)dr["UrunFiyat"];
                KdvOran = (double)dr["KDV"];
                KdvUrunFiyat = (UrunFiyat * KdvOran) + UrunFiyat;
                string sorgu = "update Urun set KdvUrunFiyat=@kdvurunfiyat where KategoriID='" + KategoriID + "' and UrunID='" + UrunID + "'";
                SqlCommand cm2 = new SqlCommand(sorgu, con);
                cm2.Parameters.AddWithValue("@kdvurunfiyat", KdvUrunFiyat);
                cm2.ExecuteNonQuery();
            }
            dr.Close();
            con.Close();

        }
    }
    public class Kategori4 : Kategori
    {

        public override void KdvHesap()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-IIC21FH\\SQLEXPRESS; Initial Catalog=MarketDB;Integrated Security=True;MultipleActiveResultSets=True");
            con.Open();
            SqlCommand cm = new SqlCommand("select * from Kategori k inner join Urun u on k.KategoriID=u.KategoriID where k.KategoriID=4", con);

            SqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                KategoriID = (int)dr["KategoriID"];
                UrunID = (int)dr["UrunID"];
                KategoriAd = dr["KategoriAd"].ToString();
                UrunFiyat = (int)dr["UrunFiyat"];
                KdvOran = (double)dr["KDV"];
                KdvUrunFiyat = (UrunFiyat * KdvOran) + UrunFiyat;
                string sorgu = "update Urun set KdvUrunFiyat=@kdvurunfiyat where KategoriID='" + KategoriID + "' and UrunID='" + UrunID + "'";
                SqlCommand cm2 = new SqlCommand(sorgu, con);
                cm2.Parameters.AddWithValue("@kdvurunfiyat", KdvUrunFiyat);
                cm2.ExecuteNonQuery();
            }
            dr.Close();
            con.Close();

        }
    }
    public class Kategori5 : Kategori
    {

        public override void KdvHesap()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-IIC21FH\\SQLEXPRESS; Initial Catalog=MarketDB;Integrated Security=True;MultipleActiveResultSets=True");
            con.Open();
            SqlCommand cm = new SqlCommand("select * from Kategori k inner join Urun u on k.KategoriID=u.KategoriID where k.KategoriID=5", con);

            SqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                KategoriID = (int)dr["KategoriID"];
                UrunID = (int)dr["UrunID"];
                KategoriAd = dr["KategoriAd"].ToString();
                UrunFiyat = (int)dr["UrunFiyat"];
                KdvOran = (double)dr["KDV"];
                KdvUrunFiyat = (UrunFiyat * KdvOran) + UrunFiyat;
                string sorgu = "update Urun set KdvUrunFiyat=@kdvurunfiyat where KategoriID='" + KategoriID + "' and UrunID='" + UrunID + "'";
                SqlCommand cm2 = new SqlCommand(sorgu, con);
                cm2.Parameters.AddWithValue("@kdvurunfiyat", KdvUrunFiyat);
                cm2.ExecuteNonQuery();
            }
            dr.Close();
            con.Close();

        }
    }

}
