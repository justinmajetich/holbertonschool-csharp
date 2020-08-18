using System;
using System.Collections.Generic;


class LList
{
    public static int Length(LinkedList<int> myLList)
    {
        var count = 0;

        foreach (var node in myLList)
        {
            count++;
        }

        return count;
    }
}