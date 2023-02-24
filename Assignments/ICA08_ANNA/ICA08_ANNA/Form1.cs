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
        List<int> generatedInts; //generated list
        List<int> sortedInts; //sorted list
        Stopwatch stopwatch; //timer for sort time
        public Form1()
        {
            InitializeComponent();
            generatedInts = new List<int>();
            stopwatch = new Stopwatch();
        }

        //Generate button clicked
        private void UI_Genval_Btn_Click(object sender, EventArgs e)
        {
            generatedInts.Clear();
            Random random = new Random(); //random generator
            int numVals; //number of values to generate
            int minVal; //minimum value of generated ints
            int maxVal; //maximum value of generated ints

            if (int.TryParse(UI_Numval_Tbx.Text, out numVals) && int.TryParse(UI_Minval_Tbx.Text, out minVal) && int.TryParse(UI_Maxval_Tbx.Text, out maxVal))
            {
                //error checking for inputs
                if (numVals < 10) MessageBox.Show("Must generate at least 10 values.");
                else if (minVal >= maxVal) MessageBox.Show("Minimum value must be smaller than maximum value.");
                else
                {
                    //adds generated ints to list
                    for (int i = 0; i < numVals; i++)
                    {
                        generatedInts.Add(random.Next(minVal, maxVal + 1));
                    }

                    //displays list to textbox
                    UI_Unsorted_Tbx.Text = String.Empty;
                    foreach (int i in generatedInts)
                    {
                        UI_Unsorted_Tbx.Text += $"{i.ToString()} ";
                    }

                    //enable sort button
                    UI_Sort_Btn.Enabled = true;
                }
            }
            else MessageBox.Show("Please enter valid integers for number of, minimum, and maximum values.");
        }

        //Sort button clicks
        private void UI_Sort_Btn_Click(object sender, EventArgs e)
        {
            stopwatch.Reset();
            stopwatch.Start();
            sortedInts = new List<int>(generatedInts);

            //radio selection
            if (UI_Bubble_Radbtn.Checked) BubbleSort(ref sortedInts);
            else if (UI_Selection_Radbtn.Checked) SelectionSort(ref sortedInts);
            else if (UI_Insertion_Radbtn.Checked) InsertionSort(ref sortedInts);
            else if (UI_Quick_Radbtn.Checked) QuickSort(ref sortedInts, 0, sortedInts.Count - 1);

            //display sorted list to textbox
            UI_Sorted_Tbx.Text = String.Empty;
            foreach (int i in sortedInts)
            {
                UI_Sorted_Tbx.Text += $"{i.ToString()} ";
            }

            //show stopwatch ticks
            stopwatch.Stop();
            UI_Time_Tbx.Text = stopwatch.ElapsedTicks.ToString();
        }

        //********************************************************************************************
        //Method: private void Swap(ref List<int> list, int posA, int posB)
        //Purpose: Swaps two int values in a list
        //Parameters: ref List<int> list - list to preform swap
        //int posA - first index to swap
        //int posB - second index to swap
        //*********************************************************************************************
        private void Swap(ref List<int> list, int posA, int posB)
        {
            int temp = list[posA]; 
            list[posA] = list[posB];
            list[posB] = temp;
        }

        //********************************************************************************************
        //Method: private void BubbleSort(ref List<int> list)
        //Purpose: Sorts a list of ints using bubble sort
        //Parameters: ref List<int> list - list to preform sort
        //*********************************************************************************************
        private void BubbleSort(ref List<int> list)
        {
            int n = list.Count(); //list length

            //outer loop
            for (int i = 0; i < n; i++)
            {
                //inner loop
                for (int j = 0; j < (n - (i + 1)); j++)
                {
                    if (list[j] > list[j + 1])
                    {
                        Swap(ref list, j, j + 1);
                    }
                }
            }
        }

        //********************************************************************************************
        //Method: private void SelectionSort(ref List<int> list)
        //Purpose: Sorts a list of ints using selection sort
        //Parameters: ref List<int> list - list to preform sort
        //*********************************************************************************************

        private void SelectionSort(ref List<int> list)
        {
            int n = list.Count(); //list length
            int maxPos; //index of maximum value
            int lastPos; //index of last value in list

            //outer loop (passes)
            for (int pass = 0; pass < n - 1; pass++)
            {
                maxPos = 0;
                lastPos = n - 1 - pass;
                //inner loop
                for (int j = 0; j < n - pass; j++)
                {
                    if (list[j] > list[maxPos])
                    {
                        maxPos = j;
                    }
                }
                Swap(ref list, maxPos, lastPos);
            }
        }

        //********************************************************************************************
        //Method: private void InsertionSort(ref List<int> list)
        //Purpose: Sorts a list of ints using insertion sort
        //Parameters: ref List<int> list - list to preform sort
        //*********************************************************************************************
        private void InsertionSort(ref List<int> list)
        {
            int n = list.Count(); //list length
            int temp; //temp storage

            //outer loop (passes)
            for (int pass = 1; pass < n; pass++)
            {
                temp = list[pass];
                int j = pass - 1;
                //shift values
                while ((j >= 0) && (list[j] > temp))
                {
                    list[j + 1] = list[j];
                    j = j - 1;
                }
                //insertion
                list[j + 1] = temp;
            }
        }

        //********************************************************************************************
        //Method: private void QuickSort(ref List<int> list, int low, int high)
        //Purpose: Sorts a list of ints using quick sort
        //Parameters: ref List<int> list - list to preform sort
        //int low - low index of sort region
        //int high - high index of sort region
        //*********************************************************************************************
        private void QuickSort(ref List<int> list, int low, int high)
        {
            int partIndex; //partition index
            if (low < high)
            {
                partIndex = Partition(ref list, low, high);

                //recursion
                QuickSort(ref list, low, partIndex - 1);
                QuickSort(ref list, partIndex + 1, high);
            }
        }

        //********************************************************************************************
        //Method: private int Partition(ref List<int> list, int low, int high)
        //Purpose: selects last index as pivot and relocates to correct position
        //Parameters: ref List<int> list - list to preform sort
        //int low - low index of sort region
        //int high - high index of sort region
        //Returns: int - 
        //*********************************************************************************************
        private int Partition(ref List<int> list, int low, int high)
        {
            int pivot = list[high];
            int i = low - 1;

            for (int j = low; j <= high - 1; j++)
            {
                if (list[j] < pivot)
                {
                    i++;
                    Swap(ref list, i, j);
                }
            }
            Swap(ref list, i + 1, high);
            return (i + 1);
        }

        //clears sorted textbox
        private void UI_Clearsort_Btn_Click(object sender, EventArgs e)
        {
            UI_Sorted_Tbx.Text = String.Empty;
        }

        //clears unsorted textbox
        private void UI_Clearraw_Btn_Click(object sender, EventArgs e)
        {
            UI_Unsorted_Tbx.Text = String.Empty;
        }

        //writes unsorted list to textbox
        private void UI_Redisplay_Btn_Click(object sender, EventArgs e)
        {
            UI_Unsorted_Tbx.Text = string.Empty;
            foreach (int i in generatedInts)
            {
                UI_Unsorted_Tbx.Text += $"{i.ToString()} ";
            }
        }
    }
}
