using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Problems.Tests
{
    [TestClass]
    public sealed class RomanToIntegerTests
    {
        [TestMethod]
        [DataRow("IV", 4)]
        [DataRow("LVIII", 58)]
        [DataRow("XIX", 19)]
        public void Method_ReturnsIntegerNumberFromRomanValue(string value, int expectedResult)
        {
            // Act
            var actualResult = RomanToInteger.Method(value);

            // Assert
            Assert.AreEqual(actualResult, expectedResult);
        }
    }
}