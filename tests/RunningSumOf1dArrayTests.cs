using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LeetCode.Problems.Tests
{
    [TestClass]
    public sealed class RunningSumOf1dArrayTests
    {
        [TestMethod]
        [DataRow(new int[] { 1, 2, 3, 4 }, new int[] { 1, 3, 6, 10 })]
        [DataRow(new int[] { 1, 1, 1, 1, 1 }, new int[] { 1, 2, 3, 4, 5 })]
        [DataRow(new int[] { 3, 1, 2, 10, 1 }, new int[] { 3, 4, 6, 16, 17 })]
        public void Run_ReturnsSumOf1dArray(int[] nums, int[] expected)
        {
            // Act
            var actual = RunningSumOf1dArray.Run(nums);

            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}