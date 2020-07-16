using System;

class Program
{
    static void Main(string[] args)
    {
        int[][] jagged =
        {
            new int[] {0, 1, 2, 3},
            new int[] {0, 1, 2, 3, 4, 5, 6},
            new int[] {0, 1}
        };

        var yLength = jagged.GetLength(0);

        for (var y = 0; y < yLength; y++)
        {
            var xLength = jagged[y].Length;
            for (var x = 0; x < xLength; x++)
            {
                Console.Write(jagged[y][x]);
                if (x < xLength - 1)
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}