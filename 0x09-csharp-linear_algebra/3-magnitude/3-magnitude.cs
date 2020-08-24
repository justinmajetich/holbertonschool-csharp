using System;


/// <summary>
/// Provides a suite of linear algebra helper methods.
/// </summary>
class VectorMath
{
    /// <summary>
    /// Calculate the magnitude of a 2D or 3D vector.
    /// </summary>
    /// <param name="vector">Vector for which to calculate magnitude.</param>
    /// <returns></returns>
    public static double Magnitude(double[] vector)
    {    
        // Find magnitude of 2D vector using Pythagorean logic
        if (vector.Length == 2 || vector.Length == 3)
        {
            double sum = 0;

            // Raise each value by power of 2
            foreach (var value in vector)
                sum += Math.Pow(value, 2);
            
            // Square sum of all raised values
            return Math.Round(Math.Sqrt(sum), 2);
        }
        
        // If vector is of inappropriate dimension
        return -1;
    }
}
