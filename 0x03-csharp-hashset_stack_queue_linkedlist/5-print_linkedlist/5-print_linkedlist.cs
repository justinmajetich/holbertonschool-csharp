using System;
using System.Collections.Generic;

class LList
{
    public static LinkedList<int> CreatePrint(int size)
    {
        var linkedList = new LinkedList<int>();

        for (var i = 0; i < size; i++)
        {
            Console.WriteLine(i);
            linkedList.AddLast(i);
        }

        return linkedList;
    }
}