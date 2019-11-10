using System.Linq;
using System.Text;
using FluentAssertions;
using ProgrammingProblems;
using Xunit;

namespace ProgrammingProblemsTests
{
	
	public class FizBuzzTests
	{
		[Fact]
		public void ReturnsFizBuzzWhen0Provided()
		{
			FizBuzzTest(0).Should().Be("FizBuzz");
		}

		[Fact]
		public void ReturnsFizWhen3Provided()
		{
			FizBuzzTest(3).Should().Be("Fiz");
		}

		[Fact]
		public void ReturnsBuzzWhen5Provided()
		{
			FizBuzzTest(5).Should().Be("Buzz");
		}

		[Fact]
		public void ReturnsFizBuzzWhen15Provided()
		{
			FizBuzzTest(15).Should().Be("FizBuzz");
		}

		[Fact]
		public void Test1Thru20()
		{
			var sut = new FizBuzz();
			var sb = new StringBuilder();
			Enumerable.Range(1, 20).ToList().ForEach(x => sb.Append(sut.Test(x) + " "));

			var expected = "1 2 Fiz 4 Buzz Fiz 7 8 Fiz Buzz 11 Fiz 13 14 FizBuzz 16 17 Fiz 19 Buzz ";
			var actual = sb.ToString();
			actual.Should().Be(expected);
		}

		private static string FizBuzzTest(int number)
		{
			return new FizBuzz().Test(number);
		}
	}
}