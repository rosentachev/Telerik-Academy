using System;

class SumThreeNumbers
{
    static void Main()
    {
        //Write a program that reads 3 integer numbers from the console and prints their sum.

        Console.WriteLine("Please enter three numbers");
        string input = Console.ReadLine();
        int firstNumber = int.Parse(input);
        input = Console.ReadLine();
        int secondNumber = int.Parse(input);
        input = Console.ReadLine();
        int thirdNumber = int.Parse(input);
        int sum = firstNumber + secondNumber + thirdNumber;
        Console.WriteLine("The sum of {0}, {1} and {2} is equal to {3}", firstNumber, secondNumber, thirdNumber, sum);
    }
}
