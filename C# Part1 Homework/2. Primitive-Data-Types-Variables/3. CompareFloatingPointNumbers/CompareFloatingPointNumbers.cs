using System;

class CompareFloatingPointNumbers
{
    static void Main()
    {
        //Write a program that safely compares floating-point numbers with precision of 0.000001. 
        // Examples:(5.3 ; 6.01) -> false;  (5.00000001 ; 5.00000003) -> true

        double firstNum = 5.3;
        double secondNum = 6.01;
        double thirdNum = 5.00000001;
        double fourthNum = 5.00000003;

        bool firstCompare = Math.Abs(firstNum - secondNum) < 0.000001;
        bool secondCompare = Math.Abs(thirdNum - fourthNum) < 0.000001;
        Console.WriteLine("{0} is equal to {1} with precision of 0.000001 -> {2}", firstNum, secondNum, firstCompare);
        Console.WriteLine("{0} is equal to {1} with precision of 0.000001 -> {2}", thirdNum, fourthNum, secondCompare);
    }
}
