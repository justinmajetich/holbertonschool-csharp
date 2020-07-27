using System;
using System.Collections.Generic;

class List
{
    public static List<int> CommonElements(List<int> list1, List<int> list2)
    {
        // Create a SortedSet from List
        var sortedSet = new SortedSet<int>(list1);

        // Intersect sorted set with second collection
        sortedSet.IntersectWith(list2);

        // Convert SortedSet back to List and return
        return new List<int>(sortedSet);
    }
}