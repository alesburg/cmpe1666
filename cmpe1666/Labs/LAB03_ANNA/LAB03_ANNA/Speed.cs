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
    public partial class Speed : Form
    {
        public delSpeed _Speed = null;
        public Speed()
        {
            InitializeComponent();
        }

        private void Speed_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }

        private void UI_Speed_Trckbar_Scroll(object sender, EventArgs e)
        {
            _Speed.Invoke(UI_Speed_Trckbar.Value);
        }

        private void CallbackCheck(bool show)
        {

        }
    }
}
