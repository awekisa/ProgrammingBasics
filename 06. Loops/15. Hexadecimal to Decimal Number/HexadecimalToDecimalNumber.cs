using System;

class HexadecimalToDecimalNumber
{
    static void Main()
    {
        // 216 = 2 x 161 = 2 x 16

        string inputString = Console.ReadLine();
        Int64 result = 0;

        char[] reversedResult = inputString.ToCharArray();
        Array.Reverse(reversedResult);
        Console.WriteLine(reversedResult);

        for (int positionLeftToRight = 0; positionLeftToRight <= inputString.Length - 1; positionLeftToRight++)
        {
            if ((Int64)(reversedResult[positionLeftToRight] - '0') >= 0 && (Int64)(reversedResult[positionLeftToRight] - '0') <= 9)
            {
                result = (result + (Int64)(reversedResult[positionLeftToRight] - '0') * (Int64)Math.Pow(16, positionLeftToRight));
            }
            else
            {
                switch (reversedResult[positionLeftToRight])
                {
                    case 'A':
                        result = (result + 10 * (Int64)Math.Pow(16, positionLeftToRight));
                        break;
                    case 'B':
                        result = (result + 11 * (Int64)Math.Pow(16, positionLeftToRight));
                        break;
                    case 'C':
                        result = (result + 12 * (Int64)Math.Pow(16, positionLeftToRight));
                        break;
                    case 'D':
                        result = (result + 13 * (Int64)Math.Pow(16, positionLeftToRight));
                        break;
                    case 'E':
                        result = (result + 14 * (Int64)Math.Pow(16, positionLeftToRight));
                        break;
                    case 'F':
                        result = (result + (15 * (Int64)Math.Pow(16, positionLeftToRight)));
                        break;

                    default:
                        break;
                }
                Console.WriteLine(result);
            }
        }
        Console.WriteLine(result);
    }
}

