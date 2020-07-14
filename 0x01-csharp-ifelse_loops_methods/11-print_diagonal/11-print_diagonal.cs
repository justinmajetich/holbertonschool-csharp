using System;


class Line
{
    public static void PrintDiagonal(int length) {
        for (var y = 0; y < length; y++) {
            for (var x = 0; x < y; x++) {
                Console.Write(" ");
            }
            Console.WriteLine("\\");
        }
        Console.WriteLine();
    }
}