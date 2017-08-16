using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Char_Generator
{
	public class Aptitudes
	{
		public static List<string> available = new List<string>();
		public List<string> possessed = new List<string>();

		static Aptitudes()
		{
			available = FileIO.readCsv("TextFiles\\Aptitudes_CSV.csv");
		}

		public Aptitudes()
		{

		}

		public Aptitudes(string[] FILL_ME_UP)
		{

		}

		public string getAvailable()
		{
			string toBeReturned = "";
			foreach (string aptitude in available)
			{
				toBeReturned += aptitude + "\n";
			}
			return toBeReturned;
		}

		public string getPossesed()
		{
			string toBeReturned = "";
			foreach (string aptitude in possessed)
			{
				toBeReturned += aptitude + "\n";
			}
			return toBeReturned;
		}

	}
}
