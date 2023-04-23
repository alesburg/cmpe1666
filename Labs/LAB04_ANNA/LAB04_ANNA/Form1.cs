/* 
 * LAB #04 - Stacky List Draw (CMPE1666)
 * 
 * Drawing application using stack of linked lists
 *
 * Author: Anna Lesburg
 * 
 * Modification History:
 * 22 APR 2023 - Created
 * 23 APR 2023 - Finished and tested
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
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
        Point leftclick = new Point(-1, -1); //left click for start of line
        Point mousepos = new Point(-1, -1); //mouse position
        Point rightclick = new Point(-1, -1); //right click for end of line

        public Form1()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (!drawing && canvas.GetLastMouseLeftClick(out leftclick))
            {
                drawing = true;
                lastMousePos = leftclick;
                lineStack.Push(new LinkedList<LineSeg>());
            }
            else if (drawing && canvas.GetLastMousePosition(out mousepos))
            {
                lineStack.Peek().AddLast(new LineSeg(lastMousePos, mousepos,2,1,Color.Red)); //placeholder thickness, alpha, color
                canvas.AddLine(lastMousePos.X, lastMousePos.Y, mousepos.X, mousepos.Y, Color.Red, 2);
                lastMousePos = mousepos;
            }
            else if (drawing && canvas.GetLastMouseRightClick(out rightclick))
            {
                drawing = false;
            }

            UpdateUI();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lineStack = new Stack<LinkedList<LineSeg>>();
            canvas = new CDrawer(1024, 768);
            timer.Start();
            drawing = false;
            lastMousePos = new Point(-1, -1);
            UpdateUI();
        }

        private int UpdateUI()
        {
            int segcount = 0;
            foreach (LinkedList<LineSeg> l in lineStack)
            {
                segcount += l.Count;
            }
            UI_Status_Label.Text = $"{lineStack.Count} lines, {segcount} total segments.";

            if (lineStack.Count < 1) UI_UndoLine_Btn.Enabled = false;
            else UI_UndoLine_Btn.Enabled = true;

            if (lineStack.Count < 1 || lineStack.Peek().Count < 1) UI_UndoSeg_Btn.Enabled = false;
            else UI_UndoSeg_Btn.Enabled = true;

            return segcount;
        }

        private void RenderAll()
        {
            canvas.Clear();
           foreach(LinkedList<LineSeg> l in lineStack)
            {
                foreach(LineSeg line in l)
                {
                    canvas.AddLine(line.start.X,line.start.Y,line.end.X,line.end.Y,line.color,line.thickness);
                }
            }
        }

        private void UI_UndoLine_Btn_Click(object sender, EventArgs e)
        {
            drawing = false;
            if (lineStack.Count > 0) lineStack.Pop();
            RenderAll();
        }

        private void UI_UndoSeg_Btn_Click(object sender, EventArgs e)
        {
            drawing = false;
            if (lineStack.Peek().Count < 1 && lineStack.Count > 0) lineStack.Pop(); 
            else if(UpdateUI() > 0) lineStack.Peek().RemoveLast();
            
            RenderAll();
        }

        private void UI_Reduce_Btn_Click(object sender, EventArgs e)
        {

        }
    }
}
