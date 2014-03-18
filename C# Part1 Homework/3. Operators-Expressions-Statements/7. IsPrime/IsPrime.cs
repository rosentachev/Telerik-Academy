using System;

class IsPrime
{
    static void Main()
    {
        //Write an expression that checks if given positive integer number n (n ≤ 100) is prime. E.g. 37 is prime.

        Console.Write("Enter a positive integer number from 0 to 100: ");
        int number = int.Parse(Console.ReadLine());
        bool isPrime = true;
        for (int i = 2; i < number; i++)
        {
            if (number % i == 0)
            {
                isPrime = false;
                break;
            }
        }
        Console.WriteLine(isPrime == false ? "{0} is not a prime number" : "{0} is a prime number", number);
    }
}
