using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace DataSetLayer
{
    public class Baglanti
	{
		public static SqlConnection bgl=new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Db_Yaz_Okul;Integrated Security=True");
    }
}
