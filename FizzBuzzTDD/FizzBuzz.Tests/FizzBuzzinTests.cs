using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;
using static FizzBuzz.FizzBuzzin;

namespace FizzBuzz.Tests
{

	[TestClass]
	public class FizzBuzzinTests
	{
		[TestMethod]
		public void NoFizzOrBuzz()
		{
			GetNthFizzBuzz(1).ShouldBe("1");
		}

		[TestMethod]
		public void OneFizz()
		{
			GetNthFizzBuzz(3).ShouldBe("Fizz");
		}

		[TestMethod]
		public void OneBuzz()
		{
			GetNthFizzBuzz(5).ShouldBe("Buzz");
		}

		[TestMethod]
		public void OneFizzBuzz()
		{
			GetNthFizzBuzz(15).ShouldBe("Fizz Buzz");
		}

		[TestMethod]
		public void NaturalsFrom1To31Inclusive()
		{
			var expected = "1, 2, Fizz, 4, Buzz, Fizz, 7, 8, Fizz, Buzz, 11, Fizz, 13, 14, Fizz Buzz, 16, 17," +
			               " Fizz, 19, Buzz, Fizz, 22, 23, Fizz, Buzz, 26, Fizz, 28, 29, Fizz Buzz, 31";
			var actual = GetFizzBuzzFromOneToN_Inclusive(to: 31);
			actual.ShouldBe(expected);
		}

	}
}
