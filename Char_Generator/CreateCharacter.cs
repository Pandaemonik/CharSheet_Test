using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;
using Newtonsoft.Json;

namespace Char_Generator
{
	public partial class CreateCharacter : Form
	{
		List<Regiment> regiments = new List<Regiment>();
		List<Specialty> specialties = new List<Specialty>();
		Dictionary<string, string> demeanors = new Dictionary<string, string>();
		Character selectedCharacter;
		Character newCharacter;
		DiceRoller diceRoller = new DiceRoller();

		public CreateCharacter(Character selectedCharacter)
		{
			InitializeComponent();
			this.selectedCharacter = selectedCharacter;
			newCharacter = new Character();
		}

		public Character getSelectedCharacter()
		{
			return selectedCharacter;
		}

		async void CreateCharacter_Shown(object sender, EventArgs e)
		{
			try
			{
				var client = new MongoClient("mongodb://localhost:27017");

				var database = client.GetDatabase("main");
				var collectionRegiments = database.GetCollection<BsonDocument>("regiment");
				var collectionSpecialties = database.GetCollection<BsonDocument>("specialties");
				await collectionSpecialties.Find(new BsonDocument()).ForEachAsync(x => specialties.Add(
																JsonConvert.DeserializeObject<Specialty>(x.ToJson())));
				await collectionRegiments.Find(new BsonDocument()).ForEachAsync(x => regiments.Add(
												JsonConvert.DeserializeObject<Regiment>(x.ToJson())));
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: Could not establish connection to DB(" + ex.Message + ") using default");
				regiments = JsonConvert.DeserializeObject<List<Regiment>>(FileIO.readJson("TextFiles\\defaults\\default.regiment"));
				specialties = JsonConvert.DeserializeObject<List<Specialty>>(FileIO.readJson("TextFiles\\defaults\\default.specialties"));
			}

			var demeanorsTemp = new List<string>();
			demeanorsTemp = JsonConvert.DeserializeObject<List<string>>(FileIO.readJson("TextFiles\\defaults\\default.demeanors"));
			string[] parsed = new string[2];
			foreach (string demeanor in demeanorsTemp)
			{
				parsed = parseDemeanorName(demeanor);
				demeanors.Add(parsed[0], parsed[1]);
			}
			listBoxRegiment.Items.AddRange(validateRegiment());
			listBoxDemeanor.Items.AddRange(validateDemeanors());
			listBoxSpecialty.Items.AddRange(validateSpecialty());
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
			var toBeReturned = new List<string>();
			foreach (Regiment singleRegiment in regiments)
			{
				toBeReturned.Add(singleRegiment.name);
			}
			if (toBeReturned.Count == 0)
			{
				toBeReturned.Add("No Regiments available");
			}
			return toBeReturned.ToArray();
		}

		string[] validateSpecialty()
		{
			var toBeReturned = new List<string>();
			foreach (Specialty singleSpecialty in specialties)
			{
				toBeReturned.Add(singleSpecialty.name);
			}

			if (toBeReturned.Count == 0)
			{
				toBeReturned.Add("No specialty available");
			}

			return toBeReturned.ToArray();
		}

