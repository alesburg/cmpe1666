/* 
 * ICA #06 - Flood Fill (CMPE1666)
 * 
 * Forms application with GDIDrawer to perform flood fill with recursion
 *
 * Author: Anna Lesburg
 * 
 * Modification History:
 * 31 JAN 2023 - Created
 * 5 FEB 2023 - Debugging
 * 6 FEB 6 2023 - Finished and tested
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GDIDrawer;

namespace ICA06_Anna
{
    public partial class Form1 : Form
    {
        static CDrawer canvas = new CDrawer(); //GDIDrawer Window
        static Color[,] colorArray = new Color[80, 60]; //color array
        static Point rightClick; //tracks right click
        static Point prevRightClick = new Point(-1,-1); //tracks previous right click

        public Form1()
        {
            canvas.Scale = 10;
            canvas.ContinuousUpdate = false;
            canvas.RedundaMouse = false;
            InitializeComponent();
        }

        //color dialog popup
        private void UI_FillColor_Btn_Click(object sender, EventArgs e)
        {
            MouseClickTimer.Stop();
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = UI_Color_Picbx.BackColor;

            if (colorDialog.ShowDialog() == DialogResult.OK) UI_Color_Picbx.BackColor = colorDialog.Color;
        }

        //generates array of red pixels to canvas
        private void UI_Generate_Btn_Click(object sender, EventArgs e)
        {
            Random random = new Random(); //random generator
            int blocksNum = UI_NumBlocks_Trckbar.Value; //number of blocks to generate based on trackbar
            Point redPoint; //genrated point

            //clear array
            MouseClickTimer.Stop();
            for (int y = 0; y < 60; y++)
            {
                for (int x = 0; x < 80; x++)
                {
                    colorArray[x, y] = Color.Black;
                }
            }

            //set border color
            for (int y = 0; y < 60; y++)
            {
                colorArray[0, y] = Color.Red;
                colorArray[79, y] = Color.Red;
            }
            for (int x = 0; x < 80; x++)
            {
                colorArray[x, 0] = Color.Red;
                colorArray[x, 59] = Color.Red;
            }

            //random red blocks
            for (int i = 0; i < blocksNum;)
            {
                //check if red point already exists
                if (colorArray[random.Next(1, 80), random.Next(1, 60)] != Color.Red)
                {
                    redPoint = new Point(random.Next(1, 80), random.Next(1, 60));
                    colorArray[redPoint.X, redPoint.Y] = Color.Red;
                    i++;
                }
            }

            //draw array to canvas
            for (int y = 0; y < 60; y++)
            {
                for (int x = 0; x < 80; x++)
                {
                    canvas.SetBBScaledPixel(x, y, colorArray[x, y]);
                }
                canvas.Render();
            }
        }

        //starts timer to detect mouse clicks
        private void UI_Fill_Btn_Click(object sender, EventArgs e)
        {
            MouseClickTimer.Start();
        }

        private void FloodFill(int x, int y, Color target, Color replacement)
        {
            //base cases
            if (colorArray[x, y] != target) return;
            else if (colorArray[x, y] == replacement) return;
            else
            {
                colorArray[x,y] = replacement;
                canvas.SetBBScaledPixel(x, y, replacement);
                //recursion
                FloodFill(x - 1, y, target, replacement);
                FloodFill(x + 1, y, target, replacement);
                FloodFill(x, y - 1, target, replacement);
                FloodFill(x, y + 1, target, replacement);

                //render canvas
                canvas.Render(); 
            }
        }

        //gets mouse click and passes to floodfill on tick
        private void MouseClickTimer_Tick(object sender, EventArgs e)
        {  
            canvas.GetLastMouseRightClickScaled(out rightClick);
            if (rightClick != prevRightClick)
            {
                prevRightClick = new Point(rightClick.X,rightClick.Y);
                FloodFill(rightClick.X, rightClick.Y,Color.Black,UI_Color_Picbx.BackColor);
            }
        }
    }
}
