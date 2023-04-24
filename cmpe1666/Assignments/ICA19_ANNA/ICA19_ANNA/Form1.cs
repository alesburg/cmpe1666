/* 
 * Assignment #19 - Collections, Predicates and Lambda Expressions (CMPE1666)
 * 
 * Collections, Predicates and Lambda Expressions
 *
 * Author: Anna Lesburg
 * 
 * Modification History:
 * 22 APR 2023 - Created, finished, and tested
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

namespace ICA19_ANNA
{
    public partial class Form1 : Form
    {
        public struct Sensor
        {
            public int SensorId;
            public double temperature;

            public Sensor(int SensorId, double temperature)
            {
                this.SensorId = SensorId;
                this.temperature = temperature;
            }

            public override string ToString()
            {
                return $"Sensor Id: {SensorId}, Temperature: {temperature}";
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void UI_GenSensors_Btn_Click(object sender, EventArgs e)
        {
            int numSensors;
            Random random = new Random();

            if(int.TryParse(UI_SensorNum_Tbx.Text,out numSensors))
            {
                for(int i = 0; i < numSensors; i++)
                {

                }
            }
        }
    }
}
