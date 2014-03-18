using System;

class IsValueOfBitOne
{
    static void Main()
    {
        //Write a boolean expression that returns if the bit at position p (counting from 0) 
        //in a given integer number v has value of 1. Example: v=5; p=1 -> false

        Console.Write("Enter a integer number: ");
        int v = int.Parse(Console.ReadLine());
        Console.Write("Enter position for the bit: ");
        int p = int.Parse(Console.ReadLine());
        int mask = 1 << p;
        int numberAndMask = v & mask;
        int bit = numberAndMask >> p;
        Console.WriteLine("The value of {0} bit in number {1} is 1 -> {2}", p, v, bit == 1);
    }
}
