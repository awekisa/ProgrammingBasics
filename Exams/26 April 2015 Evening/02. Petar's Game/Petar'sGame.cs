using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        BigInteger first = BigInteger.Parse(Console.ReadLine());
        BigInteger final = BigInteger.Parse(Console.ReadLine());
        string rep = Console.ReadLine();
        BigInteger sum = 0;

        for (BigInteger i = first; i < final; i++)
        {
            if (i % 5 == 0)
            {
                sum += i;
            }
            else
            {
                sum += i % 5;
            }
        }
        
             
        string[] resultString = new string[sum.ToString().Length];
        for (int i = 0; i < resultString.Length; i++)
        {
            resultString[i] = Convert.ToString(sum.ToString()[i]);
        }
        string replace = string.Empty;
        if (sum % 2 != 0)
        {
            replace = resultString[resultString.Length - 1];

        }
        else
        {
            replace = resultString[0];
        }
        for (int i = 0; i < resultString.Length; i++)
        {
            if (resultString[i] == replace)
            {
                resultString[i] = rep;
                
            }
        }

        for (int i = 0; i < resultString.Length; i++)
        {
            Console.Write(resultString[i]);
            
        }
        Console.WriteLine();

    }
}

