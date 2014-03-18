using System;

class TrapezoidArea
{
    static void Main()
    {
        //Write an expression that calculates trapezoid's area by given sides a and b and height h.

        Console.Write("Enter trapezoid side a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter trapezoid side b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter trapezoid height: ");
        double height = double.Parse(Console.ReadLine());
        double area = ((a + b) / 2) * height;
        Console.WriteLine("Trapezoid's area is equal to: {0}", area);
    }
}
