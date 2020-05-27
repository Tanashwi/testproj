namespace ConsoleApp1.Classes
{
    public class FixedValues
    {
        private static string[] firstDigits = {
                       "", "One ", "Two ", "Three ", "Four ",
                       "Five ", "Six ", "Seven ", "Eight ",
                       "Nine ", "Ten ", "Eleven ", "Twelve ",
                       "Thirteen ", "Fourteen ", "Fifteen ",
                       "Sixteen ", "Seventeen ", "Eighteen ",
                       "Nineteen "};

        //left first 2 empty in array, for handling values
        private static string[] secondDigits = {"", "", "Twenty ", "Thirty ", "Forty ",
                       "Fifty ", "Sixty ", "Seventy ", "Eighty ",
                       "Ninety "};

        public static string[] FirstDigits { get => firstDigits; set => firstDigits = value; }
        public static string[] SecondDigits { get => secondDigits; set => secondDigits = value; }
    }
}
