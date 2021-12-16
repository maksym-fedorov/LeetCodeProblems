using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Problems.Tests
{
    [TestClass]
    public sealed class LongestCommonPrefixTests
    {
        [TestMethod]
        [DataRow(new string[] { "flower", "flow", "light" }, "")]
        [DataRow(new string[] { "flower", "flow", "flight" }, "fl")]
        public void Method_ReturnsLongestCommonPrefixInArrayOfStrings(string[] array, string expectedResult)
        {
            var actualResult = LongestCommonPrefix.Method(array);

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}