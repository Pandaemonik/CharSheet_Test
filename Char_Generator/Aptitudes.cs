using System.Collections.Generic;
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
			try
			{
				available = JsonConvert.DeserializeObject<List<string>>(FileIO.readJson("TextFiles\\data\\default_aptitudes.json"));
			}
			catch
			{
				available.Add("General");
				available.Add("Offence");
				available.Add("Finesse");
				available.Add("Defence");
				available.Add("Psyker");
				available.Add("Knowledge");
				available.Add("Leadership");
				available.Add("Fieldcraft");
				available.Add("Social");
				available.Add("Weapon Skill");
				available.Add("Ballistic Skill");
				available.Add("Strength");
				available.Add("Toughness");
				available.Add("Agility");
				available.Add("Intelligence");
				available.Add("Perception");
				available.Add("Willpower");
				available.Add("Fellowship");
			}
		}

		public static bool CheckAvailable(string toBeChecked)
		{
			if (available.Contains(toBeChecked))
				return true;
			return false;
		}

		public bool checkPossesed(string toBeChecked)
		{
			if (possessed.Contains(toBeChecked))
				return true;
			return false; ;
		}

		[JsonConstructor]
		public Aptitudes() { }

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

		public override string ToString()
		{
			var toBeReturned = string.Empty;
			possessed.ForEach(x => toBeReturned += x + "\n");
			return toBeReturned;
		}

		public string[] getNames()
		{
			var toBeReturned = new List<string>();
			possessed.ForEach(x => toBeReturned.Add(x));
			return toBeReturned.ToArray();
		}
	}
}
