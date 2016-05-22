using System;

class ExtractBitThree
{
    static void Main()
    {
        int inputNimber = int.Parse(Console.ReadLine());

        //string binInt = Convert.ToString(inputNimber, 2).PadLeft(32, '0');
        //Console.WriteLine(binInt);

        int newInt = inputNimber >> 3;

        //string newBinInt = Convert.ToString(newInt, 2).PadLeft(32, '0');
        //Console.WriteLine(newBinInt);

        int bit = newInt & 1;
        Console.WriteLine(bit);
    }
}

