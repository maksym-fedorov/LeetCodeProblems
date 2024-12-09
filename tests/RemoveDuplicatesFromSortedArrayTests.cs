using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Problems.Tests
{
    [TestClass]
    public sealed class RemoveDuplicatesFromSortedArrayTests
    {
        [TestMethod]
        [DataRow(new int[] { 1, 2, 3 }, 3)]
        [DataRow(new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }, 5)]
        public void Run_RemovesDuplicatesAndReturnsArrayLength(int[] array, int expected)
        {
            // Act
            var actual = RemoveDuplicatesFromSortedArray.Run(array);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}