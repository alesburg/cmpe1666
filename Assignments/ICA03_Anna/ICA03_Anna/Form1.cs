﻿/* 
 * ICA #03 - Kind-of-sort-of-Timing (CMPE1666)
 * 
 * Forms application that demonstrates order of forms events in output diagnostics
 *
 * Author: Anna Lesburg
 * 
 * Modification History:
 * 19 JAN 2023 - Created
 * 23 JAN 2023 - Finished UI
 * 24 JAN 2023 - Finished and tested
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

namespace ICA03_Anna
{
    public partial class Timer : Form
    {
        System.Diagnostics.Stopwatch Stopwatch = new System.Diagnostics.Stopwatch(); //stopwatch

        public Timer()
        {
            InitializeComponent();
        }

        //start button clicked
        private void UI_Start_Btn_Click(object sender, EventArgs e)
        {
            Stopwatch.Start();
        }

        //stop button clicked
        private void UI_Stop_Btn_Click(object sender, EventArgs e)
        {
            Stopwatch.Stop();
        }

        //reset button clicked
        private void UI_Reset_Btn_Click(object sender, EventArgs e)
        {
            Stopwatch.Reset();
            UI_Timer_Lstbx.Items.Clear();
        }

        //split button clicked
        private void UI_Split_Btn_Click(object sender, EventArgs e)
        {
            //check for time already present in listbox
            if (!(UI_Timer_Lstbx.Items.Contains(FormattedTime((int)Stopwatch.ElapsedMilliseconds))))
            {
                UI_Timer_Lstbx.Items.Add(FormattedTime((int)Stopwatch.ElapsedMilliseconds));
            }
        }

        //refresh UI on timer tick
        private void UI_Refresh_Timer_Tick(object sender, EventArgs e)
        {
            UI_Timer_Lbl.Text = FormattedTime((int)Stopwatch.ElapsedMilliseconds);
        }

        //********************************************************************************************
        //Method: private string FormattedTime(int msTotal)
        //Purpose: Formats total ms from timespan to display on UI
        //Parameters: int msTotal - total milliseconds elapsed
        //Returns: string
        //*********************************************************************************************
        private string FormattedTime(int msTotal)
        {
            int day; //calculated days elapsed
            int hr; //calculated hours elapsed
            int min; //calculated minutes elapsed
            int sec; //calculated seconds elapsed
            int hundredthSec; //calculated hundredths of seconds elapsed

            //calculate days if ms elapsed > 1 day
            day = msTotal > 86400000 ? msTotal / 86400000 : 0;
            msTotal = msTotal > 86400000 ? msTotal % 86400000 : msTotal;

            //calculate hours if ms elapsed > 1 hr
            hr = msTotal > 3600000 ? msTotal / 3600000 : 0;
            msTotal = msTotal > 3600000 ? msTotal % 3600000 : msTotal;

            //calculate minutes if ms elapsed > 1 min
            min = msTotal > 60000 ? msTotal / 60000 : 0;
            msTotal = msTotal > 60000 ? msTotal % 60000 : msTotal;

            //calculate secs if ms elapsed > 1 sec
            sec = msTotal > 1000 ? msTotal / 1000 : 0;
            msTotal = msTotal > 1000 ? msTotal % 1000 : msTotal;

            //calculate hunredths of seconds
            hundredthSec = msTotal / 10;

            //return formatted string
            return $"({day}) {hr:D2}:{min:D2}:{sec:D2}.{hundredthSec:D2}";
        }
    }
}