		string[] validateDemeanors()
		{
			var toBeReturned = new List<string>();
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
			newCharacter.regiment = listBoxRegiment.Text.Trim();
			newCharacter.specialty = listBoxSpecialty.Text.Trim();
			newCharacter.name = textBoxName.Text.Trim();
			newCharacter.demeanour = listBoxDemeanor.Text.Trim() + " - " + textBoxDemeanor.Text.Trim();
			newCharacter.description = textBoxDescription.Text;
			newCharacter.experienceSpent = 0;
			newCharacter.experienceLeft = 600;
			var selectedSpecialty = specialties.Find(x => x.name.Trim() == listBoxSpecialty.Text.Trim());
			var selectedRegiment = regiments.Find(x => x.name.Trim() == listBoxRegiment.Text.Trim());
			assignSkills(selectedSpecialty, selectedRegiment);
			assignWounds(selectedSpecialty, selectedRegiment);
			assignSpecialRules(selectedSpecialty, selectedRegiment);
			assignTalents(selectedSpecialty, selectedRegiment);
			assignAptitudes(selectedSpecialty, selectedRegiment);
			assignCharacteristics(selectedSpecialty, selectedRegiment);
			FileIO.saveCharactertoJson(selectedCharacter);
			selectedCharacter = newCharacter;
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
			var toBeDisplayed = specialties.Find(x => x.name.Trim() == listBoxSpecialty.Text.Trim());
			textBoxSpecialty.Text = toBeDisplayed.ToString();
			buttonCreate.Enabled = checkCreateButtonEnabled();
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
			var parsed = new List<string>();
			var startIndex = toBeParsed.IndexOf(':');
			var name = toBeParsed.Substring(0, startIndex);
			var length = toBeParsed.Length - startIndex - 1;
			var description = toBeParsed.Substring(startIndex + 1, length);

			parsed.Add(name.Trim());
			parsed.Add(description.Trim());
			return parsed.ToArray();
		}

		int getCharacteristicRoll()
		{
			var characteristicRoll = diceRoller.RollDice("2d10+20");
			return characteristicRoll;
		}

		void textBoxName_TextChanged(object sender, EventArgs e)
		{
			buttonCreate.Enabled = checkCreateButtonEnabled();
		}

		void assignSkills(Specialty selectedSpecialty, Regiment selectedRegiment)
		{
			selectedRegiment.skills.skill.ForEach(newCharacter.skills.Add);
			selectedSpecialty.skills.skill.ForEach(newCharacter.skills.Add);
		}

		void assignCharacteristics(Specialty selectedSpecialty, Regiment selectedRegiment)
		{
			selectedSpecialty.characteristics.characteristic.ForEach(newCharacter.characteristics.Add);
			selectedRegiment.characteristics.characteristic.ForEach((x => newCharacter.characteristics.addValue(x.Name, x.Value)));
			newCharacter.characteristics.addValue("Weapon Skill", int.Parse(textBoxWeaponSkill.Text));
			newCharacter.characteristics.addValue("Ballistic Skill", int.Parse(textBoxBallisticSkill.Text));
			newCharacter.characteristics.addValue("Strength", int.Parse(textBoxStrenght.Text));
			newCharacter.characteristics.addValue("Toughness", int.Parse(textBoxToughness.Text));
			newCharacter.characteristics.addValue("Agility", int.Parse(textBoxAgility.Text));
			newCharacter.characteristics.addValue("Intelligence", int.Parse(textBoxIntelligence.Text));
			newCharacter.characteristics.addValue("Perception", int.Parse(textBoxPerception.Text));
			newCharacter.characteristics.addValue("Willpower", int.Parse(textBoxWillpower.Text));
			newCharacter.characteristics.addValue("Fellowship", int.Parse(textBoxFellowship.Text));
		}

		void assignTalents(Specialty selectedSpecialty, Regiment selectedRegiment)
		{
			selectedRegiment.talents.talent.ForEach(newCharacter.talents.Add);
			selectedSpecialty.talents.talent.ForEach(newCharacter.talents.Add);
		}

		void assignAptitudes(Specialty selectedSpecialty, Regiment selectedRegiment)
		{
			selectedRegiment.aptitides.possessed.ForEach(newCharacter.aptitudes.Add);
			selectedSpecialty.aptitides.possessed.ForEach(newCharacter.aptitudes.Add);
		}

		void assignSpecialRules(Specialty selectedSpecialty, Regiment selectedRegiment)
		{
			selectedRegiment.specialRules.ForEach(newCharacter.specialRules.Add);
			selectedSpecialty.specialRules.ForEach(newCharacter.specialRules.Add);
		}

		void assignWounds(Specialty selectedSpecialty, Regiment selectedRegiment)
		{
			newCharacter.wounds = selectedRegiment.wounds + selectedSpecialty.wounds + diceRoller.RollDice("1d5") ;
		}

	}
}
