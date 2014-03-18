using System;

class IsFemale
{
    static void Main()
    {
        // Declare a boolean variable called isFemale and assign an appropriate value corresponding to your gender.

        string myGender = "Male";
        bool isFemale = (myGender == "Female");
        Console.WriteLine("You are female - {0}", isFemale);
    }
}
