using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITYLAYER;
using FACADELAYER;

namespace BUSINESSLOGICLAYER
{
    class BLLNOTLAR
    {
        public static bool GUNCELLE(ENTITYNOTLAR deger)
        {
            if(deger.OGRID!=null&&deger.Ortalama!=null&&deger.Ortalama!=null&&deger.Proje!=null&&deger.S1!=null&&deger.S2!=null&&deger.S3!=null&&deger.OGRID>=0&&deger.Ortalama>=0&&deger.S1>=0&&deger.S2>=0&&deger.S3>=0&&deger.Ortalama<=100&&deger.Proje>=0&&deger.Proje<=100&&deger.S1<=100&&deger.S2<=100&&deger.S3<=100)
            {
                return FACADENOTLAR.GUNCELLE(deger);
            }
            return false;
        }
        public static List<ENTITYNOTLAR>LISTELE()
        {
            return FACADENOTLAR.NOTLISTELE();
        }
    }
}
