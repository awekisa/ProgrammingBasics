using System;

class MatrixOfNumbers
{
    static void Main()
    {
        int inputNumber = int.Parse(Console.ReadLine());
        
        for (int countVertical = 1; countVertical <= inputNumber; countVertical++)
        {
            Console.Write("\n{0} ", countVertical);
            
            for (int countHorizontal = countVertical + 1;countHorizontal <= inputNumber + countVertical - 1; countHorizontal++)
            {
                
                Console.Write("{0} ", countHorizontal);
            }
            
        }
        Console.WriteLine();
        
    }
}

