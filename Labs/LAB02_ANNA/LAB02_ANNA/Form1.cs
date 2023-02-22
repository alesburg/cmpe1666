/* 
 * LAB #02 - PicBender (CMPE1666)
 * 
 * Forms application for picture editing using bitmaps
 *
 * Author: Anna Lesburg
 * 
 * Modification History:
 * 07 FEB 2023 - Created
 * 08 FEB 2023 - UI finished
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

namespace LAB02_ANNA
{
    public partial class Form1 : Form
    {
        string imagePath; //path of selected image
        public Form1()
        {
            InitializeComponent();
        }

        //changes UI lables based on trackbar scroll
        private void UI_Intensity_Trckbar_Scroll(object sender, EventArgs e)
        {
            if (UI_Tint_Radbtn.Checked)
            {
                if (UI_Intensity_Trckbar.Value == 50)
                {
                    UI_Value_Lbl.Text = "No Tint";
                }
                else if (UI_Intensity_Trckbar.Value < 50)
                {
                    UI_Value_Lbl.Text = $"To Red: {50 - UI_Intensity_Trckbar.Value}";
                }
                else
                {
                    UI_Value_Lbl.Text = $"To Green: {UI_Intensity_Trckbar.Value - 50}";
                }
            }
            else
            {
                UI_Value_Lbl.Text = UI_Intensity_Trckbar.Value.ToString();
            }
        }

        //changes UI trackbar labels based on radio buttons
        private void UI_RadBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (UI_Tint_Radbtn.Checked)
            {
                UI_Left_Lbl.Text = "Red";
                UI_Right_Lbl.Text = "Green";
                if (UI_Intensity_Trckbar.Value == 50)
                {
                    UI_Value_Lbl.Text = "No Tint";
                }
                else if (UI_Intensity_Trckbar.Value < 50)
                {
                    UI_Value_Lbl.Text = $"To Red: {50 - UI_Intensity_Trckbar.Value}";
                }
                else
                {
                    UI_Value_Lbl.Text = $"To Green: {UI_Intensity_Trckbar.Value - 50}";
                }
            }
            else
            {
                UI_Left_Lbl.Text = "Less";
                UI_Right_Lbl.Text = "More";
                UI_Value_Lbl.Text = UI_Intensity_Trckbar.Value.ToString();
            }
        }

        //Load image button clicked
        private void UI_LoadPic_Btn_Click(object sender, EventArgs e)
        {
            openImageDialog.InitialDirectory = "c://";
            openImageDialog.Filter = "JPEG Images (*.jpg)|*.jpg|PNG Images (*.png)|*.png|BMP Images (*.bmp)|*.bmp|All files (*.*)|*.*";
            openImageDialog.FilterIndex = 3;
            openImageDialog.RestoreDirectory = true;
            if (openImageDialog.ShowDialog() == DialogResult.OK)
            {
                imagePath = openImageDialog.FileName;
            }
        }
    }
}
