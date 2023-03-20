/* 
 * ICA #13 - Color This! (CMPE1666)
 * 
 * Forms application that demonstrates modeless dialogs, properties and delegates
 *
 * Author: Anna Lesburg
 * 
 * Modification History:
 * 20 MAR 2023 - Created, tested, finished
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

namespace ICA13_ANNA
{
    public partial class Form1 : Form
    {
        colorForm colorForm = new colorForm(); //modeless dialog object

        public Form1()
        {
            InitializeComponent();
        }

        //on click
        private void Form1_Click(object sender, EventArgs e)
        {
            //attach methods to delegates then show form
            colorForm._color = CallBackColor;
            colorForm._opacity = CallBackOpacity;
            colorForm.Show();
        }

        //on load
        private void Form1_Load(object sender, EventArgs e)
        {
            Color bcolor = this.BackColor; //holds form backcolor on load

            //set slider values using properties
            colorForm.R = bcolor.R;
            colorForm.G = bcolor.G;
            colorForm.B = bcolor.B;
        }

        //callback for form rgb
        private void CallBackColor(int r, int g, int b)
        {
            this.BackColor = Color.FromArgb(r, g, b);
        }

        //callback for form opacity
        private void CallBackOpacity(int o)
        {
            double opacity = (double)(o / 100.0);
            this.Opacity = opacity;
        }

    }
}
