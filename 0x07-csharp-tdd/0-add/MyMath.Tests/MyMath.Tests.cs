using NUnit.Framework;

namespace MyMath.Tests
{
    [TestFixture]
    /// <summary>
    /// Tests for the Operations class
    /// </summary>
    public class OperationsTests
    {
        [Test]
        /// <summary>
        /// Tests the Add operation on two valid integer arguments
        /// </summary>
        public void Add_WhenTwoIntsAdded_ReturnsCorrectSum(
            [Values(1, -3, 5, -10, 18, -28, 56, 199, 1035, 30456)] int a,
            [Values(0, -6, 9, 13, 17, 42, 78, 852, -9099, 12000)] int b)
        {
            // Act - add two ints using Add method
            var testSum = Operations.Add(a, b);

            // Assert - correct sum is produced
            Assert.That(testSum == (a + b));
        }
    }
}