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
    public delegate void delDisplay(string filename, double rPercent, double gPercent, double bPercent); //delegate to display to listbox
    public partial class Form1 : Form
    {
        delDisplay delDisplay; //delegate to display to listbox
        List<Thread> threads = new List<Thread>(); //list of threads
        public Form1()
        {
            InitializeComponent();
        }

        private void UI_Go_Btn_Click(object sender, EventArgs e)
        {
            //open file dialog
            openFileDialog.Filter = "All Files (Images) | *.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                UI_Listbx.Items.Add("Starting...");
                timer.Start();

                //iterate over files and start threads, add to list
                foreach (string filename in openFileDialog.FileNames)
                {
                    Thread th = new Thread(new ParameterizedThreadStart(ProcessImage));
                    th.IsBackground = true;
                    threads.Add(th);
                    th.Start(filename);
                }
            }
        }

        //********************************************************************************************
        //Method: private void ProcessImage(object arg)
        //Purpose: Processes image and calculates color ratios
        //Parameters: object arg - image filepath
        //*********************************************************************************************
        private void ProcessImage(object arg)
        {
            Bitmap bm; //bitmap
            int rTotal = 0; //sum of total red values
            int gTotal = 0; //sum of total green values
            int bTotal = 0; //sum of total blue values
            int total; //total color values
            double rPercent; //ratio of red values
            double gPercent; //ratio of green values
            double bPercent; //ratio of blue values

            //check for correct arguement
            if (arg is string filename)
            {
                try
                {
                    //attach method to delegate
                    delDisplay = Display;

                    //create bitmap
                    bm = (Bitmap)Bitmap.FromFile(filename);

                    //iterate over bitmap, sum color values
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
                    //calculate totals and ratios
                    total = rTotal + gTotal + bTotal;
                    rPercent = (double)rTotal / total;
                    gPercent = (double)gTotal / total;
                    bPercent = (double)bTotal / total;

                    //Invoke display thread
                    Invoke(delDisplay, filename, rPercent, gPercent, bPercent);
                }
                catch (Exception ex)
                {
                    return;
                }
            }
        }

        //********************************************************************************************
        //Method: private void Display(string filename,double rPercent, double gPercent, double bPercent)
        //Purpose: Displays processed image ratios to listbox
        //Parameters: string filename - file path to display
        //double rPercent - ratio of red values in image
        //double gPercent - ratio of green values in image
        //double bPercent - ratio of blue values in image
        //*********************************************************************************************
        private void Display(string filename, double rPercent, double gPercent, double bPercent)
        {
            UI_Listbx.Items.Add($"(R:{rPercent:P1}, G:{gPercent:P1}, B:{bPercent:P1}) : {filename}");
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            bool running = false;
            //iterate over threads, set flag if any are running
            foreach (Thread thread in threads)
            {
                if (thread.IsAlive) running = true;
            }

            //if all threads finished
            if (!running)
            {
                timer.Stop();
                UI_Listbx.Items.Add("Done..");
            }
        }
    }
}
