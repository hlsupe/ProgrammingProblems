using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProgrammingProblems.Tests
{
    [TestClass]
    public class FibonacciUsingRecursiveSolutionTests
    {
        [TestMethod]
        public void Returns0For1StFib()
        {
            Assert.AreEqual(0, new FibonacciUsingRecursiveSolution().GetFibonacciNumberAtIndex(1));
        }

        [TestMethod]
        public void Returns1For2ndFib()
        {
            Assert.AreEqual(1, new FibonacciUsingRecursiveSolution().GetFibonacciNumberAtIndex(2));
        }

        [TestMethod]
        public void Returns1For3rdFib()
        {
            Assert.AreEqual(1, new FibonacciUsingRecursiveSolution().GetFibonacciNumberAtIndex(3));
        }

        [TestMethod]
        public void Returns2For4ThFib()
        {
            Assert.AreEqual(2, new FibonacciUsingRecursiveSolution().GetFibonacciNumberAtIndex(4));
        }

        [TestMethod]
        public void Returns3For5ThFib()
        {
            Assert.AreEqual(3, new FibonacciUsingRecursiveSolution().GetFibonacciNumberAtIndex(5));
        }

        [TestMethod]
        public void Returns5For6ThFib()
        {
            Assert.AreEqual(5, new FibonacciUsingRecursiveSolution().GetFibonacciNumberAtIndex(6));
        }

        [TestMethod]
        public void ThrowsInvalidOperationFor0ThFib()
        {
            Assert.ThrowsException<InvalidOperationException>(() =>
                new FibonacciUsingRecursiveSolution().GetFibonacciNumberAtIndex(0));
        }

        [TestMethod]
        public void ThrowsInvalidOperationForNegative1ThFib()
        {
            Assert.ThrowsException<InvalidOperationException>(() =>
                new FibonacciUsingRecursiveSolution().GetFibonacciNumberAtIndex(-1));
        }
    }
}