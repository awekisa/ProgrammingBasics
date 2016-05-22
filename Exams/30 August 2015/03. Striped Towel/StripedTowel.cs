using System;

class StripedTowel
{
    static void Main()
    {
        byte input = byte.Parse(Console.ReadLine());

        
        for (int i = 0; i < input / 2; i++)
        {
            for (int top = 0; top < input; top++)            // top
            {
                if (top == 0 | top % 3 == 0)
                {
                    Console.Write("#");
                }
                else
                {
                    Console.Write(".");
                }
            }
            Console.WriteLine();

            for (int middle = 0; middle < input; middle++)           // middle
            {
                if ((middle + 1) % 3 == 0)
                {
                    Console.Write("#");
                }
                else
                {
                    Console.Write(".");
                }
            }
            Console.WriteLine();
            for (int middle = 0; middle < input; middle++)
            {
                if ((middle + 2) % 3 == 0)
                {
                    Console.Write("#");
                }
                else
                {
                    Console.Write(".");
                }
            }
            Console.WriteLine();            
        }
        for (int bottom = 0; bottom < input; bottom++)            // bottom
        {
            if (bottom == 0 | bottom % 3 == 0)
            {
                Console.Write("#");
            }
            else
            {
                Console.Write(".");
            }
        }
    }
        
}

