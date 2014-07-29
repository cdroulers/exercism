using System.Linq;

public class Bob
{
    public string Hey(string input)
    {
        if (Bob.IsSilence(input))
        {
            return "Fine. Be that way!";
        }

        if (Bob.IsYelling(input))
        {
            return "Woah, chill out!";
        }

        if (Bob.IsQuestion(input))
        {
            return "Sure.";
        }

        return "Whatever.";
    }

    private static bool IsSilence(string input)
    {
        return string.IsNullOrWhiteSpace(input);
    }

    private static bool IsYelling(string input)
    {
        return input.Any(x => char.IsLetter(x)) && input.All(x => !char.IsLetter(x) || char.IsUpper(x));
    }

    private static bool IsQuestion(string input)
    {
        return input.EndsWith("?");
    }
}
