﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lec2B_Ex6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void UI_Name_Tbx_TextChanged(object sender, EventArgs e)
        {
            UI_Display_Tbx.Text = UI_Name_Tbx.Text;
        }
    }
}
