using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICA13_ANNA
{
    public partial class Form1 : Form
    {
        colorForm colorForm = new colorForm();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            colorForm.Show();
            colorForm._color = CallBackColor;
            colorForm._opacity = CallBackOpacity;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Color bcolor = Form.DefaultBackColor;

            colorForm.R = bcolor.R;
            colorForm.G = bcolor.G;
            colorForm.B = bcolor.B;
        }

        private void CallBackColor(int r, int g, int b)
        {
            this.BackColor = Color.FromArgb(r, g, b); 
        }
        private void CallBackOpacity(int o)
        {
            this.Opacity = o/100;
        }

    }
}
