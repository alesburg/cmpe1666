/* 
 * ICA #11 - Fontify (CMPE1666)
 * 
 * Forms application that samples fonts using support dialogs
 *
 * Author: Anna Lesburg
 * 
 * Modification History:
 * 13 MAR 2023 - Created
 * 14 MAR 2023 - Finished and Tested
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

namespace ICA11_ANNA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //click font sample
        private void UI_FontSample_Lbl_Click(object sender, EventArgs e)
        {
            Format formatDialog = new Format(); //Format Dialog

            //sends current font to format 
            formatDialog.dialogFont = UI_FontSample_Lbl.Font;
            formatDialog.dialogColor = UI_FontSample_Lbl.ForeColor;

            //when ok on format dialog clicked
            if(formatDialog.ShowDialog() == DialogResult.OK)
            {
                //gets color and font from format dialog
                UI_FontSample_Lbl.Font = formatDialog.dialogFont;
                UI_FontSample_Lbl.ForeColor = formatDialog.dialogColor;
            }
        }
    }
}
