using System;

class ExchangeTwoInt
{
    static void Main()
    {
        //Write an if statement that examines two integer variables and exchanges their values
        //if the first one is greater than the second one.

        Console.WriteLine("Please enter two integer numbers (on separate lines)");
        string input = Console.ReadLine();
        int firstNumber = int.Parse(input);
        input = Console.ReadLine();
        int secondNumber = int.Parse(input);

        int exchange = secondNumber;

        if (firstNumber > secondNumber)
        {
            secondNumber = firstNumber;
            firstNumber = exchange;
            Console.WriteLine("First number is {0} and the second number is {1}", firstNumber, secondNumber);
        }
        else
        {
            Console.WriteLine("First number is {0} and the second number is {1}", firstNumber, secondNumber);
        }
    }
}
