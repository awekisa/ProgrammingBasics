using System;

class FourDigitNumber
{
    static void Main()
    {
        int inputNumber = int.Parse(Console.ReadLine());
        int d = inputNumber % 10;
        inputNumber /= 10;
        int c = inputNumber % 10;
        inputNumber /= 10;
        int b = inputNumber % 10;
        inputNumber /= 10;
        int a = inputNumber;

        int sum = a + b + c + d;
        string reverseOrder = Convert.ToString(d) + Convert.ToString(c) + Convert.ToString(b) + Convert.ToString(a);
        string lastDigitFirst = Convert.ToString(d) + Convert.ToString(a) + Convert.ToString(b) + Convert.ToString(c);
        string switchSecondAndThird = Convert.ToString(a) + Convert.ToString(c) + Convert.ToString(b) + Convert.ToString(d);

        Console.WriteLine(sum);
        Console.WriteLine(reverseOrder);
        Console.WriteLine(lastDigitFirst);
        Console.WriteLine(switchSecondAndThird);



    }
}

