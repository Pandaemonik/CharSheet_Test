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
		//public List<Talent> TalentList = new List<Talent>();
		public List<Talent> TalentList = new List<Talent>();

		public Talents()
		{
			String buffer = String.Empty;
			try
			{
				using (Stream myStream = File.OpenRead(Path.Combine(Environment.CurrentDirectory, 
					"TextFiles\\Talents_CSV.csv")))
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
			// }

			String[] bufferArray = buffer.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);

			int iterbuffer = 0;
			try
			{
				for (int i = 0; i < bufferArray.Length; i++)
				{
					if (!bufferArray[i].Contains("<VOID>"))
					{
						iterbuffer = i;
						TalentList.Add(new Talent(bufferArray[i]));
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: Failed to add new Talents at iteration : " + iterbuffer + " Buffer Size: " + bufferArray.Length + "\n" + ex.Message);
			}

		}

		public Talents(StreamReader csvFile)
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
						TalentList.Add(new Talent(bufferArray[i]));
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: Failed to add new Talents at iteration : " + iterbuffer + " Buffer Size: " + bufferArray.Length + "\n" + ex.Message);
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
