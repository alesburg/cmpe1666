/* 
 * ICA #04 - Palindrome (CMPE1666)
 * 
 * Forms application that checks palindromes using recursion
 *
 * Author: Anna Lesburg
 * 
 * Modification History:
 * 27 JAN 2023 - Created
 * 30 JAN 2023 - Added recursive method and OpenFileDialog
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


namespace ICA05_Anna
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static bool IsPalindrome(string checkStr, int lowIndex, int highIndex)
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

        private void UI_TestVal_RadBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (UI_TestVal_RadBtn.Checked == true)
            {
                UI_TestVal_Tbx.Visible = true;
                UI_TestVal_Lbl.Visible = true;
                UI_TestValResult_Tbx.Visible = true;
                UI_TestResult_Lbl.Visible = true;

                UI_CountFile_Lbl.Visible = false;
                UI_CountFile_Tbx.Visible = false;
                UI_ExTime_Lbl.Visible = false;
                UI_ExTime_Tbx.Visible = false;
                UI_File_Lstbx.Visible = false;
                Ui_List_Lbl.Visible = false;
            }
            else
            {
                UI_CountFile_Lbl.Visible = true;
                UI_CountFile_Tbx.Visible = true;
                UI_ExTime_Lbl.Visible = true;
                UI_ExTime_Tbx.Visible = true;
                UI_File_Lstbx.Visible = true;
                Ui_List_Lbl.Visible = true;

                UI_TestVal_Tbx.Visible = false;
                UI_TestVal_Lbl.Visible = false;
                UI_TestValResult_Tbx.Visible = false;
                UI_TestResult_Lbl.Visible = false;
            }
        }

        private void UI_Find_Btn_Click(object sender, EventArgs e)
        {
            string fileName; //name of file chosen
            if (UI_TestVal_RadBtn.Checked)
            {
                if (UI_TestVal_Tbx.Text != "")
                {
                    if (IsPalindrome(UI_TestVal_Tbx.Text, 0, UI_TestVal_Tbx.Text.Length - 1)) UI_TestValResult_Tbx.Text = "true";
                    else UI_TestValResult_Tbx.Text = "false";
                }
            }
            else
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    fileName = openFileDialog.FileName;
                    CheckPaliFromFile(fileName);
                }
            }
        }
        
        private void CheckPaliFromFile(string fileName)
        {
            string[] lineArray; //array of strings from file
            int paliCount = 0; //total number of palindromes found
            System.Diagnostics.Stopwatch exTime = new System.Diagnostics.Stopwatch();
            exTime.Start();

            lineArray = File.ReadAllLines(fileName);

            foreach (string line in lineArray)
            {
                if (line != "" && IsPalindrome(line, 0, line.Length - 1))
                {
                    paliCount++;
                    UI_File_Lstbx.Items.Add(line);
                }
            }
            UI_CountFile_Tbx.Text = paliCount.ToString();
            UI_ExTime_Tbx.Text = $"{exTime.ElapsedMilliseconds.ToString()} ms";
        }
    }
}
