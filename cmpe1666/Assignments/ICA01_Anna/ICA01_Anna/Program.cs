/////////////////////////////////////////////////////////////////////////////

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
            int arraySize; //size of array to generate
            int valueMin; //minimum value of ints in array
            int valueMax; //maximum value of ints in array
            int[] array; //int array to generate
            int searchValue; //int value to search for in array
            int occurrences; //occurrences of searchValue in array
            string input; //user input for repeating search
            bool valid; //is user input valid
            bool repeat = false; //repeat search prompt?

            Console.WriteLine("\t\t CMPE 1666 - ICA1 Winter 2022 - Anna Lesburg\n");

            GetInt(out arraySize, "Input the size of the array to generate (10-100): ", 10, 100);

            GetRange(out valueMin, out valueMax);

            array = GenerateArray(arraySize, valueMin, valueMax);

            DisplayArray(array);
            //loops as long as user inputs Y
            do {
                GetInt(out searchValue, $"\n\nEnter value to be searched ({valueMin}-{valueMax}): ", valueMin, valueMax);

                occurrences = CountOccurrences(array, searchValue);

                if (occurrences < 1) Console.WriteLine("\n{0} not found in array", searchValue);
                else Console.WriteLine("\nNumber of occurrences of {0} is {1}", searchValue, occurrences);

                do
                {
                    Console.Write("\nDo you want to search for another value? (Y/N, y/n): ");
                    input = Console.ReadLine().ToLower();
                    switch (input)
                    {
                        case "y":
                            repeat = true;
                            valid = true;
                            break;
                        case "n":
                            repeat = false;
                            valid = true;
                            break;
                        default:
                            valid = false;
                            break;
                    }
                } while (!valid);
            } while (repeat);

            Console.ReadLine();
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
            //gets minimum
            GetInt(out min, "\nEnter the lower limit of the range of values to generate (0-100): ", 0, 100);
            //gets maximum
            GetInt(out max, "\nEnter the upper limit of the range of values to generate (0-100): ", 0, 100);
        }

        //********************************************************************************************
        //Method: private static int[] GenerateArray(int numValues, int min, int max)
        //Purpose: Fills an array of specified size with random values within a specified range
        //Parameters: int numValues - array size
        //int min - lower bound of generated ints
        //int max - upped bound of generated ints
        //*********************************************************************************************
        private static int[] GenerateArray(int numValues, int min, int max)
        {
            Random random = new Random(); //random number generator
            int[] array = new int[numValues]; //generated array

            //fills array with random ints
            for(int i = 0; i < array.Length; i++)
            array[i] = random.Next(min, max + 1);
            return array;
        }

        //********************************************************************************************
        //Method: private static void DisplayArray(int[] array)
        //Purpose: Displays array to console
        //Parameters: int[] array - array to display
        //*********************************************************************************************
        private static void DisplayArray(int[] array)
        {
            Console.Write("\nThe generated values are: ");

            //writes each iteration in array
            foreach(int i in array) Console.Write("{0}, ",i);
        }

        //********************************************************************************************
        //Method: private static int CountOccurrences(int[] array, int value)
        //Purpose: Counts instances of value in array
        //Parameters: int[] array - array to search
        //int value - value to search
        //*********************************************************************************************
        private static int CountOccurrences(int[] array, int value)
        {
            int counter = 0; //counts instances of value in array

            //checks if each iteration in array is equal to value and updates counter
            foreach(int i in array)
            {
                if (i == value) counter++;
            }

            return counter;
        }
    }
}


