using System;

class GreatestOfFiveVariables
{
    static void Main()
    {
        //Write a program that finds the greatest of given 5 variables.

        Console.WriteLine("Please enter five variables (on separate lines)");
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        int thirdNumber = int.Parse(Console.ReadLine());
        int fourthNumber = int.Parse(Console.ReadLine());
        int fifthNumber = int.Parse(Console.ReadLine());

        int greatestNumber = firstNumber;

        if (secondNumber > greatestNumber)
        {
            greatestNumber = secondNumber;
        }
        if (thirdNumber > greatestNumber)
        {
            greatestNumber = thirdNumber;
        }
        if (fourthNumber > greatestNumber)
        {
            greatestNumber = fourthNumber;
        }
        if (fifthNumber > greatestNumber)
        {
            greatestNumber = fifthNumber;
        }
        Console.WriteLine("The greatest number is {0}.", greatestNumber);
    }
}
