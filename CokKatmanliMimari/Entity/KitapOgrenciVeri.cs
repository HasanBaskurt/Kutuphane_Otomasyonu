using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    //Kitap ve ogrenci için kullanılan ortak verilerini diğer katmanlarda kullanabilmek için get set işlemi yapıldı
    public class KitapOgrenciVeri
    {
        int kitapId;
        string ogrenciAd, ogrenciSoyad, kitapAd, kitapTeslim;
        DateTime kitapAlinma;
        bool kitapKontrol;

        
        public int KitapId { get => kitapId; set => kitapId = value; }
        public string OgrenciAd { get => ogrenciAd; set => ogrenciAd = value; }
        public string OgrenciSoyad { get => ogrenciSoyad; set => ogrenciSoyad = value; }
        public string KitapAd { get => kitapAd; set => kitapAd = value; }
        public DateTime KitapAlinma { get => kitapAlinma; set => kitapAlinma = value; }
        public string KitapTeslim { get => kitapTeslim; set => kitapTeslim = value; }
        public bool KitapKontrol { get => kitapKontrol; set => kitapKontrol = value; }

    }
}
