using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> newNode = new LinkedListNode<int>(n);

        for (var current = myLList.First; current != null; current = current.Next)
        {
            if (n <= current.Value)
            {
                newNode = myLList.AddBefore(current, n);
                break;
            }
        }
        return newNode;
    }
}