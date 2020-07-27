using System;
using System.Collections.Generic;


class MyQueue
{
    public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
    {
        // Take size of queue
        var count = aQueue.Count;
        Console.WriteLine("Number of items: {0}", count);

        // Peek top value if queue not empty
        if (count > 0)
        {
            Console.WriteLine("Top item: {0}", aQueue.Peek());
        }
        else
        {
            Console.WriteLine("Queue is empty");
        }

        // Determine if stack contains value
        var containsSearch = aQueue.Contains(search);
        Console.WriteLine("Queue contains \"{0}\": {1}", search, containsSearch);

        // If search value present, remove items up to and including value 
        if (containsSearch)
        {
            while (true)
            {
                var item = aQueue.Peek();
                aQueue.Dequeue();
                if (item == search)
                {
                    break;
                }
            }
        }

         // Add new item to stack
        aQueue.Enqueue(newItem);
        
        return aQueue;
    }
}