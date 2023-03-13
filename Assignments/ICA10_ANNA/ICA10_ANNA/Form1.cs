/* 
 * ICA #10 - Sorting Structs (CMPE1666)
 * 
 * Forms application that draws and manipulates lines using structs
 *
 * Author: Anna Lesburg
 * 
 * Modification History:
 * 7 MAR 2023 - Created
 * 8 MAR 2023 - Finished, Tested, Documented
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GDIDrawer;

namespace ICA10_ANNA
{
    public partial class Form1 : Form
    {
        
        public struct SLine //Line struct
        {
            public Point startPoint; //starting point of line
            public Point endPoint; //ending point of line
            public Color lineColor; //color of line
            public byte thickness; //thickness of line

            //constructor
            public SLine(Point startPoint, Point endPoint, Color lineColor, byte thickness)
            {
                this.startPoint = startPoint;
                this.endPoint = endPoint;
                this.lineColor = lineColor;
                this.thickness = thickness;
            }
        }

        CDrawer canvas; //GDIDrawer window
        Point startPoint; //starting point from click
        Point endPoint; //ending point from click
        Point prevRightClick; //previous right click 
        List<SLine> lines; //list of drawn lines
        eState state; //state of line drawer
        private enum eState { State_Idle, State_Armed } //enum for state of line drawer

        public Form1()
        {
            InitializeComponent();
        }

        //********************************************************************************************
        //Method: private void Render(SLine line)
        //Purpose: draws passed line to GDIDrawer
        //Parameters: Sline line - line to draw
        //*********************************************************************************************
        private void Render(SLine line)
        {
            canvas.AddLine(line.startPoint.X, line.startPoint.Y, line.endPoint.X, line.endPoint.Y, line.lineColor, line.thickness);
            lines.Add(line);
            canvas.Render();
        }

        //********************************************************************************************
        //Method: private void Render()
        //Purpose: draws entire list to GDIDrawer
        //*********************************************************************************************
        private void Render()
        {
            canvas.Clear();
            foreach(SLine line in lines)
            {
                Render(line);
            }
        }

        //on form load
        private void Form1_Load(object sender, EventArgs e)
        {
            canvas = new CDrawer(800, 800, false, true); //initialize GDIDrawer window
            lines = new List<SLine>(); //initialize list of lines
            state = eState.State_Idle; //starts in idle state
            endPoint = new Point(-1, -1); //set endpoint out of bounds for redundancy checking
            prevRightClick = new Point(-1, -1); //set prev click out of bounds for redundancy checking
        }

        //on timer tick
        private void MouseTimer_Tick(object sender, EventArgs e)
        {
            Point clickLeft; //left click point
            Point clickRight; //right click point
            SLine line; //line struct

            canvas.GetLastMouseLeftClick(out clickLeft);

            //if in idle state on valid click go to armed state
            if (state == eState.State_Idle && clickLeft != endPoint)
            {
                startPoint = clickLeft;
                state = eState.State_Armed;
                UI_State_Lbl.Text = "ARMED";
                UI_State_Lbl.ForeColor = Color.Red;
            }
            //if in armed state on valid click draw line and go to idle state
            else if (state == eState.State_Armed && clickLeft != startPoint)
            {
                endPoint = clickLeft;
                line = new SLine(startPoint, endPoint, Color.Red, 5);
                Render(line);
                state = eState.State_Idle;
                UI_State_Lbl.Text = "IDLE";
                UI_State_Lbl.ForeColor = Color.Blue;
            }

            //on valid right click randomize lines
            canvas.GetLastMouseRightClick(out clickRight);
            if(clickRight != prevRightClick)
            {
                prevRightClick = clickRight;
                ChangeLines();
            }
        }

        //********************************************************************************************
        //Method: private void ChangeLines()
        //Purpose: copies list and randomizes color and thickness
        //*********************************************************************************************
        private void ChangeLines()
        {
            canvas.Clear();
            List<SLine> modLines = new List<SLine>(); //list of modified lines
            Random random = new Random(); //random thickness generator

            foreach (SLine line in lines)
            {
                modLines.Add(new SLine(line.startPoint, line.endPoint, RandColor.GetColor(), (byte)random.Next(1, 16)));
            }
            lines = new List<SLine>(modLines);
            canvas.Clear();
            Render();
        }
    }
}
