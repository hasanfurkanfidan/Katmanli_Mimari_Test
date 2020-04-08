using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITYLAYER;
using FACADELAYER;
namespace BUSINESSLOGICLAYER
{
    public class BLLOGRENCII
    {
        public static int EKLE(ENTITYOGRENCI deger)
        {
            if(deger.AD !=null)
            {
                return FACADEOGRENCI.EKLE(deger);
            }
            return -1;
        }
        public static bool SIL(int deger)
        {
            if(deger !=null)
            {
                FACADEOGRENCI.SIL(deger);
            }
            return false;
        }
        public static bool GUNCELLE(ENTITYOGRENCI deger)
        {
            if(deger.AD !=null&&deger.ID!=null)
            {
                FACADEOGRENCI.GUNCELLE(deger);
            }
            return false;
        }
        public static List<ENTITYOGRENCI>LISTELE()
        {
            return FACADEOGRENCI.OGRENCILISTESI();
        }
    }
}
