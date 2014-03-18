using System;

class IsThirdDigitSeven
{
    static void Main()
    {
        //Write an expression that checks for given integer if its third digit (right-to-left) is 7. 
        //E. g. 1732 -> true.

        Console.Write("Enter a integer number: ");
        int number = int.Parse(Console.ReadLine());
        int divideBy100 = number / 100;
        Console.WriteLine("Is the third digit seven -> {0}", divideBy100 % 10 == 7);
    }
}
