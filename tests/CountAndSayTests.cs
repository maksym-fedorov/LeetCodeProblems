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
        public void CountandSay_ValuesInRangeFromOneToFive_CorrectStringExpected(int n, string expected)
        {
            var actual = CountAndSay.Method(n);

            Assert.AreEqual(expected, actual);
        }
    }
}