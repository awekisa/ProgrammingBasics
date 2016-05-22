using System;


namespace _01.Fibonacci_Numbers
{
    class FibonacciNumbers
    {
        static void FibonaciNumbers(int inputNumber)
        {
            int fibonacci = 1;
            int next = 1;
            Console.WriteLine();

            for (int a = 0; a < inputNumber; a++)
            {
                
                int temp = fibonacci;
                fibonacci = next;
                next = next + temp;




            }
            Console.WriteLine(fibonacci);
        }
        static void Main()
        {

            int inputNumber = int.Parse(Console.ReadLine());
            FibonaciNumbers(inputNumber);
        }
    }
}
