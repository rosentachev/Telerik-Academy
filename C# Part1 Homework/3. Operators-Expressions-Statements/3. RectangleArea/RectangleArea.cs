using System;

class RectangleArea
{
    static void Main()
    {
        //Write an expression that calculates rectangle’s area by given width and height.

        Console.Write("Enter rectangle's width: ");
        double width = double.Parse(Console.ReadLine());
        Console.Write("Enter rectangle's height: ");
        double height = double.Parse(Console.ReadLine());
        double area = width * height;
        Console.WriteLine("Rectangle's area is equal to: {0}", area);
    }
}
