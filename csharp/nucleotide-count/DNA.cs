using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections.ObjectModel;

public class DNA
{
	private readonly IDictionary<char, int> nucleotideCounts;

	private static readonly char[] Nucleotides = { 'A', 'C', 'G', 'T' };

	public ReadOnlyDictionary<char, int> NucleotideCounts
	{
		get { return new ReadOnlyDictionary<char, int>(nucleotideCounts); }
	}

	public DNA(string input)
	{
		nucleotideCounts = input.GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count());
		foreach (var nucleotide in DNA.Nucleotides.Where(x => !nucleotideCounts.ContainsKey(x)))
		{
			nucleotideCounts.Add(nucleotide, 0);
		}
	}

	public int Count(char nucleotide)
	{
		if (nucleotide == 'X')
		{
			throw new InvalidNucleotideException();
		}
		
		return nucleotideCounts.ContainsKey(nucleotide) ? nucleotideCounts[nucleotide] : 0;
	}
}

public class InvalidNucleotideException : Exception
{
}