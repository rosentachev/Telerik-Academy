using System;

class SignOfTheProduct
{
    static void Main()
    {
        //Write a program that shows the sign (+ or -) of the product of three real numbers without calculating it. 
        //Use a sequence of if statements.

        Console.WriteLine("Please enter 3 real numbers (on separate lines)");
        string input = Console.ReadLine();
        int firstNumber = int.Parse(input);
        input = Console.ReadLine();
        int secondNumber = int.Parse(input);
        input = Console.ReadLine();
        int thirdNumber = int.Parse(input);

        if (firstNumber > 0 && secondNumber > 0 && thirdNumber > 0)
        {
            Console.WriteLine("The sign of the product of this 3 numbers will be: +");
        }
        else if (firstNumber > 0 && secondNumber < 0 && thirdNumber < 0)
        {
            Console.WriteLine("The sign of the product of this 3 numbers will be: +");
        }
        else if (firstNumber < 0 && secondNumber > 0 && thirdNumber < 0)
        {
            Console.WriteLine("The sign of the product of this 3 numbers will be: +");
        }
        else if (firstNumber < 0 && secondNumber < 0 && thirdNumber > 0)
        {
            Console.WriteLine("The sign of the product of this 3 numbers will be: +");
        }
        else if (firstNumber < 0 && secondNumber < 0 && thirdNumber < 0)
        {
            Console.WriteLine("The sign of the product of this 3 numbers will be: -");
        }
        else if (firstNumber < 0 && secondNumber > 0 && thirdNumber > 0)
        {
            Console.WriteLine("The sign of the product of this 3 numbers will be: -");
        }
        else if (firstNumber > 0 && secondNumber < 0 && thirdNumber > 0)
        {
            Console.WriteLine("The sign of the product of this 3 numbers will be: -");
        }
        else if (firstNumber > 0 && secondNumber > 0 && thirdNumber < 0)
        {
            Console.WriteLine("The sign of the product of this 3 numbers will be: -");
        }
        else if (firstNumber == 0 || secondNumber == 0 || thirdNumber == 0)
        {
            Console.WriteLine("The result is zero because one of the numbers is zero.");
        }
    }
}
