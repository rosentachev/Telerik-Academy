using System;

class ChooseIntDoubleOrString
{
    static void Main()
    {
        //Write a program that, depending on the user's choice inputs int, double or string variable. 
        //If the variable is integer or double, increases it with 1. 
        //If the variable is string, appends "*" at its end. 
        //The program must show the value of that variable as a console output. Use switch statement.

        Console.Write("Please enter 0 for Int, 1 for Double or 2 for String variable.");
        string input = Console.ReadLine();
        int choice = int.Parse(input);

        switch (choice)
        {
            case 0:
                Console.Write("You chooce Int variable. Enter a Int number: ");
                input = Console.ReadLine();
                int integerNumber = int.Parse(input);
                Console.WriteLine("The result is {0}.", integerNumber + 1);
                break;
            case 1:
                Console.Write("You chooce Double variable. Enter a Double number: ");
                input = Console.ReadLine();
                double doubleNumber = double.Parse(input);
                Console.WriteLine("The result is {0}.", doubleNumber + 1);
                break;
            case 2:
                Console.Write("You chooce String variable. Enter a String: ");
                input = Console.ReadLine();
                Console.WriteLine("The result is {0}.", input + "*");
                break;
            default :
                Console.WriteLine("You must enter 0, 1 or 2 as a input!");
                break;
        }
    }
}
