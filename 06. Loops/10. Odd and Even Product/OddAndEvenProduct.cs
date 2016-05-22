using System;

class OddAndEvenProduct
{
    static void Main()
    {
        string inputString = Console.ReadLine();
        string[] elements = inputString.Split(' ');
        
        int numberOfElements = elements.Length;



        Console.WriteLine();
        int oddIndex = 0;
        int evenIndex = 1;
        int evenNumbers = 0;
        int oddNumbers = 0;
        int sumEven = 1;
        int sumOdd = 1;

        for (int count = 1; count <= numberOfElements; count++)
        {
            if (count % 2 == 0)
            {
                evenNumbers = int.Parse(elements[evenIndex]);
                sumEven *= evenNumbers;

                evenIndex += 2;
                
            }
            else
            {
                oddNumbers = int.Parse(elements[oddIndex]);
                sumOdd *= oddNumbers;
                oddIndex += 2;
                
            }

                   
        }
        if (sumEven == sumOdd)
        {
            Console.WriteLine("yes\nproduct = {0}", sumEven);
        }
        else
        {
            Console.WriteLine("no\nodd_product= {0}\neven_product = {1}", sumOdd, sumEven);
        }
        
    }
}


