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
	public partial class OgrenciListesi : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			List<EntitiyOgrenci> entitiyOgrencis = OgreciBll.OgrenciBlllistele();
			Repeater1.DataSource = entitiyOgrencis;
			Repeater1.DataBind();
		}
	}
}