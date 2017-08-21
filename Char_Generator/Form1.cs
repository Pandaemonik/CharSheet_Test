using System;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Char_Generator
{
	public partial class charGenMain : Form
	{

		Talents testTalents;
		Skills testSkills;
		Aptitudes testAptitudes;
		Attributes testAttributes;
		Character testCharacter;

		public charGenMain()
		{
			InitializeComponent();
		}

		void loadTalantsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//testTalents = new Talents();
			//testSkills = new Skills();
			MenuItemCreateRegiment.Enabled = true;
			MenuItemCreateCharacter.Enabled = true;
		}

		void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		void saveTalantsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			System.IO.File.WriteAllText(System.IO.Path.Combine(Environment.CurrentDirectory,
				"TextFiles\\Talents_XML(new).xml"), testTalents.SerializeXML());
		}

		void displayInDetailsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			listBoxTalantDetails.Items.AddRange(testSkills.getNames());
			listBoxTalantDetails.Items.AddRange(testTalents.getNames());
		}

		void displayInLabelToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBoxCurrentlyKnown.Text +=testTalents.ToString();
		}

		void listBoxTalantDetails_SelectedIndexChanged(object sender, EventArgs e)
		{
			var curSelected = testTalents.Find(listBoxTalantDetails.Text);
			richTextBoxName.Text = curSelected.Name;
			richTextBoxTier.Text = curSelected.Tier;
			richTextBoxAptitudes.Text = curSelected.primary + ", " + curSelected.secondary;
			richTextBoxPrerequisites.Text = curSelected.Prerequisites;
			richTextBoxBenefit.Text = curSelected.Benefit;
			richTextBoxDetails.Text = curSelected.Details;
		}

		void buttonSaveAsXml_Click(object sender, EventArgs e)
		{
			System.IO.File.WriteAllText(System.IO.Path.Combine(Environment.CurrentDirectory,
				"TextFiles\\Talents_XML(new).xml"), testTalents.SerializeXML());
		}

		void charGenMain_Shown(object sender, EventArgs e)
		{
			//testCharacter = new Character();
			testCharacter = JsonConvert.DeserializeObject<Character>(FileIO.readJson("TextFiles\\Character_JSON.json"));
			testTalents = testCharacter.talents;
			testSkills =  testCharacter.skills;
			testAptitudes =  testCharacter.aptitudes;
			testAttributes =  testCharacter.attributes;

			//listBoxTalantDetails.Items.AddRange(testTalents.getNames());
		}

		void listBoxCharacters_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		public void buttonSaveCharacterJson_Click(object sender, EventArgs e)
		{
			System.IO.File.WriteAllText(System.IO.Path.Combine(Environment.CurrentDirectory,
			"TextFiles\\Character_JSON(new).json"), testCharacter.SerializeJSON());
		}

		void showSkills_Click(object sender, EventArgs e)
		{
			richTextBoxCurrentlyKnown.Text = string.Empty;
			richTextBoxCurrentlyKnown.Text += testSkills.ToString();
		}

		void showTalents_Click(object sender, EventArgs e)
		{
			richTextBoxCurrentlyKnown.Text = string.Empty;
			richTextBoxCurrentlyKnown.Text += testTalents.ToString();
		}

		void showAptitudes_Click(object sender, EventArgs e)
		{
			richTextBoxCurrentlyKnown.Text = string.Empty;
			richTextBoxCurrentlyKnown.Text += testAptitudes.ToString();
		}

		void showAttributes_Click(object sender, EventArgs e)
		{
			richTextBoxCurrentlyKnown.Text = string.Empty;
			richTextBoxCurrentlyKnown.Text += testAttributes.ToString();
		}

		void showCharacter_Click(object sender, EventArgs e)
		{
			richTextBoxCurrentlyKnown.Text = string.Empty;
			richTextBoxCurrentlyKnown.Text += testCharacter + "\n";
		}

		void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}
