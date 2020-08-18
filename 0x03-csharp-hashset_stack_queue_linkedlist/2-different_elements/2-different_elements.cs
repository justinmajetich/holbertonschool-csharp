using System;
using System.Collections.Generic;

class List
{
    public static List<int> DifferentElements(List<int> list1, List<int> list2)
    {
        var sortedSet = new SortedSet<int>(list1);
        sortedSet.SymmetricExceptWith(list2);
        return new List<int>(sortedSet);
    }
}