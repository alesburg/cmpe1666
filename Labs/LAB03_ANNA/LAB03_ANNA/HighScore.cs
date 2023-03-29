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
        public int Mode
        {
            set
            {
                mode = value;
            }
        }
        public int pHighScore
        {
            get
            {
                return highscore;
            }
        }
        int mode;
        int highscore;
        string player;
        string newscore;
        StreamWriter swOut;
        StreamReader swIn;
        public HighScore()
        {
            InitializeComponent();
            if (File.Exists($"{mode}highscore.txt"))
            {
                swIn = new StreamReader($"{mode}highscore.txt");
                player = swIn.ReadLine();
                newscore = swIn.ReadLine();
                int.TryParse(newscore,out highscore);
                swIn.Close();
            }
            else
            {
                highscore = 0;
            }
        }

        private void UI_OK_Btn_Click(object sender, EventArgs e)
        {
            swOut = new StreamWriter($"{mode}highscore.txt");
            swOut.WriteLine(player);
            swOut.WriteLine(highscore);
            swOut.Close();
            Hide();
        }

        private void UI_Cancel_Btn_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
