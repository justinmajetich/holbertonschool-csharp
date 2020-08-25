using System;


/// <summary>
/// Provides a suite of linear algebra helper methods.
/// </summary>
class VectorMath
{
    /// <summary>
    /// Multiplies a vector by a given scalar.
    /// </summary>
    /// <param name="vector">Vector to be multiplied.</param>
    /// <param name="scalar">Real number to multiply against vector.</param>
    /// <returns></returns>
    public static double[] Multiply(double[] vector, double scalar)
    {
        if ((vector.Length == 2 || vector.Length == 3))
        {
            for (int i = 0; i < vector.Length; i++)
                vector[i] *= scalar;
            return vector;
        }
        return new double[] {-1};
    }
}
