namespace ProgrammingProblems
{
	public static class IntExtensions
	{
		public static bool DivisibleBy(this int number, int divider)
		{
			return number % divider == 0;
		}
	}

	public class FizBuzz
	{
		public string Test(int number)
		{
			var result = string.Empty;

			if (number.DivisibleBy(3))
				result = "Fiz";

			if (number.DivisibleBy(5))
				result += "Buzz";

			if (string.IsNullOrEmpty(result))
				result = number.ToString();

			return result;
		}
	}
}