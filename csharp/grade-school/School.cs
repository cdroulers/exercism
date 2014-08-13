using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

public class School
{
	private readonly IDictionary<int, IList<string>> roster;

	public ReadOnlyDictionary<int, IList<string>> Roster
	{
		get { return new ReadOnlyDictionary<int, IList<string>>(roster); }
	}

	public School()
	{
		roster = new Dictionary<int, IList<string>>();
	}

	public void Add(string name, int grade)
	{
		if (!roster.ContainsKey(grade))
		{
			roster.Add(grade, new List<string>());
		}

		roster[grade].Add(name);
		((List<string>)roster[grade]).Sort();
	}

	public IList<string> Grade(int grade)
	{
		return roster.ContainsKey(grade) ? roster[grade] : new List<string>();
	}
}