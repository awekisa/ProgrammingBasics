using System;

class PrintASequence
{
    static void Main()
    {
        // Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...


        for (int a = 2; a < 12; a++)
        {
            if (a % 2 == 0)
            {
                Console.Write(a + ", ");
            }
            else if ((a % 2 != 0) && a != 11)
            {
                Console.Write(- a +", ");
            }
            else
            {
                Console.Write(-a);
            }


        }
        Console.WriteLine();
    }
}

