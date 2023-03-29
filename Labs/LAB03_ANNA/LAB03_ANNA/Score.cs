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
    public partial class Score : Form
    {
        public int scoreSet
        {
            set
            {
                UI_Score_Lbl.Text = value.ToString();
            }
        }
        public Score()
        {
            InitializeComponent();
        }

        private void Score_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }
    }
}
