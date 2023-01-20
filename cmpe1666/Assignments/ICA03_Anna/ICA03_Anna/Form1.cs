/* 
 * ICA #03 - Kind-of-sort-of-Timing (CMPE1666)
 * 
 * Forms application that demonstrates order of forms events in output diagnostics
 *
 * Author: Anna Lesburg
 * 
 * Modification History:
 * 19 JAN 2023 - Created
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

namespace ICA03_Anna
{
    public partial class Form1 : Form
    {
        System.Diagnostics.Stopwatch Stopwatch = new System.Diagnostics.Stopwatch();
        public Form1()
        {
            InitializeComponent();
        }

        private void UI_Start_Btn_Click(object sender, EventArgs e)
        {
            Stopwatch.Start();
        }

        private void UI_Stop_Btn_Click(object sender, EventArgs e)
        {
            Stopwatch.Stop();
        }

        private void UI_Reset_Btn_Click(object sender, EventArgs e)
        {
            Stopwatch.Reset();
        }

        private void UI_Split_Btn_Click(object sender, EventArgs e)
        {

        }

        private void UI_Refresh_Timer_Tick(object sender, EventArgs e)
        {
            
            UI_Timer_Lbl.Text = FormattedTime();
        }

        static private string FormattedTime()
        {

        }
    }
}
