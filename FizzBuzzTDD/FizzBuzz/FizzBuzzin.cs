namespace FizzBuzz
{
	public class FizzBuzzin
	{
		public static string GetNthFizzBuzz(int n)
		{
			if (IsaMultipleOfThree(n))
			{
				return "Fizz";
			}
			else if (IsaMultipleOfFive(n))
			{
				return "Buzz";
			}
			return n.ToString();
		}

		private static bool IsaMultipleOfFive(int n)
		{
			return n % 5 == 0;
		}

		private static bool IsaMultipleOfThree(int n)
		{
			return n % 3 == 0;
		}
	}
}
