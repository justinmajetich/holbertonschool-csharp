﻿using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> newNode = new LinkedListNode<int>(n);

        if (myLList.Count == 0)
        {
            myLList.AddFirst(newNode);
            return newNode;
        }

        for (var current = myLList.First; current != null; current = current.Next)
        {
            if (n <= current.Value)
            {
                myLList.AddBefore(current, newNode);
                break;
            }
        }
        return newNode;
    }
}