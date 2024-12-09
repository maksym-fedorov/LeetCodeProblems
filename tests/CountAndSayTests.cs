using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Problems.Tests
{
    [TestClass]
    public sealed class CountAndSayTests
    {
        [TestMethod]
        [DataRow(1, "1")]
        [DataRow(2, "11")]
        [DataRow(3, "21")]
        [DataRow(4, "1211")]
        [DataRow(5, "111221")]
        public void Run_ValuesInRangeFromOneToFive_CorrectStringExpected(int n, string expected)
        {
            // Act
            var actual = CountAndSay.Run(n);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}