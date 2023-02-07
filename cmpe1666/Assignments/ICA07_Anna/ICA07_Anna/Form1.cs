/* 
 * ICA #07 - Binary Search (CMPE1666)
 * 
 * Forms application utilizing lists and binary search alogorithm
 *
 * Author: Anna Lesburg
 * 
 * Modification History:
 * 07 FEB 2023 - Created, debugged and tested
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

namespace ICA07_Anna
{
    public partial class Form1 : Form
    {
        static List<string> list = new List<string>(); //list object
        public Form1()
        {
            InitializeComponent();
        }

        private void UI_AddName_Button_Click(object sender, EventArgs e)
        {
            //adds textbox contents to list and displays in left box
            if (UI_Name_Tbx.Text != "")
            {
                list.Add(UI_Name_Tbx.Text);
                UI_Unsorted_Listbx.Items.Add(UI_Name_Tbx.Text);
                UI_Name_Tbx.Text= null;
            }

            //sorts list and displays in right box
            list.Sort();
            UI_Sorted_LstBx.Items.Clear();
            foreach(string i in list)
            {
                UI_Sorted_LstBx.Items.Add(i);
            }
        }

        private void UI_Search_Button_Click(object sender, EventArgs e)
        {
            int index; //index of searched string
            if (UI_Name_Tbx.Text != "") 
            {
                index = BinarySearch(UI_Name_Tbx.Text, 0, UI_Sorted_LstBx.Items.Count);
                if(index > -1)
                {
                    MessageBox.Show($"{UI_Name_Tbx.Text} found at index {index}");
                    UI_Name_Tbx.Text = null;
                }
                else
                {
                    MessageBox.Show($"{UI_Name_Tbx.Text} not found");
                    UI_Name_Tbx.Text = null;
                }
                
            }
        }

        //********************************************************************************************
        //Method: private int BinarySearch(string query, List<string> list)
        //Purpose: Recursive Binary search for list object containing strings
        //Parameters: string query - string to search for
        //int low - low index of binary search
        //int high - high index of binary search
        //Returns: int - index of query in list, -1 if not present
        //*********************************************************************************************
        private int BinarySearch(string query, int low, int high)
        {
            int mid = (low + high) / 2; //calculate midpoint

            //base cases
            if (low > high) return -1;
            else if (list[mid] == query) return mid;

            //recursive cases
            else if (query.CompareTo(list[mid]) < 0) return BinarySearch(query, low, mid - 1);
            else return BinarySearch(query, mid + 1, high);
        }

    }
}
