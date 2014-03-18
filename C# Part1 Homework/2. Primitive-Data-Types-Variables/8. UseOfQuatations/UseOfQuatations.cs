using System;

class UseOfQuatations
{
    static void Main()
    {
        // Declare two string variables and assign them with following value: The "use" of quatations causes difficulties.
        // Do the above in two different ways: with and without using quoted strings.

        string withQuatation = "The \"use\" of quatations causes difficulties.";
        string withoutQuatation = @"The ""use"" of quatations causes difficulties.";

        Console.WriteLine("Quoted string: {0}\nNon quoted string: {1}", withQuatation, withoutQuatation);
    }
}
