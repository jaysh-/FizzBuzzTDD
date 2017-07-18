namespace FizzBuzz
{
	public class FizzBuzzin
	{
		public static string GetNthFizzBuzz(int n)
		{
			if (n % 3 == 0)
			{
				return "Fizz";
			}
			return n.ToString();
		}
	}
}
