using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataSetLayer;
using AdminPanel;
using BusinessLogicLayer;

namespace AdminPanel
{
	public partial class Adminformpanel : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void Button1_Click(object sender, EventArgs e)
		{
			
		}

		protected void Button2_Click(object sender, EventArgs e)
		{
			
		}

		protected void Button2_Click1(object sender, EventArgs e)
		{
		
		}

		protected void Button1_Click1(object sender, EventArgs e)
		{
			EntitiyOgrenci ogr = new EntitiyOgrenci();
			ogr.AD = txtAd.Text;
			ogr.SOYAD = txtSoyad.Text;
			ogr.FOTORAF = txtFoto.Text;
			ogr.NUMARA = txtNumara.Text;
			ogr.SİFRE = txtSifre.Text;
			OgreciBll.OgrenciEkle(ogr);
		
		}
	}
}