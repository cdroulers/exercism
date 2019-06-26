using System;
using System.Linq;

public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
        return string.Join(
            "",
            phrase
                .Split(new[] { " ", "-" }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim('_')[0].ToString().ToUpperInvariant()));
    }
}