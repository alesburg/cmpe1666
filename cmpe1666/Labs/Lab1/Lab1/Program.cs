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
        static CDrawer Display;
        static void Main(string[] args)
        {

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
                if (!success) Console.WriteLine("Bad Input");
                else return outputNum;
            } while (!success);
        }
    }
}
