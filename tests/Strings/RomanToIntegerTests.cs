using LeetCode.Problems.Strings;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Problems.Tests.Strings
{
    [TestClass]
    public sealed class RomanToIntegerTests
    {
        [TestMethod]
        [DataRow("IV", 4)]
        [DataRow("LVIII", 58)]
        [DataRow("XIX", 19)]
        public void Run_ReturnsIntegerNumberFromRomanValue(string value, int expected)
        {
            // Act
            var actual = RomanToInteger.Run(value);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
