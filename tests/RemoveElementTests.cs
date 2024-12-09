using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Problems.Tests
{
    [TestClass]
    public sealed class RemoveElementFromArrayTests
    {
        [TestMethod]
        [DataRow(new int[] { 0, 0, 1, 1, 1, 3, 3, 4 }, 2, 8)]
        [DataRow(new int[] { 0, 0, 1, 1, 1, 3, 3, 4 }, 3, 6)]
        [DataRow(new int[] { 0, 0, 1, 1, 1, 2, 2, 3 }, 1, 5)]
        public void Run_RemovesElementFromArrayAndReturnsArrayLength(int[] array, int removeValue, int expected)
        {
            // Act
            var actual = RemoveElementFromArray.Run(array, removeValue);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}