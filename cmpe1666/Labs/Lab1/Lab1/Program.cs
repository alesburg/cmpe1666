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

        //********************************************************************************************
        //Method: private static void Normalize(double input)
        //Purpose: Normalizes input value into bills and coins, displays to GDIDrawer
        //Parameters: double input - value to normalize
        //*********************************************************************************************
        private static void Normalize(double input)
        {
            int dollars = (int)(Math.Floor(input)); //int value of dollars
            int cents = (int)((input - dollars) * 100); //int value of cents
            int numFifties; //number of fifties to display
            int numTwenties; //number of twenties to display
            int numTens; //number of tens to display
            int numFives; //number of fives to display
            int numToonies; //number of toonies to display
            int numLoonies; //number of loonies to display
            int numQuarters; //number of quarters to display
            int numDimes; //number of dimes to display
            int numNickels; //number of nickels to display
            int displayCount = 0; //counts elements that have been displayed

            //fifties
            numFifties = dollars / 50;
            dollars = dollars % 50;
            Console.WriteLine($"Fifty x {numFifties}");
            if (numFifties > 0)
            {
                RenderBill(50, numFifties, displayCount);
                displayCount++;
            }

            //twenties
            numTwenties = dollars / 20;
            dollars = dollars % 20;
            Console.WriteLine($"Twenty x {numTwenties}");
            if (numTwenties > 0)
            {
                RenderBill(20, numTwenties, displayCount);
                displayCount++;
            }

            //tens
            numTens = dollars / 10;
            dollars = dollars % 10;
            Console.WriteLine($"Ten x {numTens}");
            if (numTens > 0)
            {
                RenderBill(10, numTens, displayCount);
                displayCount++;
            }

            //fives
            numFives = dollars / 5;
            dollars = dollars % 5;
            Console.WriteLine($"Five x {numFives}");
            if (numFives > 0)
            {
                RenderBill(5, numFives, displayCount);
                displayCount++;
            }

            //toonies
            numToonies = dollars / 2;
            dollars = dollars % 2;
            Console.WriteLine($"Toonie x {numToonies}");
            if (numToonies > 0)
            {
                RenderCoin(2, numToonies, displayCount);
                displayCount++;
            }

            //loonies
            numLoonies = dollars;
            Console.WriteLine($"Loonie x {numLoonies}");
            if (numLoonies > 0)
            {
                RenderCoin(1, numLoonies, displayCount);
                displayCount++;
            }

            //quarters
            numQuarters = cents / 25;
            cents = cents % 25;
            Console.WriteLine($"Quarter x {numQuarters}");
            if (numQuarters > 0)
            {
                RenderCoin(0.25, numQuarters, displayCount);
                displayCount++;
            }

            //dimes
            numDimes = cents / 10;
            cents = cents % 10;
            Console.WriteLine($"Dime x {numDimes}");
            if (numDimes > 0)
            {
                RenderCoin(0.10, numDimes, displayCount);
                displayCount++;
            }

            //nickels
            numNickels = cents / 5;
            Console.WriteLine($"Nickel x {numNickels}");
            if (numNickels > 0)
            {
                RenderCoin(0.10, numNickels, displayCount);
                displayCount++;
            }
        }

        private static void RenderBill(double value, int quantity, int count)
        {
            System.Drawing.Color color = Color.Gray; //determines color of bill

            //determines color of bill
            switch (value)
            {
                case 50:
                    color = Color.LightCoral;
                    break;
                case 20:
                    color = Color.PaleGreen;
                    break;
                case 10:
                    color = Color.Lavender;
                    break;
                case 5:
                    color = Color.LightBlue;
                    break;
            }

            Display.AddCenteredRectangle(Display.m_ciWidth / 4, 150 + count * 95, 200, 85, color, 3, Color.DarkGray);
            Display.AddText($"{value:C2} x {quantity}", 12, Display.m_ciWidth / 6, 125 + count * 95, 100, 50, Color.Black);
        }

        private static void RenderCoin(double value, int quantity, int count)
        {

            System.Drawing.Color color = Color.Gray; //determines color of coin

            //determines color of coin
            switch (value)
            {
                case 2:
                    color = Color.PaleGoldenrod;
                    break;
                case 1:
                    color = Color.Gold;
                    break;
                default:
                    color = Color.LightGray;
                    break;
            }
            if (quantity < 4)
            {
                Display.AddCenteredEllipse(Display.m_ciWidth / 4, 150 + count * 95, 85, 85, color, 3, Color.DarkGray);
                Display.AddText($"{value:C2} x {quantity}", 12, Display.m_ciWidth / 6 + 15, 125 + count * 95, 100, 50, Color.Black);
            }
        }
    }
}
