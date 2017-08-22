using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Char_Generator
{
	public class Attributes
	{
		public List<Attribute> attribute = new List<Attribute>();

		[JsonConstructor]
		public Attributes() { }

		public Attributes(string csvPath)
		{
			var csvLines = FileIO.readCsv(csvPath);
			addAttributesFromCsv(csvLines);
		}

		public Attributes(StreamReader csvFile)
		{
			var csvLines = FileIO.readCsv(csvFile);
			addAttributesFromCsv(csvLines);
		}

		void addAttributesFromCsv(List<string> csvLines)
		{
			try
			{
				foreach (string csvLine in csvLines)
				{
					var csvSplit = csvLine.Split('|');
					if (csvSplit[0] != null || csvSplit[1] != null || csvSplit[2] != null || csvSplit[3] != null)
					{
						if (Aptitudes.CheckAvailable(csvSplit[0].Trim()) && Aptitudes.CheckAvailable(csvSplit[1].Trim()))
						{
							attribute.Add(new Attribute(csvSplit));
						}
						else
						{
							attribute.Add(new Attribute(csvSplit));
						}
					}
					else
					{
						attribute.Add(new Attribute());
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: Failed to add new Skills at iteration : " + ex.Message);

			}
		}

		public Attribute Find(string toBeFound)
		{
			var temp = attribute.Find(x => x.Name == toBeFound);
			return temp;
		}

		public void Add(Attribute attribute)
		{
			try
			{
				this.attribute.Add(attribute);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: Failed to insert skill. Original error is : \n" + ex.Message);
			}
		}

		public override string ToString()
		{
			var toBeReturned = string.Empty;
			attribute.ForEach(x => toBeReturned += x + "\n");
			return toBeReturned;
		}

		public string[] getNames()
		{
			var toBeReturned = new List<string>();
			attribute.ForEach(x => toBeReturned.Add(x.Name));
			return toBeReturned.ToArray();
		}


		public string getDisplayed()
		{
			string toBeReturned = string.Empty;

			foreach (Attribute single in attribute)
			{
				toBeReturned += single.Name + ": " + (single.Value + (5 * single.Tier)).ToString()+"\n";
			}
			return toBeReturned;
		}
	}
}
