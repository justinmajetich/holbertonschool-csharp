using System;

/// <summary>
/// Provides a suite of linear algebra helper methods.
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Multiplies the elements of a matrix by a given scalar.
    /// </summary>
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        if ((matrix.GetLength(0) == 2 && matrix.GetLength(1) == 2) || 
            (matrix.GetLength(0) == 3 && matrix.GetLength(1) == 3))
        {
            for (int y = 0; y < matrix.GetLength(0); y++)
            {
                for (int x = 0; x < matrix.GetLength(1); x++)
                {
                    // Multiply each value by scalar
                    matrix[y,x] *= scalar;
                }
            }
            return matrix;
        }
        return new double[,] { {-1} };
    }
}
