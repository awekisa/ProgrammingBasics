using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Longest_Area_in_Array
{
    class LongestAreaInArray
    {
        static void Main()
        {
            int numberOfInputs = int.Parse(Console.ReadLine());
            string[] elements = new string[numberOfInputs];
            List<string> longestSequence = new List<string>();
            List<string> temp = new List<string>();
            string tempString = string.Empty;


            for (int i = 0; i < numberOfInputs; i++)
            {
                elements[i] = Console.ReadLine();
            }

            tempString = elements[0];
            for (int i = 0; i < numberOfInputs; i++)
            {
                if (longestSequence.Count == 0)
                {
                    longestSequence.Add(elements[i]);
                    tempString = elements[i];
                }
                else
                {
                    if (elements[i] == tempString)
                    {
                        longestSequence.Add(elements[i]);
                        tempString = elements[i];
                    }
                    else
                    {
                        if (temp.Count == 0)
                        {
                            temp.AddRange(longestSequence);
                        }
                        else if (longestSequence.Count >= temp.Count && longestSequence[0] == temp[0])
                        {
                            temp.AddRange(longestSequence);
                            
                        }
                        else
                        {
                            temp.Clear();
                            temp.AddRange(longestSequence);
                        }
                        longestSequence.Clear();
                        tempString = elements[i];
                        longestSequence.Add(elements[i]);
                        
                    }
                }                               
            }
            if (longestSequence.Count > temp.Count)
            {
                Console.WriteLine();
                Console.WriteLine(longestSequence.Count);
                foreach (string item in longestSequence)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine(temp.Count);
                foreach (string item in temp)
                {
                    Console.WriteLine(item);
                }
            }

            

        }
    }
}
