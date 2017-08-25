using System;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;
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

		async void charGenMain_Shown(object sender, EventArgs e)
		{
			try
			{
				var client = new MongoClient("mongodb://localhost:27017");
				var database = client.GetDatabase("main");
				var collection = database.GetCollection<BsonDocument>("characters");
				var filter = Builders<BsonDocument>.Filter.Eq("_id", "default");
				var character = await collection.Find(filter).FirstAsync();
				selectedCharacter = JsonConvert.DeserializeObject<Character>(character.ToJson());
				refresh();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: Could not establish connection to DB(" + ex.Message + ") using default");
				selectedCharacter = JsonConvert.DeserializeObject<Character>(FileIO.readJson("TextFiles\\defaults\\default.character"));
				refresh();
			}
		}

		void exportCharacterToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FileIO.saveCharactertoJson(selectedCharacter);
		}

		void importCharacterToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				var characterFile = FileIO.openFile();
				if (characterFile != "NULL")
				{
					selectedCharacter = JsonConvert.DeserializeObject<Character>(FileIO.readCharacter(characterFile));
					refresh();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: While loading character. \n" + ex.Message + "\nWill load default");
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
			characterCreationWindow.ShowDialog();
			selectedCharacter = characterCreationWindow.getSelectedCharacter();
			refresh();
		}

		void buttonSpendXp_Click(object sender, EventArgs e)
		{
			var xpSpendWindow = new spendXpForm(selectedCharacter);
			xpSpendWindow.ShowDialog();
			selectedCharacter = xpSpendWindow.GetSelectedCharacter();
			refresh();
		}

		void addExpirienceToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var addExperienceWindow = new AddExperience(selectedCharacter);
			addExperienceWindow.ShowDialog();
			selectedCharacter = addExperienceWindow.getSelectedCharacter();
			refresh();
		}
	}
}
