using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lec2B_Ex5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void UI_Sum_Btn_Click(object sender, EventArgs e)
        {
            int val1;
            int val2;
            int sum;
            
            int.TryParse(UI_Val1_Tbx.Text, out val1);
            int.TryParse(UI_Val2_Tbx.Text, out val2);
            sum = val1 + val2;
            

            UI_Sum_Tbx.Text = sum.ToString();
        }
    }
}
