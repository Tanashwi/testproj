namespace ConsoleApp1.Classes
{
    public class ConvertingLogic
    {
        public static string ConvertToString(int inputParam)
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
                finalString += FixedValues.SecondDigits[v / 10] + FixedValues.FirstDigits[v % 10];

            }
            else
            {
                finalString += FixedValues.FirstDigits[v];
            }

            if (v != 0)
            {
                finalString += positionValue;
            }

            return finalString;
        }
    }
}
