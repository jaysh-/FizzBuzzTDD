namespace FizzBuzz
{
	public class FizzBuzzin
	{
		public static string GetNthFizzBuzz(int n)
		{
			if (IsAMultipleOfThree(n))
			{
				return "Fizz";
			}

			if (n % 5 == 0)
			{
				return "Buzz";
			}
			return n.ToString();
		}

		private static bool IsAMultipleOfThree(int n)
		{
			return n % 3 == 0;
		}
	}
}
