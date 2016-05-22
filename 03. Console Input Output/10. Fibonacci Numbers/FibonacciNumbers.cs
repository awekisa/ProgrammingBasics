using System;

class FibonacciNumbers
{
    static void Main()
    {
        int inputnumber = int.Parse(Console.ReadLine());

        

        int fibonacci = 0;
        int next = 1;
        Console.WriteLine();
        
        for (int a = 0; a < inputnumber; a++)
        {
            Console.Write("{0} ", fibonacci);
            int temp = fibonacci;
            fibonacci = next;
            next = next + temp;


            
        }
        Console.WriteLine();
        
    }




}




