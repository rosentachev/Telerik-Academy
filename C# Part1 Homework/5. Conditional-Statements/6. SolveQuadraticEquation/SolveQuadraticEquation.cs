using System;

class SolveQuadraticEquation
{
    static void Main()
    {
        //Write a program that enters the coefficients a, b and c of a quadratic equation
		//a*x2 + b*x + c = 0
		//and calculates and prints its real roots. Note that quadratic equations may have 0, 1 or 2 real roots.

        Console.Write("Enter coefficient a: ");
        string input = Console.ReadLine();
        double coefA = double.Parse(input);
        Console.Write("Enter coefficient b: ");
        input = Console.ReadLine();
        double coefB = double.Parse(input);
        Console.Write("Enter coefficient c: ");
        input = Console.ReadLine();
        double coefC = double.Parse(input);

        double discriminant = coefB * coefB - 4 * coefA * coefC;
        if (discriminant > 0)
        {
            double x1 = (-coefB + Math.Sqrt(discriminant)) / (2 * coefA);
            double x2 = (-coefB - Math.Sqrt(discriminant)) / (2 * coefA);
            Console.WriteLine("First root is equal to {0}", x1);
            Console.WriteLine("Second root is equal to {0}", x2);
        }
        else if (discriminant == 0)
        {
            Console.WriteLine("The discriminant is zero and there is exactly one real root -> {0}", -coefB / (2 * coefA));
        }
        else if (discriminant < 0)
        {
            Console.WriteLine("There are no real roots because the discriminant is negative ({0})", discriminant);
        }
    }
}
