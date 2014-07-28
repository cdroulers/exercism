using System.Linq;

public class Bob
{
    public string Hey(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return "Fine. Be that way!";
        }

        if (Bob.IsYelling(input))
        {
            return "Woah, chill out!";
        }

        if (input.EndsWith("?"))
        {
            return "Sure.";
        }

        return "Whatever.";
    }

    private static bool IsYelling(string input)
    {
        return input.Any(x => char.IsLetter(x)) && input.All(x => !char.IsLetter(x) || char.IsUpper(x));
    }
}
