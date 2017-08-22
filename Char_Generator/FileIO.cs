using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Char_Generator
{
	public static class FileIO
	{
		public static List<string> readCsv(string csvLocation)
		{
			var toBeReturned = new List<string>();
			var buffer = string.Empty;

			try
			{
				using (Stream myStream = File.OpenRead(Path.Combine(Environment.CurrentDirectory,
				csvLocation)))
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

			var bufferArray = buffer.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);

			int iterbuffer = 0;
			try
			{
				for (int i = 0; i < bufferArray.Length; i++)
				{
					if (!bufferArray[i].Contains("<VOID>"))
					{
						iterbuffer = i;
						toBeReturned.Add(bufferArray[i]);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: Failed to add new item at iteration : " + iterbuffer + " Buffer Size: " + bufferArray.Length + "\n" + ex.Message);
			}

			return toBeReturned;
		}

		public static List<string> readCsv(StreamReader csvFile)
		{
			var buffer = csvFile.ReadToEnd();
			var bufferArray = buffer.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
			var toBeReturned = new List<string>();

			int iterbuffer = 0;
			try
			{
				for (int i = 0; i < bufferArray.Length; i++)
				{
					if (!bufferArray[i].Contains("<VOID>"))
					{
						iterbuffer = i;
						toBeReturned.Add(bufferArray[i]);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: Failed to add new Talents at iteration : " + iterbuffer + " Buffer Size: " + bufferArray.Length + "\n" + ex.Message);
			}

			return toBeReturned;
		}

		public static string readJson(string jsonLocation)
		{
			var toBeReturned = string.Empty;

			try
			{
				using (Stream myStream = File.OpenRead(Path.Combine(Environment.CurrentDirectory, jsonLocation)))
				{
					if (myStream != null)
					{
						using (StreamReader jsonFile = new StreamReader(myStream))
						{
							toBeReturned = jsonFile.ReadToEnd();
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: Could not read file from disk. Original error: \n" + ex.Message);
			}

			return toBeReturned;
		}

		public static string SerializeJSON(object o)
		{
			var json = JsonConvert.SerializeObject(o, Formatting.Indented);
			return json;
		}

		public static void writeToFile(string fileName,string text)
		{
			File.WriteAllText(Path.Combine(Environment.CurrentDirectory, fileName),text);
		}
	}
}
