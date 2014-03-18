using System;

class Sequence
{
    static void Main(string[] args)
    {
        //Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...

        for (int i = 2; i <= 11; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
            else
            {
                Console.WriteLine("-" + i);
            }
        }
    }
}
