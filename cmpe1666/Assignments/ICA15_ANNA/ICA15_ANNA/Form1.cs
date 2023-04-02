/* 
 * ICA #15 - Color Analyzer (CMPE1666)
 * 
 * Analyzes bitmaps using threads
 *
 * Author: Anna Lesburg
 * 
 * Modification History:
 * 02 APR 2023 - Created, tested, finished
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
    public delegate void delDisplay(string filename, double rPercent, double gPercent, double bPercent);
    public partial class Form1 : Form
    {
        delDisplay delDisplay;
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
            Bitmap bm;
            int rTotal = 0;
            int gTotal = 0;
            int bTotal = 0;
            int total;
            double rPercent;
            double gPercent;
            double bPercent;

            if (arg is string filename)
            {
                try
                {
                    delDisplay = Display;
                    bm = (Bitmap)Bitmap.FromFile(filename);
                    for (int x = 0; x < bm.Width; x++)
                    {
                        for (int y = 0; y < bm.Height; y++)
                        {
                            Color rgb = bm.GetPixel(x, y);
                            rTotal += rgb.R;
                            gTotal += rgb.G;
                            bTotal += rgb.B;
                        }
                    }
                    total = rTotal + gTotal + bTotal;
                    rPercent = (double)rTotal / total;
                    gPercent = (double)gTotal/ total;
                    bPercent = (double)bTotal/ total;
                    Invoke(delDisplay, filename, rPercent, gPercent, bPercent);
                }
                catch (Exception ex)
                {
                    return;
                }
            }
        }

        private void Display(string filename,double rPercent, double gPercent, double bPercent)
        {
            UI_Listbx.Items.Add($"(R:{rPercent:P1}, G:{gPercent:P1}, B:{bPercent:P1}) : {filename}");
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            bool running = false;
            foreach(Thread thread in threads)
            {
                if (thread.IsAlive) running = true;
            }
            if (!running)
            {
                timer.Stop();
                UI_Listbx.Items.Add("Done..");
            }
        }
    }
}
