using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entities;

namespace Tests
{
    [TestClass]
    public class PalindromeCheckerTests
    {
        [TestMethod]
        public void CheckEmptyStringIsPalindromeTest()
        {
            PalindromeChecker checker = new PalindromeChecker();

            Assert.IsTrue(checker.Check(""));
        }

        [TestMethod]
        public void CheckStringLengthOneIsPalindromeTest()
        {
            PalindromeChecker checker = new PalindromeChecker();

            Assert.IsTrue(checker.Check("A"));
        }

        [TestMethod]
        public void CheckStringLengthTwoIsPalindromeTest()
        {
            PalindromeChecker checker = new PalindromeChecker();

            Assert.IsTrue(checker.Check("AA"));
        }

        [TestMethod]
        public void CheckStringLengthTwoIsNotPalindromeTest()
        {
            PalindromeChecker checker = new PalindromeChecker();

            Assert.IsFalse(checker.Check("AB"));
        }

        [TestMethod]
        public void CheckStringLength2NIsPalindromeTest()
        {
            PalindromeChecker checker = new PalindromeChecker();

            Assert.IsTrue(checker.Check("ABBA"));
        }

        [TestMethod]
        public void CheckStringLength2NIsNotPalindromeTest()
        {
            PalindromeChecker checker = new PalindromeChecker();

            Assert.IsFalse(checker.Check("ABBC"));
        }

        [TestMethod]
        public void CheckStringLength2N1IsPalindromeTest()
        {
            PalindromeChecker checker = new PalindromeChecker();

            Assert.IsTrue(checker.Check("ABCBA"));
        }

        [TestMethod]
        public void CheckStringLength2N1IsNotPalindromeTest()
        {
            PalindromeChecker checker = new PalindromeChecker();

            Assert.IsFalse(checker.Check("ABCBC"));
        }
    }
}
