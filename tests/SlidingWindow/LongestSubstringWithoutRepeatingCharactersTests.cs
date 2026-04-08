using LeetCode.Problems.SlidingWindow;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Problems.Tests.SlidingWindow
{
    [TestClass]
    public sealed class LongestSubstringWithoutRepeatingCharactersTests
    {
        [TestMethod]
        [DataRow("abcabcbb", 3)]
        [DataRow("bbbbb", 1)]
        [DataRow("pwwkew", 3)]
        [DataRow("", 0)]
        [DataRow(" ", 1)]
        [DataRow("au", 2)]
        [DataRow("dvdf", 3)]
        public void LengthOfLongestSubstring_ReturnsExpectedLength(string input, int expected)
        {
            // Act
            var actual = LongestSubstringWithoutRepeatingCharacters.LengthOfLongestSubstring(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
