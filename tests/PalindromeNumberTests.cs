using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Problems.Tests
{
    [TestClass]
    public sealed class PalindromeNumberTests
    {
        [TestMethod]
        [DataRow(-1, false)]
        [DataRow(-11, false)]
        [DataRow(123320, false)]
        [DataRow(1, true)]
        [DataRow(11, true)]
        [DataRow(123321, true)]
        public void Run_ChecksWhetherTheNumberIsPalindrome(int value, bool expected)
        {
            var actual = PalindromeNumber.Run(value);

            Assert.AreEqual(expected, actual);
        }
    }
}