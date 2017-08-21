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
			var csvLines = FileIO.readCsv("TextFiles\\Skills_CSV.csv");

			foreach (string csvLine in csvLines)
			{
				var csvSplit = csvLine.Split('|');
				if (csvSplit[0] != null || csvSplit[1] != null || csvSplit[2] != null || csvSplit[3] != null
					|| csvSplit[4] != null)
				{
					skill.Add(new Skill(csvSplit));//TODO:Validate input and use proper constructor
				}
				else
				{
					skill.Add(new Skill());
				}
			}
		}

		public Skills(StreamReader csvFile)
		{
			var csvLines = FileIO.readCsv(csvFile);

			try
			{
				foreach (string csvLine in csvLines)
				{
					var csvSplit = csvLine.Split('|');
					if (csvSplit[0] != null || csvSplit[1] != null || csvSplit[2] != null || csvSplit[3] != null
						|| csvSplit[4] != null)
					{
						skill.Add(new Skill(csvSplit));//TODO:Validate input and use proper constructor
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
			var temp = skill.Find(x => x.Name == toBeFound);
			return temp;
		}

		public void Add(Skill skill)
		{
			try
			{
				this.skill.Add(skill);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: Failed to insert skill. Original error is : \n" + ex.Message);
			}
		}

		public string SerializeJSON()
		{
			var json = JsonConvert.SerializeObject(this, Formatting.Indented);
			return json;
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

	}
}
