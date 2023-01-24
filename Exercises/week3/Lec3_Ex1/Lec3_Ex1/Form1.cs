using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lec3_Ex1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void UI_Calc_Btn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(UI_Value_Txtbx.Text, out int value))
            {
                UI_Result_Txtbx.Text = SumInts(value).ToString();
            }
        }

        private static int SumInts(int n)
        {
            if (n < 1)
            {
                return 0;
            }
            else
            {
                return SumInts(n - 1) + n;
            }
        }
    }
}
