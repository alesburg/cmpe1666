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

namespace Exam3Practice2
{
    public delegate void delDisplay();
    public partial class Form1 : Form
    {
        List<int> fixedList;
        List<int> variableList;
        delDisplay display;

        public struct GenerateParameters
        {
            public int min;
            public int max;
            public int qty;

            public GenerateParameters(int min, int max, int qty)
            {
                this.min = min;
                this.max = max;
                this.qty = qty;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private static List<int> GenerateValues(int min, int max, int qty)
        {
            Random random= new Random();
            List<int> values = new List<int>();

            for(int i = 0; i < qty; i++)
            {
                values.Add(random.Next(min, max+1));
            }
            return values;
        }

        private void UI_GenerateFixed_Btn_Click(object sender, EventArgs e)
        {
            Thread FixedThread = new Thread(GenerateFixed);
            FixedThread.IsBackground = true;
            FixedThread.Start();
        }

        private void GenerateFixed()
        {
            fixedList = GenerateValues(0, 100, 40);
            display = DisplayFixed;
            Invoke(display);

        }
        
        private void DisplayFixed()
        {
            UI_Fixed_Lstbx.Items.Clear();
            foreach(int i in fixedList)
            {
                UI_Fixed_Lstbx.Items.Add(i);
            }
        }

        private void UI_GenerateVariable_Btn_Click(object sender, EventArgs e)
        {
            GenerateParameters parameters;
            int min;
            int max;
            int qty;

            int.TryParse(UI_Min_Tbx.Text, out min);
            int.TryParse(UI_Max_Tbx.Text, out max);
            int.TryParse(UI_Qty_Tbx.Text, out qty);
            parameters = new GenerateParameters(min, max, qty);

            Thread VariableThread = new Thread(new ParameterizedThreadStart(GenerateVariable));
            VariableThread.IsBackground=true;
            VariableThread.Start(parameters);
        }

        private void GenerateVariable(object obj)
        {
            if(obj is GenerateParameters)
            {
                GenerateParameters parameters = (GenerateParameters)obj;
                variableList = GenerateValues(parameters.min, parameters.max, parameters.qty);
                display = DisplayVariable;
                Invoke(display);
            }
        }

        private void DisplayVariable()
        {
            UI_Variable_Lstbx.Items.Clear();
            foreach (int i in variableList)
            {
                UI_Variable_Lstbx.Items.Add(i);
            }
        }
    }
}
