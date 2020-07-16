using System;

class Array
{
    public static int elementAt(int[] array, int index)
    {
        if (index >= 0 && index < array.Length)
        {
            return array[index];
        }
        else
        {
            Console.WriteLine("Index out of range");
            return -1;
        }
    }
}