public static class Year
{
    public static bool IsLeap(int year)
    {
        return year.IsDivisibleBy(4) &&
            (!year.IsDivisibleBy(100) ||
            year.IsDivisibleBy(400));
    }

    private static bool IsDivisibleBy(this int number, int divisor)
    {
        return number % divisor == 0;
    }
}