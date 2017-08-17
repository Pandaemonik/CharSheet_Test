using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Char_Generator
{
	[XmlRoot(Namespace = "", IsNullable = false)]
	public class Attributes
	{
		[XmlArray("AttributeArray")]
		[XmlArrayItem("Attribute", typeof(Attribute))]
		public List<Attribute> AttributeList = new List<Attribute>();

		public Attributes()
		{
			var csvLines = FileIO.readCsv("TextFiles\\Attributes_CSV.csv");

			foreach (string csvLine in csvLines)
			{
				var csvSplit = csvLine.Split('|');
				if (csvSplit[0] != null || csvSplit[1] != null || csvSplit[2] != null || csvSplit[3] != null)
				{
					AttributeList.Add(new Attribute(csvSplit));//TODO:Validate input and use proper constructor
				}
				else
				{
					AttributeList.Add(new Attribute());
				}
			}
		}

		public Attributes(StreamReader csvFile)
		{
			var buffer = csvFile.ReadToEnd();
			var bufferArray = buffer.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);

			int iterbuffer = 0;
			try
			{
				for (int i = 0; i < bufferArray.Length; i++)
				{
					if (!bufferArray[i].Contains("<VOID>"))
					{
						iterbuffer = i;
						var csvSplit = bufferArray[i].Split('|');
						if (csvSplit[0] != null || csvSplit[1] != null || csvSplit[2] != null || csvSplit[3] != null)
						{
							AttributeList.Add(new Attribute(csvSplit));//TODO:Validate input and use proper constructor
						}
						else
						{
							AttributeList.Add(new Attribute());
						}
					}
				}
			}
			catch (Exception ex)
			{
				System.Windows.Forms.MessageBox.Show("Error: Failed to add new Attributes at iteration : "
													 + iterbuffer + " Buffer Size: " + bufferArray.Length
													 + "\n" + ex.Message);
			}

		}

		public Attribute Find(string toBeFound)
		{
			var temp = AttributeList.Find(x => x.name == toBeFound);
			return temp;
		}

		public void Add(Attribute attribute)
		{
			try
			{
				AttributeList.Add(attribute);
			}
			catch (Exception ex)
			{
				System.Windows.Forms.MessageBox.Show("Error: Failed to insert skill. Original error is : \n" + ex.Message);
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
	}
}
