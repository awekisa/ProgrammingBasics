using System;


namespace _05.Sorting_Numbers
{
    class SortingNumbers
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            int[] numbers = new int[input];
            for (int i = 0; i < input; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());

            }
            Array.Sort<int>(numbers);
            Console.WriteLine();
            for (int i = 0; i < input; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}

