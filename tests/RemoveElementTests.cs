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
        public void Method_RemovesElementFromArrayAndReturnsArrayLength(int[] array, int removeValue, int expectedResult)
        {
            // Act
            var actualResult = RemoveElementFromArray.Method(array, removeValue);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}