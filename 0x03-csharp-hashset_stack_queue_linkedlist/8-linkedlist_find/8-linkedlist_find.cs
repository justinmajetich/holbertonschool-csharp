using System;
using System.Collections.Generic;

class LList
{
    public static int FindNode(LinkedList<int> myLList, int value)
    {
        var index = 0;

        foreach (var node in myLList)
        {
            if (node == value)
            {
                return index;
            }
            index++;
        }
        return -1;
    }
}