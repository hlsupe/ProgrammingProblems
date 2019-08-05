using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProgrammingProblems.Tests
{
    [TestClass]
    public class FibonacciUsingIterativeSolutionTests
    {
        [TestMethod]
        public void Returns0For1StFib()
        {
            Assert.AreEqual(0, new FibonacciUsingIterativeSolution().GetFibonacciNumberAtIndex(1));
        }

        [TestMethod]
        public void Returns1For2ndFib()
        {
            Assert.AreEqual(1, new FibonacciUsingIterativeSolution().GetFibonacciNumberAtIndex(2));
        }

        [TestMethod]
        public void Returns1For3rdFib()
        {
            Assert.AreEqual(1, new FibonacciUsingIterativeSolution().GetFibonacciNumberAtIndex(3));
        }

        [TestMethod]
        public void Returns2For4ThFib()
        {
            Assert.AreEqual(2, new FibonacciUsingIterativeSolution().GetFibonacciNumberAtIndex(4));
        }

        [TestMethod]
        public void Returns3For5ThFib()
        {
            Assert.AreEqual(3, new FibonacciUsingIterativeSolution().GetFibonacciNumberAtIndex(5));
        }

        [TestMethod]
        public void Returns5For6ThFib()
        {
            Assert.AreEqual(5, new FibonacciUsingIterativeSolution().GetFibonacciNumberAtIndex(6));
        }

        [TestMethod]
        public void ThrowsInvalidOperationFor0ThFib()
        {
            Assert.ThrowsException<InvalidOperationException>(() =>
                new FibonacciUsingIterativeSolution().GetFibonacciNumberAtIndex(0));
        }

        [TestMethod]
        public void ThrowsInvalidOperationForNegative1ThFib()
        {
            Assert.ThrowsException<InvalidOperationException>(() =>
                new FibonacciUsingIterativeSolution().GetFibonacciNumberAtIndex(-1));
        }
    }
}