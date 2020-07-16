using System;

class Array
{
    public static void Reverse(int[] array)
    {
        if (array != null && array.Length > 0)
        {
            for (var i = array.Length - 1; i >= 0; i--)
            {
                Console.Write(array[i]);
                if (i > 0)
                {
                    Console.Write(" ");
                }
            }
        }
        Console.WriteLine();
    }
}