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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GDIDrawer;

namespace ICA06_Anna
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void UI_FillColor_Btn_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = UI_Color_Picbx.BackColor;

            if(colorDialog.ShowDialog() == DialogResult.OK) UI_Color_Picbx.BackColor= colorDialog.Color;
        }
    }
}
