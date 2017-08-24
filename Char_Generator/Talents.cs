using System;
using System.Collections.Generic;

using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Char_Generator
{
	public class Talents
	{
		public List<Talent> talent = new List<Talent>();

		[JsonConstructor]
		public Talents() { }

		public Talents(string csvPath)
		{
			var csvLines = FileIO.readCsv(csvPath);
			addTalentsFromCsv(csvLines);
		}

		public Talents(StreamReader csvFile)
		{
			var csvLines = FileIO.readCsv(csvFile);
			addTalentsFromCsv(csvLines);

		}

		void addTalentsFromCsv(List<string> csvLines)
		{
			try
			{
				foreach (string csvLine in csvLines)
				{
					var csvSplit = csvLine.Split('|');
					if (csvSplit[0] != null || csvSplit[1] != null || csvSplit[2] != null || csvSplit[3] != null || csvSplit[4] != null ||
				csvSplit[5] != null || csvSplit[6] != null || csvSplit[7] != null)
					{
						if (Aptitudes.CheckAvailable(csvSplit[2].Trim()) && Aptitudes.CheckAvailable(csvSplit[3].Trim()))
						{
							talent.Add(new Talent(csvSplit));
						}
						else
						{
							talent.Add(new Talent());
						}
					}
					else
					{
						talent.Add(new Talent());
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: Failed to add new Skills at iteration : " + ex.Message);
			}

		}

		public Talent Find(string toBeFound)
		{
			toBeFound = toBeFound.Trim();
			var temp = talent.Find(x => x.Name == toBeFound);
			return temp;
		}

		public bool Contains(string toBefound)
		{
			foreach (Talent singleTalent in talent)
			{
				if (singleTalent.Name == toBefound)
				{ return true; }
			}
			return false;
		}

		public void Add(Talent talent)
		{
			try
			{
				this.talent.Add(talent);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: Failed to insert talent. Original error is : \n" + ex.Message);
			}
		}

		public void Remove(string toBeRemovedName)
		{
			talent.Remove(Find(toBeRemovedName));
		}

		public string SerializeXML()
		{
			var s = new XmlSerializer(GetType());
			var sb = new StringBuilder();
			var w = new StringWriter(sb);
			s.Serialize(w, this);
			w.Flush();
			return sb.ToString();
		}

		public override string ToString()
		{
			var toBeReturned = string.Empty;
			talent.ForEach(x => toBeReturned += x + "\n");
			return toBeReturned;
		}

		public string[] getNames()
		{
			var toBeReturned = new List<string>();			talent.ForEach(x => toBeReturned.Add(x.Name));

			return toBeReturned.ToArray();
		}


	}
}
