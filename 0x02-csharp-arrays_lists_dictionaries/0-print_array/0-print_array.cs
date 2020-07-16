using System;


class Array
{
    public static int[] CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }

        int[] arr = new int[size];


        for (var i = 0; i < arr.Length; i++)
        {
            Console.Write(i);
            if (i < arr.Length - 1)
            {
                Console.Write(" ");
            }
        }
        Console.WriteLine();
        return arr;
    }
}