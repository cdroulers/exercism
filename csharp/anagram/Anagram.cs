using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Anagram
{
	public readonly string Word;

	public Anagram(string word)
	{
		this.Word = word;
	}

	public string[] Match(IEnumerable<string> input)
	{
		var results = new List<string>();

		foreach (var word in input.Where(x => x.Length == this.Word.Length && x != this.Word))
		{
			if (this.Word.ToList().Intersect(word.ToList()).Count() == this.Word.Length)
			{
				results.Add(word);
			}
		}

		results.Reverse();
		return results.ToArray();
	}
}