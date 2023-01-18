using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lec2B_Ex7
{
    public partial class Form1 : Form
    {
        static int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void UI_Timer_Tick(object sender, EventArgs e)
        {
            count++;
            Text = count.ToString();
        }
    }
}
