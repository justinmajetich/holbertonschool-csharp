using System;

namespace MyMath
{
    public class Matrix
    {
        public static int[,] Divide(int[,] matrix, int num)
        {
            try
            {
                for (var y = 0; y < matrix.GetLength(0); y++)
                {
                    for (var x = 0; x < matrix.GetLength(1); x++)
                    {
                        matrix[y,x] = matrix[y,x] / num;
                    }
                }

                return matrix;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Num cannot be 0");
                return null;
            }
            catch (NullReferenceException)
            {
                return null;
            }
        }
    }
}
