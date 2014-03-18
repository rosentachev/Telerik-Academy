using System;

class SumWithAccuracy
{
    static void Main()
    {
        //Write a program to calculate the sum (with accuracy of 0.001): 1 + 1/2 - 1/3 + 1/4 - 1/5 + ...

        double sum = 1;
        for (int i = 2; i <= 1000; i++)
        {
            sum += (1d / i);
            i++;
            sum -= (1d / i);
        }
        Console.WriteLine("{0:0.000}", sum);
    }
}
