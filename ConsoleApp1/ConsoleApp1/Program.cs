﻿using ConsoleApp1.Classes;
using System;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter numeric value less than or equal to 99,999 only. No alphabets.");
            var inputField = Console.ReadLine();
            if (inputField.ToString().Length > 5)
            {
                Console.WriteLine("Enter value less than 5, means conversion is implemented till 99,999 only.");
                //We can implement it, but pdf asked till 10 thousand. We will need to go on adding conditions in implemented class.
                //Right now, it is assumed that, user will enter only NUMERIC fields and not alphabets.
                Console.WriteLine("Enter once Again:");
                inputField = Console.ReadLine();
            }
            Console.WriteLine("\n" + inputField + " is splelled as:" + ConvertingLogic.ConvertToString(Convert.ToInt32(inputField)));
            Console.ReadKey();
        }
    }
}
