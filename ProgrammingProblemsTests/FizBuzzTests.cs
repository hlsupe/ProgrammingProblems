using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProgrammingProblems.Tests
{
    [TestClass]
    public class FizBuzzTests
    {
        [TestMethod]
        public void ReturnsFizBuzzWhen0Provided()
        {
            Assert.AreEqual("FizBuzz", new FizBuzz().Test(0));
        }

        [TestMethod]
        public void ReturnsFizWhen3Provided()
        {
            Assert.AreEqual("Fiz", new FizBuzz().Test(3));
        }

        [TestMethod]
        public void ReturnsBuzzWhen5Provided()
        {
            Assert.AreEqual("Buzz", new FizBuzz().Test(5));
        }

        [TestMethod]
        public void ReturnsFizBuzzWhen15Provided()
        {
            Assert.AreEqual("FizBuzz", new FizBuzz().Test(15));
        }

        [TestMethod]
        public void Test1Thru20()
        {
            FizBuzz sut = new FizBuzz();
            StringBuilder sb = new StringBuilder();
            Enumerable.Range(1, 20).ToList().ForEach(x => sb.Append(sut.Test(x) + " "));

            string expected = "1 2 Fiz 4 Buzz Fiz 7 8 Fiz Buzz 11 Fiz 13 14 FizBuzz 16 17 Fiz 19 Buzz ";
            string actual = sb.ToString();
            Assert.AreEqual(expected, actual);
        }
    }
}