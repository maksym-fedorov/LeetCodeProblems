using LeetCode.Problems.TwoPointers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Problems.Tests.TwoPointers
{
    [TestClass]
    public sealed class ContainerWithMostWaterTests
    {
        [TestMethod]
        [DataRow(49, 1, 8, 6, 2, 5, 4, 8, 3, 7)]
        [DataRow(1, 1, 1)]
        [DataRow(16, 4, 3, 2, 1, 4)]
        [DataRow(2, 1, 2, 1)]
        [DataRow(17, 2, 3, 4, 5, 18, 17, 6)]
        public void GetMaxArea_ReturnsMaxArea(int expected, params int[] heights)
        {
            // Act
            var actual = ContainerWithMostWater.GetMaxArea(heights);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
