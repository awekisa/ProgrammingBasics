using System;

class MinMaxSumAndAverageOfNNumbers
{
    static void Main()
    {
        int numberOfInputs = int.Parse(Console.ReadLine());
        int min = 0;
        int max = 0;
        int sum = 0;
        double avg = 0.00;
        
        int tempMin = 0;
        int tempMax = 0;

        for (int count = 1; count <= numberOfInputs; count++)
        {
            int inputNumbers = int.Parse(Console.ReadLine());
            if (count == 1)                                                         // only first time case in the loop
            {
                tempMin = inputNumbers;
                tempMax = inputNumbers;
            }
            
            min = Math.Min(tempMin, inputNumbers);
            tempMin = min;

            max = Math.Max(tempMax, inputNumbers);
            tempMax = max;

            sum += inputNumbers;

        }
        avg = sum / Convert.ToDouble(numberOfInputs);
        Console.WriteLine("min = {0}", min);
        Console.WriteLine("max = {0}", max);
        Console.WriteLine("sum = {0}", sum);
        Console.WriteLine("avg = {0:F2}", avg);



    }
}

