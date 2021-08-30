using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataSetLayer;
using BusinessLogicLayer;



namespace AdminPanel
{
	public partial class OgrenciGuncellme : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			int x = Convert.ToInt32(Request.QueryString["Ogrid"]);
			txtid.Text = x.ToString();		
			txtid.Enabled = false;

			EntitiyOgrenci ogr = new EntitiyOgrenci();
			List<EntitiyOgrenci> ogrlist = OgreciBll.OgrenciBllGuncelle(x);
			txtad.Text = ogrlist[1].AD.ToString();
			txtSoyad.Text = ogrlist[2].SOYAD.ToString();
			txtFoto.Text = ogrlist[3].FOTORAF.ToString();
			txtSifre.Text = ogrlist[4].SİFRE.ToString();
			txtNumara.Text = ogrlist[5].NUMARA.ToString();
			

		}
	}
}