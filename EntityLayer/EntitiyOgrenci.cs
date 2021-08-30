using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityLayer
{
	
	public class EntitiyOgrenci
    {
	    private string ad;
	    private string soyad;
	    private int id;
	    private string numara;
	    private string fotoraf;
	    private double bakiye;
	    private string sifre;

	    public string AD
	    {
		    get => ad;
		    set => ad = value;
	    }

	    public string SOYAD
	    {
		    get => soyad;
		    set => soyad = value;
	    }

	    public int ID
	    {
		    get => id;
		    set => id = value;
	    }

	    public string NUMARA
	    {
		    get => numara;
		    set => numara = value;
	    }

	    public string FOTORAF
	    {
		    get => fotoraf;
		    set => fotoraf = value;
	    }

	    public double BAKİYE
	    {
		    get => bakiye;
		    set => bakiye = value;
	    }

	    public string SİFRE
	    {
		    get => sifre;
		    set => sifre = value;
	    }
    }
}
