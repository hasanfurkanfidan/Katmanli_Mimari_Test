using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITYLAYER;
using System.Data.SqlClient;
using System.Data;
namespace FACADELAYER
{
     public class FACADENOTLAR
    {
        public static bool GUNCELLE(ENTITYNOTLAR deger)
        {
            SqlCommand komut = new SqlCommand("NOTGUNCELLE", SQLBAGLANTISI.baglanti);
            komut.CommandType = CommandType.StoredProcedure;
           if(komut.Connection.State !=ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("OGRID", deger.OGRID);
            komut.Parameters.AddWithValue("SINAV1", deger.S1);
            komut.Parameters.AddWithValue("SINAV2", deger.S2);
            komut.Parameters.AddWithValue("SINAV3", deger.S3);
            komut.Parameters.AddWithValue("SINAV4", deger.Ortalama);
            komut.Parameters.AddWithValue("DURUM", deger.Durum);
            return komut.ExecuteNonQuery()> 0;
        }
        public static List<ENTITYNOTLAR> NOTLISTELE()
        {
            List<ENTITYNOTLAR> degerler = new List<ENTITYNOTLAR>();
            SqlCommand komut = new SqlCommand("NOTLISTESI", SQLBAGLANTISI.baglanti);
            komut.CommandType = CommandType.StoredProcedure;

            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                ENTITYNOTLAR ent = new ENTITYNOTLAR();
                ent.S1 = Convert.ToInt32(dr["SINAV1"]);
                ent.S2 = Convert.ToInt32(dr["SINAV2"]);
                ent.S3 = Convert.ToInt32(dr["SINAV3"]);
                ent.Ortalama = Convert.ToInt32(dr["ORTALAMA"]);
                ent.Durum = Convert.ToBoolean(dr["DURUM"]);

                degerler.Add(ent);



            }
            dr.Close();
            return degerler;
        }
        
    }
}
