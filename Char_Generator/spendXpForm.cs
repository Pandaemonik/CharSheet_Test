using System.Collections.Generic;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Char_Generator
{
	public partial class spendXpForm : Form
	{
		Character selectedCharacter;
		Character tempCharacter;
		Talents availableTalents;
		Skills availableSkills;

		public spendXpForm(Character selectedCharacter)
		{
			InitializeComponent();
			this.selectedCharacter = selectedCharacter;
			tempCharacter = selectedCharacter;
			availableTalents = JsonConvert.DeserializeObject<Talents>(FileIO.readJson("TextFiles\\talents_JSON.json"));
			availableSkills = JsonConvert.DeserializeObject<Skills>(FileIO.readJson("TextFiles\\skills_JSON.json"));
		}

		public Character GetSelectedCharacter()
		{
			return selectedCharacter;
		}

		void spendXpForm_Load(object sender, System.EventArgs e)
		{
			textBoxAvailableXp.Text = tempCharacter.experienceLeft.ToString();
			listBoxTalents.Items.AddRange(validateTalents());
			listBoxAttributes.Items.AddRange(validateAttributes());
			listBoxSkills.Items.AddRange(validateSkills());
			buttonBuySkill.Enabled = false;
			buttonBuyTalents.Enabled = false;
			buttonBuyAttributes.Enabled = false;
			buttonRefund.Enabled = false;
		}

		string[] validateTalents()
		{
			List<string> toBeReturned = new List<string>();
			foreach (Talent singleTalent in availableTalents.talent)
			{
				if (!tempCharacter.talents.Contains(singleTalent.Name))
				{
					toBeReturned.Add(singleTalent.Name);
				}
			}
			if (toBeReturned.Count == 0)
			{
				toBeReturned.Add("No talents available");
			}
			return toBeReturned.ToArray();
		}

		string[] validateSkills()
		{
			List<string> toBeReturned = new List<string>();
			foreach (var singleSkill in availableSkills.skill)
			{
				if (singleSkill.Specialist != "N/A")
				{
					var temp = tempCharacter.skills.Find(singleSkill.Name, singleSkill.Specialist);
					if (temp != null)
					{
						if (temp.Tier < 3)
						{
							toBeReturned.Add(singleSkill.Name + "(" + singleSkill.Specialist + ") +" +
											 ((temp.Tier + 1) * 10));
						}
					}
					else
					{
						toBeReturned.Add(singleSkill.Name + "(" + singleSkill.Specialist + ")");
					}
				}
				else
				{
					var temp = tempCharacter.skills.Find(singleSkill.Name);
					if (temp != null)
					{
						if (temp.Tier < 3)
						{
							toBeReturned.Add(singleSkill.Name + " +" + ((temp.Tier + 1) * 10));
						}
					}
					else
					{
						toBeReturned.Add(singleSkill.Name);
					}
				}
			}
			if (toBeReturned.Count == 0)
			{
				toBeReturned.Add("No skills available");
			}
			return toBeReturned.ToArray();
		}

		string[] validateAttributes()
		{
			List<string> toBeReturned = new List<string>();
			foreach (Attribute singleAttribute in tempCharacter.attributes.attribute)
			{
				if (singleAttribute.Tier < 4)
				{
					toBeReturned.Add(singleAttribute.Name + " +" + ((singleAttribute.Tier + 1) * 5).ToString());
				}
			}

			if (toBeReturned.Count == 0)
			{
				toBeReturned.Add("No upgrades available");
			}
			return toBeReturned.ToArray();
		}

		string calculateTalentCost(string talentToBuyName)
		{
			int cost = 0;
			var talentToBuy = availableTalents.Find(talentToBuyName);
			var aptitudeCount = tempCharacter.checkAptitudesCount(talentToBuy.primary, talentToBuy.secondary);
			if (aptitudeCount == 2)
			{
				cost = 100 + (talentToBuy.Tier * 100);
			}
			if (aptitudeCount == 1)
			{
				cost = 150 + (talentToBuy.Tier * 150);
			}
			if (aptitudeCount == 0)
			{
				cost = 300 + (talentToBuy.Tier * 300);
			}
			return cost.ToString();
		}

		string calculateSkillCost(string skillToBuyName, string skillToBuySpecialty, int isBought)
		{
			int cost = 0;
			int tier = 0;

			var skillToBuy = availableSkills.Find(skillToBuyName, skillToBuySpecialty);
			var aptitudeCount = tempCharacter.checkAptitudesCount(skillToBuy.Primary, skillToBuy.Secondary);
			var temp = tempCharacter.skills.Find(skillToBuyName, skillToBuySpecialty);

			if (temp != null)
			{
				tier = temp.Tier - isBought + 1;
				if (tier > 2)
				{
					tier = 2;
				}
			}
			cost = ((3 - aptitudeCount) * 100) + ((tier * 100) * (3 - aptitudeCount));


			return cost.ToString();
		}

		string calculateAttributeCost(string attributeToBuyName, int isBought)
		{
			int cost = 0;
			var attributeToBuy = tempCharacter.attributes.Find(attributeToBuyName);
			var aptitudeCount = tempCharacter.checkAptitudesCount(attributeToBuy.Name, attributeToBuy.Secondary);

			var tier = attributeToBuy.Tier - isBought;
			if (tier < 0)
			{
				tier = 0;
			}
			if (aptitudeCount == 2)
			{
				if (attributeToBuy.Tier == 0)
				{
					cost = 100;
				}
				else
				{
					cost = 250 + (250 * (tier - 1));
				}
			}
			if (aptitudeCount == 1)
			{
				cost = 250 * (tier + 1);
			}
			if (aptitudeCount == 0)
			{
				if (tier == 3)
				{
					cost = 2500;
				}
				else
				{
					cost = 250 + (250 * tier);
				}
			}
			return cost.ToString();
		}

		void buttonBuySkill_Click(object sender, System.EventArgs e)
		{
			var toBeParsed = listBoxSkills.Text;
			var parsed = parseSkillName(toBeParsed);
			if (parsed[1] != "N/A")
			{
				listBoxBuyList.Items.Add("(S)" + parsed[0] + "(" + parsed[1] + ")");
			}
			else
			{
				listBoxBuyList.Items.Add("(S)" + parsed[0]);
			}

			if (selectedCharacter.skills.Find(parsed[0], parsed[1]) != null)
			{
				var foundSkill = selectedCharacter.skills.Find(parsed[0], parsed[1]);
				tempCharacter.skills.Add(foundSkill);
			}
			else
			{
				var foundSkill = availableSkills.Find(parsed[0], parsed[1]);
				tempCharacter.skills.Add(foundSkill);
			}

			var totalCost = int.Parse(textBoxTotalXp.Text);
			var skillCost = int.Parse(textBoxSkillCost.Text);
			totalCost += skillCost;
			var availableXp = int.Parse(textBoxAvailableXp.Text);

			if (totalCost > availableXp)
			{
				buttonFinalize.Enabled = false;
			}
			textBoxTotalXp.Text = totalCost.ToString();
			listBoxSkills.Items.Clear();
			listBoxSkills.Items.AddRange(validateSkills());
			buttonBuySkill.Enabled = false;
		}

		void buttonBuyTalents_Click(object sender, System.EventArgs e)
		{
			var toBeBought = listBoxTalents.Text;
			listBoxBuyList.Items.Add("(T)" + toBeBought);
			var found = availableTalents.Find(toBeBought);

			if (found != null)
			{
				tempCharacter.talents.Add(found);
			}
			else
			{
				MessageBox.Show("Error: Failed to insert talent. Talent is empty.");
			}

			var totalCost = int.Parse(textBoxTotalXp.Text);
			var talentCost = int.Parse(textBoxTalentCost.Text);
			totalCost += talentCost;
			var availableXp = int.Parse(textBoxAvailableXp.Text);

			if (totalCost > availableXp)
			{
				//buttonFinalize.Enabled = false;
			}
			textBoxTotalXp.Text = totalCost.ToString();
			listBoxTalents.Items.Clear();
			listBoxTalents.Items.AddRange(validateTalents());
			buttonBuyTalents.Enabled = false;
		}

		void buttonBuyAttributes_Click(object sender, System.EventArgs e)
		{
			var toBeParsed = listBoxAttributes.Text;
			var name = parseAttributeName(toBeParsed);

			listBoxBuyList.Items.Add("(A)" + name);

			var foundAttribute = tempCharacter.attributes.Find(name);
			if (foundAttribute != null)
			{
				tempCharacter.attributes.Add(foundAttribute);
			}
			else
			{
				MessageBox.Show("Error: Failed to insert attribute. Attribute is empty.");
			}

			var totalCost = int.Parse(textBoxTotalXp.Text);
			var attributeCost = int.Parse(textBoxAttributeCost.Text);
			totalCost += attributeCost;
			var availableXp = int.Parse(textBoxAvailableXp.Text);

			if (totalCost > availableXp)
			{
				//buttonFinalize.Enabled = false;
			}
			textBoxTotalXp.Text = totalCost.ToString();
			listBoxAttributes.Items.Clear();
			listBoxAttributes.Items.AddRange(validateAttributes());
			buttonBuyAttributes.Enabled = false;
		}

		void buttonRefund_Click(object sender, System.EventArgs e)
		{
			var toBeParsed = listBoxBuyList.Text;
			var parsed = parseBoughtName(toBeParsed);

			if (parsed[0] == "(T)")
			{
				tempCharacter.talents.Remove(parsed[1]);
				listBoxTalents.Items.Clear();
				listBoxTalents.Items.AddRange(validateTalents());
			}
			if (parsed[0] == "(S)")
			{
				var foundSkill = selectedCharacter.skills.Find(parsed[1], parsed[2]);
				if (foundSkill != null)
				{
					tempCharacter.skills.Remove(foundSkill);
				}
				else
				{
					MessageBox.Show("Error: Failed to remove skill. Skill not found .");
					Hide();
				}

				listBoxSkills.Items.Clear();
				listBoxSkills.Items.AddRange(validateSkills());
			}
			if (parsed[0] == "(A)")
			{
				var foundAttribute = tempCharacter.attributes.Find(parsed[1]);

				if (foundAttribute != null)
				{
					tempCharacter.attributes.Remove(foundAttribute);
				}
				else
				{
					MessageBox.Show("Error: Failed to insert attribute. Attribute is empty.");
				}
				listBoxAttributes.Items.Clear();
				listBoxAttributes.Items.AddRange(validateAttributes());
			}

			var totalCost = int.Parse(textBoxTotalXp.Text);
			System.Console.Write(totalCost + "\n");
			var refundedCost = int.Parse(textBoxSelected.Text);
			System.Console.Write(refundedCost + "\n");
			totalCost -= refundedCost;
			System.Console.Write(totalCost + "\n");
			var availableXp = int.Parse(textBoxAvailableXp.Text);
			System.Console.Write(availableXp + "\n");

			if (totalCost <= availableXp)
			{
				buttonFinalize.Enabled = true;
			}
			textBoxTotalXp.Text = totalCost.ToString();
			listBoxBuyList.Items.Remove(listBoxBuyList.SelectedItem);
			listBoxBuyList.SelectedIndex = -1;
			listBoxBuyList.Refresh();
			buttonRefund.Enabled = false;
		}

		void buttonFinalize_Click(object sender, System.EventArgs e)
		{
			var totalCost = int.Parse(textBoxTotalXp.Text);
			tempCharacter.experienceLeft -= totalCost;
			tempCharacter.experienceSpent += totalCost;
			selectedCharacter = tempCharacter;
			Hide();
		}

		void listBoxSkills_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			buttonBuySkill.Enabled = true;
			var toBeParsed = listBoxSkills.Text;
			var parsed = parseSkillName(toBeParsed);
			textBoxSkillCost.Text = calculateSkillCost(parsed[0].Trim(), parsed[1].Trim(), 0);
		}

		void listBoxTalents_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			var curSelected = availableTalents.Find(listBoxTalents.Text);
			textBoxTalent.Text = curSelected.ToString();
			textBoxTalentCost.Text = calculateTalentCost(listBoxTalents.Text);
			buttonBuyTalents.Enabled = true;
		}

		void listBoxAttributes_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			var temp = listBoxAttributes.Text;
			var name = parseAttributeName(temp);
			textBoxAttributeCost.Text = calculateAttributeCost(name, 0);
			buttonBuyAttributes.Enabled = true;
		}

		void listBoxBuyList_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			var toBeParsed = listBoxBuyList.Text;
			if (toBeParsed != string.Empty)
			{
				var parsed = parseBoughtName(toBeParsed);
				if (parsed[0] == "(T)")
				{
					textBoxSelected.Text = calculateTalentCost(parsed[1]);
				}
				if (parsed[0] == "(S)")
				{
					textBoxSelected.Text = calculateSkillCost(parsed[1], parsed[2], 1);
				}
				if (parsed[0] == "(A)")
				{
					textBoxSelected.Text = calculateAttributeCost(parsed[1], 1);
					if (textBoxSelected.Text == "0")
					{
						textBoxSelected.Text = "100";
					}
				}
				buttonRefund.Enabled = true;
			}
			else
			{
				textBoxSelected.Text = "0";
			}
		}

		string[] parseSkillName(string nameToBeParsed)
		{
			List<string> parsed = new List<string>();
			if (nameToBeParsed.Contains("("))
			{
				var startIndex = nameToBeParsed.IndexOf('(');
				var endIndex = nameToBeParsed.IndexOf(')');
				var length = endIndex - startIndex - 1;
				var specialty = nameToBeParsed.Substring(startIndex + 1, length);
				var name = nameToBeParsed.Substring(0, startIndex);
				var bonus = "0";

				if (nameToBeParsed.Contains("+"))
				{
					startIndex = nameToBeParsed.IndexOf('+');
					length = nameToBeParsed.Length - startIndex - 1;
					bonus = nameToBeParsed.Substring(startIndex + 1, length);
				}
				parsed.Add(name.Trim());
				parsed.Add(specialty.Trim());
				parsed.Add(bonus.Trim());
				return parsed.ToArray();
			}
			if (nameToBeParsed.Contains("+"))
			{
				var endIndex = nameToBeParsed.IndexOf('+');
				var name = nameToBeParsed.Substring(0, endIndex);
				var length = nameToBeParsed.Length - endIndex - 1;
				var bonus = nameToBeParsed.Substring(endIndex + 1, length);
				parsed.Add(name.Trim());
				parsed.Add("N/A");
				parsed.Add(bonus.Trim());
				return parsed.ToArray();
			}
			parsed.Add(nameToBeParsed.Trim());
			parsed.Add("N/A");
			parsed.Add("0");
			return parsed.ToArray();
		}

		string parseAttributeName(string toBeParsed)
		{
			var endIndex = toBeParsed.IndexOf('+');
			var name = toBeParsed.Substring(0, endIndex);
			return name.Trim();
		}

		string[] parseBoughtName(string toBeParsed)
		{
			toBeParsed = toBeParsed.Trim();
			List<string> toBeReturned = new List<string>();
			var type = toBeParsed.Substring(0, 3).Trim();
			toBeReturned.Add(type);

			if (type == "(T)")
			{
				var name = toBeParsed.Substring(3, toBeParsed.Length - 3);
				toBeReturned.Add(name.Trim());
				return toBeReturned.ToArray();
			}
			if (type == "(A)")
			{
				var name = toBeParsed.Substring(3, toBeParsed.Length - 3);
				toBeReturned.Add(name.Trim());
				return toBeReturned.ToArray();
			}
			if (type == "(S)")
			{
				var name = toBeParsed.Substring(3, toBeParsed.Length - 3);
				var parsedSkill = parseSkillName(name);
				foreach (string part in parsedSkill)
				{
					toBeReturned.Add(part.Trim());
				}
				name = string.Empty;
				foreach (string part in toBeReturned)
				{
					name += part + "\n";
				}
			}
			return toBeReturned.ToArray();
		}
	}
}