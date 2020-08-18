using System;
using System.Collections.Generic;

class LList
{
    public static int GetNode(LinkedList<int> myLList, int n)
    {
        var index = 0;

        foreach (var node in myLList)
        {
            if (index == n)
            {
                return node;
            }
            index++;
        }
        return 0;
    }
}