using System;
using System.Text;

namespace _07.Matrix_of_Palindromes
{
    class MatrixOfPalindromes
    {


        static void Main()
        {
            int inputRows = int.Parse(Console.ReadLine());
            int inputCols = int.Parse(Console.ReadLine());
            string[,] matrix = new string[inputRows, inputCols];            
            string printMiddle = "a";
            string print = "a";

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = print + printMiddle + print;
                    Console.Write(matrix[row, col] + " ");

                    if (col == 0)
                    {
                        printMiddle = Convert.ToString((char)(col + (int)(char)(row + 98)));
                    }
                    else
                    {
                        if (col >= 1)
                        {
                            printMiddle = Convert.ToString((char)(col + (int)(char)(row + 98)));
                        }
                        if (col == matrix.GetLength(1) - 1)
                        {
                            printMiddle = Convert.ToString((char)(row + 98));
                        }
                    }                   
                }
                Console.WriteLine();
                print = Convert.ToString((char)(row + 98));
            }

        }

    }
}
