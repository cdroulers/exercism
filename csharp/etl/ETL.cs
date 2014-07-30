using System.Collections.Generic;

public class ETL
{
    public static IDictionary<string, int> Transform(IDictionary<int, IList<string>> input)
    {
        var result = new Dictionary<string, int>();

        foreach (var points in input)
        {
            foreach (var letter in points.Value)
            {
                result[letter.ToLowerInvariant()] = points.Key;
            }
        }

        return result;
    }
}
