using System.Text.RegularExpressions;

public class PhoneNumber
{
	private static readonly Regex NumbersOnlyRegex = new Regex(@"[^0-9]");

	public PhoneNumber(string numbers)
	{
		this.Number = PhoneNumber.ParseNumbers(numbers);
		this.AreaCode = this.Number.Substring(0, 3);
	}

	public string Number { get; private set; }

	public string AreaCode { get; private set; }

	private static string ParseNumbers(string numbers)
	{
		var onlyNumbers = PhoneNumber.NumbersOnlyRegex.Replace(numbers, string.Empty);

		if (onlyNumbers.Length == 11 && onlyNumbers[0] == '1')
		{
			onlyNumbers = onlyNumbers.Substring(1);
		}
		else if (onlyNumbers.Length != 10)
		{
			onlyNumbers = "0000000000";
		}

		return onlyNumbers;
	}

	public override string ToString()
	{
		return string.Format("({0}) {1}-{2}", this.AreaCode, this.Number.Substring(3, 3), this.Number.Substring(6));
	}
}