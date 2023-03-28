/* 
 * LAB #03 - BallZ (CMPE1666)
 * 
 * Forms and GDIDrawer game
 *
 * Author: Anna Lesburg
 * 
 * Modification History:
 * 25 MAR 2023 - Created forms and game start UI
 * 27 MAR 2023 - Created Randomize and Display methods
 * 28 MAR 2023 - 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
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
        int diffSelect;
        Point lastrClick = new Point(-1,-1);
        public enum eState { Alive, Dead };
        public struct Ball
        {
            public Color color;
            public eState state;

            public Ball(Color color, eState state)
            {
                this.color = color;
                this.state = state;
            }
        }
        Ball[,] balls = new Ball[ColCount, RowCount];
        public Form1()
        {
            InitializeComponent();
        }

        private void UI_Play_Btn_Click(object sender, EventArgs e)
        {
            Score score = new Score();
            if (UI_ShowScore_Chkbx.Checked)
            {
                score.Show();
            }
            modal DifficultySelect = new modal();
            if (DifficultySelect.ShowDialog() == DialogResult.OK)
            {
                diffSelect = DifficultySelect.difficulty;
                game = new CDrawer(GameWidth, GameHeight, false, false);
                timer.Start();
                Randomize();
                UI_Play_Btn.Enabled = false;
            }
        }


        private void Randomize()
        {
            Color[] colors = { Color.Red, Color.Blue, Color.Yellow, Color.Green, Color.Purple };
            Random random = new Random();
            for (int y = 0; y < RowCount; y++)
            {
                for (int x = 0; x < ColCount; x++)
                {
                    balls[x, y] = new Ball(colors[random.Next(0, diffSelect)], eState.Alive);
                }
            }
            Display();
        }

        private void Display()
        {
            game.Clear();
            for (int y = 0; y < RowCount; y++)
            {
                for (int x = 0; x < ColCount; x++)
                {
                    if (balls[x, y].state == eState.Alive) game.AddEllipse(x * BallSize, y * BallSize, BallSize, BallSize, balls[x, y].color);
                }
            }
            game.Render();

        }

        private int BallsAlive()
        {
            int alive = 0;
            for (int y = 0; y < RowCount; y++)
            {
                for (int x = 0; x < ColCount; x++)
                {
                    if (balls[x, y].state == eState.Alive) alive++;
                }
            }
            return alive;
        }

        private int CheckBalls(int row, int col, Color color)
        {
            int ballsKilled;
            if (col < 0 || col > ColCount-1 || row < 0 || row > RowCount-1) return 0;
            else if (balls[col, row].state == eState.Dead) return 0;
            else if (balls[col, row].color != color) return 0;
            else
            {
                balls[col, row].state = eState.Dead;
                ballsKilled = 1;
                ballsKilled += CheckBalls(row + 1, col, color);
                ballsKilled += CheckBalls(row - 1, col, color);
                ballsKilled += CheckBalls(row, col + 1, color);
                ballsKilled += CheckBalls(row, col - 1, color);
            }
            return ballsKilled;
        }

        private int StepDown()
        {
            int dropped = 0;
            for (int y = 0; y < RowCount; y++)
            {
                for (int x = 0; x < ColCount; x++)
                {
                    if (balls[x, y].state == eState.Dead && y > 0)
                    {
                        if (balls[x,y-1].state == eState.Alive)
                        {
                            balls[x, y].state = eState.Alive;
                            balls[x, y].color = balls[x, y - 1].color;
                            balls[x, y - 1].state = eState.Alive;
                            dropped++;
                        }
                    }
                }
            }
            Display();
            return dropped;
        }

        private int FallDown()
        {
            int steps = 0;
            do
            {
                steps += StepDown();
                System.Threading.Thread.Sleep(1000);
            }while (steps != 0);
            return steps;
        }

        private int Pick()
        {
            Point rClick;
            int row;
            int col;
            if (!game.GetLastMouseRightClick(out rClick)) return 0;
            row = rClick.Y/BallSize;
            col = rClick.X/BallSize;
            if (balls[col, row].state == eState.Dead) return 0;
            CheckBalls(row, col, balls[col,row].color);
            return 1;

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if(Pick() != 0)
            {
                Display();
            }
        }
    }
}
