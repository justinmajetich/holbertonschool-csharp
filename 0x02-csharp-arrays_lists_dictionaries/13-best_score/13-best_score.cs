using System;
using System.Linq;
using System.Collections.Generic;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        KeyValuePair<string, int> bestScore = new KeyValuePair<string, int>("None", 0);

        foreach (KeyValuePair<string, int> kv in myList)
        {
            if (bestScore.Key == "None" || bestScore.Value < kv.Value)
            {
                bestScore = kv;
            }
        }

        return bestScore.Key;
    }
}