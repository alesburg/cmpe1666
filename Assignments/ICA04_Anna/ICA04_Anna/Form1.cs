/* 
 * ICA #04 - Speed Conversion (CMPE1666)
 * 
 * Forms application that converts mph and km/h to m/s
 *
 * Author: Anna Lesburg
 * 
 * Modification History:
 * 24 JAN 2023 - Created
 * 25 JAN 2023 - Added event code and methods + documentation
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.PerformanceData;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICA04_Anna
{
    public partial class Form1 : Form
    {
        const double KMTOM = 0.2777777778; //constant for converting kmph to m/s, source unitconverters.net
        const double MITOM = 0.44704; //constant for converting mph to m/s, source unitconverters.net
        public Form1()
        {
            InitializeComponent();
        }

        //called when radio buttons changed
        private void UI_Radbtn_CheckedChanged(object sender, EventArgs e)
        {
            UI_output_Txtbx.Text = Convert(UI_input_Txtbx.Text);
        }

        //called when text is changed in input box
        private void UI_input_Txtbx_TextChanged(object sender, EventArgs e)
        {
            UI_output_Txtbx.Text = Convert(UI_input_Txtbx.Text);
        }

        //********************************************************************************************
        //Method: private string Convert(string speedString)
        //Purpose: Returns formatted string to converting kmph or mph to m/s with error checking
        //Parameters: string speedString - input from user
        //Returns: string
        //*********************************************************************************************
        private string Convert(string speedString)
        {
            bool success; //parse double from string successful?
            double speed; //speed value to convert

            success = double.TryParse(speedString, out speed);

            if (UI_Mph_Radbtn.Checked) speed = speed * MITOM;
            else speed = speed * KMTOM;

            if (success) return $"{speed:F2} m/s";
            else return "Unable to convert input.";
        }
    }
}
