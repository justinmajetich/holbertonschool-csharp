using System;

class Matrix
{
    public static int[,] Square(int[,] myMatrix)
    {
        int yLength = myMatrix.GetLength(0);
        int xLength = myMatrix.GetLength(1);
        
        int[,] newMatrix = new int[yLength,xLength];

        for (var y = 0; y < yLength; y++)
        {
            for (var x = 0; x < xLength; x++)
            {
                newMatrix[y,x] = (myMatrix[y,x] * myMatrix[y,x]);
            }
        }
        return newMatrix;
    }
}