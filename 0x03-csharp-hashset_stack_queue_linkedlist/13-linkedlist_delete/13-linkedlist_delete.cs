using System;
using System.Collections.Generic;

class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        LinkedListNode<int> current = myLList.First;
        int i = 0;

        while (current != null)
        {
            if (i == index)
            {
                myLList.Remove(current);
                break;
            }
            current = current.Next;
            i++;
        }
    }
}