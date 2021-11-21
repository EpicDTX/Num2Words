using Num2Words.Services;
using NUnit.Framework;

namespace FeatureTest
{
    public class NumberTranslatorServiceTests
    {
        public NumberTranslatorService? service = null;
        [SetUp]
        public void Setup()
        {
            service = new();
        }

        [Test]
        public void SinglesTest()
        {
            int[] numbers = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            string[] words = new string[] {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            for (int i = 0; i < numbers.Length; i++) { 
                var output = service.Convert((float)numbers[i]);
                Assert.AreEqual(words[i] + " dollars", output);
            }
        }

        [Test]
        public void TensTest()
        {
            int[] numbers = new int[] { 10, 20, 30, 40, 50, 60, 70, 80, 90 };
            string[] words = new string[] { "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
            for (int i = 0; i < numbers.Length; i++)
            {
                var output = service.Convert((float)numbers[i]);
                Assert.AreEqual(words[i] + " dollars", output);
            }

            numbers = new int[] { 13, 19, 24, 32, 46, 58, 63, 75, 87, 99 };
            words = new string[] { "thirteen", "nineteen", "twenty-four", "thirty-two", "forty-six", "fifty-eight", "sixty-three", "seventy-five", "eighty-seven", "ninety-nine" };
            for (int i = 0; i < numbers.Length; i++)
            {
                var output = service.Convert((float)numbers[i]);
                Assert.AreEqual(words[i] + " dollars", output);
            }
        }

        [Test]
        public void HundredsTest()
        {
            int[] numbers = new int[] { 100, 200, 300, 400, 500, 600, 700, 800, 900 };
            string[] words = new string[] { "one hundred", "two hundred", "three hundred", "four hundred", "five hundred", "six hundred", "seven hundred", "eight hundred", "nine hundred" };
            for (int i = 0; i < numbers.Length; i++)
            {
                var output = service.Convert((float)numbers[i]);
                Assert.AreEqual(words[i] + " dollars", output);
            }

            numbers = new int[] { 132, 294, 321, 464, 558, 673, 745, 837, 999 };
            words = new string[] { "one hundred and thirty-two", "two hundred and ninety-four", "three hundred and twenty-one", "four hundred and sixty-four", "five hundred and fifty-eight", "six hundred and seventy-three", "seven hundred and forty-five", "eight hundred and thirty-seven", "nine hundred and ninety-nine" };
            for (int i = 0; i < numbers.Length; i++)
            {
                var output = service.Convert((float)numbers[i]);
                Assert.AreEqual(words[i] + " dollars", output);
            }
        }

        [Test]
        public void ThousandsTest()
        {
            int[] numbers = new int[] { 1000, 2000, 3000, 4000, 5000, 6000, 7000, 8000, 9000 };
            string[] words = new string[] { "one thousand", "two thousand", "three thousand", "four thousand", "five thousand", "six thousand", "seven thousand", "eight thousand", "nine thousand" };
            for (int i = 0; i < numbers.Length; i++)
            {
                var output = service.Convert((float)numbers[i]);
                Assert.AreEqual(words[i] + " dollars", output);
            }

            numbers = new int[] { 1999, 2837, 3745, 4673, 5558, 6464, 7321, 8294, 9132, 9999 };
            words = new string[] { "one thousand nine hundred and ninety-nine", "two thousand eight hundred and thirty-seven", "three thousand seven hundred and forty-five", "four thousand six hundred and seventy-three", "five thousand five hundred and fifty-eight", "six thousand four hundred and sixty-four", "seven thousand three hundred and twenty-one", "eight thousand two hundred and ninety-four", "nine thousand one hundred and thirty-two", "nine thousand nine hundred and ninety-nine" };
            for (int i = 0; i < numbers.Length; i++)
            {
                var output = service.Convert((float)numbers[i]);
                Assert.AreEqual(words[i] + " dollars", output);
            }
        }

        [Test]
        public void SinglesWithCentsTest()
        {
            double[] numbers = new double[] { 0.12, 1.85, 2.79, 3.62, 4.46, 5.21, 6.55, 7.84, 8.66, 9.71, 9.99 };
            string[] words = new string[] { "zero dollars and twelve cents", "one dollars and eighty-five cents", "two dollars and seventy-nine cents", "three dollars and sixty-two cents", "four dollars and forty-six cents", "five dollars and twenty-one cents", "six dollars and fifty-five cents", "seven dollars and eighty-four cents", "eight dollars and sixty-six cents", "nine dollars and seventy-one cents", "nine dollars and ninety-nine cents" };
            for (int i = 0; i < numbers.Length; i++)
            {
                var output = service.Convert((float)numbers[i]);
                Assert.AreEqual(words[i], output);
            }
        }

        [Test]
        public void TensWithCentsTest()
        {
            double[] numbers = new double[] { 10.71, 20.66, 30.84, 40.55, 50.21, 60.46, 70.62, 80.79, 90.12 };
            string[] words = new string[] { "ten dollars and seventy-one cents", "twenty dollars and sixty-six cents", "thirty dollars and eighty-four cents", "forty dollars and fifty-five cents", "fifty dollars and twenty-one cents", "sixty dollars and forty-six cents", "seventy dollars and sixty-two cents", "eighty dollars and seventy-nine cents", "ninety dollars and twelve cents" };
            for (int i = 0; i < numbers.Length; i++)
            {
                var output = service.Convert((float)numbers[i]);
                Assert.AreEqual(words[i], output);
            }
        }

        [Test]
        public void HundredsWithCentsTest()
        {
            double[] numbers = new double[] { 100.12, 294.79, 321.62, 464.46, 501.21, 673.55, 700.84, 837.66, 900.71};
            string[] words = new string[] { "one hundred dollars and twelve cents", "two hundred and ninety-four dollars and seventy-nine cents", "three hundred and twenty-one dollars and sixty-two cents", "four hundred and sixty-four dollars and forty-six cents", "five hundred and one dollars and twenty-one cents", "six hundred and seventy-three dollars and fifty-five cents", "seven hundred dollars and eighty-four cents", "eight hundred and thirty-seven dollars and sixty-six cents", "nine hundred dollars and seventy-one cents" };

            for (int i = 0; i < numbers.Length; i++)
            {
                var output = service.Convert((float)numbers[i]);
                Assert.AreEqual(words[i], output);
            }
        }

        [Test]
        public void ThousandsWithCentsTest()
        {
            double[] numbers = new double[] { 1010.71, 2213.66, 3000.84, 4024.55, 5323.21, 6004.46, 7200.62, 8000.79, 9678.12, 9999.99 };
            string[] words = new string[] { "one thousand and ten dollars and seventy-one cents", "two thousand two hundred and thirteen dollars and sixty-six cents", "three thousand dollars and eighty-four cents", "four thousand and twenty-four dollars and fifty-five cents", "five thousand three hundred and twenty-three dollars and twenty-one cents", "six thousand and four dollars and forty-six cents", "seven thousand two hundred dollars and sixty-two cents", "eight thousand dollars and seventy-nine cents", "nine thousand six hundred and seventy-eight dollars and twelve cents", "nine thousand nine hundred and ninety-nine dollars and ninety-nine cents" };
            for (int i = 0; i < numbers.Length; i++)
            {
                var output = service.Convert((float)numbers[i]);
                Assert.AreEqual(words[i], output);
            }
        }
    }
}