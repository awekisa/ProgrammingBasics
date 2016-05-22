using System;

class Program
{
    static void Main()
    {
        int inputNumber = int.Parse(Console.ReadLine());

        for (int count = 1; count <= inputNumber; count++)
        {
            if (count % 3 == 0 )
            {
                
            }
            else if (count % 7 == 0)
            {
                
            }
            else
            {
                Console.Write("{0} ", count);
            }
        }
    }
}

