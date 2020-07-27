using System;
using System.Collections.Generic;

class LList
{
    public static int Sum(LinkedList<int> myLList)
    {
        var sum = 0;

        foreach (var node in myLList)
        {
            sum += node;
        }
        return sum;
    }
}