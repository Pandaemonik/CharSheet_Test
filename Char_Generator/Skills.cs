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
	public class Skills
	{
		[XmlArray("SkillList")]
		[XmlArrayItem("Skill", typeof(Skill))]
		public List<Skill> SkillList = new List<Skill>();

		public Skills()
		{
			String buffer = String.Empty;
			try
			{
				using (Stream myStream = File.OpenRead(Path.Combine(Environment.CurrentDirectory,
					"TextFiles\\Skills_CSV.csv")))
				{
					if (myStream != null)
					{
						using (StreamReader csvFile = new StreamReader(myStream))
						{
							buffer = csvFile.ReadToEnd();
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: Could not read file from disk. Original error: \n" + ex.Message);
			}

			String[] bufferArray = buffer.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);

			int iterbuffer = 0;
			try
			{
				for (int i = 0; i < bufferArray.Length; i++)
				{
					if (!bufferArray[i].Contains("<VOID>"))
					{
						iterbuffer = i;
						String[] csvSplit = bufferArray[i].Split('|');
						if (csvSplit[0] != null || csvSplit[1] != null || csvSplit[2] != null || csvSplit[3] != null
							|| csvSplit[4] != null)
						{
							SkillList.Add(new Skill(csvSplit));//TODO:Validate input and use proper constructor
						}
						else
						{
							SkillList.Add(new Skill());
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: Failed to add new Skills at iteration : " + iterbuffer + " Buffer Size: " + bufferArray.Length + "\n" + ex.Message);
			}

		}

		public Skills(StreamReader csvFile)
		{
			String buffer = csvFile.ReadToEnd();
			String[] bufferArray = buffer.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);

			int iterbuffer = 0;
			try
			{
				for (int i = 0; i < bufferArray.Length; i++)
				{
					if (!bufferArray[i].Contains("<VOID>"))
					{
						iterbuffer = i;
						String[] csvSplit = bufferArray[i].Split('|');
						if (csvSplit[0] != null || csvSplit[1] != null || csvSplit[2] != null || csvSplit[3] != null
							|| csvSplit[4] != null)
						{
							SkillList.Add(new Skill(csvSplit));//TODO:Validate input and use proper constructor
						}
						else
						{
							SkillList.Add(new Skill());
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: Failed to add new Skills at iteration : " + iterbuffer + " Buffer Size: " + bufferArray.Length + "\n" + ex.Message);
			}

		}

		public Skill Find(string toBeFound)
		{
			Skill temp = SkillList.Find(x => x.name == toBeFound);
			return temp;
		}

		public void Add(Skill skill)
		{
			try
			{
				SkillList.Add(skill);
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
