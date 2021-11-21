namespace Num2Words.Services
{
    public class NumberTranslatorService : INumberTranslatorService
    {
        public NumberTranslatorService()
        {
        }

        //private readonly Dictionary<string, string> translator = new()
        //{
        //    ["0"] = "zero", ["1"] = "one", ["2"] = "two", ["3"] = "three", ["4"] = "four",
        //    ["5"] = "five", ["6"] = "six", ["7"] = "seven", ["8"] = "eight", ["9"] = "nine",
        //    ["10"] = "ten", ["11"] = "eleven", ["12"] = "twelve", ["13"] = "thirteen", ["14"] = "fourteen",
        //    ["15"] = "fifteen", ["16"] = "sixteen", ["17"] = "seventeen", ["18"] = "eighteen", ["19"] = "nineteen",
        //    ["20"] = "twenty", ["30"] = "thirty", ["40"] = "forty", ["50"] = "fifty", ["60"] = "sixty",
        //    ["70"] = "seventy", ["80"] = "eighty", ["90"] = "ninety", ["100"] = "hundred", ["1000"] = "thousand",
        //};

        private readonly Dictionary<int, string> translator = new()
        {
            [0] = "zero", [1] = "one", [2] = "two", [3] = "three", [4] = "four",
            [5] = "five", [6] = "six", [7] = "seven", [8] = "eight", [9] = "nine",
            [10] = "ten", [11] = "eleven", [12] = "twelve", [13] = "thirteen", [14] = "fourteen",
            [15] = "fifteen", [16] = "sixteen", [17] = "seventeen", [18] = "eighteen", [19] = "nineteen",
            [20] = "twenty", [30] = "thirty", [40] = "forty", [50] = "fifty", [60] = "sixty",
            [70] = "seventy", [80] = "eighty", [90] = "ninety", [100] = "hundred", [1000] = "thousand",
        };

        public string Convert(float number)
        {
            var output = "";
            var numberString = number.ToString();
            var dollars = (int) number;
            var cents = -1;

            if (numberString.Contains("."))
            {
                var dollarsString = numberString.Split('.')[0];
                dollars = int.Parse(dollarsString);

                var centsString = numberString.Split('.')[1];
                if(centsString.Length == 1)
                {
                    centsString = centsString + "0";
                }
                cents = int.Parse(centsString);
            }

            output = TranslateDollars(dollars) + " dollars";

            if (cents >= 0)
            {
                output = output + " and " + TranslateCents(cents) + " cents";
            }

            return output;
        }

        public string TranslateDollars(int number)
        {
            var output = "";
            if (number < 20)
            {
                output = translator[number];
            }
            else if (number < 100)
            {
                var tens = number / 10;
                var singles = number % 10;

                if (singles > 0)
                {
                    output = output + translator[tens * 10] + "-" + translator[singles];
                }
                else
                {
                    output = output + translator[tens * 10];
                }
            }
            else if (number < 1000)
            {
                var hundreds = number / 100;
                var tens = number % 100 / 10;
                var singles = number % 10;

                output = translator[hundreds] + " " + translator[100];

                // For the values in the dictionary already (e.g. eleven, twelve, etc.)
                if (number % 100 < 20 && number % 10 > 0)
                {
                    output = output + " and " + translator[number % 100];
                }
                else
                {
                    if (tens > 0)
                    {
                        output = output + " and " + translator[tens * 10];
                    }

                    if (singles > 0)
                    {
                        output = output + "-" + translator[singles];
                    }
                }
            }
            else if (number < 10000)
            {
                var thousands = number / 1000;
                var hundreds = number % 1000 / 100;
                var tens = number % 1000 % 100 / 10;
                var singles = number % 1000 % 100 % 10;

                output = translator[thousands] + " " + translator[1000];

                if (hundreds > 0)
                {
                    output = output + " " + translator[hundreds] + " " + translator[100];
                }

                // For the values in the dictionary already (e.g. eleven, twelve, etc.)
                if (number % 1000 % 100 < 20 && number % 1000 % 100 > 0)
                {
                    output = output + " and " + translator[number % 100];
                }
                else
                {
                    if (tens > 0)
                    {
                        output = output + " and " + translator[tens * 10];
                    }

                    if (singles > 0)
                    {
                        output = output + "-" + translator[singles];
                    }
                }
            }

            return output;
        }

        public string TranslateCents(int number)
        {
            var output = "";

            if (number < 20)
            {
                output = translator[number];
            }
            else if (number < 100)
            {
                var tens = number / 10;
                var singles = number % 10;

                if (singles > 0)
                {
                    output = output + translator[tens * 10] + "-" + translator[singles];
                }
                else
                {
                    output = output + translator[tens * 10];
                }
            }

            return output;
        }
    }
}
