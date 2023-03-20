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
    public delegate void delColor(int r, int g, int b); //delegate for rgb
    public delegate void delOpacity(int o); //delegate for opacity

    public partial class colorForm : Form
    {
        //initialize delegates
        public delColor _color = null;
        public delOpacity _opacity = null;

        //set only properties, used on load
        public int R
        {
            set
            {
                UI_R_Trckbar.Value = value;
            }
        }
        public int G
        {
            set
            {
                UI_G_Trckbar.Value = value;
            }
        }
        public int B
        {
            set
            {
                UI_B_Trckbar.Value = value;
            }
        }
        public int O
        {
            set
            {
                UI_Opacity_Trckbar.Value = value;
            }
        }
        public colorForm()
        {
            InitializeComponent();
        }

        //on any trackbar change
        private void UI_Trckbar_Scroll(object sender, EventArgs e)
        {
            //invoke delegates
            _color.Invoke(UI_R_Trckbar.Value, UI_G_Trckbar.Value, UI_B_Trckbar.Value);
            _opacity.Invoke(UI_Opacity_Trckbar.Value);
        }

        //intercept form close by user
        private void colorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }
    }
}
