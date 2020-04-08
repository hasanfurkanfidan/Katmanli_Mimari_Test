using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITYLAYER;
using FACADELAYER;
namespace BUSINESSLOGICLAYER
{
   public class BLLKULUP
    {
        public static int EKLE(ENTITYKULUP deger)
        {
            if(deger.KULUPAD!=null)
            {
                return FACADEKULUP.EKLE(deger);
            }
            return -1;
        }
        public static bool GUNCELLE(ENTITYKULUP deger)
        {
            if(deger.KULUPAD !=null&&deger.KULUPAD !=null)
            {
                return FACADEKULUP.GUNCELLE(deger);
            }
            return false;
        }
        public static bool SIL(int deger)
        {
            if(deger != null)
            {
                return FACADEKULUP.SIL(deger); 
            }
            return false;

        }
        public static List<ENTITYKULUP>LISTELE()
        {
            return FACADEKULUP.KULUPLISTESI();
        }
    }
}
