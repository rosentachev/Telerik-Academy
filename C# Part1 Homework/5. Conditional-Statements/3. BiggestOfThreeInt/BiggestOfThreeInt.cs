using System;

class BiggestOfThreeInt
{
    static void Main()
    {
        //Write a program that finds the biggest of three integers using nested if statements.

        Console.WriteLine("Please enter 3 integer numbers (on separate lines)");
        string input = Console.ReadLine();
        int firstNumber = int.Parse(input);
        input = Console.ReadLine();
        int secondNumber = int.Parse(input);
        input = Console.ReadLine();
        int thirdNumber = int.Parse(input);

        if (firstNumber > secondNumber && firstNumber > thirdNumber)
        {
            Console.WriteLine("The biggest number is {0}", firstNumber);
        }
        else if (secondNumber > firstNumber && secondNumber > thirdNumber)
        {
            Console.WriteLine("The biggest number is {0}", secondNumber);
        }
        else
        {
            Console.WriteLine("The biggest number is {0}", thirdNumber);
        }
    }
}
