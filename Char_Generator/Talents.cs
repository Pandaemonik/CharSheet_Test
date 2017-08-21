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

			foreach (string csvLine in csvLines)
			{
				talent.Add(new Talent(csvLine));
			}
		}

		public Talents(StreamReader csvFile)
		{
			var csvLines = FileIO.readCsv(csvFile);

			foreach (string csvLine in csvLines)
			{
				talent.Add(new Talent(csvLine));
			}
		}

		public Talent Find(string toBeFound)
		{
			var temp = talent.Find(x => x.Name == toBeFound);
			return temp;
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

		public string SerializeXML()
		{
			var s = new XmlSerializer(GetType());
			var sb = new StringBuilder();
			var w = new StringWriter(sb);
			s.Serialize(w, this);
			w.Flush();
			return sb.ToString();
		}

		public string SerializeJSON()
		{
			var json = JsonConvert.SerializeObject(this, Formatting.Indented);
			return json;
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
