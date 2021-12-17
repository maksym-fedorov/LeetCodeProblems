using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LeetCode.Problems.Tests
{
    [TestClass]
    public sealed class FindNUniqueIntegersSumUpToZeroTests
    {
        [TestMethod]
        [DataRow(4, new int[] { -1, -2, 2, 1 })]
        [DataRow(5, new int[] { -1, -2, 0, 2, 1 })]
        public void Run_FindsNUniqueIntegersSumUpToZero(int n, int[] expected)
        {
            // Act
            var actual = FindNUniqueIntegersSumUpToZero.Run(n);

            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}