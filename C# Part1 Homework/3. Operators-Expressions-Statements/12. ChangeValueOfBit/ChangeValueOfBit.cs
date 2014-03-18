using System;

class ChangeValueOfBit
{
    static void Main()
    {
        //We are given integer number n, value v (v=0 or 1) and a position p. 
        //Write a sequence of operators that modifies n to hold the value v 
        //at the position p from the binary representation of n.
	    //Example: n = 5 (00000101), p=3, v=1 -> 13 (00001101)
	    //n = 5 (00000101), p=2, v=0 -> 1 (00000001)

        Console.Write("Enter a integer number: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter a value for bit (0 or 1): ");
        int v = int.Parse(Console.ReadLine());
        Console.Write("Enter position for the bit: ");
        int p = int.Parse(Console.ReadLine());
        if (v == 1)
        {
            int newNumber = n | (1 << p);
            Console.WriteLine("The new number is: {0}", newNumber);
        }
        else
        {
            int newNumber = n & (~(1 << p));
            Console.WriteLine("The new number is: {0}", newNumber);
        }
    }
}
