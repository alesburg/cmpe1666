/* 
 * LAB #02 - PicBender (CMPE1666)
 * 
 * Forms application for picture editing using bitmaps
 *
 * Author: Anna Lesburg
 * 
 * Modification History:
 * 07 FEB 2023 - Created
 * 24 FEB 2023 - Finished UI and bitmap methods
 * 27 FEB 2023 - Finished progress bar, tested and documented
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
        Bitmap Bitmap; //bitmap of loaded image
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
                UI_Transform_Btn.Enabled = true;
                try
                {
                    UI_Pic_Picbx.Load(imagePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    Bitmap = new Bitmap(UI_Pic_Picbx.Image);
                }
            }

        }

        //transform button clicked
        private void UI_Transform_Btn_Click(object sender, EventArgs e)
        {
            UI_Operation_Progbar.Value = 0;
            Bitmap transformedBM = new Bitmap(UI_Pic_Picbx.Image);

            //radio button selection
            if (UI_BW_Radbtn.Checked) BlackAndWhite(transformedBM, UI_Intensity_Trckbar.Value);
            else if (UI_Contrast_RadBtn.Checked) Contrast(transformedBM, UI_Intensity_Trckbar.Value);
            else if (UI_Tint_Radbtn.Checked) Tint(transformedBM, UI_Intensity_Trckbar.Value);
            else if (UI_Noise_Radbtn.Checked) Noise(transformedBM, UI_Intensity_Trckbar.Value);

            UI_Revert_Btn.Enabled = true;
            UI_Pic_Picbx.Image = transformedBM;
            UI_Operation_Progbar.Value = 0;
        }

        //revert button clicked
        private void UI_Revert_Btn_Click(object sender, EventArgs e)
        {
            UI_Pic_Picbx.Image = Bitmap;
        }

        //********************************************************************************************
        //Method: private void BlackAndWhite(Bitmap bm, int value)
        //Purpose: makes bitmap black and white based on value
        //Parameters: Bitmap bm -  bitmap to edit
        //int value - intensity of effect
        //*********************************************************************************************
        private void BlackAndWhite(Bitmap bm, int value)
        {
            Color rgb; //rgb value of pixel
            int r; //red value of pixel
            int g; //green value of pixel
            int b; //blue value of pixel
            int avg; //average of rgb

            //iterates through every pixel in bitmap
            for (int x = 0; x < bm.Width; x++)
            {
                for (int y = 0; y < bm.Height; y++)
                {
                    rgb = bm.GetPixel(x, y);
                    r = rgb.R;
                    g = rgb.G;
                    b = rgb.B;
                    avg = (r + g + b) / 3;
                    r = r + ((avg - r) * value / 100);
                    g = g + ((avg - g) * value / 100);
                    b = b + ((avg - b) * value / 100);
                    bm.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
                UpdateProgress(x / bm.Width);
            }
        }

        //********************************************************************************************
        //Method: private void Contrast(Bitmap bm, int value)
        //Purpose: increases bitmap contrast based on value
        //Parameters: Bitmap bm -  bitmap to edit
        //int value - intensity of effect
        //*********************************************************************************************
        private void Contrast(Bitmap bm, int value)
        {
            Color rgb; //rgb value of pixel
            int r; //red value of pixel
            int g; //green value of pixel
            int b; //blue value of pixel
            int amount = value / 5; //adjust for contrast

            //iterates through every pixel in bitmap
            for (int x = 0; x < bm.Width; x++)
            {
                for (int y = 0; y < bm.Height; y++)
                {
                    rgb = bm.GetPixel(x, y);
                    r = rgb.R;
                    g = rgb.G;
                    b = rgb.B;
                    //conditionals prevent wrap
                    r = r > 128 ? (r + amount) > 255 ? 255 : r + amount : (r - amount) > 0 ? r - amount : 0;
                    g = g > 128 ? (g + amount) > 255 ? 255 : g + amount : (g - amount) > 0 ? g - amount : 0;
                    b = b > 128 ? (b + amount) > 255 ? 255 : b + amount : (b - amount) > 0 ? b - amount : 0;
                    bm.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
                UpdateProgress(x / bm.Width);
            }
        }

        //********************************************************************************************
        //Method: private void Tint(Bitmap bm, int value)
        //Purpose: edits bitmap tint based on value
        //Parameters: Bitmap bm -  bitmap to edit
        //int value - intensity of effect
        //*********************************************************************************************
        private void Tint(Bitmap bm, int value)
        {
            Color rgb; //rgb value of pixel
            int r; //red value of pixel
            int g; //green value of pixel
            int b; //blue value of pixel
            int greenBias; //amount of red to tint
            int redBias; //amount of green to tint

            //iterates through every pixel in bitmap
            for (int x = 0; x < bm.Width; x++)
            {
                for (int y = 0; y < bm.Height; y++)
                {
                    rgb = bm.GetPixel(x, y);
                    r = rgb.R;
                    g = rgb.G;
                    b = rgb.B;
                    greenBias = g + (value - 50);
                    redBias = r + (50 - value);
                    if (value < 50) r = redBias > 255 ? 255 : redBias;
                    else if (value > 50) g = greenBias > 255 ? 255 : greenBias;
                    bm.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
                UpdateProgress(x / bm.Width);
            }
        }

        //********************************************************************************************
        //Method: private void Noise(Bitmap bm, int value)
        //Purpose: adds noise to bitmap based on value
        //Parameters: Bitmap bm -  bitmap to edit
        //int value - intensity of effect
        //*********************************************************************************************
        private void Noise(Bitmap bm, int value)
        {
            Random rand = new Random(); //random generator 
            Color rgb; //rgb value of pixel
            int r; //red value of pixel
            int g; //green value of pixel
            int b; //blue value of pixel
            int newR; //new red value
            int newG; //new green value
            int newB; //new blue value

            //iterates through every pixel in bitmap
            for (int x = 0; x < bm.Width; x++)
            {
                for (int y = 0; y < bm.Height; y++)
                {
                    rgb = bm.GetPixel(x, y);
                    r = rgb.R;
                    g = rgb.G;
                    b = rgb.B;

                    newR = r + (rand.Next() % ((value + 1) * 2)) - value;
                    newG = g + (rand.Next() % ((value + 1) * 2)) - value;
                    newB = b + (rand.Next() % ((value + 1) * 2)) - value;

                    //conditionals prevent wrap
                    r = newR > 255 ? 255 : newR < 0 ? 0 : newR;
                    g = newG > 255 ? 255 : newG < 0 ? 0 : newG;
                    b = newB > 255 ? 255 : newB < 0 ? 0 : newB;

                    bm.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
                UpdateProgress(x / bm.Width);
            }
        }

        //doesnt work
        private void UpdateProgress(double ratio)
        {
            UI_Operation_Progbar.Value = (int)(ratio * 100);
        }
    }
}
