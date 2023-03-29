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
    public delegate void delScoreCheck(bool show); //delegate for clearing checkbox
    public partial class Score : Form
    {
        public delScoreCheck _scoreCheck = null; //initialize delegate
        
        //property for updateing score
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
                _scoreCheck.Invoke(false); 
                e.Cancel = true;
                Hide();
            }
        }
    }
}
