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
        public void Run_ReturnsPositionForInsertValueKeepingOrder(int[] array, int insertValue, int expected)
        {
            // Act
            var actual = SearchInsertPosition.Run(array, insertValue);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Run_ThrowsArgumentNullException_WhenArrayIsNull()
        {
            // Act
            // Assert
            Assert.ThrowsException<ArgumentNullException>(() => SearchInsertPosition.Run(null, 0));
        }
    }
}