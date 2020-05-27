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

        static string ConvertToString(int inputParam)
        {
            string outputString = "";

            outputString = ConvertFunToString((int)(inputParam % 100));

            return outputString;
        }

        private static string ConvertFunToString(int v)
        {
            string finalString = "";

            finalString += firstDigits[v];

            return finalString;
        }
    }
}
