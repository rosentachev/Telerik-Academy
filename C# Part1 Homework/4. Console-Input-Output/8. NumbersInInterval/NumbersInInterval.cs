using System;

class NumbersInInterval
{
    static void Main()
    {
        //Write a program that reads an integer number n from the console and prints all the numbers 
        //in the interval [1..n], each on a single line.

        Console.Write("Enter a number n for the interval [1, n]: ");
        string input = Console.ReadLine();
        int n = int.Parse(input);
        Console.WriteLine("All numbers in interval [1, {0}]", n);
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(i);
        }
    }
}