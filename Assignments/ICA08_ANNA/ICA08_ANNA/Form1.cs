﻿/* 
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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICA08_ANNA
{   
    public partial class Form1 : Form
    {
        List<int> generatedInts;
        Stopwatch stopwatch;
        public Form1()
        {
            InitializeComponent();
            generatedInts = new List<int>();
            stopwatch = new Stopwatch();

        }

        private void UI_Genval_Btn_Click(object sender, EventArgs e)
        {

        }
    }
}
