using System;
using System.Collections.Generic;

class List
{
    public static List<int> CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }

        List<int> newList = new List<int>();

        for (var i = 0; i < size; i++)
        {
            Console.Write(i);
            if (i < size - 1)
            {
                Console.Write(" ");
            }
            newList.Add(i);
        }
        Console.WriteLine();
        
        return newList;
    }
}