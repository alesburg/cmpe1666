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

        Random Random = new Random(); //random generator object

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
