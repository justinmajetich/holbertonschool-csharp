using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] grid = new int[,] {
            {0, 0, 0, 0, 0},
            {0, 0, 0, 0, 0},
            {0, 0, 1, 0, 0},
            {0, 0, 0, 0, 0},
            {0, 0, 0, 0, 0}
        };

        for (var y = 0; y < 5; y++)
        {
            for (var x = 0; x < 5; x++)
            {
                Console.Write(grid[y, x]);
                if (x < 4)
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}