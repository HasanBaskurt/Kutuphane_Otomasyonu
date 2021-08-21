using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;  // Veri tabanı bağlantısı için gerekli kütüphaneyi ekledik.
using System.Data;       // Veri tabanı bağlantısı için gerekli kütüphaneyi ekledik.
using Entity;           // Entity katmanını kullandık.
using System.Windows.Forms;

namespace DAL
{
    public class OgrenciDAL
    {
        //Öğrencinin tabloda kayıtlı olma durumu kontrol edildi
        public static bool ogrenciKontrol(OgrenciVeri ogr)
        {
            OleDbCommand command = new OleDbCommand("Select * from Ogrenci where OgrenciNo=@OgrenciNo and OgrenciSifre=@OgrenciSifre", Baglanti.baglanti);
            Baglanti.Connection(command);
            command.Parameters.AddWithValue("@OgrenciNo",ogr.OgrenciNo);
            command.Parameters.AddWithValue("@OgrenciSifre",ogr.OgrenciSifre);

            OleDbDataReader okuma = command.ExecuteReader();
            bool sonuc=false;
            int sayac =0;

            while(okuma.Read())
            {
                sayac++;
            }


            if(sayac>0)
            {
                sonuc = true;
            }

            return sonuc;


        }

        //Yeni eklenecek öğrenci ile veri tabanındaki herhangi bir öğrencinin numraları çakışmaması için kontrol edildi
        public static bool OgrenciOkulNoKontrol(OgrenciVeri ogrenci)
        {
            OleDbCommand command = new OleDbCommand("Select count(OgrenciNo) FROM Ogrenci Where OgrenciNo=@OgrenciNo", Baglanti.baglanti);
            Baglanti.Connection(command);
            command.Parameters.AddWithValue("@OgrenciNo", ogrenci.OgrenciNo);
            int count = Convert.ToInt32(command.ExecuteScalar());

            if (count > 0)
            {
                return false;
            }
            return true;

        }

        //Ogrenci no ve şifreye ait id çekildi ve int döndürüldü
        public static int ogrenciIdSorgu(OgrenciVeri ogr)
        {
            OleDbCommand command = new OleDbCommand("Select OgrenciId from Ogrenci where OgrenciNo=@OgrenciNo and OgrenciSifre=@OgrenciSifre", Baglanti.baglanti);
            Baglanti.Connection(command);
            command.Parameters.AddWithValue("@OgrenciNo", ogr.OgrenciNo);
            command.Parameters.AddWithValue("@OgrenciSifre", ogr.OgrenciSifre);

            OleDbDataReader okuma = command.ExecuteReader();
            
            int id = 0;

            while (okuma.Read())
            {
                id = int.Parse(okuma["OgrenciId"].ToString());
            }
            return id;
        }

        //Öğrenci id ile veritabanında kayıtlı olma durumu kontrol edildi
        public static bool ogrenciSorgu(OgrenciVeri ogr)
        {
            OleDbCommand command = new OleDbCommand("Select * from Ogrenci where OgrenciId=@OgrenciId", Baglanti.baglanti);
            Baglanti.Connection(command);
            command.Parameters.AddWithValue("@OgrenciId", ogr.OgrenciId);

            OleDbDataReader okuma = command.ExecuteReader();
            bool sonuc = false;
            int sayac = 0;

            while (okuma.Read())
            {
                sayac++;
            }


            if (sayac > 0)
            {
                sonuc = true;
            }

            return sonuc;


        }


        // Öğrenci tablosuna girilen öğrenci bilgileri eklendi
        public static int ogrenciEkle(OgrenciVeri ogrenci)
        {
            OleDbCommand command = new OleDbCommand("insert into Ogrenci(OgrenciAd,OgrenciSoyad,OgrenciNo,OgrenciSifre,OgrenciCinsiyet) values(@OgrenciAd,@OgrenciSoyad,@OgrenciNo,@OgrenciSifre,@OgrenciCinsiyet)", Baglanti.baglanti);
            Baglanti.Connection(command);                                                       
            command.Parameters.AddWithValue("@OgrenciAd", ogrenci.OgrenciAd);
            command.Parameters.AddWithValue("@OgrenciSoyad", ogrenci.OgrenciSoyad);
            command.Parameters.AddWithValue("@OgrenciNo", ogrenci.OgrenciNo);
            command.Parameters.AddWithValue("@OgrenciSifre", ogrenci.OgrenciSifre);
            command.Parameters.AddWithValue("@OgrenciCinsiyet", ogrenci.OgrenciCinsiyet);

            return command.ExecuteNonQuery();
        }


