using System;


/// <summary>
/// Provides a suite of linear algebra helper methods.
/// </summary>
class VectorMath
{
    /// <summary>
    /// Add two 2D or 3D vectors.
    /// </summary>
    /// <param name="vector1">Vector to add to.</param>
    /// <param name="vector2">Vector to be added to.</param>
    /// <returns></returns>
    public static double[] Add(double[] vector1, double[] vector2)
    {
        if ((vector1.Length == 2 || vector1.Length == 3) && vector1.Length == vector2.Length)
        {
            for (int i = 0; i < vector1.Length; i++)
                vector1[i] += vector2[i];
            return vector1;
        }
        return new double[] {-1};
    }
}
