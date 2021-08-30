using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityLayer
{
	public class EntityDers
	{
		private string DersAd;
		private string dersmin;
		private string dersmax;
		private int id;

		public string DERSAD
		{
			get => DersAd;
			set => DersAd = value;
		}

		public string DERSMIN
		{
			get => dersmin;
			set => dersmin = value;
		}

		public string DERSMAX
		{
			get => dersmax;
			set => dersmax = value;
		}

		public int Id
		{
			get => id;
			set => id = value;
		}
	}
}
