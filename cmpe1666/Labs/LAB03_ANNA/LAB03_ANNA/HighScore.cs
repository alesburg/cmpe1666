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
        //get mode from main form
        public int Mode
        {
            set
            {
                mode = value;
            }
        }
        //new score from main form
        public int newHS
        {
            set
            {
                newscore = value;
            }
        }
        int newscore; 
        int mode;
        StreamWriter swOut; //streamwriter
        
        public HighScore()
        {
            InitializeComponent();
        }

        private void UI_OK_Btn_Click(object sender, EventArgs e)
        {
            //write highscore to file
            swOut = new StreamWriter($"{mode}highscore.txt");
            swOut.WriteLine(UI_PlayerName_Tbx.Text);
            swOut.WriteLine(newscore);
            swOut.Close();
            Hide();
        }

        private void UI_Cancel_Btn_Click(object sender, EventArgs e)
        {
            //cancel
            Hide();
        }
    }
}
