using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

public class Phrase
{
	private readonly string input;

	public Phrase(string input)
	{
		this.input = Phrase.FilterPhrase(input);
	}

	public IDictionary<string, int> WordCount()
	{
		var words = this.input.Split(' ').Where(x => !string.IsNullOrWhiteSpace(x));

		return words.GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count());
	}

	private static string FilterPhrase(string word)
	{
		var builder = new StringBuilder();
		for (int i = 0; i < word.Length; i++)
		{
			if (word[i] != '\'' && !char.IsLetter(word[i]) && !char.IsDigit(word[i]))
			{
				builder.Append(" ");
			}
			else
			{
				builder.Append(char.ToLower(word[i]));
			}
		}
		return builder.ToString();
	}
}