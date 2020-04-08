using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITYLAYER
{
    public class ENTITYOGRENCI
    {
        int _ID;
        string _AD;
        string _SOYAD;
        string _FOTOGRAF;
        int _KULUPID;

        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        public string AD
        {
            get { return _AD; }
            set { _AD = value; }
        }
        public string SOYAD
        {
            get { return _SOYAD; }
            set { _SOYAD = value; }
        }
        public string FOTOGRAF
        {
            get { return _FOTOGRAF; }
            set { _FOTOGRAF = value; }
        }
        public int KULUPID
        {
            get { return _KULUPID; }
            set { _KULUPID = value; }
        }


    }
}
