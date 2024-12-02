using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace LeetCode.Problems.Tests
{
    [TestClass]
    public sealed class TwoSumTests
    {
        [TestMethod]
        [DynamicData(nameof(GetTestData), DynamicDataSourceType.Method)]
        public void Run_ReturnsPairOfIndiciesOfElementsWhichProducesSum(int[] array, int sum, int[] expected)
        {
            // Act
            var actual = TwoSum.Run(array, sum);

            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        private static IEnumerable<object[]> GetTestData()
        {
            yield return new object[] { new int[] { 1, 3, 5, -2, -4 }, 4, new int[] { 0, 1 } };
            yield return new object[] { new int[] { -3, 3, 5, 0, -4 }, -1, new int[] { 1, 4 } };
            yield return new object[] { new int[] { -2, 3, 5, 9 }, 7, new int[] { 0, 3 } };
        }
    }
}