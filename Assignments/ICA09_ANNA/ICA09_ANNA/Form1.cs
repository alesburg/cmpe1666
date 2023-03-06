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
using System.Linq;
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
                return $"{empID}:   {empSalary}";
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
            int[] givenSalaries = { 4500, 2800, 1900, 3100, 7000, 3500, 2200, 2800, 2850, 3150, 400, 4500, 600, 7200, 3700, 2100, 2450, 2500, 3250, 3700, 3800, 4200, 4100, 3900 };
            for (int i = 0; i < givenIDs.Length; i++)
            {
                givenEmployees.Add(new Employees(givenIDs[i], givenSalaries[i]).ToString);
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
            }
        }
    }
}
