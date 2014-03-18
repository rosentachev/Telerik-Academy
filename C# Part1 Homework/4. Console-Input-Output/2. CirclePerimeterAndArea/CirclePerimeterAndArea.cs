using System;

class CirclePerimeterAndArea
{
    static void Main()
    {
        //Write a program that reads the radius r of a circle and prints its perimeter and area.

        Console.Write("Please enter circle radius: ");
        string input = Console.ReadLine();
        double radius = double.Parse(input);
        double pi = Math.PI;
        double perimeter = 2 * pi * radius;
        double area = pi * radius * radius;
        Console.WriteLine("The perimeter and area of circle with radius {0} are {1:F2} and {2:F2}", radius, perimeter, area);
    }
}
