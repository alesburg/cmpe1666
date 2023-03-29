using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB03_ANNA
{
    public delegate void delSpeed(int speed);
    public delegate void delSpeedCheck(bool show);
    public partial class Speed : Form
    {
        public delSpeed _Speed = null;
        public delSpeedCheck _speedCheck = null;
        public Speed()
        {
            InitializeComponent();
        }

        private void Speed_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                _speedCheck.Invoke(false);
                e.Cancel = true;
                Hide();
            }
        }

        //update speed on trackbar scroll
        private void UI_Speed_Trckbar_Scroll(object sender, EventArgs e)
        {
            _Speed.Invoke(UI_Speed_Trckbar.Value);
        }

    }
}
