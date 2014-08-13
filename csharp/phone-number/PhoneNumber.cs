using System.Text.RegularExpressions;

public class PhoneNumber
{
	private readonly string numbers;
	private readonly string areaCode;

	private static readonly Regex NumbersOnlyRegex = new Regex(@"[^0-9]");

	public PhoneNumber(string numbers)
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

		this.numbers = onlyNumbers;
		this.areaCode = onlyNumbers.Substring(0, 3);
	}

	public string Number
	{
		get { return this.numbers; }
	}

	public string AreaCode
	{
		get { return this.areaCode; }
	}

	public override string ToString()
	{
		return string.Format("({0}) {1}-{2}", this.areaCode, this.numbers.Substring(3, 3), this.numbers.Substring(6, 4));
	}
}