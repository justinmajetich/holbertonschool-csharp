using System;


class Number
{
    public static int PrintLastDigit(int number) {
        int lastDigit = (number >= 0) ? (number % 10) : (number % 10) * -1;
        Console.Write(lastDigit);
        return lastDigit;
    }
}