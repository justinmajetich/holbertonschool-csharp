using System;

namespace _12_fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var i = 1; i <= 100; i++) {
                if (i % 15 == 0) {
                    Console.Write("FizzBuzz");
                } else if (i % 5 == 0) {
                    Console.Write("Buzz");
                } else if (i % 3 == 0) {
                    Console.Write("Fizz");
                } else {
                    Console.Write(i);
                }

                if (i != 100) {
                    Console.Write(" ");
                }
            }

        }
    }
}
