using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;      // DAL katmanına erişim sağlandı
using Entity;  //   Entity katmanına erişim sağlandı

namespace BL
{
    public class OgrenciBL
    {
        public static bool ogrenciKontrol_BL(OgrenciVeri ogrenci)
        {
            if (ogrenci.OgrenciNo != "" && ogrenci.OgrenciSifre != "") // Gelen verilerin boş olmadığı kontrol edildi
            {
                return OgrenciDAL.ogrenciKontrol(ogrenci); // Veritabanından girilen değerlere ait öğrenci kontrol edildi
            }

            else                    //Eğer gelen veri boş ise false döndürdü
                return true;
        }

        public static bool ogrenciOkulNoKOntrol(OgrenciVeri ogrenci)
        {
            if (ogrenci.OgrenciNo != "") // Gelen verilerin boş olmadığı kontrol edildi
            {
                return OgrenciDAL.OgrenciOkulNoKontrol(ogrenci); // Veritabanından girilen değerlere ait öğrenci kontrol edildi
            }

            else                    //Eğer gelen veri boş ise false döndürdü
                return false;
        }

        public static int ogrenciIdSorgu(OgrenciVeri ogrenci)
        {
            if (ogrenci.OgrenciNo != "" && ogrenci.OgrenciSifre != "") // Gelen verilerin boş olmadığı kontrol edildi
            {
                return OgrenciDAL.ogrenciIdSorgu(ogrenci); // Veritabanından girilen değerlere ait öğrenci kontrol edildi
            }

            else                    //Eğer gelen veri boş ise false döndürdü
                return -1;
        }

        public static OgrenciVeri ogrenciIdBilgi(OgrenciVeri ogrenci)
        {
            if (ogrenci.OgrenciId != 0) // Gelen verilerin boş olmadığı kontrol edildi
            {
                return OgrenciDAL.ogrenciIdBilgi(ogrenci); // Veritabanından girilen değerlere ait öğrenci kontrol edildi
            }

            else                    //Eğer gelen veri boş ise NULL döndürdü
                return null;
        }

        public static bool ogrenciSorgu_BL(OgrenciVeri ogrenci)
        {
            if (ogrenci.OgrenciId != 0) // Gelen verilerin boş olmadığı kontrol edildi
            {
                return OgrenciDAL.ogrenciSorgu(ogrenci); // Veritabanından girilen değerlere ait öğrenci kontrol edildi
            }

            else                    //Eğer gelen veri boş ise false döndürdü
                return false;
        }


        //Girilen öğrenci bilgileri DAL katmanı kullanılarak veritabanına eklendi
        public static int ogrenciEkle(OgrenciVeri ogrenci)
        {
            if (ogrenci.OgrenciAd != "" && ogrenci.OgrenciSoyad != "" && ogrenci.OgrenciNo != "" && ogrenci.OgrenciSifre != "" && ogrenci.OgrenciCinsiyet != "")
            {

                return OgrenciDAL.ogrenciEkle(ogrenci);
            }

            else
                return -1;
        }


        //Girilen id 'ye  ait öğrenci DAL katmanı kullanılarak veri tabanından silindi
        public static int ogrenciSil(OgrenciVeri ogrenci)
        {
            if (ogrenci.OgrenciId != 0)
            {

                return OgrenciDAL.ogrenciSil(ogrenci);
            }

            else
                return -1;
        }

        //Girilen id 'ye  ait öğrenci DAL katmanı kullanılarak veri tabanındaki verileri güncellendi
        public static int ogrenciGuncelle(OgrenciVeri ogrenci)
        {
            if (ogrenci.OgrenciAd != "" && ogrenci.OgrenciSoyad != "" && ogrenci.OgrenciNo != "" && ogrenci.OgrenciSifre != "" && ogrenci.OgrenciCinsiyet != "" && ogrenci.OgrenciId != 0)
            {

                return OgrenciDAL.ogrenciGuncelle(ogrenci);
            }

            else
                return -1;
        }


        //Veri tabanındaki tüm öğrenci bilgileri DAL katmanı kullanılarak listeye aktarıldı
        public static List<OgrenciVeri> liste()
        {
           
            return OgrenciDAL.liste();
        }

        




    }
}
