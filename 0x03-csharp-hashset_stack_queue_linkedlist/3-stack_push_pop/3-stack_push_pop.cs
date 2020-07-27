using System;
using System.Collections.Generic;

class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        // Take size of stack
        var count = aStack.Count;
        Console.WriteLine("Number of items: {0}", count);

        // Peek top value if stack is not empty
        if (count > 0)
        {
            Console.WriteLine("Top item: {0}", aStack.Peek());
        }
        else
        {
            Console.WriteLine("Stack is empty");
        }
         
        // Determine if stack contains value
        var containsSearch = aStack.Contains(search);
        Console.WriteLine("Stack contains \"{0}\": {1}", search, containsSearch);

        // If search value present, remove items up to and including value 
        if (containsSearch)
        {
            while (true)
            {
                var item = aStack.Peek();
                aStack.Pop();
                if (item == search)
                {
                    break;
                }
            }
        }

         // Add new item to stack
        aStack.Push(newItem);
        
        return aStack;
    }
}