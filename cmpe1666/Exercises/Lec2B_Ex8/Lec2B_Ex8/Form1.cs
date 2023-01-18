using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lec2B_Ex8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void UI_Price_Tbx_TextChanged(object sender, EventArgs e)
        {
            double price;
            double.TryParse(UI_Price_Tbx.Text, out price);

            UI_Price_Tbx.Text = 
        }
    }
}
