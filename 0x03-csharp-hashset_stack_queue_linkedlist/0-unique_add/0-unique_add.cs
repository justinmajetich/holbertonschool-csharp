using System;
using System.Linq;
using System.Collections.Generic;

class List
{
    public static int Sum(List<int> myList)
    {
        // Convert List to HashSet, automatically removing duplicates
        HashSet<int> hashSet = new HashSet<int>(myList);

        // Return sum of HashSet using Linq Sum() method
        return hashSet.Sum();
    }
}