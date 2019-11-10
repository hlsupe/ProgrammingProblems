using FluentAssertions;
using ProgrammingProblems;
using Xunit;

namespace ProgrammingProblemsTests
{
	public class SwapperUsingXorOperationTests : SwapperTests
	{
		public SwapperUsingXorOperationTests() : base(new SwapperUsingXorOperation())
		{
		}
	}

	public class SwapperUsingArithmeticOperationTests: SwapperTests
	{
		public SwapperUsingArithmeticOperationTests() : base(new SwapperUsingArithmeticOperation())
		{
		}
	}

	public abstract class SwapperTests
	{
		private readonly ITwoNumberSwapper _sut;

		protected SwapperTests(ITwoNumberSwapper sut)
		{
			_sut = sut;
		}

		[Fact]
		public void SwapsPositiveValues()
		{
			// Arrange
			int a = 20, b = 30;

			// Act
			_sut.Swap(ref a, ref b);

			// Assert
			a.Should().Be(30);
			b.Should().Be(20);
		}

		[Fact]
		public void SwapsNegativeValues()
		{
			// Arrange
			int a = -20, b = -30;

			// Act
			_sut.Swap(ref a, ref b);

			// Assert
			a.Should().Be(-30);
			b.Should().Be(-20);
		}

		[Fact]
		public void SwapsZeros()
		{
			// Arrange
			int a = 0, b = 0;

			// Act
			_sut.Swap(ref a, ref b);

			// Assert
			a.Should().Be(0);
			b.Should().Be(0);
		}

		[Fact]
		public void SwapsSameNonZeroValues()
		{
			// Arrange
			int a = 33, b = 33;

			// Act
			_sut.Swap(ref a, ref b);

			// Assert
			a.Should().Be(33);
			b.Should().Be(33);
		}
	}
}