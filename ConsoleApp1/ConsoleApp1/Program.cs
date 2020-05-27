using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter numeric value less than or equal to 99,999 only. No alphabets.");
            var inputField = Console.ReadLine();
            if (inputField.ToString().Length > 5)
                Console.WriteLine("Enter value less than 5, means conversion is implemented till 99,999 only.");
            //We can implement it, but pdf asked till 10 thousand. We will need to go on adding conditions in implemented class.
            //Right now, it is assumed that, user will enter only NUMERIC fields and not alphabets.
            Console.WriteLine("Enter once Again:");
            inputField = Console.ReadLine();

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
