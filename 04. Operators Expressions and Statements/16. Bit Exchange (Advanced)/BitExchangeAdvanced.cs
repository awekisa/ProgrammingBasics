using System;

class BitExchangeAdvanced
{
    static void Main()
    {
        try
        {
            uint inputNumber = uint.Parse(Console.ReadLine());
            uint positionFirstBits = uint.Parse(Console.ReadLine());
            uint positionLastBits = uint.Parse(Console.ReadLine());
            uint numberOfBits = uint.Parse(Console.ReadLine());
            uint maskTemp = 1;
            uint mask = 1;
            for (int i = 1; i < (numberOfBits); i++)
            {
                mask <<= 1;
                mask |= maskTemp;
                maskTemp = mask;
            }
            uint startFirstBits = positionFirstBits;
            uint endFirstBits = positionFirstBits + numberOfBits;
            uint startLastBits = positionLastBits;
            uint endLastBits = positionLastBits + numberOfBits;

            if (endFirstBits >= startLastBits && startFirstBits <= endLastBits)
            {
                Console.WriteLine("overlapping");
                return;
            }
            else if (positionFirstBits + numberOfBits > 32 || positionLastBits + numberOfBits > 32 || positionFirstBits < 1 || positionLastBits < 1)
            {
                Console.WriteLine("out of range");
                return;
            }
            else
            {

                uint firstBits = inputNumber & (mask << Convert.ToInt32(positionFirstBits));
                firstBits >>= Convert.ToInt32(positionFirstBits);


                uint lastBits = inputNumber & (mask << Convert.ToInt32(positionLastBits));
                lastBits >>= Convert.ToInt32(positionLastBits);


                inputNumber = inputNumber & ~(mask << Convert.ToInt32(positionFirstBits));


                inputNumber = inputNumber & ~(mask << Convert.ToInt32(positionLastBits));


                inputNumber = inputNumber | (lastBits << Convert.ToInt32(positionFirstBits));


                inputNumber = inputNumber | (firstBits << Convert.ToInt32(positionLastBits));



                Console.WriteLine(inputNumber);
                Console.WriteLine(Convert.ToString(inputNumber, 2).PadLeft(32, '0'));
            }
        }
        catch (OverflowException)
        {
            Console.WriteLine("out of range");
            return;
        }

    }





}


