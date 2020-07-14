using System;

class Line
{
    public static void PrintLine(int length) {
        if (length >= 0) {
            for (var i = 0; i < length; i++) {
                Console.Write("_");
            }
        }
        Console.Write("\n");
    }
}