using System;

class EmployeeRecord
{
    static void Main()
    {
        // A marketing firm wants to keep record of its employees. 
        // Each record would have the following characteristics – first name, family name, age, gender (m or f), 
        // ID number, unique employee number (27560000 to 27569999). 
        // Declare the variables needed to keep the information for a single employee 
        // using appropriate data types and descriptive names.

        string firstName = "Pesho";
        string familyName = "Ivanov";
        byte age = 20;
        char gender = 'm';
        int idNumber = 642736077;
        int uniqueNumber = 27560001;

        Console.WriteLine(@"
                            Information about the employee.
                            1. Employee first name: {0}
                            2. Employee family name: {1}
                            3. Employee age: {2}
                            4. Employee gender: {3}
                            5. Employee ID number: {4}
                            6. Employee unique number: {5}", firstName, familyName, age, gender, idNumber, uniqueNumber);
    }
}
