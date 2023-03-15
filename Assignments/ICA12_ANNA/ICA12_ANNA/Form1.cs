/* 
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
        //Purpose: returns lowercase string
        //Parameters: string input - string to edit
        //Returns: string - edited string
        //********************************************************************************************
        private string Uppercase(string input)
        {
            return input.ToUpper();
        }

        private string Lowercase(string input)
        {
            return input.ToLower();
        }

        private string Flipcase(string input)
        {
            string output = "";
            foreach (char c in input)
            {
                if (char.IsLetter(c))
                {
                    if (char.IsUpper(c)) output += c.ToString().ToUpper();
                    else if (char.IsLower(c)) output += c.ToString().ToLower();
                }
            }
            return output;
        }
    }
}

