/* 
 * ICA #06 - Flood Fill (CMPE1666)
 * 
 * Forms application with GDIDrawer to perform flood fill with recursion
 *
 * Author: Anna Lesburg
 * 
 * Modification History:
 * 31 JAN 2023 - Created
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public Form1()
        {
            canvas.Scale = 10;
            InitializeComponent();
        }

        private void UI_FillColor_Btn_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = UI_Color_Picbx.BackColor;

            if(colorDialog.ShowDialog() == DialogResult.OK) UI_Color_Picbx.BackColor= colorDialog.Color;
        }

        private void UI_Generate_Btn_Click(object sender, EventArgs e)
        {
            Random random= new Random(); //random generator
            int blocksNum = UI_NumBlocks_Trckbar.Value; //number of blocks to generate based on trackbar

            //clear array
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
                colorArray[x,0] = Color.Red;
                colorArray[x,59] = Color.Red;
            }

            //random red blocks
            for (int i = 0; i < blocksNum;i++)
            {
                colorArray[random.Next(1,80),random.Next(1,60)] = Color.Red;
            }


           //draw array to canvas
           for(int y = 0; y < 60; y++)
            {
                for(int x = 0; x < 80; x++)
                {
                    canvas.SetBBScaledPixel(x, y, colorArray[x, y]);
                }
            }
        }
    }
}
