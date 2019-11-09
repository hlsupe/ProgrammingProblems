using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProgrammingProblems;

namespace ProgrammingProblemsTests
{
	//TODO Use Xunit pattern to eliminate duplication of code in FibonacciUsingIterativeSolutionTests and FibonacciUsingRecursiveSolutionTests 
	[TestClass]
	public class FibonacciUsingIterativeSolutionTests
	{
		[TestMethod]
		public void Returns0For1StFib()
		{
			FibonacciNumberAtIndex(1).Should().Be(0);
		}

		[TestMethod]
		public void Returns1For2ndFib()
		{
			FibonacciNumberAtIndex(2).Should().Be(1);
		}

		[TestMethod]
		public void Returns1For3rdFib()
		{
			FibonacciNumberAtIndex(3).Should().Be(1);
		}

		[TestMethod]
		public void Returns2For4ThFib()
		{
			FibonacciNumberAtIndex(4).Should().Be(2);
		}

		[TestMethod]
		public void Returns3For5ThFib()
		{
			FibonacciNumberAtIndex(5).Should().Be(3);
		}

		[TestMethod]
		public void Returns5For6ThFib()
		{
			FibonacciNumberAtIndex(6).Should().Be(5);
		}

		[TestMethod]
		public void ThrowsInvalidOperationFor0ThFib()
		{
			Assert.ThrowsException<InvalidOperationException>(() =>
				FibonacciNumberAtIndex(0));
		}

		[TestMethod]
		public void ThrowsInvalidOperationForNegative1ThFib()
		{
			Assert.ThrowsException<InvalidOperationException>(() =>
				FibonacciNumberAtIndex(-1));
		}

		private static long FibonacciNumberAtIndex(int index)
		{
			return new FibonacciUsingIterativeSolution().GetFibonacciNumberAtIndex(index);
		}
	}
}