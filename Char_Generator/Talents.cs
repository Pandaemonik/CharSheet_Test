using System;
using System.Collections.Generic;

using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Char_Generator
{
	[XmlRoot(Namespace = "", IsNullable = false)]
	public class Talents
	{
		[XmlArray("TalentList")]
		[XmlArrayItem("Talent", typeof(Talent))]
		public List<Talent> TalentList = new List<Talent>();

		public Talents()
		{
			List<string> csvLines = FileIO.readCsv("TextFiles\\Talents_CSV.csv");

			foreach (string csvLine in csvLines)
			{
				TalentList.Add(new Talent(csvLine));
			}
		}

		public Talents(StreamReader csvFile)
		{
			List<string> csvLines = FileIO.readCsv(csvFile);

			foreach (string csvLine in csvLines)
			{
				TalentList.Add(new Talent(csvLine));
			}
		}

		public Talent Find(String toBeFound)
		{
			Talent temp = TalentList.Find(x => x.Name == toBeFound);
			return temp;
		}

		public void Add(Talent talent)
		{
			try
			{
				TalentList.Add(talent);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: Failed to insert talent. Original error is : \n" + ex.Message);
			}
		}

		public string SerializeXML()
		{
			XmlSerializer s = new XmlSerializer(this.GetType());
			StringBuilder sb = new StringBuilder();
			TextWriter w = new StringWriter(sb);
			s.Serialize(w, this);
			w.Flush();
			return sb.ToString();
		}

		public string SerializeJSON()
		{
			string json = JsonConvert.SerializeObject(this);
			return json;
		}
	}
}
