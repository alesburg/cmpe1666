/* 
 * ICA #10 - Sorting Structs (CMPE1666)
 * 
 * Forms application that draws and manipulates lines using structs
 *
 * Author: Anna Lesburg
 * 
 * Modification History:
 * 7 MAR 2023 - Created
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GDIDrawer;

namespace ICA10_ANNA
{
    public partial class Form1 : Form
    {
        public struct SLine
        {
            public Point startPoint;
            public Point endPoint;
            public Color lineColor;
            public byte thickness;

            //constructor
            public SLine(Point startPoint, Point endPoint , Color lineColor, byte thickness)
            {
                this.startPoint = startPoint;
                this.endPoint = endPoint;
                this.lineColor = lineColor;
                this.thickness = thickness;
            }
        }

        CDrawer canvas;
        Point startPoint;
        List<SLine> lines;
        eState state;
        private enum eState { State_Idle, State_Armed}
        public Form1()
        {
            InitializeComponent();
        }

        private void Render(SLine line)
        {
            canvas.AddLine(line.startPoint.X,line.startPoint.Y,line.endPoint.X,line.endPoint.Y,line.lineColor,line.thickness);
            canvas.Render();
        }

        private void Render()
        {
            canvas.Clear();
            foreach(SLine line in lines)
            {
                Render(line);
            }
            canvas.Render();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            canvas = new CDrawer(800,800,false,false);
            state = eState.State_Idle;
        }

        private void MouseTimer_Tick(object sender, EventArgs e)
        {
            if (state == eState.State_Armed)
            {
                Point endPoint;
                canvas.GetLastMouseLeftClick(out endPoint);
                SLine line = new SLine(startPoint,endPoint,Color.Red,5);
                Render(line);
                state= eState.State_Idle;
            }
            else
            {
                canvas.GetLastMouseLeftClick(out startPoint);
                state = eState.State_Armed;
            }
        }
    }
}
