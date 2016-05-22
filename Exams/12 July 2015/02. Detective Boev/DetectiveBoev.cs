using System;

class DetectiveBoev
{
    static void Main()
    {
        string codeWord = Console.ReadLine();
        string message = Console.ReadLine();
        int mask = 0;
        int resultChar = 0;
        

        char[] chars = codeWord.ToCharArray();
        char[] messageSymbols = message.ToCharArray();
        string result = string.Empty;

        foreach (char item in chars)
        {
            mask += Convert.ToInt32(item);
        }


        int sum = 0;
        while (mask != 0)
        {
            sum += mask % 10;
            mask /= 10;
        }
        while (sum > 9)
        {
            mask = sum;
            sum = 0;
            while (mask != 0)
            {
                sum += mask % 10;
                mask /= 10;
            }
        }



        foreach (char item in messageSymbols)
        {
            Convert.ToInt32(item);
            if (item % sum == 0)
            {
                resultChar = item + sum;
                result += (char)resultChar;

            }
            else
            {
                resultChar = item - sum;
                result += (char)resultChar;
                
            }
        }
        char[] temp = result.ToCharArray();
        Array.Reverse(temp);
        result = new string(temp);
        Console.WriteLine(result);
    }
}

