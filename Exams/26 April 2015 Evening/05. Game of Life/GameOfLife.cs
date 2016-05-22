using System;

class GameOfLife
{
    static void Main()
    {
        int numberOfInputs = int.Parse(Console.ReadLine());
        int[] inputRow = new int[numberOfInputs];
        int[] rowValue = new int[numberOfInputs];
        int[] matrix = new int[10];
        int inputCount = 0;
        for (int i = 0; i < numberOfInputs; i++)                 // input
        {           
                inputRow[i] = int.Parse(Console.ReadLine());
                rowValue[i] = int.Parse(Console.ReadLine());
            
            
        }

        for (int row = 0; row < 10; row++)          // drawing rows
        {
            if (inputCount < inputRow.Length && row == inputRow[inputCount])
            {
                matrix[row] = 0 | 1 << rowValue[inputCount];
                Console.WriteLine(Convert.ToString(matrix[row], 2).PadLeft(10, '0'));
                inputCount += 1;
            }
            else
            {
                matrix[row] = 0;
                Console.WriteLine(Convert.ToString(0, 2).PadLeft(10, '0'));
            }


        }
    }
}

