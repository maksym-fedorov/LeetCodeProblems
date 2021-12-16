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
        public void Run_ReturnsReversedValue(int value, int expected)
        {
            // Act
            var actual = ReverseInteger.Run(value);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}