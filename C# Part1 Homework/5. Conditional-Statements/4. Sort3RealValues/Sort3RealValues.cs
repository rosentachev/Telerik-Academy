using System;

class Sort3RealValues
{
    static void Main()
    {
        //Sort 3 real values in descending order using nested if statements.

        Console.WriteLine("Please enter 3 integer numbers (on separate lines)");
        string input = Console.ReadLine();
        int firstNumber = int.Parse(input);
        input = Console.ReadLine();
        int secondNumber = int.Parse(input);
        input = Console.ReadLine();
        int thirdNumber = int.Parse(input);

        if (firstNumber > secondNumber && firstNumber > thirdNumber)
        {
            if (secondNumber > thirdNumber)
            {
                Console.WriteLine("{0}\n{1}\n{2}", firstNumber, secondNumber, thirdNumber);
            }
            else
            {
                Console.WriteLine("{0}\n{1}\n{2}", firstNumber, thirdNumber, secondNumber);
            }
        }
        else if (secondNumber > firstNumber && secondNumber > thirdNumber)
        {
            if (firstNumber > thirdNumber)
            {
                Console.WriteLine("{0}\n{1}\n{2}", secondNumber, firstNumber, thirdNumber);
            }
            else
            {
                Console.WriteLine("{0}\n{1}\n{2}", secondNumber, thirdNumber, firstNumber);
            }
        }
        else if (thirdNumber > firstNumber && thirdNumber > secondNumber)
        {
            if (firstNumber > secondNumber)
            {
                Console.WriteLine("{0}\n{1}\n{2}", thirdNumber, firstNumber, secondNumber);
            }
            else
            {
                Console.WriteLine("{0}\n{1}\n{2}", thirdNumber, secondNumber, firstNumber);
            }
        }
    }
}