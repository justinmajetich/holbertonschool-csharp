using NUnit.Framework;

namespace Text.Tests
{
    public class StrTests
    {
        [TestCase("racecar")]
        [TestCase("LEVEL")]
        [TestCase("daD")]
        [TestCase("RaCeCAr")]
        public void IsPalindrome_WhenStringIsPalindrome_ReturnsTrue(string testString)
        {
            // Act
            bool isPalindrome = Str.IsPalindrome(testString);

            // Assert
            Assert.That(isPalindrome == true);
        }

        [TestCase("ra ce ca     r")]
        [TestCase("L:EV EL...")]
        [TestCase("da,,,,D")]
        [TestCase("R aC   eC:::::,,Ar")]
        public void IsPalindrome_WhenStringIsPalindromeWithSpaceAndOrPunctuation_ReturnsTrue(string testString)
        {
            // Act
            bool isPalindrome = Str.IsPalindrome(testString);

            // Assert
            Assert.That(isPalindrome == true);
        }

        [Test]
        public void IsPalindrome_WhenStringIsEmpty_ReturnsTrue()
        {
            // Arrange - init empty string
            var testString = string.Empty;

            // Act
            bool isPalindrome = Str.IsPalindrome(testString);

            // Assert
            Assert.That(isPalindrome == true);
        }

        [TestCase("Mother")]
        [TestCase("brother")]
        [TestCase("FATHER")]
        public void IsPalindrome_WhenStringIsNotPalindrome_ReturnsFalse(string testString)
        {
            // Act
            bool isPalindrome = Str.IsPalindrome(testString);

            // Assert
            Assert.That(isPalindrome == false);
        }
    }
}