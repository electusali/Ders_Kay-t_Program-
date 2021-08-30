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
	public partial class Ogrenc : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			int x = Convert.ToInt32(Request.QueryString["Ogrid"]);
			Response.Write(x);

			EntitiyOgrenci entitiy = new EntitiyOgrenci();
			entitiy.ID = x;
			OgreciBll.OgrenciSilBll(entitiy.ID);
			Response.Redirect("OgrenciListesi.aspx");
		}
	}
}