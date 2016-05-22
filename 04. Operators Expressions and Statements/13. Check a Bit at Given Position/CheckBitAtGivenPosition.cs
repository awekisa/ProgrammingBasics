using System;

class CheckBitAtGivenPosition
{
    static void Main()
    {
        int inputNumber = int.Parse(Console.ReadLine());
        int position = int.Parse(Console.ReadLine());
        bool bitIsOne = true;
        //string Bitnumber = Convert.ToString(inputNumber, 2).PadLeft(64, '0');
        //Console.WriteLine(Bitnumber);
        int newNumber = inputNumber >> position;
        //string newBitNumber = Convert.ToString(newNumber, 2).PadLeft(64, '0');
        //Console.WriteLine(newBitNumber);
        int bit = newNumber & 1;
        
        if (bit == 1)
        {
            bitIsOne = true;
            Console.WriteLine(bitIsOne);
        }
        else
        {
            bitIsOne = false;
            Console.WriteLine(bitIsOne);
        }
    }
}

