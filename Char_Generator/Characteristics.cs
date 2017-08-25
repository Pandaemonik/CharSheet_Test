using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Char_Generator
{
	public class Characteristics
	{
		public List<Characteristic> characteristic = new List<Characteristic>();

		[JsonConstructor]
		public Characteristics() { }

		public Characteristics(string csvPath)
		{
			var csvLines = FileIO.readCsv(csvPath);
			addCharacteristicsFromCsv(csvLines);
		}

		public Characteristics(StreamReader csvFile)
		{
			var csvLines = FileIO.readCsv(csvFile);
			addCharacteristicsFromCsv(csvLines);
		}

		void addCharacteristicsFromCsv(List<string> csvLines)
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
							characteristic.Add(new Characteristic(csvSplit));
						}
						else
						{
							characteristic.Add(new Characteristic(csvSplit));
						}
					}
					else
					{
						characteristic.Add(new Characteristic());
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: Failed to add new Skills at iteration : " + ex.Message);

			}
		}

		public Characteristic Find(string toBeFound)
		{
			toBeFound = toBeFound.Trim();
			var temp = characteristic.Find(x => x.Name == toBeFound);
			return temp;
		}

		public void Add(Characteristic characteristicToBeAdded)
		{
			try
			{
				if (characteristicToBeAdded != null)
				{
					if (characteristic.Contains(characteristicToBeAdded))
					{
						int index = characteristic.IndexOf(characteristicToBeAdded);
						characteristic[index].Tier++;
						if (characteristic[index].Tier > 4)
						{
							characteristic[index].Tier = 4;
						}
					}
					else
					{
						characteristic.Add(characteristicToBeAdded);
					}
				}
				else
				{
					MessageBox.Show("Error: Failed to insert skill. Skill is empty");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: Failed to insert skill. Original error is : \n" + ex.Message);
			}
		}

		public override string ToString()
		{
			var toBeReturned = string.Empty;
			characteristic.ForEach(x => toBeReturned += x + "\n");
			return toBeReturned;
		}

		public string[] getNames()
		{
			var toBeReturned = new List<string>();
			characteristic.ForEach(x => toBeReturned.Add(x.Name));
			return toBeReturned.ToArray();
		}

		public void Remove(Characteristic toBeRemoved)
		{
			if (toBeRemoved != null)
			{
				int index = characteristic.IndexOf(toBeRemoved);
				if (characteristic[index].Tier > 0)
				{
					characteristic[index].Tier--;
				}
				else
				{
					characteristic[index].Tier = 0;
				}
			}
			else
			{
				MessageBox.Show("Error: Failed to remove Characteristic. Characteristic is empty");
			}
		}

		public string getDisplayed()
		{
			string toBeReturned = string.Empty;

			foreach (Characteristic single in characteristic)
			{
				if (single.Value > 0)
				{
					toBeReturned += single.Name + ": " + (single.Value + (5 * single.Tier)).ToString() + "\n";
				}
			}
			return toBeReturned;
		}

		public void addValue(string characteristicName, int value)
		{
			characteristicName = characteristicName.Trim();
			var foundCharacteristic = characteristic.Find(x => x.Name == characteristicName);

			if (characteristicName != null)
			{
				int index = characteristic.IndexOf(foundCharacteristic);
				characteristic[index].Value += value;
			}
			else
			{
				MessageBox.Show("Error: Failed to insert skill. Skill is empty");;
			}
		}
	}
}
