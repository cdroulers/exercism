using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class Phrase
{
	private readonly string input;

	public Phrase(string input)
	{
		this.input = input;
	}

	public IDictionary<string, int> WordCount()
	{
		var words = this.input.Split(' ').Select(Phrase.FilterWord).Where(x => !string.IsNullOrWhiteSpace(x));

		return words.GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count());
	}

	private static string FilterWord(string word)
	{
		var r = new Regex(@"[^a-zA-Z]+$|^[^a-zA-Z]+");
		return r.Replace(word, string.Empty);
	}
}