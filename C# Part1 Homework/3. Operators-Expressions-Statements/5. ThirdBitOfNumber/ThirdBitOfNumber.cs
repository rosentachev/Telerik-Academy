using System;

class ThirdBitOfNumber
{
    static void Main()
    {
        //Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.

        Console.Write("Enter a integer number: ");
        int number = int.Parse(Console.ReadLine());
        int p = 3;
        int mask = 1 << p;
        int numberAndMask = number & mask;
        int bit = numberAndMask >> p;
        Console.WriteLine("Third bit of the number is 1 -> {0}", bit == 1);
    }
}
