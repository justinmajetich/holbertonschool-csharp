using System;


class Program
{
    static void Main(string[] args)
    {
        for (int n1 = 0; n1 <= 9; n1++) {
            for (int n2 = n1 + 1; n2 <= 9; n2++) {
                if (n1 == 8 && n2 ==9)
                    Console.WriteLine($"{n1}{n2}");
                else
                    Console.Write($"{n1}{n2}, ");
            }
        }
    }
}