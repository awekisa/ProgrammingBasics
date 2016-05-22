using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._1_Other_Wigle_Wigle
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] numbers = Console.ReadLine().Split().Select(long.Parse).ToArray();

            for (int j = 0; j < numbers.Length; j += 2)
            {
                long first = numbers[j];
                long second = numbers[j + 1];
                for (int i = 0; i < 64; i += 2)
                {
                    long firstCurr = (first >> i) & 1;
                    Console.WriteLine(firstCurr);
                    long secondCurr = (second >> i) & 1;
                    Console.WriteLine(secondCurr);
                    if (firstCurr != secondCurr)
                    {
                        first = first ^ ((long)1 << i);
                        second = second ^ ((long)1 << i);
                    }
                }
                first = ~first;
                first = first & ~((long)1 << 63);
                second = ~second;
                second = second & ~((long)1 << 63);
                string f = Convert.ToString(first, 2).PadLeft(63, '0');
                string s = Convert.ToString(second, 2).PadLeft(63, '0');

                Console.Write(Convert.ToInt64(f, 2));
                Console.WriteLine(" " + f);

                Console.Write(Convert.ToInt64(s, 2));
                Console.WriteLine(" " + s);
            }
        }
    }
}
