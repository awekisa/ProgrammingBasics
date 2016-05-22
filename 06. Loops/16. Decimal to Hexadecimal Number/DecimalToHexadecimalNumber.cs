using System;

class DecimalToHexadecimalNumber
{
    static void Main()
    {
        long inputNumber = Int64.Parse(Console.ReadLine());
        


        string result = "";

        do
        {
            if (inputNumber % 16 >= 0 && inputNumber % 16 <= 9)
            {
                result += Convert.ToString(inputNumber % 16);
            }
            else
            {
                switch (inputNumber % 16)
                {
                    case 10:
                        result += "A";
                        break;
                    case 11:
                        result += "B";
                        break;
                    case 12:
                        result += "C";
                        break;
                    case 13:
                        result += "D";
                        break;
                    case 14:
                        result += "E";
                        break;
                    case 15:
                        result += "F";
                        break;
                    default:
                        break;
                }
            }
                       
            inputNumber /= 16;
            
        }
        while (inputNumber != 0);
        

        char[] reversedResult = result.ToCharArray();
        Array.Reverse(reversedResult);
        string finalString = new string(reversedResult);
        Console.WriteLine();
        Console.WriteLine(finalString);

    }
}

