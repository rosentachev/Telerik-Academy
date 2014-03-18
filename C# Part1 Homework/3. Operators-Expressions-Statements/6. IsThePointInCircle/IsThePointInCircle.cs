using System;

class IsThePointInCircle
{
    static void Main()
    {
        //Write an expression that checks if given point (x, y) is within a circle K(O, 5).

        Console.Write("Enter point x coordinate: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Enter point y coordinate: ");
        double y = double.Parse(Console.ReadLine());
        if ((x * x) + (y * y) <= 25)
        {
            Console.WriteLine("The point with coordinates ({0}, {1}) is within the circle K(0, 5).", x, y);
        }
        else
        {
            Console.WriteLine("The point with coordinates ({0}, {1}) is without the circle K(0, 5).", x, y);
        }
    }
}
