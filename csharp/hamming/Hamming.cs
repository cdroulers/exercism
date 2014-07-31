using System;

public static class Hamming
{
	public static int Compute(string first, string second)
	{
		int total = 0;
		for (int i = 0; i < Math.Min(first.Length, second.Length); i++)
		{
			if (first[i] != second[i])
			{
				total++;
			}
		}

		return total;
	}
}