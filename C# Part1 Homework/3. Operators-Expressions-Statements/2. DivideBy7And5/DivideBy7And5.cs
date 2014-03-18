using System;

class DivideBy7And5
{
    static void Main()
    {
        //Write a boolean expression that checks for given integer 
        //if it can be divided (without remainder) by 7 and 5 in the same time.

        Console.Write("Enter a integer number: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("The number can be divided by 5 and 7 in the same time -> {0}", number % 5 == 0 & number % 7 == 0);
    }
}
