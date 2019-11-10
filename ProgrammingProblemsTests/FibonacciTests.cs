using System;
using FluentAssertions;
using ProgrammingProblems;
using Xunit;

namespace ProgrammingProblemsTests
{
	public class FibonacciUsingIterativeSolutionTests : FibonacciTests
	{
		public FibonacciUsingIterativeSolutionTests() : base(new FibonacciUsingIterativeSolution())
		{
		}
	}

	public class FibonacciUsingRecursiveSolutionTests : FibonacciTests
	{
		public FibonacciUsingRecursiveSolutionTests() : base(new FibonacciUsingRecursiveSolution())
		{
		}
	}

	public abstract class FibonacciTests
	{
		private readonly IFibonacci _sut;

		protected FibonacciTests(IFibonacci sut)
		{
			_sut = sut;
		}
		private long FibonacciNumberAtIndex(int index)
		{
			return _sut.GetFibonacciNumberAtIndex(index);
		}

		[Fact]
		public void Returns0For1StFib()
		{
			FibonacciNumberAtIndex(1).Should().Be(0);
		}

		[Fact]
		public void Returns1For2ndFib()
		{
			FibonacciNumberAtIndex(2).Should().Be(1);
		}

		[Fact]
		public void Returns1For3rdFib()
		{
			FibonacciNumberAtIndex(3).Should().Be(1);
		}

		[Fact]
		public void Returns2For4ThFib()
		{
			FibonacciNumberAtIndex(4).Should().Be(2);
		}

		[Fact]
		public void Returns3For5ThFib()
		{
			FibonacciNumberAtIndex(5).Should().Be(3);
		}

		[Fact]
		public void Returns5For6ThFib()
		{
			FibonacciNumberAtIndex(6).Should().Be(5);
		}

		[Fact]
		public void ThrowsInvalidOperationFor0ThFib()
		{	
			Assert.Throws<InvalidOperationException>(() =>
				FibonacciNumberAtIndex(0));
		}

		[Fact]
		public void ThrowsInvalidOperationForNegative1ThFib()
		{
			Assert.Throws<InvalidOperationException>(() =>
				FibonacciNumberAtIndex(-1));
		}

		
	}
}