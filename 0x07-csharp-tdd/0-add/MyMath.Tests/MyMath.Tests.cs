using NUnit.Framework;

namespace MyMath.Tests
{
    /// <summary>
    /// Tests for the Operations class
    /// </summary>
    [TestFixture]
    public class OperationsTests
    {
        /// <summary>
        /// Tests the Add operation on two valid integer arguments
        /// </summary>
        [Test]
        public void Add_WhenTwoIntsAdded_ReturnsCorrectSum(
            [Values(1, -3, 5, -10, 18, -28, 56, 199, 1035, 30456)] int a,
            [Values(0, -6, 9, 13, 17, 42, 78, 852, -9099, 12000)] int b)
        {
            // Act - add two ints using Add method
            var testSum = Operations.Add(a, b);

            // Assert - correct sum is produced
            Assert.That(testSum == (a + b));
        }

        [Test]
        public void Add_WhenMinAndMaxAdded_ReturnsNegOne()
        {
            // Act - add two ints using Add method
            var testSum = Operations.Add(int.MinValue, int.MaxValue);

            // Assert - correct sum is produced
            Assert.That(testSum == -1);
        }
    }
}