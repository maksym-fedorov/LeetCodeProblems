using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LeetCode.Problems.Tests
{
    [TestClass]
    public sealed class BestTimeToBuyAndSellStockTests
    {
        [TestMethod]
        [DynamicData(nameof(GetTestData), DynamicDataSourceType.Method)]
        public void MaxProfit_ShouldReturnExpected(int[] prices, int expected)
        {
            // Arrange
            // Act
            var actual = BestTimeToBuyAndSellStock.MaxProfit(prices);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        private static IEnumerable<object[]> GetTestData()
        {
            yield return new object[] { new int[] { 1, 2 }, 1 };
            yield return new object[] { new int[] { 2, 4, 1 }, 2 };
            yield return new object[] { new int[] { 2, 1, 4 }, 3 };
            yield return new object[] { new int[] { 7, 6, 4, 3, 1 }, 0 };
            yield return new object[] { new int[] { 7, 1, 5, 3, 6, 4 }, 5 };
        }
    }
}