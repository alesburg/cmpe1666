/* 
 * ICA #09 - Sorting Structs (CMPE1666)
 * 
 * Forms application thaat creates and sorts lists of structs
 *
 * Author: Anna Lesburg
 * 
 * Modification History:
 * 3 MAR 2023 - Created
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICA09_ANNA
{
    public partial class Form1 : Form
    {
        public struct Employees
        {
            public int empID;
            public int empSalary; 

            //constructor
            public Employees(int empID, int empSalary)
            {
                this.empID = empID;
                this.empSalary = empSalary;

            }
            public override string ToString()
            {
                if (empID < 10) return $"{empID}:             {empSalary}";
                if(empID < 100) return $"{empID}:           {empSalary}";
                if(empID < 1000) return $"{empID}:         {empSalary}";
                else return $"{empID}:       {empSalary}";
            }
        };
        List<Employees> fileEmployees;
        List<Employees> givenEmployees;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fileEmployees = new List<Employees>();
            givenEmployees = new List<Employees>();
            int[] givenIDs = { 28, 53, 12, 18, 8, 2, 19, 57, 62, 34, 23, 14, 48, 35, 55, 22, 26, 15, 7, 9, 32, 43, 41, 51 };
            int[] givenSalaries = { 4500, 2800, 1900, 3100, 7000, 3500, 2200, 2800, 2850, 3150, 4000, 4500, 6000, 7200, 3700, 2100, 2450, 2500, 3250, 3700, 3800, 4200, 4100, 3900 };

            for (int i = 0; i < givenIDs.Length; i++)
            {
                givenEmployees.Add(new Employees(givenIDs[i], givenSalaries[i]));
            }

        }

        private void UI_DisplayUnsorted_Btn_Click(object sender, EventArgs e)
        {
            UI_Unsorted_Lstbx.Items.Clear();

            if (UI_ProvList_Radbtn.Checked)
            {
                for(int i = 0; i < givenEmployees.Count; i++)
                {
                    UI_Unsorted_Lstbx.Items.Add(givenEmployees[i]);

                }
            } else
            {
                for (int i = 0; i < fileEmployees.Count; i++)
                {
                    UI_Unsorted_Lstbx.Items.Add(fileEmployees[i]);
                }
            }
        }

        private void UI_ClearUnsorted_Btn_Click(object sender, EventArgs e)
        {
            UI_Unsorted_Lstbx.Items.Clear();
        }

        private void UI_ClearSorted_Btn_Click(object sender, EventArgs e)
        {
            UI_Sorted_Lstbox.Items.Clear();
        }

        private void UI_LoadFiles_Btn_Click(object sender, EventArgs e)
        {
            string idsFile;
            string salariesFile;
            string[] temp;
            int[] fileIDs = {1};
            int[] fileSalaries = {1};
            try
            {
                OpenFileDialog OpenIDs = new OpenFileDialog();
                OpenIDs.Title = "Select Employee IDs: ";
                if (OpenIDs.ShowDialog() == DialogResult.OK)
                {
                    idsFile = OpenIDs.FileName;
                    temp = File.ReadAllLines(idsFile);
                    fileIDs = new int[temp.Length];
                    for (int i = 0; i < temp.Length; i++)
                    {
                        int.TryParse(temp[i], out fileIDs[i]);
                    }
                }

                OpenFileDialog OpenSalaries = new OpenFileDialog();
                OpenSalaries.Title = "Select Employee Salaries: ";
                if (OpenSalaries.ShowDialog() == DialogResult.OK)
                {
                    salariesFile = OpenSalaries.FileName;
                    temp = File.ReadAllLines(salariesFile);
                    fileSalaries = new int[temp.Length];
                    for (int i = 0; i < temp.Length; i++)
                    {
                        int.TryParse(temp[i], out fileSalaries[i]);
                    }
                }

                for (int i = 0; i < fileIDs.Length; i++)
                {
                    fileEmployees.Add(new Employees(fileIDs[i], fileSalaries[i]));
                }

                
            } catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.ToString()}");
            }
        }

        //********************************************************************************************
        //Method: private void Swap(ref List<int> list, int posA, int posB)
        //Purpose: Swaps two int values(with enums) in a list
        //Parameters: ref List<int> list - list to preform swap
        //int posA - first index to swap
        //int posB - second index to swap
        //*********************************************************************************************
        private void Swap(ref List<Employees> list, int posA, int posB)
        {
            Employees temp = list[posA];
            list[posA] = list[posB];
            list[posB] = temp;
        }

        //********************************************************************************************
        //Method: private void BubbleSort(ref List<int> list)
        //Purpose: Sorts a list of ints (with enums) using bubble sort
        //Parameters: ref List<int> list - list to preform sort
        //*********************************************************************************************
        private void BubbleSort(ref List<Employees> list)
        {
            int n = list.Count(); //list length

            //outer loop
            for (int i = 0; i < n; i++)
            {
                //inner loop
                for (int j = 0; j < (n - (i + 1)); j++)
                {
                    if (list[j].empID > list[j + 1].empID)
                    {
                        Swap(ref list, j, j + 1);
                    }
                }
            }
        }

        //********************************************************************************************
        //Method: private void QuickSort(ref List<int> list, int low, int high)
        //Purpose: Sorts a list of ints using quick sort
        //Parameters: ref List<int> list - list to preform sort
        //int low - low index of sort region
        //int high - high index of sort region
        //*********************************************************************************************
        private void QuickSort(ref List<Employees> list, int low, int high)
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
        //Method: private int Partition(ref List<Employees> list, int low, int high)
        //Purpose: selects last index as pivot and relocates to correct position
        //Parameters: ref List<Employees> list - list to preform sort
        //int low - low index of sort region
        //int high - high index of sort region
        //Returns: int - partition index
        //*********************************************************************************************
        private int Partition(ref List<Employees> list, int low, int high)
        {
            int pivot = list[high].empID;
            int i = low - 1;

            for (int j = low; j <= high - 1; j++)
            {
                if (list[j].empID < pivot)
                {
                    i++;
                    Swap(ref list, i, j);
                }
            }
            Swap(ref list, i + 1, high);
            return (i + 1);
        }

        private void UI_N2Sorting_Btn_Click(object sender, EventArgs e)
        {
            if(UI_ProvList_Radbtn.Checked)
            {
                BubbleSort(ref givenEmployees);
                for(int i = 0; i < givenEmployees.Count; i++)
                {
                    UI_Sorted_Lstbox.Items.Add(givenEmployees[i]);
                }
            }else
            {
                BubbleSort(ref fileEmployees);
                for (int i = 0; i < fileEmployees.Count; i++)
                {
                    UI_Sorted_Lstbox.Items.Add(fileEmployees[i]);
                }
            }
        }
    }
}
