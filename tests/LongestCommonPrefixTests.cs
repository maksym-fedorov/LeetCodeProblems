using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Problems.Tests
{
    [TestClass]
    public sealed class LongestCommonPrefixTests
    {
        [TestMethod]
        [DataRow(new string[] { "flower", "flow", "light" }, "")]
        [DataRow(new string[] { "flower", "flow", "flight" }, "fl")]
        public void Run_ReturnsLongestCommonPrefixInArrayOfStrings(string[] array, string expected)
        {
            var actual = LongestCommonPrefix.Run(array);

            Assert.AreEqual(expected, actual);
        }
    }
}