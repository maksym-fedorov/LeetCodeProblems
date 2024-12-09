using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Problems.Tests
{
    [TestClass]
    public sealed class ReverseStringTests
    {
        [TestMethod]
        [DataRow(new[] { 'h', 'e', 'l', 'l', 'o' }, new[] { 'o', 'l', 'l', 'e', 'h' })]
        [DataRow(new[] { 'H', 'a', 'n', 'n', 'a', 'h' }, new[] { 'h', 'a', 'n', 'n', 'a', 'H' })]
        public void Run_ReversesString(char[] s, char[] expected)
        {
            // Act
            ReverseString.Run(s);
            var actual = s;

            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}