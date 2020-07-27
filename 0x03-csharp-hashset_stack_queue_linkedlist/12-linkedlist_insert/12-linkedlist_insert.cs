using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> newNode = new LinkedListNode<int>(n);

        if (myLList.Count == 0)
        {
            myLList.AddFirst(newNode);
        }
        else
        {
            LinkedListNode<int> current = myLList.First;
            while (current != null)
            {
                if (n <= current.Value)
                {
                    myLList.AddBefore(current, newNode);
                    break;
                }
                current = current.Next;
            }
        }
        return newNode;
    }
}