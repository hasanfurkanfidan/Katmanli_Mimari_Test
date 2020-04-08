using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITYLAYER
{
    public class ENTITYNOTLAR
    {
        int _OGRID;
        int _s1;
        int _s2;
        int _s3;
        int _proje;
        double _ortalama;
        bool _durum;
        public int OGRID { get => _OGRID; set => _OGRID = value; }
        public int S1 { get => _s1; set => _s1 = value; }
        public int S2 { get => _s2; set => _s2 = value; }
        public int S3 { get => _s3; set => _s3 = value; }
        public int Proje { get => _proje; set => _proje = value; }
        public double Ortalama { get => _ortalama; set => _ortalama = value; }
        public bool Durum { get => _durum; set => _durum = value; }
    }
}
