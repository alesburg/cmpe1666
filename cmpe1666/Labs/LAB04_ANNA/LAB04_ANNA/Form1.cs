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
        Point leftclick; //left click for start of line
        Point mousepos; //mouse position
        Point rightclick; //right click for end of line

        public Form1()
        {
            InitializeComponent();
        }

        //every 10ms
        private void timer_Tick(object sender, EventArgs e)
        {
            //if not drawing and new left click detected - start line 
            if (!drawing && canvas.GetLastMouseLeftClick(out leftclick))
            {
                drawing = true;
                lastMousePos = leftclick;
                lineStack.Push(new LinkedList<LineSeg>());
            }
            //if drawing and mouse is moved - add line segment
            else if (drawing && canvas.GetLastMousePosition(out mousepos))
            {
                lineStack.Peek().AddLast(new LineSeg(lastMousePos, mousepos,(byte)UI_Thickness_Trkbar.Value,1,colorDialog.Color)); //alpha???
                canvas.AddLine(lastMousePos.X, lastMousePos.Y, mousepos.X, mousepos.Y, colorDialog.Color, (byte)UI_Thickness_Trkbar.Value);
                lastMousePos = mousepos;
            }
            //if drawing and new right click detected - end line
            else if (drawing && canvas.GetLastMouseRightClick(out rightclick))
            {
                drawing = false;
            }

            //call status update
            UpdateUI();
        }

        //on load
        private void Form1_Load(object sender, EventArgs e)
        {
            lineStack = new Stack<LinkedList<LineSeg>>(); //initialize line stack
            canvas = new CDrawer(1024, 768); //initialize GDIDrawer
            timer.Start(); //start timer
            drawing = false; //not drawing
            //lastMousePos = new Point(-1, -1);
            colorDialog.Color = Color.Red;
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

            if (lineStack.Count < 1 || lineStack.Peek().Count < 2) UI_Reduce_Btn.Enabled = false;
            else UI_Reduce_Btn.Enabled = true;

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
                
            if(lineStack.Count > 0 && lineStack.Peek().Count > 0) lineStack.Peek().RemoveLast();
            if (lineStack.Peek().Count == 0) lineStack.Pop();

            RenderAll();
        }

        private void UI_Reduce_Btn_Click(object sender, EventArgs e)
        {
            if(UpdateUI() > 1)
            {
                
            }
        }

        private void UI_Color_Btn_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
        }

        private void UI_Thickness_Trkbar_Scroll(object sender, EventArgs e)
        {
            UI_Thickness_Lbl.Text = $"Thickness: {UI_Thickness_Trkbar.Value}";
        }
    }
}
