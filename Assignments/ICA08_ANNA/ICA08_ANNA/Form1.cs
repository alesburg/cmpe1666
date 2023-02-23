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
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICA08_ANNA
{   
    public partial class Form1 : Form
    {
        List<int> generatedInts;
        List<int> sortedInts;
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

                    UI_Sort_Btn.Enabled = true;
                }
            }else MessageBox.Show("Please enter valid integers number of, minimum, and maximum values.");
        }

        private void UI_Sort_Btn_Click(object sender, EventArgs e)
        {
            stopwatch.Start();
            sortedInts = new List<int>(generatedInts);

            if (UI_Bubble_Radbtn.Checked) BubbleSort(ref sortedInts);
            else if (UI_Selection_Radbtn.Checked) SelectionSort(ref sortedInts);
            else if (UI_Insertion_Radbtn.Checked) InsertionSort(ref sortedInts);
            else if (UI_Quick_Radbtn.Checked) ;


            UI_Sorted_Tbx.Text = String.Empty;

            foreach (int i in sortedInts)
            {
                UI_Sorted_Tbx.Text += $"{i.ToString()} ";
            }
            stopwatch.Stop();
            UI_Time_Tbx.Text = stopwatch.Elapsed.TotalMilliseconds.ToString();

        }

        private void Swap(ref List<int> list,int posA, int posB)
        {
            int temp = list[posA];
            list[posA] = list[posB];
            list[posB] = temp;
        }

        private void BubbleSort(ref List<int> list)
        {
            int n = list.Count();
            bool swapped = false;

            for (int i = 0; i < n; i++)
            {
                for(int j = 0; j < (n-(i+1)); j++)
                {
                    if (list[j] > list[j + 1])
                    {
                        Swap(ref list,j,j+1);
                        swapped = true;
                    }
                    if (!swapped) return;
                }
            }
        }

        private void SelectionSort(ref List<int> list)
        {
            int n = list.Count();
            int maxPos;
            int lastPos;

            for (int pass = 0; pass < n - 1; pass++)
            {
                maxPos = 0;
                lastPos = n - 1 - pass;
                for(int j = 0; j < n - pass; j++)
                {
                    if (list[j] > list[maxPos])
                    {
                        maxPos = j;
                    }
                    Swap(ref list, maxPos,lastPos);
                }
            }
        }

        private void InsertionSort(ref List<int> list)
        {
            int n = list.Count();
            int temp;
            for (int pass = 1; pass < n; pass++)
            {
                temp = list[pass];
                int j = pass - 1;
                while((j>=0) && (list[j] > temp))
                {
                    list[j+1] = list[j];
                    j = j - 1;
                }
                list[j + 1] = temp;
            }
        }
    }
}
