using System;

class Int
{
    public static void divide(int a, int b)
    {
        int quotient = 0;

        try
        {
            quotient = a / b;
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero");
            quotient = 0;
        }
        finally
        {
            Console.WriteLine($"{a} / {b} = {quotient}");
        }
    }
}