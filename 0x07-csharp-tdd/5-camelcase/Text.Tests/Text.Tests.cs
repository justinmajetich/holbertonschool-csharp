using NUnit.Framework;

namespace Text.Tests
{
    public class StrTests
    {
        [TestCase("camel")]
        [TestCase("blooper")]
        [TestCase("a")]
        public void CamelCase_WhenOneWord_ReturnOne(string s)
        {
            // Act
            int result = Str.CamelCase(s);

            // Assert
            Assert.That(result == 1);
        }

        [TestCase("camelCase", 2)]
        [TestCase("blooperReal", 2)]
        [TestCase("aDogAteMyHomework", 5)]     
        [TestCase("itIsMyOnlyRegretThatIHaveButOneLifeToLoseForMyCountry", 16)]
        public void CamelCase_WhenMultipleWords_ReturnsCorrectWordCount(string s, int expected)
        {
            // Act
            int result = Str.CamelCase(s);

            // Assert
            Assert.That(result == expected);        
        }
        
        [TestCase("IO", 2)]
        [TestCase("Html", 1)]
        public void CamelCase_Acronyms_ReturnsCorrectWordCount(string s, int expected)
        {
            // Act
            int result = Str.CamelCase(s);

            // Assert
            Assert.That(result == expected);
        }

        [TestCase("")]
        public void CamelCase_WhenEmptyString_ReturnZero(string s)
        {
            // Act
            int result = Str.CamelCase(s);

            // Assert
            Assert.That(result == 0);
        }

        [TestCase(null)]
        public void CamelCase_WhenNullString_ReturnZero(string s)
        {
            // Act
            int result = Str.CamelCase(null);

            // Assert
            Assert.That(result == 0);
        }
    }
}