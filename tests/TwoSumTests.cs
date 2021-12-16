using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace LeetCode.Problems.Tests
{
    [TestClass]
    public sealed class TwoSumTests
    {
        [TestMethod]
        public void Method_ThrowsArgumentException_WhenNoElementsWhichProducesSum()
        {
            // Arrange
            var array = new int[] { 1, 3, 5, -2, -4 };
            var sum = 7;

            // Act
            var exception = Assert.ThrowsException<ArgumentException>(() => TwoSum.Method(array, sum));

            // Assert
            Assert.AreEqual("Incorrect input data", exception.Message);
        }

        [TestMethod]
        [DynamicData(nameof(GetTestData), DynamicDataSourceType.Method)]
        public void Method_ReturnsPairOfIndiciesOfElementsWhichProducesSum(int[] array, int sum, ValueTuple<int, int> expectedResult)
        {
            // Act
            var actualResult = TwoSum.Method(array, sum);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        private static IEnumerable<object[]> GetTestData()
        {
            yield return new object[] { new int[] { 1, 3, 5, -2, -4 }, 4, ValueTuple.Create(0, 1) };
            yield return new object[] { new int[] { -3, 3, 5, 0, -4 }, -1, ValueTuple.Create(1, 4) };
            yield return new object[] { new int[] { -2, 3, 5, 9 }, 7, ValueTuple.Create(0, 3) };
        }
    }
}