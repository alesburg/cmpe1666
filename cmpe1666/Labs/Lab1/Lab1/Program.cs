/* 
 * Lab #01 - Review Exercise (CMPE1666)
 * 
 * 
 *
 * Author: Anna Lesburg
 * 
 * Modification History:
 * 11 JAN 2023: Created
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using GDIDrawer;

namespace Lab1
{
    internal class Program
    {
        public static CDrawer Display;
        static void Main(string[] args)
        {
            double input; //user input value
            double roundedInput; //input rounded to nearest 0.05
            do
            {
                input = ParseInput("How much money do you wish to convert?: ");
                roundedInput = RoundPennies(input);
                Console.WriteLine($"User entry of {input:C2} interpreted and rounded to {roundedInput:C2}");

                Console.ReadKey();
            } while (false);
        }

        private static double ParseInput(string prompt)
        {
            string input; //user input string
            string output = null; //output string
            double outputNum; //output double from output string
            bool afterPoint = false; //is char after decimal point in input
            int decimalCount = 0; //counts decimal place
            bool success; //could input be parsed to double?

            //repeats until valid input received
            do
            {
                Console.Write(prompt);
                input = Console.ReadLine();

                foreach (char c in input)
                {
                    if (!afterPoint && c == '.')
                    {
                        output += c;
                        afterPoint = true;
                    }
                    else if (!afterPoint && char.IsDigit(c)) output += c;
                    else if (afterPoint && char.IsDigit(c) && decimalCount < 2)
                    {
                        output += c;
                        decimalCount++;
                    }
                }
                success = double.TryParse(output, out outputNum);
                if (!success) Console.WriteLine("Unable to get currency value from input. Please try again.");

            } while (!success);
            return outputNum;
        }

        private static double RoundPennies(double input)
        {
            double result = Math.Round(input / 0.05) * 0.05;
            return result;
        }

        private static void Normalize(double input)
        {
            double dollars = Math.Floor(input);
            double cents = input - dollars;
        }
    }
}
