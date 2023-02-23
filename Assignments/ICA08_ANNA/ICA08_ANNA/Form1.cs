/* 
 * ICA #08 - Sorting Methods (CMPE1666)
 * 
 * Forms application to demonstrate sorting methods
 *
 * Author: Anna Lesburg
 * 
 * Modification History:
 * 23 FEB 2023 - Created
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

namespace ICA08_ANNA
{   
    public partial class Form1 : Form
    {
        List<int> generatedInts;
        Stopwatch stopwatch;
        public Form1()
        {
            InitializeComponent();
            generatedInts = new List<int>();
            stopwatch = new Stopwatch();

        }

        private void UI_Genval_Btn_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int numVals;
            int minVal;
            int maxVal;

            if (int.TryParse(UI_Numval_Tbx.Text, out numVals) && int.TryParse(UI_Minval_Tbx.Text, out minVal) && int.TryParse(UI_Maxval_Tbx.Text, out maxVal))
            {
                if (numVals < 10) MessageBox.Show("Must generate at least 10 values.");
                else if (minVal >= maxVal) MessageBox.Show("Minimum value must be smaller than maximum value.");
                else
                {
                    for(int i = 0; i < numVals; i++)
                    {
                        generatedInts.Add(random.Next(minVal,maxVal + 1));
                    }

                    UI_Unsorted_Tbx.Text = String.Empty;

                    foreach(int i in generatedInts)
                    {
                        UI_Unsorted_Tbx.Text += $"{i.ToString()} ";
                    }
                }
            }else MessageBox.Show("Please enter valid integers number of, minimum, and maximum values.");
        }
    }
}
