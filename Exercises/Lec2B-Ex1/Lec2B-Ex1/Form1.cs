using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lec2B_Ex1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            UI_Display_Lbl.Text = "Initial Label Value";
        }

        private void UI_Change_Button_Click(object sender, EventArgs e)
        {
            
            UI_Display_Lbl.Text = "Hello World!";
        }
    }
}
