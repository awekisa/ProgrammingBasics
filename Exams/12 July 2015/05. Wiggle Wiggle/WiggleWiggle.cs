using System;
using System.Numerics;
using System.Collections.Generic;
using System.Text;

class WiggleWiggle
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] numbers = input.Split(' ');
        BigInteger[] inputNumbers = new BigInteger[numbers.Length];
        BigInteger firstBit = 0;
        BigInteger secondBit = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            inputNumbers[i] = BigInteger.Parse(numbers[i]);
        }

        for (int i = 0; i < inputNumbers.Length; i += 2)
        {

            for (int bit = 0; bit < 64; bit += 2)
            {
                int maskZero = ~(1 << bit);
                int maskOne = 1 << bit;
                firstBit = inputNumbers[i] & (1 << bit);
                firstBit >>= bit;
                secondBit = inputNumbers[i + 1] & (1 << bit);
                secondBit >>= bit;
                if (firstBit != secondBit)
                {
                    if (firstBit == 1)
                    {
                        inputNumbers[i] = inputNumbers[i] & maskZero;
                        //Console.WriteLine("* final {0}: {1}", bit, inputNumbers[i].ToBinaryString().PadLeft(64, '0'));
                        inputNumbers[i + 1] = inputNumbers[i + 1] | maskOne;
                        //Console.WriteLine("* final {0}: {1}", bit + 1, inputNumbers[i + 1].ToBinaryString().PadLeft(64, '0'));
                    }
                    else
                    {
                        inputNumbers[i] = inputNumbers[i] | maskOne;
                        //Console.WriteLine("* final {0}: {1}", bit, inputNumbers[i].ToBinaryString().PadLeft(64, '0'));
                        inputNumbers[i + 1] = inputNumbers[i + 1] & maskZero;
                        //Console.WriteLine("* final {0}: {1}", bit + 1, inputNumbers[i + 1].ToBinaryString().PadLeft(64, '0'));
                    }


                }
                else
                {
                    //Console.WriteLine("* final {0}: {1}", bit, inputNumbers[i].ToBinaryString().PadLeft(64, '0'));
                    //Console.WriteLine("* final {0}: {1}", bit + 1, inputNumbers[i + 1].ToBinaryString().PadLeft(64, '0'));
                }


            }
            Console.WriteLine("{0} {1}", inputNumbers[i+1], inputNumbers[i+1].ToBinaryString().PadLeft(64, '0'));

            

            //for (int bitCount = 0; bitCount < 63; bitCount++)
            //{
            //    int maskZero = ~(1 << bitCount);
            //    int maskOne = 1 << bitCount;
            //    BigInteger bitCheck = inputNumbers[i] & (1 << bitCount);
            //    bitCheck >>= bitCount;
            //    BigInteger bitCheckSecond = inputNumbers[i + 1] & (1 << bitCount);
                
                

                
            //    if (bitCheck == 1)
            //    {
                    
            //        numberReversed[i] = inputNumbers[i] & maskZero;

            //        //Console.WriteLine("{0} {1}", numberReversed[i], numberReversed[i].ToBinaryString().PadLeft(64, '1'));


            //    }
            //    else
            //    {
            //        numberReversed[i] = inputNumbers[i] | maskOne;

            //        //Console.WriteLine("{0} {1}", numberReversed[i], numberReversed[i].ToBinaryString().PadLeft(64, '1'));

            //    }
            //    //Console.WriteLine("{0} {1}", bitCount, bitCheck);
                
            //    if (bitCheckSecond == 1)
            //    {
            //        numberReversed[i + 1] = inputNumbers[i + 1] & maskZero;
            //        Console.WriteLine("{0} {1}", numberReversed[i+1], numberReversed[i+1].ToBinaryString().PadLeft(64, '1'));
            //    }
            //    else
            //    {
            //        numberReversed[i + 1] = numberReversed[i + 1] | maskOne;
            //        Console.WriteLine("{0} {1}", numberReversed[i + 1], numberReversed[i + 1].ToBinaryString().PadLeft(64, '1'));
            //    }
            //    Console.WriteLine("{0} {1}", bitCount, bitCheckSecond);
            
            

        }
        BigInteger[] numberReversed = new BigInteger[inputNumbers.Length];

        for (int j = 0; j < inputNumbers.Length; j++)
        {
            numberReversed[j] = ~inputNumbers[j];
            numberReversed[j] = numberReversed[j] & ((long)1 << 63);
            Console.WriteLine("{0} {1}", numberReversed[j], numberReversed[j].ToBinaryString().PadLeft(64, '1'));
        }
        
        
        //Console.WriteLine("{0} {1}", numberReversed[i + 1], numberReversed[i + 1].ToBinaryString().PadLeft(64, '1'));
    }

}


public static class BigIntegerExtensions
{
    /// <summary>
    /// Converts a <see cref="BigInteger"/> to a binary string.
    /// </summary>
    /// <param name="bigint">A <see cref="BigInteger"/>.</param>
    /// <returns>
    /// A <see cref="System.String"/> containing a binary
    /// representation of the supplied <see cref="BigInteger"/>.
    /// </returns>
    public static string ToBinaryString(this BigInteger bigint)
    {
        var bytes = bigint.ToByteArray();
        var idx = bytes.Length - 1;

        // Create a StringBuilder having appropriate capacity.
        var base2 = new StringBuilder(bytes.Length * 8);

        // Convert first byte to binary.
        var binary = Convert.ToString(bytes[idx], 2);

        // Ensure leading zero exists if value is positive.
        if (binary[0] != '0' && bigint.Sign == 1)
        {
            base2.Append('0');
        }

        // Append binary string to StringBuilder.
        base2.Append(binary);

        // Convert remaining bytes adding leading zeros.
        for (idx--; idx >= 0; idx--)
        {
            base2.Append(Convert.ToString(bytes[idx], 2).PadLeft(8, '0'));
        }

        return base2.ToString();

    }
}





