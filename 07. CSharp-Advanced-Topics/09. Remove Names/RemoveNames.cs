using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Remove_Names
{
    class RemoveNames
    {
        static void Main()
        {
            string inputOne = Console.ReadLine();
            string inputTwo = Console.ReadLine();
            List<string> temp = new List<string>(inputOne.Split(' '));
            List<string> remove = new List<string>(inputTwo.Split(' '));
            List<string> result = new List<string>();
            result.AddRange(temp);

            foreach (string item in temp)
            {
                for (int i = 0; i < remove.Count; i++)
                {
                    if (item == remove[i])
                    {
                        result.Remove(item);
                    }
                }
            }
            Console.WriteLine();
            
                Console.Write(string.Join(", ", result));
            
            Console.WriteLine();
        }
    }
}
