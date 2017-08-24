using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Char_Generator
{
	public partial class charGenMain : Form
	{
		Character selectedCharacter;

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

			OpenFileDialog openFileDialog = new OpenFileDialog();
			String buffer = String.Empty;

			openFileDialog.InitialDirectory = "E:\\C#_Projects\\Char_Generator\\Char_Generator";
			openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
			openFileDialog.FilterIndex = 2;
			openFileDialog.RestoreDirectory = true;

			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				try
				{
					using (Stream myStream = openFileDialog.OpenFile())
					{
						if (myStream != null)
						{
							using (StreamReader csvFile = new StreamReader(myStream))
							{
								buffer = csvFile.ReadToEnd();
							}
						}
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error: Could not read file from disk. Original error: \n" + ex.Message);
				}
			}
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
			selectedCharacter = JsonConvert.DeserializeObject<Character>(FileIO.readJson("TextFiles\\Characters\\default_JSON.json"));
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
			textBoxCharacteristics.Text = selectedCharacter.characteristics.getDisplayed();
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

		void showCharacteristics_Click(object sender, EventArgs e)
		{
			richTextBoxCurrentlyKnown.Text = string.Empty;
			richTextBoxCurrentlyKnown.Text += selectedCharacter.characteristics.ToString();
		}

		void showCharacter_Click(object sender, EventArgs e)
		{
			richTextBoxCurrentlyKnown.Text = string.Empty;
			richTextBoxCurrentlyKnown.Text += selectedCharacter + "\n";
		}

		void MenuItemCreateCharacter_Click(object sender, EventArgs e)
		{

			var characterCreationWindow = new CreateCharacter(selectedCharacter);
			characterCreationWindow.Show();
			//Save character 
			//Load character 
			//Display
			//Regiment test = new Regiment();
			//List<Regiment> test2 = new List<Regiment>();
			//test2.Add(test);
			//test2.Add(test);
			//FileIO.writeToFile("TextFiles\\default_regiment_JSON.json", FileIO.SerializeJSON(test2));
		}

		void buttonSpendXp_Click(object sender, EventArgs e)
		{
			var xpSpendWindow = new spendXpForm(selectedCharacter);
			xpSpendWindow.ShowDialog();
			selectedCharacter = xpSpendWindow.GetSelectedCharacter();
			refresh();
		}
	}
}
