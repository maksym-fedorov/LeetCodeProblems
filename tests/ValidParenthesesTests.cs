using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LeetCode.Problems.Tests
{
    [TestClass]
    public sealed class ValidParenthesesTests
    {
        [TestMethod]
        [DataRow("[)", false)]
        [DataRow("[}", false)]
        [DataRow("[]", true)]
        [DataRow("{]", false)]
        [DataRow("{)", false)]
        [DataRow("{}", true)]
        [DataRow("(]", false)]
        [DataRow("(}", false)]
        [DataRow("()", true)]
        [DataRow("[{((])}]", false)]
        [DataRow("[(({}))[]{}]()", true)]
        public void Run_ChecksWhetherParenthesesAreValid(string value, bool expected)
        {
            // Act
            var actual = ValidParentheses.Run(value);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}