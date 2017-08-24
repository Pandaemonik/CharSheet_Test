using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Char_Generator
{
	public partial class CreateCharacter : Form
	{
		List<Regiment> regiments = new List<Regiment>();
		List<Specialty> specialtyes = new List<Specialty>();
		Dictionary<string, string> demeanors = new Dictionary<string, string>();
		Character selectedCharacter;
		Character newCharacter;
		Random tenSidedDie = new Random();

		public CreateCharacter(Character selectedCharacter)
		{
			InitializeComponent();
			List<string> demeanorsTemp = new List<string>();
			this.selectedCharacter = selectedCharacter;

			newCharacter = new Character();
			regiments = JsonConvert.DeserializeObject<List<Regiment>>(FileIO.readJson("TextFiles\\data\\default_regiment.json"));
			demeanorsTemp = JsonConvert.DeserializeObject<List<string>>(FileIO.readJson("TextFiles\\data\\default_demeanors.json"));
			foreach (string demeanor in demeanorsTemp)
			{
				var parsed = parseDemeanorName(demeanor);
				demeanors.Add(parsed[0], parsed[1]);
			}

			//TODO Load Specialties
		}

		public Character getSelectedCharacter()
		{
			return selectedCharacter;
		}

		void CreateCharacter_Load(object sender, EventArgs e)
		{
			listBoxRegiment.Items.AddRange(validateRegiment());
			listBoxDemeanor.Items.AddRange(validateDemeanors());
			//TODO display specialty in listbox
			textBoxWeaponSkill.Text = getCharacteristicRoll().ToString();
			textBoxBallisticSkill.Text = getCharacteristicRoll().ToString();
			textBoxStrenght.Text = getCharacteristicRoll().ToString();
			textBoxToughness.Text = getCharacteristicRoll().ToString();
			textBoxAgility.Text = getCharacteristicRoll().ToString();
			textBoxIntelligence.Text = getCharacteristicRoll().ToString();
			textBoxPerception.Text = getCharacteristicRoll().ToString();
			textBoxWillpower.Text = getCharacteristicRoll().ToString();
			textBoxFellowship.Text = getCharacteristicRoll().ToString();
			buttonCreate.Enabled = checkCreateButtonEnabled();
		}

		string[] validateRegiment()
		{
			List<string> toBeReturned = new List<string>();
			foreach (Regiment singleRegiment in regiments)
			{
				toBeReturned.Add(singleRegiment.name);
			}
			if (toBeReturned.Count == 0)
			{
				toBeReturned.Add("No Regiments available");
			}
			return toBeReturned.ToArray(); ;
		}

		string[] validateSpecialty()
		{
			List<string> toBeReturned = new List<string>();
			foreach (Specialty singleSpecialty in specialtyes)
			{
				toBeReturned.Add(singleSpecialty.name);
			}

			if (toBeReturned.Count == 0)
			{
				toBeReturned.Add("No specialty available");
			}

			return toBeReturned.ToArray(); ;
		}

		string[] validateDemeanors()
		{
			List<string> toBeReturned = new List<string>();
			var keys = demeanors.Keys;

			foreach (string key in keys)
			{
				toBeReturned.Add(key);

			}
			if (toBeReturned.Count == 0)
			{
				toBeReturned.Add("No talents available");
			}
			return toBeReturned.ToArray();
		}
		bool checkCreateButtonEnabled()
		{
			if (listBoxDemeanor.SelectedIndex != -1 && listBoxRegiment.SelectedIndex != -1
				&& listBoxSpecialty.SelectedIndex != -1 && textBoxName.Text != string.Empty)
			{ return true; }
			return false;

		}
		void buttonCancel_Click(object sender, EventArgs e)
		{
			Hide();
		}

		void buttonCreate_Click(object sender, EventArgs e)
		{
			//TODO Load regiment parts to newCharacter
			//TODO Load specialty info to newCharacter
			//TODO Load demeanor info to newCharacter
			//TODO Load name to newCharacter
			//TODO Load Details to newCharacter
			//TODO Save selected Character
			//TODO Assign newCharacter to selectedCharacter
			Hide();
		}

		void listBoxRegiment_SelectedIndexChanged(object sender, EventArgs e)
		{
			var toBeDisplayed = regiments.Find(x => x.name.Trim() == listBoxRegiment.Text.Trim());
			textBoxRegiment.Text = toBeDisplayed.ToString();
			buttonCreate.Enabled = checkCreateButtonEnabled();
		}

		void listBoxSpecialty_SelectedIndexChanged(object sender, EventArgs e)
		{
			//TODO Display specialty.toString() in textBoxSpecialty
		}

		void listBoxDemeanor_SelectedIndexChanged(object sender, EventArgs e)
		{
			textBoxDemeanor.Text = demeanors[listBoxDemeanor.Text];
			buttonCreate.Enabled = checkCreateButtonEnabled();
		}

		void verifyCharacteristicIsDigit(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		string[] parseDemeanorName(string toBeParsed)
		{
			List<string> parsed = new List<string>();
			var startIndex = toBeParsed.IndexOf('-');
			var name = toBeParsed.Substring(0, startIndex);
			var length = toBeParsed.Length - startIndex - 1;
			var description = toBeParsed.Substring(startIndex + 1, length);

			parsed.Add(name.Trim());
			parsed.Add(description.Trim());
			return parsed.ToArray();
		}

		int getCharacteristicRoll()
		{
			int rollOne = tenSidedDie.Next(1, 11);
			int rollTwo = tenSidedDie.Next(1, 11);
			return rollOne + rollTwo + 20;
		}
	}
}
