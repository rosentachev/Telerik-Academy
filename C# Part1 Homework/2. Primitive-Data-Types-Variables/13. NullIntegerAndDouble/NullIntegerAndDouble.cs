using System;

class NullIntegerAndDouble
{
    static void Main()
    {
        // Create a program that assigns null values to an integer and to double variables. 
        // Try to print them on the console, try to add some values or the null literal to them and see the result.

        int? nullInteger = null;
        double? nullDouble = null;

        Console.WriteLine("Null integer -> {0}", nullInteger);
        Console.WriteLine("Null integer + 5 -> {0}", nullInteger + 5);
        Console.WriteLine("Null integer null literal -> {0}", nullInteger + null);

        Console.WriteLine("Null double -> {0}", nullDouble);
        Console.WriteLine("Null double + 5.5 -> {0}", nullDouble + 5.5);
        Console.WriteLine("Null double + null literal -> {0}", nullDouble + null);
    }
}
