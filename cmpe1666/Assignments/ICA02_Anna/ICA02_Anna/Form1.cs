﻿/* 
 * ICA #02 - Application Lifecycle (CMPE1666)
 * 
 * Forms application that demonstrates order of forms events
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
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            System.Diagnostics.Trace.WriteLine("Load event called");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Diagnostics.Trace.WriteLine("Closing event called");
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Diagnostics.Trace.WriteLine("Closed event called");
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            System.Diagnostics.Trace.WriteLine("Activated event called");
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            System.Diagnostics.Trace.WriteLine("Deactivated event called");
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            System.Diagnostics.Trace.WriteLine("Shown event called");
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            System.Diagnostics.Trace.WriteLine("Paint event called");
        }
    }
}
