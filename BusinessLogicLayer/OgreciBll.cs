using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntityLayer;
using DataSetLayer;
namespace BusinessLogicLayer
{
    public class OgreciBll
    {
	    public static int OgrenciEkle(EntitiyOgrenci pr)
	    {
		    if (pr.AD!=null && pr.SOYAD!=null && pr.FOTORAF!=null && pr.NUMARA!=null && pr.SİFRE!=null)
		    {
			    return OgrenciDal.OgrenciEkle(pr);
		    }

		    return -1;
	    }
		public static List<EntitiyOgrenci> OgrenciBlllistele()
		{
			return OgrenciDal.OgrenciListleme();
		}
		public static bool OgrenciSilBll(int id)
		{
			if (id!=null)
			{
				return OgrenciDal.OgrenciSil(id);
			}
			return false;
		}
		public static List<EntitiyOgrenci> OgrenciBllGuncelle(int id)
		{
			return OgrenciDal.OgrenciGuncelleme(id);
		}
	}
}
