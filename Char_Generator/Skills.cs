using System;
using System.Collections.Generic;

using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Char_Generator
{
	public class Skills
	{
		public List<Skill> skill = new List<Skill>();

		[JsonConstructor]
		public Skills() { }

		public Skills(string csvPath)
		{
			var csvLines = FileIO.readCsv(csvPath);
			addSkillsFromCsv(csvLines);
		}

		public Skills(StreamReader csvFile)
		{
			var csvLines = FileIO.readCsv(csvFile);
			addSkillsFromCsv(csvLines);
		}

		void addSkillsFromCsv(List<string> csvLines)
		{
			try
			{
				foreach (string csvLine in csvLines)
				{
					var csvSplit = csvLine.Split('|');
					if (csvSplit[0] != null || csvSplit[1] != null || csvSplit[2] != null || csvSplit[3] != null
						|| csvSplit[4] != null)
					{
						if (Aptitudes.CheckAvailable(csvSplit[1].Trim()) && Aptitudes.CheckAvailable(csvSplit[2].Trim()))
						{
							skill.Add(new Skill(csvSplit));
						}
						else
						{
							skill.Add(new Skill());
						}
					}
					else
					{
						skill.Add(new Skill());
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: Failed to add new Skills at iteration : " + ex.Message);
			}
		}

		public Skill Find(string toBeFound)
		{
			toBeFound = toBeFound.Trim();
			var temp = skill.Find(x => x.Name == toBeFound);
			return temp;
		}

		public Skill Find(string toBeFoundName, string toBeFoundSpecialist)
		{
			var temp = skill.Find(x => x.Name == toBeFoundName && x.Specialist == toBeFoundSpecialist);
			return temp;
		}

		public void Add(Skill skillToBeAdded)
		{
			try
			{
				if (skillToBeAdded != null)
				{
					if (skill.Contains(skillToBeAdded))
					{
						int index = skill.IndexOf(skillToBeAdded);
						skill[index].Tier++;
						if (skill[index].Tier > 3)
						{
							skill[index].Tier = 3;
						}
					}
					else
					{
						skill.Add(skillToBeAdded);
					}
				}
				else
				{
					MessageBox.Show("Error: Failed to insert skill. Skill is empty");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: Failed to insert skill. Original error is : \n" + ex.Message);
			}
		}

		public void Remove(Skill toBeRemoved)
		{
			if (toBeRemoved != null)
			{
				int index = skill.IndexOf(toBeRemoved);
				if (skill[index].Tier >0)
				{
					skill[index].Tier--;
				}
				else
				{;
					skill.Remove(toBeRemoved);
				}
			}
			else
			{
				MessageBox.Show("Error: Failed to insert skill. Skill is empty");
			}
		}

		public override string ToString()
		{
			var toBeReturned = string.Empty;
			skill.ForEach(x => toBeReturned += x + "\n");
			return toBeReturned;
		}

		public string[] getNames()
		{
			var toBeReturned = new List<string>();
			skill.ForEach(x => toBeReturned.Add(x.Name));
			return toBeReturned.ToArray();
		}

		public string getDisplayed()
		{
			string toBeReturned = string.Empty;

			foreach (Skill single in skill)
			{
				if (single.Specialist == "N/A")
				{
					toBeReturned += single.Name + ": ";
					if (single.Tier > -1)
					{
						toBeReturned += "+" + (single.Tier * 10).ToString() + "\n";
					}
					else
					{
						toBeReturned += "-10\n";
					}
				}
				else if (single.Tier > -1)
				{
					toBeReturned += single.Name + " (" + single.Specialist + "): +";
					toBeReturned += (single.Tier * 10).ToString() + "\n";
				}
			}
			return toBeReturned;
		}
	}
}
