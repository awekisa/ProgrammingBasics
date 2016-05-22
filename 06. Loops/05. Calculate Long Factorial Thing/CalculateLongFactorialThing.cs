using System;

class CalculateLongFactorialThing
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());
        double result = 1;
        

        int factorial = 1;

        for (int count = 1; count <= n; count++)
        {
            
                factorial *= count;
                result = result + (factorial / Math.Pow(x, count));
            
               
        }
        Console.WriteLine("{0:F5}", result);
        
        
    }
}

