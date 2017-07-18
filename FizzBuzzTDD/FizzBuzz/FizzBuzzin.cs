using System.Linq;

namespace FizzBuzz
{
	public class FizzBuzzin
	{
		public static string GetNthFizzBuzz(int n)
		{
			if (IsaMultipleOfFive(n) && IsaMultipleOfThree(n))
			{
				return "Fizz Buzz";
			}
			else if (IsaMultipleOfThree(n))
			{
				return "Fizz";
			}
			else if (IsaMultipleOfFive(n))
			{
				return "Buzz";
			}
			else
			{
				return n.ToString();
			}
		}


		public static string GetFizzBuzzFromOneToN_Inclusive(int to)
		{
			var result = "";

			foreach (int i in Enumerable.Range(1, to - 1))
			{
				result += (GetNthFizzBuzz(i) + ", ");
			}
			//Fence Post due to comma
			result += GetNthFizzBuzz(to);

			return result;
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
