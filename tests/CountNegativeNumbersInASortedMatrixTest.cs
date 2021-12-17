using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LeetCode.Problems.Tests
{
    [TestClass]
    public sealed class CountNegativeNumbersInASortedMatrixTest
    {
        [TestMethod]
        [DynamicData(nameof(GetTestData), DynamicDataSourceType.Method)]
        public void Run_CountsNegativeNumbersInSortedMatrix(object obj, object expectedObj)
        {
            var matrix = (int[][])obj;
            var expected = (int)expectedObj;

            // Act
            var actual = CountNegativeNumbersInASortedMatrix.Run(matrix);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        private static IEnumerable<object[]> GetTestData()
        {
            // Arrange #0
            var matrix0 = new int[][] { new int[] { 4, 3, 2, -1 }, new int[] { 3, 2, 1, -1 }, new int[] { 1, 1, -1, -2 }, new int[] { -1, -1, -2, -3 } };
            yield return new object[] { matrix0, 8 };

            // Arrange #1
            var matrix1 = new int[][] { new int[] { 3, 2 }, new int[] { 1, 0 } };
            yield return new object[] { matrix1, 0 };

            // Arrange #2
            var matrix2 = new int[][] { new int[] { 1, -1 }, new int[] { -1, -1 } };
            yield return new object[] { matrix2, 3 };

            // Arrange #3
            var matrix3 = new int[][] { new int[] { -1 } };
            yield return new object[] { matrix3, 1 };

            // Arrange #4
            var matrix4 = new int[][] { new int[] { 5, 1, 0 }, new int[] { -5, -5, -5 } };
            yield return new object[] { matrix4, 3 };
        }
    }
}