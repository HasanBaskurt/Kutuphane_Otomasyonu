using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;  // Veri tabanı bağlantısı için gerekli kütüphaneyi ekledik.
using System.Data;       // Veri tabanı bağlantısı için gerekli kütüphaneyi ekledik.
using Entity;           // Entity katmanını kullandık.

namespace DAL
{
    public class KitapDAL
    {
        // Kİtabın veri tabanındaki kitap tablosunda kayıtlı mı  diye id sorgusu ile kontrol edildi
        public static bool kitapSorgu(KitapVeri kitap)
        {
            OleDbCommand command = new OleDbCommand("Select * from Kitap where KitapId=@KitapId", Baglanti.baglanti);
            Baglanti.Connection(command);
            command.Parameters.AddWithValue("@KitapId", kitap.KitapId);

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

        //Veri tabanındaki Kitap tablosuna ekleme işlemi gerçekleştirildi
        public static int kitapEkle(KitapVeri kitap)
        {
            OleDbCommand command = new OleDbCommand("insert into Kitap(KitapAd,KitapTuru,KitapSayfa,KitapYazar) values(@KitapAd,@KitapTuru,@KitapSayfa,@KitapYazar)", Baglanti.baglanti);
            Baglanti.Connection(command);
            command.Parameters.AddWithValue("@KitapAd", kitap.KitapAd);
            command.Parameters.AddWithValue("@KitapTuru", kitap.KitapTuru);
            command.Parameters.AddWithValue("@KitapSayfa", kitap.KitapSayfa);
            command.Parameters.AddWithValue("@KitapYazar", kitap.KitapYazar);

            return command.ExecuteNonQuery();
        }


        //Veri tabanındaki Kitap tablosundaki veriler listelendi
        public static List<KitapVeri> kitapListe()
        {
            OleDbCommand command = new OleDbCommand("Select * from Kitap", Baglanti.baglanti);
            Baglanti.Connection(command);
            OleDbDataReader read = command.ExecuteReader();
            List<KitapVeri> kitap = new List<KitapVeri>();

            while (read.Read())
            {
                kitap.Add(new KitapVeri
                {
                    KitapId = int.Parse(read["KitapId"].ToString()),
                    KitapAd = read["KitapAd"].ToString(),
                    KitapTuru = read["KitapTuru"].ToString(),
                    KitapSayfa = read["KitapSayfa"].ToString(),
                    KitapYazar = read["KitapYazar"].ToString()
                });
            }

            return kitap;
        }


        // Veri tabanındaki kitap tablosunda bulunan id sorgusundaki kitap silindi
        public static int kitapSil(KitapVeri kitap)
        {
            OleDbCommand command = new OleDbCommand("Delete from Kitap where KİtapId=@KitapId ", Baglanti.baglanti);
            Baglanti.Connection(command);
            command.Parameters.AddWithValue("@KitapId", kitap.KitapId);

            return command.ExecuteNonQuery();
        }

        // Veri tabanında bulunan kitap tablosundaki kitap id ile eşleşen kitap güncellendi
        public static int kitapGuncelle(KitapVeri kitap)
        {
            OleDbCommand command = new OleDbCommand("Update Kitap set KitapAd=@KitapAd,KitapTuru=@KitapTuru,KitapSayfa=@KitapSayfa,KitapYazar=@KitapYazar where KitapId=@KitapId", Baglanti.baglanti);
            Baglanti.Connection(command);
            command.Parameters.AddWithValue("@KitapAd", kitap.KitapAd);
            command.Parameters.AddWithValue("@KitapTuru", kitap.KitapTuru);
            command.Parameters.AddWithValue("@KitapSayfa", kitap.KitapSayfa);
            command.Parameters.AddWithValue("@KitapYazar", kitap.KitapYazar);
            command.Parameters.AddWithValue("@KitapId", kitap.KitapId);

            return command.ExecuteNonQuery();
        }

        // Sorgudaki id ye sahip kitabın bilgileri kitap tablosundan çekildi
        public static KitapVeri kitapIdBilgi(KitapVeri kitap)
        {
            OleDbCommand command = new OleDbCommand("Select * from Kitap where KitapId = @KitapId", Baglanti.baglanti);
            Baglanti.Connection(command);
            command.Parameters.AddWithValue("@KitapId", kitap.KitapId);
            OleDbDataReader read = command.ExecuteReader();

            while (read.Read())
            {
                kitap.KitapAd = read["KitapAd"].ToString();
                kitap.KitapTuru = read["KitapTuru"].ToString();
                kitap.KitapSayfa = read["KitapSayfa"].ToString();
                kitap.KitapYazar = read["KitapYazar"].ToString();
            }

            return kitap;
        }
    }
}
