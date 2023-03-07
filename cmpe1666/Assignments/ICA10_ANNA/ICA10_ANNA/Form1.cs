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
        public Form1()
        {
            InitializeComponent();
        }
    }
}
