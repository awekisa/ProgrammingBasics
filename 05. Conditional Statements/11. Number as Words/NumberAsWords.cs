using System;
using System.Globalization;                          // added for the title case function

class NumberAsWords
{
    static void Main()
    {
        int inputNumber = int.Parse(Console.ReadLine());
        
        bool threeDigitNumber = (inputNumber / 100 != 0);
        bool twoDigitNumber = (inputNumber / 10 != 0 && inputNumber / 100 == 0);
        bool oneDigitNumber = (inputNumber / 10 == 0);
        bool elevenToNineteenNumber = (inputNumber >= 11 && inputNumber <= 19);
        bool roundTwoDigitNumber = (inputNumber / 10 != 0 && inputNumber / 100 == 0) && inputNumber % 10 == 0;
        
        string zero = "zero";
        string one = "one";
        string two = "two";
        string three = "three";
        string four = "four";
        string five = "five";
        string six = "six";
        string seven = "seven";
        string eight = "eight";
        string nine = "nine";
        string ten = "ten";
        string eleven = "eleven";
        string twelve = "twelve";
        string thirteen = "thirteen";
        string fourteen = "fourteen";
        string fifteen = "fifteen";
        string sixteen = "sixteen";
        string seventeen = "seventeen";
        string eighteen = "eighteen";
        string nineteen = "nineteen";

        string twenty = "twenty";
        string thirty = "thirty";
        string fourty = "fourty";
        string fifty = "fifty";
        string sixty = "sixty";
        string seventy = "seventy";
        string eighty = "eighty";
        string ninety = "ninety";
        
        string[] oneDigitString = { zero, one, two, three, four, five, six, seven, eight, nine };
        string[] elevenToNineteenString = { eleven, twelve, thirteen, fourteen, fifteen, sixteen, seventeen, eighteen, nineteen };
        string[] roundTwoDigitString = { ten, twenty, thirty, fourty, fifty, sixty, seventy, eighty, ninety };

        
       

        if (oneDigitNumber)                               //check if number is 1 digit                          
        {
            Console.WriteLine(CultureInfo.CurrentCulture.TextInfo.ToTitleCase(oneDigitString[inputNumber])); // adding CultureInfo.CurrentCulture.TextInfo.ToTitleCase for capitalization
        }
        else if (elevenToNineteenNumber)                   // check if number is 11-19
        {

            Console.WriteLine(CultureInfo.CurrentCulture.TextInfo.ToTitleCase(elevenToNineteenString[inputNumber % 10 - 1]));              // getting last digit - 1 to start counting from 0
        }
        else if (roundTwoDigitNumber)                     // check if number is 10, 20, 30, 40 etc.
        {
            Console.WriteLine(CultureInfo.CurrentCulture.TextInfo.ToTitleCase(roundTwoDigitString[inputNumber / 10 - 1]));                // getting first digit - 1 to start counting form 0
        }
        else if (twoDigitNumber)                          // check if number is among the rest of the 2 digit nimbers
        {
            Console.WriteLine("{0} {1}", CultureInfo.CurrentCulture.TextInfo.ToTitleCase(roundTwoDigitString[inputNumber / 10 - 1]), oneDigitString[inputNumber % 10]);
        }
        else if (threeDigitNumber)                        // check if number is 3 digit
        {
            if (inputNumber % 100 == 0)                             // 100, 200, 300 etc.
            {
                Console.WriteLine("{0} hundred", CultureInfo.CurrentCulture.TextInfo.ToTitleCase(oneDigitString[inputNumber / 100]));
            }
            else if (inputNumber / 10 % 10 == 0)                    // 103, 505, 908 etc.
            {
                Console.WriteLine("{0} hundred and {1}", CultureInfo.CurrentCulture.TextInfo.ToTitleCase(oneDigitString[inputNumber / 100]), oneDigitString[inputNumber % 10]);
            }
            else if (inputNumber / 10 % 10 == 1 && inputNumber % 10 != 0)          // 413, 117, 915 etc. without 210, 910, 510 etc.
            {
                Console.WriteLine("{0} hundred and {1}", CultureInfo.CurrentCulture.TextInfo.ToTitleCase(oneDigitString[inputNumber / 100]), elevenToNineteenString[inputNumber % 10 - 1]);
            }
            else if (inputNumber % 10 == 0)               // 110, 450, 830 etc.
            {
                Console.WriteLine("{0} hundred and {1}", CultureInfo.CurrentCulture.TextInfo.ToTitleCase(oneDigitString[inputNumber / 100]), roundTwoDigitString[inputNumber / 10 % 10 - 1]);//110 220, 980 etc.
            }
            else                                          // 333, 597, 928 etc.
            {
                Console.WriteLine("{0} hundred and {1} {2}", CultureInfo.CurrentCulture.TextInfo.ToTitleCase(oneDigitString[inputNumber / 100]), roundTwoDigitString[inputNumber / 10 % 10 - 1], oneDigitString[inputNumber % 10]);
            }
        }
    }
}





