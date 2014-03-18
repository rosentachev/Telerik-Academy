using System;

class First100MembersOfFibonacci
{
    static void Main()
    {
        //Write a program to print the first 100 members of the sequence of Fibonacci: 
        //0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, ...

        Console.WriteLine("First 100 members of Fibonacci sequence");
        decimal firstMember = 0;
        decimal secondMember = 1;
        decimal sum = firstMember + secondMember;
        Console.WriteLine(firstMember);
        Console.WriteLine(secondMember);
        for (int i = 0; i < 100; i++)
        {
            sum = firstMember + secondMember;
            firstMember = secondMember;
            secondMember = sum;
            Console.WriteLine(sum);
        }
    }
}
