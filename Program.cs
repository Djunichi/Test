using System;
using System.Collections.Generic;

public class Program
{
	public static void Main()
	{
		List<string> lines = new List<String>();
		lines.Add("ток");
		lines.Add("рост");
		lines.Add("кот");
		lines.Add("торс");
		lines.Add("Кто");
		lines.Add("фывап");
		lines.Add("рок");

		while (lines.Count > 0)
		{
			List<String> output = new List<String>();
			output.Add(lines[0]);

			for (int i = 1; i < lines.Count; i++)
			{
				if (String.Equals(SortString(lines[0]), SortString(lines[i])))
				{
					output.Add(lines[i]);
					lines.Remove(lines[i]);
				}
			}

			lines.Remove(lines[0]);

			output.ForEach(Console.WriteLine);
		}

	}

	public static string SortString(string input)
	{
		input = input.ToLower();
		char[] characters = input.ToCharArray();
		Array.Sort(characters);

		return new string(characters);
	}

}