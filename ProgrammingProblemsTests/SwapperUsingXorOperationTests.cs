using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProgrammingProblems.Tests
{
    [TestClass]
    public class SwapperUsingXorOperationTests
    {
        [TestMethod]
        public void SwapsPositiveValues()
        {
            // Arrange
            int a = 20, b = 30;

            // Act
            ITwoNumberSwapper sut = new SwapperUsingXorOperation();
            sut.Swap(ref a, ref b);

            // Assert
            Assert.AreEqual(30, a);
            Assert.AreEqual(20, b);
        }

        [TestMethod]
        public void SwapsNegativeValues()
        {
            // Arrange
            int a = -20, b = -30;

            // Act
            ITwoNumberSwapper sut = new SwapperUsingXorOperation();
            sut.Swap(ref a, ref b);

            // Assert
            Assert.AreEqual(-30, a);
            Assert.AreEqual(-20, b);
        }

        [TestMethod]
        public void SwapsZeros()
        {
            // Arrange
            int a = 0, b = 0;

            // Act
            ITwoNumberSwapper sut = new SwapperUsingXorOperation();
            sut.Swap(ref a, ref b);

            // Assert
            Assert.AreEqual(0, a);
            Assert.AreEqual(0, b);
        }

        [TestMethod]
        public void SwapsSameNonZeroValues()
        {
            // Arrange
            int a = 33, b = 33;

            // Act
            ITwoNumberSwapper sut = new SwapperUsingXorOperation();
            sut.Swap(ref a, ref b);

            // Assert
            Assert.AreEqual(33, a);
            Assert.AreEqual(33, b);
        }
    }
}