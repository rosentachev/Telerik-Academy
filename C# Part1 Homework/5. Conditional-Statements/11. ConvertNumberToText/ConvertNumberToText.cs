using System;

class ConvertNumberToText
{
    static void Main()
    {
        //* Write a program that converts a number in the range [0...999] to a text corresponding to its English pronunciation. 
        //Examples:
        //0 -> "Zero"
        //273 -> "Two hundred seventy three"
        //400 -> "Four hundred"
        //501 -> "Five hundred and one"
        //711 -> "Seven hundred and eleven"

        Console.Write("Please enter a number in the range [0...999] -> ");
        string input = Console.ReadLine();
        int number = int.Parse(input);
    }
}
