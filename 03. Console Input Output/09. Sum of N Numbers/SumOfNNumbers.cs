using System;

class SumOfNNumbers
{
    static void Main()
    {


        int inputNumberOfNumbers = int.Parse(Console.ReadLine());
        double number = 0;
        double newNumber = 0;


        for (int numberOfNumbers = 0; numberOfNumbers < inputNumberOfNumbers; numberOfNumbers++)
        {

            number = double.Parse(Console.ReadLine());
            newNumber += number;           
        }

        
        Console.WriteLine(newNumber);



        
    }


}


