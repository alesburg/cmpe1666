﻿/* 
 * ICA #12 - StringBender (CMPE1666)
 * 
 * Forms application that modifies given string using delegates
 *
 * Author: Anna Lesburg
 * 
 * Modification History:
 * 15 MAR 2023 - Created
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICA12_ANNA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        //*******************************************************************************************
        //Method: private string Uppercase(string input)
        //Purpose: returns uppercase string
        //Parameters: string input - string to edit
        //Returns: string - edited string
        //********************************************************************************************
        private string Uppercase(string input)
        {
            return input.ToUpper();
        }

        //*******************************************************************************************
        //Method: private string Lowercase(string input)
        //Purpose: returns lowercase string
        //Parameters: string input - string to edit
        //Returns: string - edited string
        //********************************************************************************************
        private string Lowercase(string input)
        {
            return input.ToLower();
        }

        //*******************************************************************************************
        //Method: private string Flipcase(string input)
        //Purpose: returns string with flipped cases
        //Parameters: string input - string to edit
        //Returns: string - edited string
        //********************************************************************************************
        private string Flipcase(string input)
        {
            string output = ""; //start of output string

            //iterates over string and flips cases, adds to output
            foreach (char c in input)
            {
                if (char.IsLetter(c))
                {
                    if (char.IsUpper(c)) output += c.ToString().ToLower();
                    else if (char.IsLower(c)) output += c.ToString().ToUpper();
                }
            }
            return output;
        }
    }
}

