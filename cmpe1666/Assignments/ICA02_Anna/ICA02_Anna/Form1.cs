/* 
 * ICA #02 - Application Lifecycle (CMPE1666)
 * 
 * Forms application that demonstrates order of forms events in output diagnostics
 *
 * Author: Anna Lesburg
 * 
 * Modification History:
 * 17 JAN 2023 - Created
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

namespace ICA02_Anna
{
    public partial class Form1 : Form
    {
        //initializes the form
        public Form1()
        {
            InitializeComponent();
            System.Diagnostics.Trace.WriteLine("Construction event called");
        }

        //called once form is initialized
        private void Form1_Load(object sender, EventArgs e)
        {
            System.Diagnostics.Trace.WriteLine("Load event called");
        }

        //called when exit button is clicked
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Diagnostics.Trace.WriteLine("Closing event called");
        }

        //called after Closing event
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Diagnostics.Trace.WriteLine("Closed event called");
        }

        //called after Load event and when form is the active window
        private void Form1_Activated(object sender, EventArgs e)
        {
            System.Diagnostics.Trace.WriteLine("Activated event called");
        }

        //called after Closed event and when form is not active window
        private void Form1_Deactivate(object sender, EventArgs e)
        {
            System.Diagnostics.Trace.WriteLine("Deactivated event called");
        }
        
        //called after Load event
        private void Form1_Shown(object sender, EventArgs e)
        {
            System.Diagnostics.Trace.WriteLine("Shown event called");
        }

        //called after Shown event and after being minimized or size has been changed
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            System.Diagnostics.Trace.WriteLine("Paint event called");
        }
    }
}
