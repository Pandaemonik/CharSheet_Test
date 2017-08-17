using System;
using System.Windows.Forms;

namespace Char_Generator
{
	public partial class charGenMain : Form
	{

		Talents testTalents;//TODO Add ToString Overload
		Skills testSkills;//TODO Add ToString Overload
		Aptitudes testAptitudes;//TODO Add ToString Overload
		Attributes testAttributes;//TODO Add ToString Overload
		Character testCharacter;

		public charGenMain()
		{
			InitializeComponent();
		}

		void loadTalantsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			testTalents = new Talents();
			testSkills = new Skills();
			displayInDetailsToolStripMenuItem.Enabled = true;
			displayInLabelToolStripMenuItem.Enabled = true;
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
			testSkills.SkillList.ForEach(x => listBoxTalantDetails.Items.Add(x.name));
			testTalents.TalentList.ForEach(x => listBoxTalantDetails.Items.Add(x.Name));
		}

		void displayInLabelToolStripMenuItem_Click(object sender, EventArgs e)
		{
			testTalents.TalentList.ForEach(x => richTextBoxCurrentlyKnown.Text += x + "\n");
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

		void buttonSaveAsJson_Click(object sender, EventArgs e)
		{
			System.IO.File.WriteAllText(System.IO.Path.Combine(Environment.CurrentDirectory,
				"TextFiles\\Talents_JSON(new).json"), testTalents.SerializeJSON());
		}

		void charGenMain_Shown(object sender, EventArgs e)
		{
			testTalents = new Talents();
			testSkills = new Skills();
			testAptitudes = new Aptitudes("Agility");
			testAttributes = new Attributes();
			testCharacter = new Character();

			//testAptitudes
			//testAptitudes.Add("General");
			//richTextBoxCurrentlyKnown.Text = testAptitudes.GetPossesed();

			//testSkills
			//testSkills.SkillList.ForEach(x => richTextBoxCurrentlyKnown.Text += x + "\n");

			//testTalents
			//testTalents.TalentList.ForEach(x => listBoxTalantDetails.Items.Add(x.Name));
			//testTalents.TalentList.ForEach(x => richTextBoxCurrentlyKnown.Text += x.ToString() + "\n");

			//testAttributes
			//testAttributes.AttributeList.ForEach(x => richTextBoxCurrentlyKnown.Text += x.ToString() + "\n");

			//testCharacter
			richTextBoxCurrentlyKnown.Text += testCharacter + "\n";
		}

		void listBoxCharacters_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		public void buttonSaveCharacterJson_Click(object sender, EventArgs e)
		{
			System.IO.File.WriteAllText(System.IO.Path.Combine(Environment.CurrentDirectory,
			"TextFiles\\Character_JSON(new).json"), testCharacter.SerializeJSON());
		}


	}
}
