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
        public void Method_VerifiesParentheses(string value, bool expectedResult)
        {
            // Act
            var actualResult = ValidParentheses.Method(value);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}