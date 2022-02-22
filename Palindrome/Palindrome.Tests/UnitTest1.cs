using NUnit.Framework;

namespace Palindrome.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestStringIsReversed()
        {
            var wordToCheck = "12345";
            var considerOnlyAlphabets = false;
            var stringManipulator = new StringManipulators();
            var result = stringManipulator.Reverse(wordToCheck, considerOnlyAlphabets);

            Assert.AreEqual(result.reversed, "54321");
        }

        [Test]
        public void TestMadamIsPalindromeWhenConsideringAlphabets()
        {
            var wordToCheck = "madam";
            var considerOnlyAlphabets = true;
            var stringManipulator = new StringManipulators();
            var checker = new PalindromeChecker(stringManipulator);
            var result = checker.IsPalindrome(wordToCheck, considerOnlyAlphabets);

            Assert.AreEqual(result, true);
        }

        [Test]
        public void TestMadamIsPalindromeWhenNotConsideringAlphabets()
        {
            var wordToCheck = "madam";
            var considerOnlyAlphabets = false;
            var stringManipulator = new StringManipulators();
            var checker = new PalindromeChecker(stringManipulator);
            var result = checker.IsPalindrome(wordToCheck, considerOnlyAlphabets);

            Assert.AreEqual(result, true);
        }

        [Test]
        public void TestMadamWithNonLetterIsPalindromeWhenNotConsideringAlphabets()
        {
            var wordToCheck = "ma-dam";
            var considerOnlyAlphabets = false;
            var stringManipulator = new StringManipulators();
            var checker = new PalindromeChecker(stringManipulator);
            var result = checker.IsPalindrome(wordToCheck, considerOnlyAlphabets);

            Assert.AreEqual(result, false);
        }

        [Test]
        public void TestMadamWithNonLetterIsPalindromeWhenConsideringAlphabets()
        {
            var wordToCheck = "ma-dam";
            var considerOnlyAlphabets = true;
            var stringManipulator = new StringManipulators();
            var checker = new PalindromeChecker(stringManipulator);
            var result = checker.IsPalindrome(wordToCheck, considerOnlyAlphabets);

            Assert.AreEqual(result, true);
        }


    }
}