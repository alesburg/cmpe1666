using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB02_ANNA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void UI_Contrast_RadBtn_CheckedChanged(object sender, EventArgs e)
        {
            if(UI_Contrast_RadBtn.Checked || UI_BW_Radbtn.Checked)
            {
                UI_Left_Lbl.Text = "Less";
                UI_Right_Lbl.Text = "More";
                UI_Value_Lbl.Text = UI_Intensity_Trckbar.Value.ToString();
            }
            if (UI_Tint_Radbtn.Checked)
            {
                UI_Left_Lbl.Text = "Red";
                UI_Right_Lbl.Text = "Green";
                if (UI_Intensity_Trckbar.Value < 50) //left off here
                {
                    UI_Value_Lbl.Text = UI_Intensity_Trckbar.Value;
                }
                
            }
        }

        private void UI_Intensity_Trckbar_Scroll(object sender, EventArgs e)
        {
            if (UI_Contrast_RadBtn.Checked || UI_BW_Radbtn.Checked)
            {
                UI_Value_Lbl.Text = UI_Intensity_Trckbar.Value.ToString();
            }
        }
    }
}
