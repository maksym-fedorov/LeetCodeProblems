using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LeetCode.Problems.Tests
{
    [TestClass]
    public sealed class SearchInsertPositionTests
    {
        [TestMethod]
        [DataRow(new int[0], 1, 0)]
        [DataRow(new int[] { 1 }, 1, 0)]
        [DataRow(new int[] { 1, 2, 4 }, -1, 0)]
        [DataRow(new int[] { 1, 2 }, 3, 2)]
        [DataRow(new int[] { 1, 2, 3, 7, 9 }, 5, 3)]
        public void Method_ReturnsPositionForInsertValueKeepingOrder(int[] array, int insertValue, int expectedResult)
        {
            // Act
            var actualResult = SearchInsertPosition.Method(array, insertValue);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Method_ThrowsArgumentNullException_WhenArrayIsNull()
        {
            // Act
            // Assert
            Assert.ThrowsException<ArgumentNullException>(() => SearchInsertPosition.Method(null, 0));
        }
    }
}