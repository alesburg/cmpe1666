using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GDIDrawer;

namespace LAB03_ANNA
{
    public partial class Form1 : Form
    {
        CDrawer game;
        public Form1()
        {
            InitializeComponent();
        }

        private void UI_Play_Btn_Click(object sender, EventArgs e)
        {
            modal DifficultySelect = new modal();
            if(DifficultySelect.ShowDialog() == DialogResult.OK)
            {
                game = new CDrawer();
            }
        }
    }
}
