/* 
 * LAB #04 - Stacky List Draw (CMPE1666)
 * 
 * Drawing application using stack of linked lists
 *
 * Author: Anna Lesburg
 * 
 * Modification History:
 * 22 APR 2023 - Created
 * 24 APR 2023 - Finished and tested (except for reduce complexity)
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
            public int alpha;
            public Color color;

            //constructor
            public LineSeg(Point start, Point end, byte thickness, int alpha, Color color)
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
                lineStack.Peek().AddLast(new LineSeg(lastMousePos, mousepos, (byte)UI_Thickness_Trkbar.Value, UI_Opacity_Trckbar.Value, colorDialog.Color));
                canvas.AddLine(lastMousePos.X, lastMousePos.Y, mousepos.X, mousepos.Y, Color.FromArgb(UI_Opacity_Trckbar.Value,colorDialog.Color.R,colorDialog.Color.G,colorDialog.Color.B), (byte)UI_Thickness_Trkbar.Value);
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
            colorDialog.Color = Color.Red; //default color
            UpdateUI(); //call status update
        }

        //********************************************************************************************
        //Method: private int UpdateUI()
        //Purpose: Updates status label for line and segment count
        //Returns: int - segments total
        //********************************************************************************************
        private int UpdateUI()
        {
            //iterate over linked lists in stack to count segments
            int segcount = 0;
            foreach (LinkedList<LineSeg> l in lineStack)
            {
                segcount += l.Count;
            }
            UI_Status_Label.Text = $"{lineStack.Count} lines, {segcount} total segments.";


            //enable/disable UI buttons
            if (lineStack.Count < 1) UI_UndoLine_Btn.Enabled = false;
            else UI_UndoLine_Btn.Enabled = true;

            if (lineStack.Count < 1 || lineStack.Peek().Count < 1) UI_UndoSeg_Btn.Enabled = false;
            else UI_UndoSeg_Btn.Enabled = true;

            if (lineStack.Count < 1 || lineStack.Peek().Count < 2) UI_Reduce_Btn.Enabled = false;
            else UI_Reduce_Btn.Enabled = true;

            return segcount;
        }

        //********************************************************************************************
        //Method:  private void RenderAll()
        //Purpose: Clears and re-renders all lines from list
        //********************************************************************************************
        private void RenderAll()
        {
            canvas.Clear();
            foreach (LinkedList<LineSeg> l in lineStack)
            {
                foreach (LineSeg line in l)
                {
                    canvas.AddLine(line.start.X, line.start.Y, line.end.X, line.end.Y, Color.FromArgb(line.alpha,line.color), line.thickness);
                }
            }
        }

        //undo line button
        private void UI_UndoLine_Btn_Click(object sender, EventArgs e)
        {
            drawing = false;
            if (lineStack.Count > 0) lineStack.Pop();
            RenderAll();
        }

        //undo segment button
        private void UI_UndoSeg_Btn_Click(object sender, EventArgs e)
        {
            drawing = false;

            if (lineStack.Count > 0 && lineStack.Peek().Count > 0) lineStack.Peek().RemoveLast();
            if (lineStack.Peek().Count == 0) lineStack.Pop();

            RenderAll();
        }

        //reduce complexity button
        private void UI_Reduce_Btn_Click(object sender, EventArgs e)
        {
            //if more than 2 segments in current line
            if (lineStack.Peek().Count > 1)
            {
                LinkedList<LineSeg> temp = new LinkedList<LineSeg>(); //temporary list for updated line

                //iterate over line segments
                for(LinkedListNode<LineSeg> node = lineStack.Peek().First; node != lineStack.Peek().Last && node != null; node = node.Next.Next)
                {
                    //add simplified segment to new list
                    if(lineStack.Peek().Count > 1 && node.Next != null) temp.AddLast(new LineSeg(node.Value.start, node.Next.Value.end, node.Value.thickness, node.Value.alpha, node.Value.color));
                }

                //replace old line with new line
                lineStack.Pop();
                lineStack.Push(temp);
                RenderAll();
            }
        }

        //color button
        private void UI_Color_Btn_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
        }

        //update trackbar labels
        private void UI_Thickness_Trkbar_Scroll(object sender, EventArgs e)
        {
            UI_Thickness_Lbl.Text = $"Thickness: {UI_Thickness_Trkbar.Value}";
        }

        private void UI_Opacity_Trckbar_Scroll(object sender, EventArgs e)
        {
            UI_Opacity_Lbl.Text = $"Opacity: {UI_Opacity_Trckbar.Value}";
        }
    }
}
