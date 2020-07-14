using System;

namespace _5_print_comb
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int n = 0; n < 100; n++) {
                if (n != 99)
                    Console.Write(n.ToString("D2") + ", ");
                else
                    Console.Write(n.ToString("D2") + "\n");
            }
        }
    }
}
