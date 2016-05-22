using System;

class NullValuesArithmetic
{
    static void Main()
    {
        // Create a program that assigns null values to an integer and to a double variable. Try to print these variables at the console. 
        // Try to add some number or the null literal to these variables and print the result.

        int? nullValueInt = null;
        double? nullValueDouble = null;

        Console.WriteLine(nullValueInt);
        Console.WriteLine(nullValueDouble);

        int someNumber = int.Parse(Console.ReadLine());

        Console.WriteLine(nullValueInt + someNumber);
        Console.WriteLine(nullValueInt + null);

        Console.WriteLine(nullValueDouble + someNumber);
        Console.WriteLine(nullValueDouble + null);





    }
}

