/* 
 * ICA #14 - Palidnrome Hunter! (CMPE1666)
 * 
 * Forms application that uses threading to find palindromes
 *
 * Author: Anna Lesburg
 * 
 * Modification History:
 * 25 MAR 2023 - Created
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ICA14_ANNA
{
    public partial class Form1 : Form
    {
        public List<string> lines; //list of strings from file

        public Form1()
        {
            InitializeComponent();
        }

        //********************************************************************************************
        //Method: private bool IsPalindrome(string checkStr, int lowIndex, int highIndex)
        //Purpose: Checks if string is palindrome using recursion
        //Parameters: string checkStr - string to check
        //int lowIndex - low index of string to check
        //int highIndex - high index of string to check
        //Returns: bool (true if palindrome)
        //*********************************************************************************************
        private bool IsPalindrome(string checkStr, int lowIndex, int highIndex)
        {
            //base cases
            if (checkStr.Length <= 1) return true;
            if (checkStr[lowIndex] != checkStr[highIndex]) return false;
            else if (highIndex <= lowIndex) return true;

            //recursion
            else
            {
                return IsPalindrome(checkStr, lowIndex + 1, highIndex - 1);
            }
        }

        //simple test button
        private void UI_Test_Btn_Click(object sender, EventArgs e)
        {
            if (IsPalindrome(UI_Test_Tbx.Text, 0, UI_Test_Tbx.Text.Length-1))
            {
                UI_Test_Tbx.Text = $"'{UI_Test_Tbx.Text}' is a palindrome!";
            }
            else
            {
                UI_Test_Tbx.Text = $"'{UI_Test_Tbx.Text}' is not a palindrome!";
            }
        }

        private void UI_Load_Btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                lines = new List<string>(File.ReadAllLines(openFileDialog.FileName));
                UI_Result_Tbx.Text = $"Loaded {lines.Count} words!";
            }

        }
    }
}
