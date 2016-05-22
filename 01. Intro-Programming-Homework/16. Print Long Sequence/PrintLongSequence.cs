using System;

    class PrintLongSequence
    {
        static void Main()
        {
            for (int a = 2; a < 1002; a++)
        {
            if (a % 2 == 0)
                {
                Console.Write(a + ", ");
            }
            else 
            {
                Console.Write(-a + ", ");
            }
           
            
        }
        Console.WriteLine();
    }
    }

