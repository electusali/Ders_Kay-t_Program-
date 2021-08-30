using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityLayer
{
	 public class EntityOgretmen
	 {
		 private int id;
		 private string AdSoyad;
		 private string Brans;

		 public int Id
		 {
			 get => id;
			 set => id = value;
		 }

		 public string ADSOYAD
		 {
			 get => AdSoyad;
			 set => AdSoyad = value;
		 }

		 public string BRANS
		 {
			 get => Brans;
			 set => Brans = value;
		 }
	 }
}
