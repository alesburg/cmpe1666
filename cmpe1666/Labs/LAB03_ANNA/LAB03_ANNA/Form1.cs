/* 
 * LAB #03 - BallZ (CMPE1666)
 * 
 * Forms and GDIDrawer game
 *
 * Author: Anna Lesburg
 * 
 * Modification History:
 * 25 MAR 2023 - Created forms and game start UI
 * 27 MAR 2023 - 
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
using GDIDrawer;

namespace LAB03_ANNA
{
    public partial class Form1 : Form
    {
        const int GameWidth = 800;
        const int GameHeight = 600;
        const int BallSize = 50;
        const int RowCount = GameHeight / BallSize;
        const int ColCount = GameWidth / BallSize;
        CDrawer game;
        public enum eState { Alive,Dead};
        public struct Ball
        {
            public Color color;
            public eState state;

            public Ball(Color color,eState state)
            {
                this.color = color;
                this.state = state;
            }
        }
        Ball[,] balls = new Ball[RowCount,ColCount];
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

        private void Randomize()
        {
            Color[] colors = { Color.Red,Color.Blue,Color.Yellow,Color.Green,Color.Purple};
            Random random = new Random();
            for(int y = 0; y < RowCount; y++)
            {
                for(int x = 0; x < ColCount; x++)
                {
                    balls[x, y] = new Ball(colors[random.Next(0, modal.difficulty)], eState.Alive);
                }
            }
        }
    }
}
