using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityLayer
{
	public class BasvuruForm
	{
		private int _basvuruid;
		private int _ogrenciid;
		private int _dersid;

		public int Basvuruid
		{
			get => _basvuruid;
			set => _basvuruid = value;
		}

		public int Ogrenciid
		{
			get => _ogrenciid;
			set => _ogrenciid = value;
		}

		public int Dersid
		{
			get => _dersid;
			set => _dersid = value;
		}
	}
}
