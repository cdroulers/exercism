using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Anagram
{
	public readonly string Word;
	private readonly IDictionary<char, int> _index;

	public Anagram(string word)
	{
		this.Word = word;
		this._index = Anagram.BuildIndex(this.Word);
	}

	private static IDictionary<char, int> BuildIndex(string input)
	{
		// Builds a dictionary with each character and how many time it shows up. Can then simply compare dicitonaries.
		return input.GroupBy(x => x).ToDictionary(x => char.ToLower(x.Key), x => x.Count());
	}

	public string[] Match(IEnumerable<string> input)
	{
		var results = new List<string>();

		foreach (var word in input.Where(x => x.Length == this.Word.Length && 
			string.Compare(x, this.Word, StringComparison.InvariantCultureIgnoreCase) != 0))
		{
			var index = Anagram.BuildIndex(word);
			if (this._index.Keys.Count == index.Keys.Count && this._index.All(x => index.ContainsKey(x.Key) && index[x.Key] == x.Value))
			{
				results.Add(word);
			}
		}

		return results.OrderBy(x => x).ToArray();
	}
}