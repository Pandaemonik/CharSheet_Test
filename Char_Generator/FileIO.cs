using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Char_Generator
{
	public static class FileIO
	{
		public static List<string> readCsv(string csvLocation)
		{
			List<string> toBeReturned = new List<string>();
			string buffer = string.Empty;

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

			string[] bufferArray = buffer.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);

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
			string buffer = csvFile.ReadToEnd();
			string[] bufferArray = buffer.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
			List<string> toBeReturned = new List<string>();

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
	}
}
