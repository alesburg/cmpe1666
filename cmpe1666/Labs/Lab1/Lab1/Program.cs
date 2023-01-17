/* 
 * Lab #01 - Review Exercise (CMPE1666)
 * 
 * 
 *
 * Author: Anna Lesburg
 * 
 * Modification History:
 * 11 JAN 2023: Created
 * 16 JAN 2023: Added methods
 * 17 JAN 2023: Added more methods
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using GDIDrawer;
using System.Linq.Expressions;

namespace Lab1
{
    internal class Program
    {
        public static CDrawer Display = new CDrawer();
        static void Main(string[] args)
        {
            double input; //user input value
            double roundedInput; //input rounded to nearest 0.05
            do
            {
                input = ParseInput("How much money do you wish to convert?: ");
                roundedInput = RoundPennies(input);

                Console.WriteLine($"User entry of {input:C2} interpreted and rounded to {roundedInput:C2}");
                Display.AddText($"{roundedInput:C2}", 24, Display.m_ciWidth / 2 - 100, 50, 200, 50, Color.Yellow);

                Normalize(roundedInput);
                Console.ReadKey();
            } while (false);
        }

        //********************************************************************************************
        //Method: private static double ParseInput(string prompt)
        //Purpose: Prompts user for string and parses out a double value to 2 decimal places
        //Parameters: string prompt - prompt to ask user
        //Returns: double
        //*********************************************************************************************
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

        //********************************************************************************************
        //Method: private static double RoundPennies(double input)
        //Purpose: Rounds a double value to nearest nickel
        //Parameters: double input - value to round
        //Returns: double
        //*********************************************************************************************
        private static double RoundPennies(double input)
        {
            double result = Math.Round(input / 0.05) * 0.05;
            return result;
        }

        private static void Normalize(double input)
        {
            int dollars = (int)(Math.Floor(input));
            int cents = (int)((input - dollars) * 100);
            int numFifties;
            int numTwenties;
            int numTens;
            int numFives;
            int numToonies;
            int numLoonies;
            int numQuarters;
            int numDimes;
            int numNickels;

            //fifties
            numFifties = dollars / 50;
            dollars = dollars % 50;
            Console.WriteLine($"Fifty x {numFifties}");

            //twenties
            numTwenties = dollars / 20;
            dollars = dollars % 20;
            Console.WriteLine($"Twenty x {numTwenties}");

            //tens
            numTens = dollars / 10;
            dollars = dollars % 10;
            Console.WriteLine($"Ten x {numTens}");

            //fives
            numFives = dollars / 5;
            dollars = dollars % 5;
            Console.WriteLine($"Five x {numFives}");

            //toonies
            numToonies = dollars / 2;
            dollars = dollars % 2;
            Console.WriteLine($"Toonie x {numToonies}");

            //loonies
            numLoonies = dollars;
            Console.WriteLine($"Loonie x {numLoonies}");

            //quarters
            numQuarters = cents / 25;
            cents = cents % 25;
            Console.WriteLine($"Quarter x {numQuarters}");

            //dimes
            numDimes = cents / 10;
            cents = cents % 10;
            Console.WriteLine($"Dime x {numDimes}");

            //nickels
            numNickels = cents / 5;
            Console.WriteLine($"Nickel x {numNickels}");
        }
    }
}
