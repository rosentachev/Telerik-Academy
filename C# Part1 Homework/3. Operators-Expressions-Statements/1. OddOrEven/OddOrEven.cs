using System;

class OddOrEven
{
    static void Main()
    {
        //Write an expression that checks if given integer is odd or even.

        Console.Write("Enter a integer number: ");
        int number = int.Parse(Console.ReadLine());
        if (number % 2 == 0)
        {
            Console.WriteLine("The number is even.");
        }
        else
        {
            Console.WriteLine("The number is odd.");
        }
    }
}
