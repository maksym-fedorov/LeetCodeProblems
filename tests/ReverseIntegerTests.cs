using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Problems.Tests
{
    [TestClass]
    public sealed class ReverseIntegerTests
    {
        [TestMethod]
        [DataRow(0, 0)]
        [DataRow(1234567899, 0)]
        [DataRow(-123, -321)]
        [DataRow(321, 123)]
        public void Method_ReturnsReversedValue(int value, int expectedResult)
        {
            // Act
            var actualResult = ReverseInteger.Method(value);

            // Assert
            Assert.AreEqual(actualResult, expectedResult);
        }
    }
}