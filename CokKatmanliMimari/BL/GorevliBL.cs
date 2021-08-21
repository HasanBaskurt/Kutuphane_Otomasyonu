using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;      // DAL katmanını kullandık
using Entity;   // Entity katmanını kullandık

namespace BL
{
    public class GorevliBL
    {
        //Class'i public olarak tanımlamamızın sebebi diğer classlardan erişim sağlayabilmek için

        //Girilen tc ve sifreye ait görevli veri tabanında kayıtlı mı diye DAL katmanı kullanılarak kontrol edildi
        public static bool gorevliKontrol_BL(GorevliVeri gorevli)
        {
            if (gorevli.gorevTc != "" && gorevli.gorevSifre != "")
                return GorevliDAL.gorevliKontrol(gorevli);
            
            else
                return false;
        }
    }
}
