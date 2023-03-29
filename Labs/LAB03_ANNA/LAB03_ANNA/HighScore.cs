using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LAB03_ANNA
{
    
    public partial class HighScore : Form
    {
        int mode;
        int highscore;
        StreamWriter swOut;
        public HighScore()
        {
            InitializeComponent();
        }

        private void UI_OK_Btn_Click(object sender, EventArgs e)
        {
            swOut = new StreamWriter($"{mode}highscore.txt");
        }

        private void UI_Cancel_Btn_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
