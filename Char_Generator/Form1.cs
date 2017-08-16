using System;
using System.Windows.Forms;

namespace Char_Generator
{
	public partial class charGenMain : Form
	{
		Talents testTalents;
		Skills testSkills;
		Aptitudes testAptitudes;

		public charGenMain()
		{
			InitializeComponent();
		}

		private void loadTalantsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			testTalents = new Talents();
			testSkills = new Skills();
			displayInDetailsToolStripMenuItem.Enabled = true;
			displayInLabelToolStripMenuItem.Enabled = true;
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void saveTalantsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			System.IO.File.WriteAllText(System.IO.Path.Combine(Environment.CurrentDirectory,
				"TextFiles\\Talents_XML(new).xml"), testTalents.SerializeXML());
		}

		private void displayInDetailsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			testSkills.SkillList.ForEach(x => listBoxTalantDetails.Items.Add(x.name));
			testTalents.TalentList.ForEach(x => listBoxTalantDetails.Items.Add(x.Name));
		}

		private void displayInLabelToolStripMenuItem_Click(object sender, EventArgs e)
		{
			testTalents.TalentList.ForEach(x => richTextBoxCurrentlyKnown.Text += x.ToString() + "\n");
		}

		private void listBoxTalantDetails_SelectedIndexChanged(object sender, EventArgs e)
		{
			Talent curSelected = testTalents.Find(listBoxTalantDetails.Text);
			richTextBoxName.Text = curSelected.Name;
			richTextBoxTier.Text = curSelected.Tier;
			richTextBoxAptitudes.Text = curSelected.primary + ", " + curSelected.secondary;
			richTextBoxPrerequisites.Text = curSelected.Prerequisites;
			richTextBoxBenefit.Text = curSelected.Benefit;
			richTextBoxDetails.Text = curSelected.Details;
		}

		private void buttonSaveAsXml_Click(object sender, EventArgs e)
		{
			System.IO.File.WriteAllText(System.IO.Path.Combine(Environment.CurrentDirectory,
				"TextFiles\\Talents_XML(new).xml"), testTalents.SerializeXML());
		}

		private void buttonSaveAsJson_Click(object sender, EventArgs e)
		{
			System.IO.File.WriteAllText(System.IO.Path.Combine(Environment.CurrentDirectory,
				"TextFiles\\Talents_JSON(new).json"), testTalents.SerializeJSON());
		}

		private void charGenMain_Shown(object sender, EventArgs e)
		{
			testTalents = new Talents();
			testSkills = new Skills();
			testAptitudes = new Aptitudes();
			richTextBoxCurrentlyKnown.Text = testAptitudes.ToString();
			//testSkills.SkillList.ForEach(x => richTextBoxCurrentlyKnown.Text += x + "\n");
			//testTalents.TalentList.ForEach(x => listBoxTalantDetails.Items.Add(x.Name));
			//testTalents.TalentList.ForEach(x => richTextBoxCurrentlyKnown.Text += x.ToString() + "\n");
		}
	}
}
