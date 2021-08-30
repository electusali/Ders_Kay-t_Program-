using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using EntityLayer;

namespace DataSetLayer
{
	public class OgrenciDal
	{
		public static int OgrenciEkle(EntitiyOgrenci parametre)
		{
			SqlCommand komut=new SqlCommand("Insert into Tbl_Ogrenci (ograd,ogrsoyad,ogrnumara,ogrfoto,ogrsifre) values(@p1,@p2,@p3,@p4,@p5)",Baglanti.bgl);
			if (komut.Connection.State!=ConnectionState.Open)
			{
				komut.Connection.Open();
			}

			komut.Parameters.AddWithValue("@p1", parametre.AD);
			komut.Parameters.AddWithValue("@p2", parametre.SOYAD);
			komut.Parameters.AddWithValue("@p3", parametre.NUMARA);
			komut.Parameters.AddWithValue("@p4", parametre.FOTORAF);
			komut.Parameters.AddWithValue("@p5", parametre.SİFRE);
			return komut.ExecuteNonQuery();
		
		}
		
		public static List<EntitiyOgrenci> OgrenciListleme()
		{
			
			List<EntitiyOgrenci> deger = new List<EntitiyOgrenci>();

			SqlCommand komut2 = new SqlCommand("Select* from Tbl_Ogrenci", Baglanti.bgl);
			
			if (komut2.Connection.State != ConnectionState.Open)
			{
				komut2.Connection.Open();
			}
			SqlDataReader sql = komut2.ExecuteReader();
			while (sql.Read())
			{
				EntitiyOgrenci ogr = new EntitiyOgrenci();
				ogr.ID = Convert.ToInt32(sql["Ogrid"].ToString());
				ogr.AD = sql["OgrAd"].ToString();
				ogr.SOYAD = sql["OgrSoyad"].ToString();
				ogr.NUMARA = sql["OgrNumara"].ToString();
				ogr.FOTORAF = sql["OgrFoto"].ToString();
				ogr.SİFRE = sql["OgrSifre"].ToString();
				ogr.BAKİYE = Convert.ToDouble(sql["OgrBakiye"].ToString());
				deger.Add(ogr);
			}
			Baglanti.bgl.Close();
			sql.Close();
			return deger;

		}
		public static bool OgrenciSil(int parametere)
		{
			SqlCommand komut4 = new SqlCommand("Delete from Tbl_Ogrenci where Ogrid=@p1", Baglanti.bgl);
			if (komut4.Connection.State != ConnectionState.Open)
			{
				komut4.Connection.Open();
			}
			komut4.Parameters.AddWithValue("@p1", parametere);

			return komut4.ExecuteNonQuery() > 0;

			Baglanti.bgl.Close();
		}
		public static List<EntitiyOgrenci> OgrenciGuncelleme(int id)
		{

			List<EntitiyOgrenci> deger = new List<EntitiyOgrenci>();

			SqlCommand komut5 = new SqlCommand("Select* from Tbl_Ogrenci where Ogrid=@p2", Baglanti.bgl);
			komut5.Parameters.AddWithValue("@p2", id);
			if (komut5.Connection.State != ConnectionState.Open)
			{
				komut5.Connection.Open();
			}
			SqlDataReader sql = komut5.ExecuteReader();
			while (sql.Read())
			{
				EntitiyOgrenci ogr = new EntitiyOgrenci();
				ogr.AD = sql["OgrAd"].ToString();
				ogr.SOYAD = sql["OgrSoyad"].ToString();
				ogr.NUMARA = sql["OgrNumara"].ToString();
				ogr.FOTORAF = sql["OgrFoto"].ToString();
				ogr.SİFRE = sql["OgrSifre"].ToString();
				ogr.BAKİYE = Convert.ToDouble(sql["OgrBakiye"].ToString());
				deger.Add(ogr);
			}
			Baglanti.bgl.Close();
			sql.Close();
			return deger;

		}
	}
}
