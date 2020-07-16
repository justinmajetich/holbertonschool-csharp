using System;
using System.Collections.Generic;

class List
{
    public static List<bool> DivisibleBy2(List<int> myList)
    {
        List<bool> newList = new List<bool>();
        myList.ForEach(number => newList.Add((number % 2 == 0) ? true : false));
        return newList;
    }
}