using System;
using System.Collections.Generic;

class List
{
    public static List<int> DeleteAt(List<int> myList, int index)
    {
        if (index < 0 || index > myList.Count - 1)
        {
            Console.WriteLine("Index is out of range");
        }
        else
        {
            for (var i = index; i < myList.Count; i++)
            {
                if (i + 1 < myList.Count)
                {
                    myList[i] = myList[i + 1];
                }
            }
            myList.RemoveRange(myList.Count - 1, 1);
        }
        return myList;
    }
}