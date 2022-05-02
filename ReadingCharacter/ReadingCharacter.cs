using System;
using System.Collections.Generic;

namespace readingCharacter
{
	class ReadingCharacter
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Please enter any character");
			string some = Console.ReadLine();

			Console.WriteLine(character(some));
		}

		public static string character(string ch)
		{

			//changing all the letter to lowercase
			var lowerEvery = ch.ToLower();

			//creating a dictionary to store all the letter and its value;
			Dictionary<char, int> counts = new Dictionary<char, int>();

			//looping on all the letter of the character and storing it to dictionary, if it hasnot been stored/ otherwise add and extra value
			for (int i = 0; i < lowerEvery.Length; i++)
			{
				if (!counts.ContainsKey(ch[i]))
					counts[lowerEvery[i]] = 0;
				counts[lowerEvery[i]]++;
			}

			//creating a variable and assigning first character and its value.  
			var maxChar = lowerEvery[0];
			var maxCount = counts[lowerEvery[0]];

			//looping on the dictionary and checking the highest value of every key and assigning the highest value to maxChar and its key to maxCount 
			foreach (var v in counts)
			{
				if (v.Value > maxCount)
				{
					maxCount = v.Value;
					maxChar = v.Key;
				}
			}

			return (maxChar + " has the highest occurance and has count of " + maxCount);

		}
	}
}
