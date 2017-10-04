using System;
using System.Collections.Generic;

namespace Char_Generator
{
	public class DiceRoller
	{
		Random die;

		public DiceRoller()
		{
			die = new Random();
		}

		public int RollDice(string rollString)
		{
			int result = 0;

			if (rollString.Contains("d"))
			{
				var endIndex = rollString.IndexOf('d');
				var startIndex = endIndex;
				var lenght = endIndex;

				var numberOfRolls = rollString.Substring(0, lenght);
				var numberOfSides = string.Empty;
				var modifier = 0;

				if (rollString.Contains("+") && rollString.Contains("-"))
				{
					var indexOfMinus = rollString.IndexOf('-');
					var indexOfPlus = rollString.IndexOf('+');
					var toBeParsed = string.Empty;

					endIndex = Math.Min(indexOfPlus, indexOfMinus);
					lenght = endIndex - startIndex - 1;
					numberOfSides = rollString.Substring(startIndex + 1, lenght);

					startIndex = endIndex;
					lenght = rollString.Length - startIndex;
					toBeParsed = rollString.Substring(startIndex, lenght);

					modifier += parseAddition(toBeParsed);
					modifier -= parseSubtraction(toBeParsed);
				}
				else if (rollString.Contains("+"))
				{
					modifier += parseAddition(rollString);
				}
				else if (rollString.Contains("-"))
				{
					modifier -= parseSubtraction(rollString);
				}

			}
			else
			{
				result = 0;
			}
			return result;
		}

		int parseAddition(string toBeParsed)
		{
			var toBeReturned = 0;

			return toBeReturned;
		}

		int parseSubtraction(string toBeParsed)
		{
			var toBeReturned = 0;
			return toBeReturned;
		}

		int getRoll(int rolls, int sides, int modifier)
		{
			var result = 0;
			for (int i = 0; i < rolls; i++)
			{
				result += die.Next(1, sides + 1);
			}
			return result + modifier;
		}

		void Debug(string numberOfRolls, string numberOfSides, string toBeParsed)
		{
			Console.Write("Rolls - " + numberOfRolls + "\n" +
						  "Sides - " + numberOfSides + "\n" +
						  "Modifiers - " + toBeParsed + "\n");
		}
	}
}
