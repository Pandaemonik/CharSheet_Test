using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Char_Generator
{
	public partial class charGenMain : Form
	{
		Character selectedCharacter;
		List<string> demeanores = new List<string>();

		public charGenMain()
		{
			InitializeComponent();
		}

		void exportCharacterToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FileIO.writeToFile("TextFiles\\" + selectedCharacter.name + "_JSON.json", FileIO.SerializeJSON(selectedCharacter));
			FileIO.writeToFile("TextFiles\\talents_JSON.json",FileIO.SerializeJSON(selectedCharacter.talents));
			FileIO.writeToFile("TextFiles\\skills_JSON.json",FileIO.SerializeJSON(selectedCharacter.skills));
			FileIO.writeToFile("TextFiles\\attributes_JSON.json",FileIO.SerializeJSON(selectedCharacter.aptitudes));
			FileIO.writeToFile("TextFiles\\aptitudes_JSON.json",FileIO.SerializeJSON(selectedCharacter.attributes));
		}

		void importCharacterToolStripMenuItem_Click(object sender, EventArgs e)
		{
			selectedCharacter = JsonConvert.DeserializeObject<Character>(FileIO.readJson("TextFiles\\Character_JSON.json"));
		}

		void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		void listBoxTalantDetails_SelectedIndexChanged(object sender, EventArgs e)
		{
			var curSelected = selectedCharacter.talents.Find(listBoxTalentDetails.Text);
			textBoxTalents.Text = curSelected.ToString();
		}

		void charGenMain_Shown(object sender, EventArgs e)
		{
			selectedCharacter = JsonConvert.DeserializeObject<Character>(FileIO.readJson("TextFiles\\Character_JSON.json"));
			listBoxTalentDetails.Items.AddRange(selectedCharacter.talents.getNames());
			textBoxRegiment.Text = selectedCharacter.regiment;
			textBoxSpecialty.Text = selectedCharacter.specialty;
			textBoxName.Text = selectedCharacter.name;
			textBoxDemeanor.Text = selectedCharacter.demeanour;
			textBoxDescription.Text = selectedCharacter.description;
			textBoxWounds.Text = selectedCharacter.wounds.ToString();
			textBoxXpLeft.Text = selectedCharacter.experienceLeft.ToString();
			textBoxXpSpent.Text = selectedCharacter.experienceSpent.ToString();
			textBoxSpecialRules.Text = selectedCharacter.getSpecialRules();
			textBoxAptitudes.Text = selectedCharacter.aptitudes.ToString();
			textBoxAttributes.Text = selectedCharacter.attributes.getDisplayed();
			textBoxSkills.Text = selectedCharacter.skills.getDisplayed();
	}

	void listBoxCharacters_SelectedIndexChanged(object sender, EventArgs e)
	{

	}

	void showSkills_Click(object sender, EventArgs e)
	{
		richTextBoxCurrentlyKnown.Text = string.Empty;
		richTextBoxCurrentlyKnown.Text += selectedCharacter.skills.ToString();
	}

	void showTalents_Click(object sender, EventArgs e)
	{
		richTextBoxCurrentlyKnown.Text = string.Empty;
		richTextBoxCurrentlyKnown.Text += selectedCharacter.talents.ToString();
	}

	void showAptitudes_Click(object sender, EventArgs e)
	{
		richTextBoxCurrentlyKnown.Text = string.Empty;
		richTextBoxCurrentlyKnown.Text += selectedCharacter.aptitudes.ToString();
	}

	void showAttributes_Click(object sender, EventArgs e)
	{
		richTextBoxCurrentlyKnown.Text = string.Empty;
		richTextBoxCurrentlyKnown.Text += selectedCharacter.attributes.ToString();
	}

	void showCharacter_Click(object sender, EventArgs e)
	{
		richTextBoxCurrentlyKnown.Text = string.Empty;
		richTextBoxCurrentlyKnown.Text += selectedCharacter + "\n";
	}

	void listBox1_SelectedIndexChanged(object sender, EventArgs e)
	{

	}

	void MenuItemCreateTalent_Click(object sender, EventArgs e)
	{

	}

	void MenuItemCreateCharacter_Click(object sender, EventArgs e)
	{

	}

	void MenuItemCreateRegiment_Click(object sender, EventArgs e)
	{

	}

	void charGenMain_Load(object sender, EventArgs e)
	{
		//Load Character
		//Load Demeanors
		//Load Regiment
		//Load Specialtyes
		//Load Talents
	}

	private void buttonSpendXp_Click(object sender, EventArgs e)
	{
		var xpSpender = new spendXpForm(selectedCharacter);
		xpSpender.Show();
		selectedCharacter = xpSpender.GetSelectedCharacter();
	}
}
}
