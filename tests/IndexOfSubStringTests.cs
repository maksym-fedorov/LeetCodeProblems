using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Problems.Tests
{
    [TestClass]
    public sealed class IndexOfSubStringTests
    {
        [TestMethod]
        [DataRow("", "", 0)]
        [DataRow("", "AAA", -1)]
        [DataRow("AAA", "", 0)]
        [DataRow("ABCABCBABCABC", "BAC", -1)]
        [DataRow("AAABBBAAA", "AA", 0)]
        [DataRow("AABAAABAAAC", "AABAAAC", 4)]
        public void Run_ReturnsIndexOfSubstring(string str, string subStr, int expected)
        {
            // Act
            var actual = IndexOfSubstring.Run(str, subStr);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}