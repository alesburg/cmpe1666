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
    public partial class colorForm : Form
    {
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

        private void UI_Trckbar_Scroll(object sender, EventArgs e)
        {

        }
    }
}
