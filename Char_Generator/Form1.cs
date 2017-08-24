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
			selectedCharacter = JsonConvert.DeserializeObject<Character>(FileIO.readJson("TextFiles\\default_JSON.json"));
			refresh();
		}

		void refresh()
		{
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

		void MenuItemCreateCharacter_Click(object sender, EventArgs e)
		{
			 
		}

		void MenuItemCreateRegiment_Click(object sender, EventArgs e)
		{

		}

		void buttonSpendXp_Click(object sender, EventArgs e)
		{
			var xpSpender = new spendXpForm(selectedCharacter);
			xpSpender.ShowDialog();
			selectedCharacter = xpSpender.GetSelectedCharacter();
			refresh();
		}
	}
}
