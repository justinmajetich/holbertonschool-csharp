using System;

namespace _4_print_hexa
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int n = 0; n < 99; n++)
                Console.WriteLine($"{n} = 0x{n.ToString("x")}");
        }
    }
}
