/* 
 * ICA #15 - Color Analyzer (CMPE1666)
 * 
 * Analyzes bitmaps using threads
 *
 * Author: Anna Lesburg
 * 
 * Modification History:
 * 02 APR 2023 - Created 
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
using System.Threading;

namespace ICA15_ANNA
{
    public partial class Form1 : Form
    {
        List<Thread> threads = new List<Thread>(); //list of threads
        public Form1()
        {
            InitializeComponent();
        }

        private void UI_Go_Btn_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "All Files (Images) | *.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                UI_Listbx.Items.Clear();
                UI_Listbx.Items.Add("Starting...");
                timer.Start();
                foreach(string filename in openFileDialog.FileNames)
                {
                    Thread th = new Thread(new ParameterizedThreadStart(ProcessImage));
                    th.IsBackground = true;
                    threads.Add(th);
                    th.Start(filename);
                }
            }
        }

        private void ProcessImage(object arg)
        {
            int rTotal = 0;
            int gTotal = 0;
            int bTotal = 0;
            if (arg is string filename)
            {
                try
                {
                    Bitmap bm = (Bitmap)Bitmap.FromFile(filename);
                    for (int x = 0; x < bm.Width; x++)
                    {
                        for (int y = 0; y < bm.Height; y++)
                        {
                            Color rgb = bm.GetPixel(x, y);
                            rTotal += rgb.R;
                            g = rgb.G;
                            b = rgb.B;
                        }
                    }
                }
                catch (Exception ex)
                {
                    return;
                }
            }
            
        }
    }
}
