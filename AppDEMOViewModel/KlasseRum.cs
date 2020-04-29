using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDEMOViewModel
{
    public class KlasseRum
    {
		private string _navn;

		public string Navn
		{
			get { return _navn; }
			set { _navn = value; }
		}

		private int _id;

		public int ID
		{
			get { return _id; }
			set { _id = value; }
		}

		public KlasseRum()
		{

		}

		public override string ToString()
		{
			return $"klasse:{Navn}, id {ID} ";
		}

	}
}
