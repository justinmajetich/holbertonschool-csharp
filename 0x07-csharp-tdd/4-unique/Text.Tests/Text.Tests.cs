using NUnit.Framework;

namespace Text.Tests
{
    public class StrTests
    {
        [TestCase("sass")]
        [TestCase("ttoottaally")]
        [TestCase("inn")]
        [TestCase("palindrome")]
        public void UniqueChar_WhenOneUniqueChar_ReturnCorrectIndex(string s)
        {
            // Arrange
            int expectedOutput = -1;

            for (var i = 0; i < s.Length; i++)
            {
                // If current character does not appear elsewhere in string
                if (s.Substring(i + 1).Contains(s[i].ToString()) == false &&
                    s.Substring(0, i).Contains(s[i].ToString()) == false)
                {
                    expectedOutput = i;
                    break;
                }
            }

            // Act
            var result = Str.UniqueChar(s);

            // Assert
            Assert.That(result == expectedOutput);
        }

        [TestCase("s")]
        [TestCase("i")]
        public void UniqueChar_WhenStringIsOneCharLong_ReturnCorrectIndex(string s)
        {
            // Act
            var result = Str.UniqueChar(s);

            // Assert
            Assert.That(result == 0);
        }

        [TestCase("string")]
        [TestCase("strings")]
        [TestCase("obsolete")]
        [TestCase("perfectly")]
        public void UniqueChar_WhenManyUniqueChars_ReturnCorrectIndex(string s)
        {
            // Arrange
            int expectedOutput = -1;
            for (var i = 0; i < s.Length; i++)
            {
                // If current character does not appear elsewhere in string
                if (s.Substring(i + 1).Contains(s[i].ToString()) == false &&
                    s.Substring(0, i).Contains(s[i].ToString()) == false)
                {
                    expectedOutput = i;
                    break;
                }
            }

            // Act
            var result = Str.UniqueChar(s);

            // Assert
            Assert.That(result == expectedOutput);
        }

        [TestCase("oolala")]
        [TestCase("wwwwwwwwwwwww")]
        [TestCase("anna")]
        [TestCase("hahahahahahaha")]
        public void UniqueChar_WhenNoUniqueChar_ReturnNegativeOne(string s)
        {
            // Act
            var result = Str.UniqueChar(s);

            // Assert
            Assert.That(result == -1);
        }

        [TestCase("oo")]
        [TestCase("gg")]
        public void UniqueChar_WhenTwoNonUniqueChar_ReturnNegativeOne(string s)
        {
            // Act
            var result = Str.UniqueChar(s);

            // Assert
            Assert.That(result == -1);
        }

        [TestCase(null)]
        public void UniqueChar_WhenPassedNull_ReturnNegativeOne(string s)
        {
            // Act
            var result = Str.UniqueChar(s);

            // Assert
            Assert.That(result == -1);
        }
    }
}