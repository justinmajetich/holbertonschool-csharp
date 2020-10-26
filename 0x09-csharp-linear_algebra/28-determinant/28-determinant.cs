using System;

/// <summary>
/// Provides a suite of linear algebra helper methods.
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Calculates the determinant of a 2D or 3D matrix.
    /// </summary>
    public static double Determinant(double[,] matrix)
    {
        if (matrix.GetLength(0) == 2 && matrix.GetLength(1) == 2)
        {
            return _Determinant(matrix[0,0], matrix[0,1], matrix[1,0], matrix[1,1]);
        }
        else if (matrix.GetLength(0) == 3 && matrix.GetLength(1) == 3)
        {
            return (matrix[0,0] * _Determinant(matrix[1,1], matrix[1,2], matrix[2,1], matrix[2,2])) - 
                    (matrix[0,1] * _Determinant(matrix[1,0], matrix[1,2], matrix[2,0], matrix[2,2])) +
                    (matrix[0, 2] * _Determinant(matrix[1,0], matrix[1,1], matrix[2,0], matrix[2,1]));
        }
        else
        {
            return -1;
        }
    }

    // Finds the determinant of a 2D matrix
    // represented left to right, top to bottom.
    private static double _Determinant(double a, double b, double c, double d)
    {
        return (a * d + c * b);
    }
}

