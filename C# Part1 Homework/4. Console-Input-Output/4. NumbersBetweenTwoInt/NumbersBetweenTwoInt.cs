using System;

class NumbersBetweenTwoInt
{
    static void Main()
    {
        //Write a program that reads two positive integer numbers and prints 
        //how many numbers p exist between them such that the reminder of the division by 5 is 0 (inclusive). 
        //Example: p(17,25) = 2

        Console.WriteLine("Please enter two positive integer numbers");
        string input = Console.ReadLine();
        int firstNumber = int.Parse(input);
        input = Console.ReadLine();
        int secondNumber = int.Parse(input);
        int count = 0;
        for (int i = firstNumber; i <= secondNumber; i++)
        {
            if (i % 5 == 0)
            {
                count++;
            }
        }
        Console.WriteLine("There are {0} numbers in interval ({1}, {2}) which have reminder 0 of division by 5", count, firstNumber, secondNumber);
    }
}
