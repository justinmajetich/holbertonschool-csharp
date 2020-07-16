using System;
using System.Collections.Generic;

class Dictionary
{
    public static int NumberOfKeys(Dictionary<string, string> myDict)
    {
        var counter = 0;

        foreach (KeyValuePair<string, string> entry in myDict)
        {
            counter++;
        }

        return counter;
    }
}