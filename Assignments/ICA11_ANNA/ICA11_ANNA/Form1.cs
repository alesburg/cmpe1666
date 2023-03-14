/* 
 * ICA #11 - Fontify (CMPE1666)
 * 
 * Forms application that samples fonts using support dialogs
 *
 * Author: Anna Lesburg
 * 
 * Modification History:
 * 13 MAR 2023 - Created
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

        private void UI_FontSample_Lbl_Click(object sender, EventArgs e)
        {
            Format formatDialog = new Format();
            formatDialog.dialogFont = UI_FontSample_Lbl.Font;
            formatDialog.dialogColor = UI_FontSample_Lbl.ForeColor;
            if(formatDialog.ShowDialog() == DialogResult.OK)
            {
                UI_FontSample_Lbl.Font = formatDialog.dialogFont;
                UI_FontSample_Lbl.ForeColor = formatDialog.dialogColor;
            }
        }
    }
}
