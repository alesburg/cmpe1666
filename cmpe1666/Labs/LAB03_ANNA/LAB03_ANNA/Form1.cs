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
 * 28 MAR 2023 - Finished and tested
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
        //constants
        const int GameWidth = 800;
        const int GameHeight = 600;
        const int BallSize = 50;
        const int RowCount = GameHeight / BallSize;
        const int ColCount = GameWidth / BallSize;

        int animationSpeed = 10; //animation speed, affected by modeless dialogue
        CDrawer game; //GDIDrawer window
        int diffSelect; //Difficulty selection
        int Score; //total score
        Score score = new Score(); //score modeless
        Speed speed = new Speed(); //speed modeless
        public enum eState { Alive, Dead }; //ball state enum

        //ball struct
        public struct Ball 
        {
            public Color color;
            public eState state;

            //constructor
            public Ball(Color color, eState state)
            {
                this.color = color;
                this.state = state;
            }
        }
        Ball[,] balls = new Ball[ColCount, RowCount]; // 2d ball array
        public Form1()
        {
            InitializeComponent();
        }

        private void UI_Play_Btn_Click(object sender, EventArgs e)
        {
            Score = 0;
            game.Clear();
            modal DifficultySelect = new modal();
            if (DifficultySelect.ShowDialog() == DialogResult.OK)
            {
                diffSelect = DifficultySelect.difficulty;
                timer.Start();
                Randomize();
                UI_Play_Btn.Enabled = false;
                speed._Speed = CallbackSpeed;
            }
        }

        //********************************************************************************************
        //Method: private void Randomize()
        //Purpose: Populates array of balls based on difficulty
        //*********************************************************************************************
        private void Randomize()
        {
            Color[] colors = { Color.Red, Color.Blue, Color.Yellow, Color.Green, Color.Purple }; //color array
            Random random = new Random(); //random generator

            //iterate through array and generate balls
            for (int y = 0; y < RowCount; y++)
            {
                for (int x = 0; x < ColCount; x++)
                {
                    balls[x, y] = new Ball(colors[random.Next(0, diffSelect)], eState.Alive);
                }
            }

            Display();
        }

        //********************************************************************************************
        //Method: private void Display()
        //Purpose: Draws array of balls from Randomize() to GDIDrawer
        //*********************************************************************************************
        private void Display()
        {
            //clear array, iterate through and draw
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

        //********************************************************************************************
        //Method: private int BallsAlive()
        //Purpose: Helper method that counts the number of balls still active
        //Returns: int - number of balls alive
        //*********************************************************************************************
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

        //********************************************************************************************
        //Method: private int CheckBalls(int row, int col, Color color)
        //Purpose: Checks balls recursively
        //Parameters: int row - start row
        //int col - start column
        //Color color - target color
        //Returns: int - 0 if base cased reached or number of balls killed
        //*********************************************************************************************
        private int CheckBalls(int row, int col, Color color)
        {
            int ballsKilled = 0;
            if (col < 0 || col > ColCount-1 || row < 0 || row > RowCount-1) return 0;
            else if (balls[col, row].state == eState.Dead) return 0;
            else if (balls[col, row].color != color) return 0;
            else
            {
                balls[col, row].state = eState.Dead;
                ballsKilled += 1;
                ballsKilled += CheckBalls(row + 1, col, color);
                ballsKilled += CheckBalls(row - 1, col, color);
                ballsKilled += CheckBalls(row, col + 1, color);
                ballsKilled += CheckBalls(row, col - 1, color);
            }
            
            return ballsKilled;
        }

        //********************************************************************************************
        //Method: private int StepDown()
        //Purpose: checks for empty spots, moves above balls down to fill spaces
        //Returns: int - number of balls stepped down
        //*********************************************************************************************
        private int StepDown()
        {
            int dropped = 0; //count of balls dropped
            //iterates over array
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
                            balls[x, y - 1].state = eState.Dead;
                            dropped++;
                            System.Threading.Thread.Sleep(animationSpeed);
                        }
                    }
                }
            }
            Display();
            return dropped;
        }

        //********************************************************************************************
        //Method: private int FallDown()
        //Purpose: calls StepDown() until all spaces filled
        //Returns: int - number of steps
        //*********************************************************************************************
        private int FallDown()
        {
            int steps = 0;
            do
            {
                steps = StepDown();
                System.Threading.Thread.Sleep(animationSpeed);
            }while (steps != 0);
            return steps;
        }

        //********************************************************************************************
        //Method: private int Pick()
        //Purpose: Gets mouse right click on canvas, processes
        //Returns: int - balls killed
        //*********************************************************************************************
        private int Pick()
        {
            Point rClick;
            int row;
            int col;
            if (!game.GetLastMouseRightClick(out rClick)) return 0;
            row = rClick.Y/BallSize;
            col = rClick.X/BallSize;
            if (balls[col, row].state == eState.Dead) return 0;
            return CheckBalls(row, col, balls[col, row].color);
        }

        //on timer tick
        private void timer_Tick(object sender, EventArgs e)
        {
            int roundScore = ProcessScore(Pick());
            if(roundScore > 0)
            {
                FallDown();
                score.scoreSet = Score + roundScore;
                Score = Score + roundScore;
            }
            if(BallsAlive() < 1) //game end case
            {
                game.Clear();
                game.AddText("Game Over!", 32, Color.White);
                UI_Play_Btn.Enabled = true;
            }
        }
        
        //returns score based on balls destroyed at once
        private int ProcessScore(int balls)
        {
            int score = 0;
            for (int i = 0; i < balls; i++)
            {
                score += 50 + i*10;
            }
            return score;
        }

        //build CDrawer on load
        private void Form1_Load(object sender, EventArgs e)
        {
            game = new CDrawer(GameWidth, GameHeight, false, false);
        }

        //callback for animation speed
        private void CallbackSpeed(int speed)
        {
            animationSpeed = speed;
        }

        //checkbox dialogs
        private void UI_Chkbx_CheckedChanged(object sender, EventArgs e)
        {
            if(UI_ShowScore_Chkbx.Checked)
            {
                score.Show();
            }
            else
            {
                score.Hide();
            }
            if (UI_ShowSpeed_Chkbx.Checked)
            {
                speed.Show();
            }
            else
            {
                speed.Hide();
            }
        }
    }
}
