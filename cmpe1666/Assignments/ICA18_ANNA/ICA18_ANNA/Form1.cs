/* 
 * ICA #18 - Linked Lists (CMPE1666)
 * 
 * Posting Messages to Listbox
 *
 * Author: Anna Lesburg
 * 
 * Modification History:
 * 13 APR 2023 - Created
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
            LinkedListNode<CustomerAmount> temp = linkedList.First;
            if (temp != null || temp.Value.amount > customer.amount)
            {
                while (temp.Value.amount < customer.amount)
                {
                    temp = temp.Next;
                }
                linkedList.AddAfter(temp, customer);
            }else linkedList.AddFirst(customer);
            
        }
    }
}
