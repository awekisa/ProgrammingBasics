using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Join_Lists
{
    class JoinLists
    {
        static void Main()
        {
            string inputA = Console.ReadLine();
            string inputB = (Console.ReadLine());
            string[] elementsA = inputA.Split(' ');
            List<int> listA = new List<int>();
            for (int i = 0; i < elementsA.Length; i++)
            {
                listA.Add(int.Parse(elementsA[i]));
            }
            List<int> listB = new List<int>();
            string[] elementsB = inputB.Split(' ');
            for (int i = 0; i < elementsB.Length; i++)
            {
                listB.Add(int.Parse(elementsB[i]));
            }
            List<int> joinedTemp = new List<int>();
            List<int> result = new List<int>();
            joinedTemp.AddRange(listA);
            joinedTemp.AddRange(listB);
            
            result = joinedTemp.Distinct().ToList();
            result.Sort();
            Console.WriteLine();
            foreach (var item in result)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

        }
        
    }
}
