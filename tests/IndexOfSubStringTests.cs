using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Problems.Tests
{
    [TestClass]
    public sealed class IndexOfSubStringTests
    {
        [TestMethod]
        public void IndexOfSubStringBruteForce_EmptyStringEmptySubString_ZeroExpected()
        {
            var actual = IndexOfSubstring.MethodKMP(string.Empty, string.Empty);

            Assert.AreEqual(0, actual);
        }

        [TestMethod]
        public void IndexOfSubStringBruteForce_EmptyStringNonEmptySubString_NegativeNumberExpected()
        {
            var actual = IndexOfSubstring.MethodKMP(string.Empty, "AAA");

            Assert.AreEqual(-1, actual);
        }

        [TestMethod]
        public void IndexOfSubStringBruteForce_NonEmptyStringEmptySubString_ZeroExpected()
        {
            var actual = IndexOfSubstring.MethodKMP("AAA", string.Empty);

            Assert.AreEqual(0, actual);
        }

        [TestMethod]
        public void IndexOfSubStringBruteForce_StringDoesntContainSubstring_NegativeNumberExpected()
        {
            var actual = IndexOfSubstring.MethodKMP("ABCABCBABCABC", "BAB");

            Assert.AreEqual(6, actual);
        }

        [TestMethod]
        public void IndexOfSubStringBruteForce_StringContainsSubstringAtTheBegining_ZeroNumberExpected()
        {
            var actual = IndexOfSubstring.MethodKMP("AAABBBAAA", "AA");

            Assert.AreEqual(0, actual);
        }

        [TestMethod]
        public void IndexOfSubStringBruteForce_StringContainsSubstringAtTheMiddle_PositiveNumberExpected()
        {
            var actual = IndexOfSubstring.MethodKMP("AABAAABAAAC", "AABAAAC");

            Assert.AreEqual(4, actual);
        }

        [TestMethod]
        public void IndexOfSubStringKMP_EmptyStringEmptySubString_ZeroExpected()
        {
            var actual = IndexOfSubstring.MethodKMP(string.Empty, string.Empty);

            Assert.AreEqual(0, actual);
        }

        [TestMethod]
        public void IndexOfSubStringKMP_EmptyStringNonEmptySubString_NegativeNumberExpected()
        {
            var actual = IndexOfSubstring.MethodKMP(string.Empty, "AAA");

            Assert.AreEqual(-1, actual);
        }

        [TestMethod]
        public void IndexOfSubStringKMP_NonEmptyStringEmptySubString_ZeroExpected()
        {
            var actual = IndexOfSubstring.MethodKMP("AAA", string.Empty);

            Assert.AreEqual(0, actual);
        }

        [TestMethod]
        public void IndexOfSubStringKMP_StringDoesntContainSubstring_NegativeNumberExpected()
        {
            var actual = IndexOfSubstring.MethodKMP("ABCABCBABCABC", "BAB");

            Assert.AreEqual(6, actual);
        }

        [TestMethod]
        public void IndexOfSubStringKMP_StringContainsSubstringAtTheBegining_ZeroNumberExpected()
        {
            var actual = IndexOfSubstring.MethodKMP("AAABBBAAA", "AA");

            Assert.AreEqual(0, actual);
        }

        [TestMethod]
        public void IndexOfSubStringKMP_StringContainsSubstringAtTheMiddle_PositiveNumberExpected()
        {
            var actual = IndexOfSubstring.MethodKMP("AABAAABAAAC", "AABAAAC");

            Assert.AreEqual(4, actual);
        }
    }
}