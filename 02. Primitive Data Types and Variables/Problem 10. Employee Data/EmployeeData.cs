using System;

class EmployeeData
{
    static void Main()
    {
        //  A marketing company wants to keep record of its employees. Each record would have the following characteristics:
        //•	First name
        //•	Last name
        //•	Age(0...100)
        //•	Gender(m or f)
        //•	Personal ID number(e.g. 8306112507)
        //•	Unique employee number(27560000…27569999)
        //  Declare the variables needed to keep the information for a single employee using appropriate primitive data types. Use descriptive names.
        //  Print the data at the console.

        string firstName = "Amanda";
        string lastName = "Jonson";
        byte age = 27;
        char gender = 'f';
        long personalIDNumber = 8306112507;
        int uniqueEmployeeNumber = 27563571;

        Console.WriteLine("First name: {0} \nLast name: {1} \nAge: {2} \nGender: {3} \nPersonal ID: {4} \nUnique Employee number: {5}", firstName, lastName, age, gender, personalIDNumber, uniqueEmployeeNumber);


    }
}

