using NUnit.Framework;
using System.Linq;
using System;
using System.IO;

namespace MyMath.Tests
{
    [TestFixture]
    public class MatrixTests
    {
        private int[,] matrix;

        [SetUp]
        public void SetUp()
        {
            // Initialize test matrix
            this.matrix = new int[,] {
                { 0, 1, -2, 99, 100000 },
                { 13, -4, 566, -77777, 88 },
                { 10049, -666, 53, -1, 9999999 },
            };
        }

        [Test]
        public void Divide_ByNonZeroIntegers_ReturnsCorrectQuotients(
            [Values(-99, 100, 4, 40000, -66, 631, 97531)] int divisor)
        {

            // Arrange - create expected matrix
            int[,] expectedMatrix = new int[5,5];

            for (var y = 0; y < matrix.GetLength(0); y++)
            {
                for (var x = 0; x < matrix.GetLength(1); x++)
                {
                    expectedMatrix[y,x] = matrix[y,x] / divisor;
                }
            }

            // Act - divide test matrix and check against expected output
            var dividedMatrix = Matrix.Divide(this.matrix, divisor);

            bool matricesAreEqual = true;

            for (var y = 0; y < matrix.GetLength(0); y++)
            {
                for (var x = 0; x < matrix.GetLength(1); x++)
                {
                    // Check if items at index each match
                    if (matrix[y,x] != expectedMatrix[y,x])
                    {
                        matricesAreEqual = false;
                        break;
                    }
                }
            }

            // Assert
            Assert.That(matricesAreEqual, Is.True);
        }

        [TestCase(0)]
        public void Divide_ByZero_ReturnsNull(int divisor)
        {
            // Act - create test array with class method
            var dividedMatrix = Matrix.Divide(this.matrix, divisor);

            // Assert
            Assert.That(dividedMatrix == null);
        }

        [TestCase(0)]
        public void Divide_ByZero_PrintsToConsole(int divisor)
        {
            // Set output stream
            StringWriter stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            // Act - create test array with class method
            var dividedMatrix = Matrix.Divide(this.matrix, divisor);

            // Assert
            Assert.That(stringWriter.ToString() == "Num cannot be 0\n");
        }

        [Test]
        public void Divide_MatrixIsNull_ReturnsNull()
        {
            // Act - create test array with class method
            var dividedMatrix = Matrix.Divide(null, 9);

            // Assert
            Assert.That(dividedMatrix == null);
        }
    }
}