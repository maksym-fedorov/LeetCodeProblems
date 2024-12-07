using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Problems.Tests
{
    [TestClass]
    public sealed class ReverseWordsTests
    {
        [TestMethod]
        [DataRow("Let's take LeetCode contest", "s'teL ekat edoCteeL tsetnoc")]
        [DataRow("God Ding", "doG gniD")]
        public void Run_ReturnsStringWithReversedCharactersInEachWord(string s, string expected)
        {
            // Act
            var actual = ReverseWords.Run(s);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}