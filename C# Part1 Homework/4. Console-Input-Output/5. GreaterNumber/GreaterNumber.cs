using System;

class GreaterNumber
{
    static void Main()
    {
        //Write a program that gets two numbers from the console and prints the greater of them. Don’t use if statements.

        Console.WriteLine("Enter two numbers");
        string input = Console.ReadLine();
        double firstNumber = double.Parse(input);
        input = Console.ReadLine();
        double secondNumber = double.Parse(input);
        Console.WriteLine(firstNumber > secondNumber ? "First number is greater" : "Second number is greater");
    }
}
