using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;

namespace MyMath.Tests
{
    [TestFixture]
    public class OperationsTests
    {
        [Test]
        public void Max_WhenListOfSeveralIntsPassed_ReturnsMaxInt(
            [Values(-99, 0, 44, 1066)] int a,
            [Values(-6666, 34, 1, 678932)] int b)
        {
            // Arrange
            List<int> nums = new List<int>() {99, 0, a, -45, 3, 22, -1106, b};
            var expectedMax = nums.Max();

            // Act
            var result = Operations.Max(nums);
            
            // Assert
            Assert.That(result == expectedMax);
        }
        
        [Test]
        public void Max_WhenListOfOneIntPassed_ReturnsMaxInt()
        {
            // Arrange
            List<int> nums = new List<int>() {-45};
            var expectedMax = nums.Max();

            // Act
            var result = Operations.Max(nums);
            
            // Assert
            Assert.That(result == expectedMax);
        }

        [Test]
        public void Max_WhenEmptyListIsPassed_Returns0()
        {
            // Arrange - init empty list
            List<int> nums = new List<int>();

            // Act - take max of empty list
            var result = Operations.Max(nums);

            // Assert
            Assert.That(result == 0);
        }

        [Test]
        public void Max_WhenNullIsPassed_Returns0()
        {
            // Act - take max of empty list
            var result = Operations.Max(null);

            // Assert
            Assert.That(result == 0);
        }
    }
}