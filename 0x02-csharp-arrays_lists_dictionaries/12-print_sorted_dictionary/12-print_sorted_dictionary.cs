using System;
using System.Linq;
using System.Collections.Generic;

class Dictionary
{
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        {
            List<string> keyList = myDict.Keys.ToList();
            keyList.Sort();
            foreach (string key in keyList)
            {
                Console.WriteLine($"{key}: {myDict[key]}");
            }
        }
    }
}