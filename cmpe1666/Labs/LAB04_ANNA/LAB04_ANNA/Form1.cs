/* 
 * LAB #04 - Stacky List Draw (CMPE1666)
 * 
 * Drawing application using stack of linked lists
 *
 * Author: Anna Lesburg
 * 
 * Modification History:
 * 22 APR 2023 - Created, finished and tested
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

namespace LAB04_ANNA
{
    public partial class Form1 : Form
    {
        //line segment struct
        public struct LineSeg
        {
            public Point start;
            public Point end;
            public byte thickness;
            public float alpha;
            public Color color;

            //constructor
            public LineSeg(Point start, Point end, byte thickness, float alpha, Color color)
            {
                this.start = start;
                this.end = end;
                this.thickness = thickness;
                this.alpha = alpha;
                this.color = color;
            }
        }

        Stack<LinkedList<LineSeg>> lineStack; //main stack
        CDrawer canvas; //cdrawer
        bool drawing; //currently drawing flag
        Point lastMousePos; //last mouse position

        public Form1()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Point leftclick = new Point(-1,-1); //left click for start of line
            Point mousepos = new Point(-1,-1); //mouse position
            Point rightclick = new Point(-1, -1) ; //right click for end of line

            canvas.GetLastMouseLeftClick(out leftclick);
            canvas.GetLastMousePosition(out mousepos);
            canvas.GetLastMouseRightClick(out rightclick);

            if(!drawing && leftclick != lastMousePos)
            {
                drawing = true;
                lastMousePos = leftclick;
                lineStack.Push(new LinkedList<LineSeg>());
            }else if(drawing && mousepos != lastMousePos)
            {
                lineStack.Peek().AddLast(new LineSeg(lastMousePos, mousepos,2,1,Color.Red)); //placeholder thickness, alpha, color
                canvas.AddLine(lastMousePos.X, lastMousePos.Y, mousepos.X, mousepos.Y, Color.Red, 2);
            }else if(drawing && rightclick != lastMousePos)
            {
                drawing = false;
            }

            UpdateUI();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lineStack= new Stack<LinkedList<LineSeg>>();
            canvas = new CDrawer(1024,768);
            timer.Start();
            drawing = false;
            lastMousePos = new Point(-1,-1);
            UpdateUI();
        }

        private void UpdateUI()
        {   int segcount = 0;
            foreach(LinkedList<LineSeg> l in lineStack)
            {
                segcount += l.Count;
            }
            UI_Status_Label.Text = $"{lineStack.Count} lines, {segcount} total segments.";
        }
    }
}