        // İd ye ait öğrenci , Ogrenci tablosundan silindi
        public static int ogrenciSil(OgrenciVeri ogrenci)
        {
            OleDbCommand command = new OleDbCommand("Delete from Ogrenci where OgrenciId=@OgrenciId ", Baglanti.baglanti);
            Baglanti.Connection(command);
            command.Parameters.AddWithValue("@OgrenciId", ogrenci.OgrenciId);

            return command.ExecuteNonQuery();
        }


        // Ogrenci Id ye ait bilgilerin güncellenme işlemi gerçekleştirildi
        public static int ogrenciGuncelle(OgrenciVeri ogrenci)
        {
            OleDbCommand command = new OleDbCommand("Update Ogrenci set OgrenciAd=@OgrenciAd,OgrenciSoyad=@OgrenciSoyad,OgrenciNo=@OgrenciNo,OgrenciSifre=@OgrenciSifre,OgrenciCinsiyet=@OgrenciCinsiyet where OgrenciId=@OgrenciId", Baglanti.baglanti);
            Baglanti.Connection(command);
            command.Parameters.AddWithValue("@OgrenciAd", ogrenci.OgrenciAd);
            command.Parameters.AddWithValue("@OgrenciSoyad", ogrenci.OgrenciSoyad);
            command.Parameters.AddWithValue("@OgrenciNo", ogrenci.OgrenciNo);
            command.Parameters.AddWithValue("@OgrenciSifre", ogrenci.OgrenciSifre);
            command.Parameters.AddWithValue("@OgrenciCinsiyet", ogrenci.OgrenciCinsiyet);
            command.Parameters.AddWithValue("@OgrenciId", ogrenci.OgrenciId);

            return command.ExecuteNonQuery();
        }


        // Öğrenciye ait tüm bilgilerin listelenmesi gerçekleştirildi
        public static List<OgrenciVeri> liste() 
        {
            OleDbCommand command = new OleDbCommand("Select * from Ogrenci",Baglanti.baglanti);
            Baglanti.Connection(command);
            OleDbDataReader read = command.ExecuteReader();
            List<OgrenciVeri> ogrenci = new List<OgrenciVeri>();

            while (read.Read())
            {
                ogrenci.Add(new OgrenciVeri
                {
                    OgrenciId=int.Parse(read["OgrenciId"].ToString()),
                    OgrenciAd=read["OgrenciAd"].ToString(),
                    OgrenciSoyad=read["OgrenciSoyad"].ToString(),
                    OgrenciNo=read["OgrenciNo"].ToString(),
                    OgrenciSifre=read["OgrenciSifre"].ToString(),
                    OgrenciCinsiyet=read["OgrenciCinsiyet"].ToString(),
                    OgrenciCeza=float.Parse(read["OgrenciCeza"].ToString())
                });
            }

            return ogrenci;
        }

        


        //Ogrenci id ye ait tüm bilgiler Ogrenci tablosundan çekildi
        public static OgrenciVeri ogrenciIdBilgi(OgrenciVeri ogrenci)
        {
            OleDbCommand command = new OleDbCommand("Select * from Ogrenci where OgrenciId = @OgrenciId", Baglanti.baglanti);
            Baglanti.Connection(command);
            command.Parameters.AddWithValue("@OgrenciId", ogrenci.OgrenciId);
            OleDbDataReader read = command.ExecuteReader();

            while (read.Read())
            {
                ogrenci.OgrenciAd = read["OgrenciAd"].ToString();
                ogrenci.OgrenciSoyad = read["OgrenciSoyad"].ToString();
                ogrenci.OgrenciNo = read["OgrenciNo"].ToString();
                ogrenci.OgrenciSifre = read["OgrenciSifre"].ToString();
                ogrenci.OgrenciCinsiyet = read["OgrenciCinsiyet"].ToString();
                ogrenci.OgrenciCeza = float.Parse(read["OgrenciCeza"].ToString());
            }

            return ogrenci;
        }
    }
}
