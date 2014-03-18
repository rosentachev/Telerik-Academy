using System;

class PointInCircleOutOfRectangle
{
    static void Main()
    {
        //Write an expression that checks for given point (x, y) 
        //if it is within the circle K((1,1), 3) and out of the rectangle R(top=1, left=-1, width=6, height=2).

        Console.Write("Enter point x coordinate: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Enter point y coordinate: ");
        double y = double.Parse(Console.ReadLine());
        if ((x * x) + (y * y) <= 9)
        {
            Console.WriteLine("The point with coordinates ({0}, {1}) is in circle K((1,1), 3)", x, y);
            if (x >= 1 && x <= 7 && y <= -1 && y >= -3)
            {
                Console.WriteLine("The point with coordinates ({0}, {1}) is in rectangle R((1, -1) (7, -3))", x, y);
            }
            else
            {
                Console.WriteLine("The point with coordinates ({0}, {1}) is out of rectangle R((1, -1) (7, -3))", x, y);
            }
        }
        else
        {
            Console.WriteLine("The point with coordinates ({0}, {1}) is out of circle K((1,1), 3", x, y);
            if (x >= 1 && x <= 7 && y <= -1 && y >= -3)
            {
                Console.WriteLine("The point with coordinates ({0}, {1}) is in rectangle R((1, -1) (7, -3))", x, y);
            }
            else
            {
                Console.WriteLine("The point with coordinates ({0}, {1}) is out of rectangle R((1, -1) (7, -3))", x, y);
            }
        }
    }
}
