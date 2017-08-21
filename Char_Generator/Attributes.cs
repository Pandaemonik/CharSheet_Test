using System;
using System.Collections.Generic;
using System.IO;
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

			foreach (string csvLine in csvLines)
			{
				var csvSplit = csvLine.Split('|');
				if (csvSplit[0] != null || csvSplit[1] != null || csvSplit[2] != null || csvSplit[3] != null)
				{
					attribute.Add(new Attribute(csvSplit));//TODO:Validate input and use proper constructor
				}
				else
				{
					attribute.Add(new Attribute());
				}

			}
		}

		public Attributes(StreamReader csvFile)
		{
			var csvLines = FileIO.readCsv(csvFile);

			try
			{
				foreach (string csvLine in csvLines)
				{
					var csvSplit = csvLine.Split('|');
					if (csvSplit[0] != null || csvSplit[1] != null || csvSplit[2] != null || csvSplit[3] != null)
					{
						attribute.Add(new Attribute(csvSplit));//TODO:Validate input and use proper constructor
					}
					else
					{
						attribute.Add(new Attribute());
					}
				}

			}
			catch (Exception ex)
			{
				System.Windows.Forms.MessageBox.Show("Error: Failed to add new Attributes at iteration : "
													 + "\n" + ex.Message);
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
				System.Windows.Forms.MessageBox.Show("Error: Failed to insert skill. Original error is : \n" + ex.Message);
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
			attribute.ForEach(x => toBeReturned += x + "\n");
			return toBeReturned;
		}

		public string[] getNames()
		{
			var toBeReturned = new List<string>();
			attribute.ForEach(x => toBeReturned.Add(x.Name));
			return toBeReturned.ToArray();
		}
	}
}
