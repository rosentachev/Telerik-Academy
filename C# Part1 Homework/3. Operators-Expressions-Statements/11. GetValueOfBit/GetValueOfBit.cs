using System;

class GetValueOfBit
{
    static void Main()
    {
        //Write an expression that extracts from a given integer i the value of a given bit number b. 
        //Example: i=5; b=2 -> value=1.

        Console.Write("Enter a integer number: ");
        int i = int.Parse(Console.ReadLine());
        Console.Write("Enter bit number: ");
        int b = int.Parse(Console.ReadLine());
        int mask = 1 << b;
        int numberAndMask = i & mask;
        int bit = numberAndMask >> b;
        Console.WriteLine("The value of {0} bit in number {1} is: {2}", b, i, bit);
    }
}
