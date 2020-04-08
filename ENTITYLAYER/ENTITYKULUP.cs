using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITYLAYER
{
   public class ENTITYKULUP
    {
        int _KULUPID;
        string _KULUPAD;

        public int KULUPID
        {
            get { return _KULUPID; }
            set { _KULUPID = value; }
        }
        public string KULUPAD
        {
            get { return _KULUPAD; }
            set { _KULUPAD = value; }
        }
    }
}
