using System;
using System.Linq;


/// <summary>
/// Provides a suite of linear algebra helper methods.
/// </summary>
class VectorMath
{
    /// <summary>
    /// Calculates the dot product of two vectors.
    /// </summary>
    /// <param name="vector1">First vector.</param>
    /// <param name="vector2">Second vector.</param>
    /// <returns>The dot product of two vectors.</returns>
    public static double DotProduct(double[] vector1, double[] vector2)
    {
        if ((vector1.Length == 2 || vector1.Length == 3) && vector1.Length == vector2.Length)
        {
            // Iterate through vector values
            for (int i = 0; i < vector1.Length; i++)
                // Multiply corresponding values together
                vector1[i] *= vector2[i];
            // Return sum of products
            return vector1.Sum();
        }
        return -1;
    }
}
