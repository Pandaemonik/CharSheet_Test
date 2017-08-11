using System;
using System.Collections.Generic;

namespace Char_Generator
{
	public class Aptitudes
	{
		public static List<string> available = new List<string>();
		public List<string> possessed = new List<string>();

		static Aptitudes()
		{

		}

		public Aptitudes()
		{

		}

		public Aptitudes(string[])
		{

		}

		public override string ToString()
		{
			return string.Format("[Aptitudes]");
		}
	}
}
