﻿/////////////////////////////////////////////////////////////////////////////

/// ICA #01 - Linear Search (CMPE1666)

///  

/// 

///  Author: Anna Lesburg

///  

///  Modification History:

///  9 JAN 2023 - Created

/////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICA01_Anna
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }

        //********************************************************************************************
        //Method: private static void GetInt(out int value, string prompt, int min, int max)
        //Purpose: Inputs an integer value with error checking within a minimum and maximum value
        //Parameters: out int value - accepted int value
        //string prompt - prompt to ask user
        //int min - minimum value accepted
        //int max - maximum value accepted
        //*********************************************************************************************
        private static void GetInt(out int value, string prompt, int min, int max)
        {
            bool valid = false; //is value accepted?
            //loops until value is accepted
            do
            {
                Console.Write(prompt);
                valid = int.TryParse(Console.ReadLine(), out value);
                if (!valid)
                {
                    Console.WriteLine("An invalid number was entered. Please try again.");
                }
                else
                {
                    if (value < min || value > max)
                    {
                        Console.WriteLine("The value entered is outside the range accepted");
                        valid = false;
                    }
                }
            } while (!valid);
        }

        //********************************************************************************************
        //Method: private static void GetRange(out int min, out int max)
        //Purpose: Uses GetInt to obtain a range of values from the user
        //Parameters: out int min - accepted min value
        //out int max - accepted max value
        //*********************************************************************************************
        private static void GetRange(out int min, out int max)
        {
            GetInt(out min, "Enter the lower limit of the range of values to generate (0-100): ", 0, 100);
            GetInt(out max, "Enter the upper limit of the range of values to generate (0-100): ", 0, 100);
        }
    }
}


