using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputField = Console.ReadLine();
            Console.WriteLine(ConvertToString(Convert.ToInt32(inputField)));
            Console.ReadKey();
        }

        static string[] firstDigits = {
                       "", "one ", "two ", "three ", "four ",
                       "five ", "six ", "seven ", "eight ",
                       "nine ", "ten ", "eleven ", "twelve ",
                       "thirteen ", "fourteen ", "fifteen ",
                       "sixteen ", "seventeen ", "eighteen ",
                       "nineteen "};
        //left first 2 empty in array, for handling values
        static string[] secondDigits = {"", "", "twenty ", "thirty ", "forty ",
                       "fifty ", "sixty ", "seventy ", "eighty ",
                       "ninety "};


        static string ConvertToString(int inputParam)
        {
            string outputString = "";



            outputString += ConvertFunToString((int)((inputParam / 1000) % 100), "Thousand ");

            outputString += ConvertFunToString((int)((inputParam / 100) % 10), "Hundred ");

            outputString += ConvertFunToString((int)(inputParam % 100), "");

            return outputString;
        }

        private static string ConvertFunToString(int v, string positionValue)
        {
            string finalString = "";

            if (v > 19)
            {
                finalString += secondDigits[v / 10] + firstDigits[v % 10];

            }
            else
            {
                finalString += firstDigits[v];
            }

            if (v != 0)
            {
                finalString += positionValue;
            }

            return finalString;
        }
    }
}
