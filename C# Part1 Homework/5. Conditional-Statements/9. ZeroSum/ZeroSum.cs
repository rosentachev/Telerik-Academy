using System;

class ZeroSum
{
    static void Main()
    {
        //We are given 5 integer numbers. Write a program that checks if the sum of some subset of them is 0. 
        //Example: 3, -2, 1, 1, 8 -> 1+1-2=0

        Console.WriteLine("Please enter five integer numbers (on separate lines)");
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        int thirdNumber = int.Parse(Console.ReadLine());
        int fourthNumber = int.Parse(Console.ReadLine());
        int fifthNumber = int.Parse(Console.ReadLine());

        //five numbers
        if (firstNumber + secondNumber + thirdNumber + fourthNumber + fifthNumber == 0)
        {
            Console.WriteLine("The subset which sum is zero is: {0}, {1}, {2}, {3}, {4}", firstNumber, secondNumber, thirdNumber, fourthNumber, fifthNumber);
        }

        //four numbers
        if (secondNumber + thirdNumber + fourthNumber + fifthNumber == 0)
        {
            Console.WriteLine("The subset which sum is zero is: {0}, {1}, {2}, {3}", secondNumber, thirdNumber, fourthNumber, fifthNumber);
        }
        if (firstNumber + thirdNumber + fourthNumber + fifthNumber == 0)
        {
            Console.WriteLine("The subset which sum is zero is: {0}, {1}, {2}, {3}", firstNumber, thirdNumber, fourthNumber, fifthNumber);
        }
        if (firstNumber + secondNumber + fourthNumber + fifthNumber == 0)
        {
            Console.WriteLine("The subset which sum is zero is: {0}, {1}, {2}, {3}", firstNumber, secondNumber, fourthNumber, fifthNumber);
        }
        if (firstNumber + secondNumber + thirdNumber + fifthNumber == 0)
        {
            Console.WriteLine("The subset which sum is zero is: {0}, {1}, {2}, {3}", firstNumber, secondNumber, thirdNumber, fifthNumber);
        }
        if (firstNumber + secondNumber + thirdNumber + fourthNumber == 0)
        {
            Console.WriteLine("The subset which sum is zero is: {0}, {1}, {2}, {3}", firstNumber, secondNumber, thirdNumber, fourthNumber);
        }

        //three numbers
        if (thirdNumber + fourthNumber + fifthNumber == 0)
        {
            Console.WriteLine("The subset which sum is zero is: {0}, {1}, {2}", thirdNumber, fourthNumber, fifthNumber);
        }
        if (secondNumber + fourthNumber + fifthNumber == 0)
        {
            Console.WriteLine("The subset which sum is zero is: {0}, {1}, {2}", secondNumber, fourthNumber, fifthNumber);
        }
        if (secondNumber + thirdNumber + fifthNumber == 0)
        {
            Console.WriteLine("The subset which sum is zero is: {0}, {1}, {2}", secondNumber, thirdNumber, fifthNumber);
        }
        if (secondNumber + thirdNumber + fourthNumber == 0)
        {
            Console.WriteLine("The subset which sum is zero is: {0}, {1}, {2}", secondNumber, thirdNumber, fourthNumber);
        }
        if (firstNumber + fourthNumber + fifthNumber == 0)
        {
            Console.WriteLine("The subset which sum is zero is: {0}, {1}, {2}", firstNumber, fourthNumber, fifthNumber);
        }
        if (firstNumber + thirdNumber + fifthNumber == 0)
        {
            Console.WriteLine("The subset which sum is zero is: {0}, {1}, {2}", firstNumber, thirdNumber, fifthNumber);
        }
        if (firstNumber + thirdNumber + fourthNumber == 0)
        {
            Console.WriteLine("The subset which sum is zero is: {0}, {1}, {2}", firstNumber, thirdNumber, fourthNumber);
        }
        if (firstNumber + secondNumber + fifthNumber == 0)
        {
            Console.WriteLine("The subset which sum is zero is: {0}, {1}, {2}", firstNumber, secondNumber, fifthNumber);
        }
        if (firstNumber + secondNumber + fourthNumber == 0)
        {
            Console.WriteLine("The subset which sum is zero is: {0}, {1}, {2}", firstNumber, secondNumber, fourthNumber);
        }
        if (firstNumber + secondNumber + thirdNumber == 0)
        {
            Console.WriteLine("The subset which sum is zero is: {0}, {1}, {2}", firstNumber, secondNumber, thirdNumber);
        }

        //two numbers
        if (firstNumber + secondNumber == 0)
        {
            Console.WriteLine("The subset which sum is zero is: {0}, {1}", firstNumber, secondNumber);
        }
        if (firstNumber + thirdNumber == 0)
        {
            Console.WriteLine("The subset which sum is zero is: {0}, {1}", firstNumber, thirdNumber);
        }
        if (firstNumber + fourthNumber == 0)
        {
            Console.WriteLine("The subset which sum is zero is: {0}, {1}", firstNumber, fourthNumber);
        }
        if (firstNumber + fifthNumber == 0)
        {
            Console.WriteLine("The subset which sum is zero is: {0}, {1}", firstNumber, fifthNumber);
        }
        if (secondNumber + thirdNumber == 0)
        {
            Console.WriteLine("The subset which sum is zero is: {0}, {1}", secondNumber, thirdNumber);
        }
        if (secondNumber + fourthNumber == 0)
        {
            Console.WriteLine("The subset which sum is zero is: {0}, {1}", secondNumber, fourthNumber);
        }
        if (secondNumber + fifthNumber == 0)
        {
            Console.WriteLine("The subset which sum is zero is: {0}, {1}", secondNumber, fifthNumber);
        }
        if (thirdNumber + fourthNumber == 0)
        {
            Console.WriteLine("The subset which sum is zero is: {0}, {1}", thirdNumber, fourthNumber);
        }
        if (thirdNumber + fifthNumber == 0)
        {
            Console.WriteLine("The subset which sum is zero is: {0}, {1}", thirdNumber, fifthNumber);
        }
        if (fourthNumber + fifthNumber == 0)
        {
            Console.WriteLine("The subset which sum is zero is: {0}, {1}", fourthNumber, fifthNumber);
        }
    }
}
