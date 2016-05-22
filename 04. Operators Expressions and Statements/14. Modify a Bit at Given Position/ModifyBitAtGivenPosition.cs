using System;

class ModifyBitAtGivenPosition
{
    static void Main()
    {
        int inputNumber = int.Parse(Console.ReadLine());
        int position = int.Parse(Console.ReadLine());
        int value = int.Parse(Console.ReadLine());
        int mask = 1 << position;
        int result;
               
        if (value == 0)
        {
            mask = ~(1 << position);
            result = inputNumber & mask;                     
        }
        else
        {
            result = inputNumber | mask;
            
        }
        Console.WriteLine();
        
        Console.WriteLine(Convert.ToString(result, 2).PadLeft(32, '0'));
        Console.WriteLine(result);

        
    }
}

