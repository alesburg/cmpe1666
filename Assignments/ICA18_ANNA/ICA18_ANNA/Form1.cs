/* 
 * ICA #18 - Linked Lists (CMPE1666)
 * 
 * Posting Messages to Listbox
 *
 * Author: Anna Lesburg
 * 
 * Modification History:
 * 13 APR 2023 - Created
 * 15 APR 2023 - Finished and tested
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ICA18_ANNA
{
    public partial class Form1 : Form
    {
        //customer info struct
        public struct CustomerAmount
        {
            public int id;
            public decimal amount;

            //constructor
            public CustomerAmount(int id, decimal amount)
            {
                this.id = id;
                this.amount = amount;
            }

            //tostring override
            public override string ToString()
            {
                return $"{id:D3} : {amount:C2}";
            }
        }

        LinkedList<CustomerAmount> linkedList; //linked list

        Random Random = new Random(); //random generator object

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //initialize
            linkedList = new LinkedList<CustomerAmount>();
        }

        //clear all
        private void UI_ClearAll_Btn_Click(object sender, EventArgs e)
        {
            UI_CustID_UpDown.Value = 1;
            UI_MinAmt_UpDown.Value = (decimal)0.00;
            UI_Sum_Lbl.Text = $"{0:C2}";
            UI_MinSum_Lbl.Text = $"{0:C2}";
            UI_Selected_Lstbx.Items.Clear();
            UI_CustLinfo_Lstbx.Items.Clear();
            linkedList.Clear();
        }

        private void UI_AddAmt_Btn_Click(object sender, EventArgs e)
        {
            //random customer
            CustomerAmount customer = new CustomerAmount((int)UI_CustID_UpDown.Value, (decimal)(Random.Next(0, 10000) + Random.NextDouble()));

            //add to listbox in order of creation
            UI_CustLinfo_Lstbx.Items.Add(customer);

            //add in ascending order of amount due to linked list
            AddToListSortedAsc(ref linkedList, linkedList.First, customer);
        }

        private void UI_Display_Btn_Click(object sender, EventArgs e)
        {
            //new linked list
            LinkedList<CustomerAmount> customerList = new LinkedList<CustomerAmount>();

            //add customers with specified id to new list in descending order
            foreach (CustomerAmount customer in linkedList)
            {
                if (customer.id == UI_CustID_UpDown.Value) AddToListSortedDesc(ref customerList, customerList.First, customer);
            }

            //show list in right listbox and sum
            UI_Selected_Lstbx.Items.Clear();
            foreach (CustomerAmount customer in customerList)
            {
                UI_Selected_Lstbx.Items.Add(customer.ToString());
            }
            UI_Sum_Lbl.Text = $"{SumAmount(customerList, customerList.First):C2}";
        }

        private void UI_DisplaySum_Btn_Click(object sender, EventArgs e)
        {
            //new linked list
            LinkedList<CustomerAmount> customerList = new LinkedList<CustomerAmount>();

            //add customers with specified minimum amount to new list in descending order
            foreach (CustomerAmount customer in linkedList)
            {
                if (customer.amount > UI_MinAmt_UpDown.Value) AddToListSortedDesc(ref customerList, customerList.First, customer);
            }

            //show list in right listbox and sum
            UI_Selected_Lstbx.Items.Clear();
            foreach (CustomerAmount customer in customerList)
            {
                UI_Selected_Lstbx.Items.Add(customer.ToString());
            }
            UI_MinSum_Lbl.Text = $"{SumAmount(customerList, customerList.First):C2}";
        }


        //********************************************************************************************
        //Method: private void AddToListSortedAsc(ref LinkedList<CustomerAmount> list, LinkedListNode<CustomerAmount> node, CustomerAmount customer)
        //Purpose: Recursively adds new customers to linked list in ascending order of amount
        //Parameters: ref LinkedList<CustomerAmount> list - list to add to
        // LinkedListNode<CustomerAmount> node - pointer node
        //CustomerAmount customer - customer to add
        //*********************************************************************************************
        private void AddToListSortedAsc(ref LinkedList<CustomerAmount> list, LinkedListNode<CustomerAmount> node, CustomerAmount customer)
        {
            if (node == null) list.AddLast(customer);
            else if (node.Value.amount > customer.amount) list.AddBefore(node, customer);
            else AddToListSortedAsc(ref list, node.Next, customer);
        }

        //********************************************************************************************
        //Method: private void AddToListSortedDesc(ref LinkedList<CustomerAmount> list, LinkedListNode<CustomerAmount> node, CustomerAmount customer)
        //Purpose: Recursively adds new customers to linked list in descending order of amount
        //Parameters: ref LinkedList<CustomerAmount> list - list to add to
        // LinkedListNode<CustomerAmount> node - pointer node
        //CustomerAmount customer - customer to add
        //*********************************************************************************************
        private void AddToListSortedDesc(ref LinkedList<CustomerAmount> list, LinkedListNode<CustomerAmount> node, CustomerAmount customer)
        {
            if (node == null) list.AddLast(customer);
            else if (node.Value.amount < customer.amount) list.AddBefore(node, customer);
            else AddToListSortedDesc(ref list, node.Next, customer);
        }

        //********************************************************************************************
        //Method: private decimal SumAmount(LinkedList<CustomerAmount> list, LinkedListNode<CustomerAmount> node)
        //Purpose: Recursively sums customer amounts in linked list
        //Parameters: LinkedList<CustomerAmount> list - list to sum
        //LinkedListNode<CustomerAmount> node - pointer node
        //Returns: decimal - sum of amounts
        //*********************************************************************************************
        private decimal SumAmount(LinkedList<CustomerAmount> list, LinkedListNode<CustomerAmount> node)
        {
            if (node != null)
            {
                return node.Value.amount + SumAmount(list, node.Next);
            }
            else return 0;
        }
    }
}
