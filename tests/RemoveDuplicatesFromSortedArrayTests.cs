using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Problems.Tests
{
    [TestClass]
    public sealed class RemoveDuplicatesFromSortedArrayTests
    {
        [TestMethod]
        [DataRow(new int[] { 1, 2, 3 }, 3)]
        [DataRow(new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }, 5)]
        public void Method_RemovesDuplicatesAndReturnsArrayLength(int[] array, int expectedResult)
        {
            // Act
            var actualResult = RemoveDuplicatesFromSortedArray.Method(array);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}