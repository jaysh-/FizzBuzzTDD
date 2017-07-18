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
	}
}
