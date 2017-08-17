﻿using System.Collections.Generic;
using System.Windows.Forms;
using Newtonsoft.Json;

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

		public Aptitudes(string toBeAdded)
		{
			if (available.Contains(toBeAdded))
			{
				possessed.Add(toBeAdded);
			}
			else
			{
				MessageBox.Show("Error: Failed to insert aptitude.\nReason: Aptitude \"" + toBeAdded + "\" not found.");
			}
		}

		public Aptitudes(string[] arrayToBeAdded)
		{
			foreach (string toBeAdded in arrayToBeAdded)
			{
				if (available.Contains(toBeAdded))
				{
					possessed.Add(toBeAdded);
				}
				else
				{
					MessageBox.Show("Error: Failed to insert aptitude.\nReason: Aptitude \"" + toBeAdded + "\" not found.");
				}

			}
		}

		public string GetAvailable()
		{
			string toBeReturned = "";
			foreach (string aptitude in available)
			{
				toBeReturned += aptitude + "\n";
			}
			return toBeReturned;
		}

		public string GetPossesed()
		{
			string toBeReturned = "";
			foreach (string aptitude in possessed)
			{
				toBeReturned += aptitude + "\n";
			}
			return toBeReturned;
		}

		public void Add(string toBeAdded)
		{
			if (available.Contains(toBeAdded))
			{
				possessed.Add(toBeAdded);
			}
			else
			{
				MessageBox.Show("Error: Failed to insert aptitude.\nReason: Aptitude \"" + toBeAdded + "\" not found.");
			}
		}

		public static bool CheckAvailable(string toBeChecked)
		{
			if (toBeChecked == "1")
				return true;
			return false;
		}

		public string SerializeJSON()
		{
			var json = JsonConvert.SerializeObject(this, Formatting.Indented);
			return json;
		}
	}
}
