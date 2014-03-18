using System;

class ExchangeTwoIntegers
{
    static void Main()
    {
        // Declare  two integer variables and assign them with 5 and 10 and after that exchange their values.

        int a = 5;
        int b = 10;
        int c = 0;
        Console.WriteLine("Before exchange: a={0} and b={1}", a, b);
        c = a;
        a = b;
        b = c;
        Console.WriteLine("After exchange: a={0} and b={1}", a, b);
    }
}
