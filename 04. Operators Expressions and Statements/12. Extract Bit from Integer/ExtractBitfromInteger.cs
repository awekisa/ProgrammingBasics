using System;

class ExtractBitfromInteger
{
    static void Main()
    {
        int inputNumber = int.Parse(Console.ReadLine());
        int position = int.Parse(Console.ReadLine());

        //string Bitnumber = Convert.ToString(inputNumber, 2).PadLeft(32, '0');
        //Console.WriteLine(Bitnumber);
        int newNumber = inputNumber >> position;
        //string newBitNumber = Convert.ToString(newNumber, 2).PadLeft(32, '0');
        //Console.WriteLine(newBitNumber);
        int bit = newNumber & 1;
        Console.WriteLine(bit);


        
    }
}

