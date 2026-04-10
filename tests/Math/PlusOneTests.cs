using LeetCode.Problems.Math;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Problems.Tests.Math
{
    [TestClass]
    public sealed class PlusOneTests
    {
        [TestMethod]
        [DataRow(new int[] { 1, 2, 3 }, new int[] { 1, 2, 4 })]
        [DataRow(new int[] { 4, 3, 2, 1 }, new int[] { 4, 3, 2, 2 })]
        [DataRow(new int[] { 9 }, new int[] { 1, 0 })]
        [DataRow(new int[] { 9, 9, 9 }, new int[] { 1, 0, 0, 0 })]
        [DataRow(new int[] { 0 }, new int[] { 1 })]
        [DataRow(new int[] { 1, 9 }, new int[] { 2, 0 })]
        [DataRow(new int[] { 2, 9, 9 }, new int[] { 3, 0, 0 })]
        public void Run_ReturnsPlusOneResult(int[] digits, int[] expected)
        {
            // Arrange
            var sut = new PlusOne();

            // Act
            var actual = sut.Run(digits);

            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
