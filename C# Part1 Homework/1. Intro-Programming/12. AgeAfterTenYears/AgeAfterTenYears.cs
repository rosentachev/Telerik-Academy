﻿using System;

class AgeAfterTenYears
{
    static void Main()
    {
        //* Write a program to read your age from the console and print how old you will be after 10 years.

        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine("After ten years you will be {0} years old.", age + 10);
    }
}
