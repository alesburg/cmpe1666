using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam3Practice1
{
    public partial class Form1 : Form
    {
        modeless modeless;
        public Form1()
        {
            InitializeComponent();
        }

        private void UI_Show_Chkbx_CheckedChanged(object sender, EventArgs e)
        {
            if (UI_Show_Chkbx.Checked) modeless.Show();
            else modeless.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            modeless= new modeless();
            modeless._Show = CallbackShow;
            modeless._Result = CallbackResult;
        }

        private void CallbackShow(bool show)
        {
            UI_Show_Chkbx.Checked = show;
        }

        private void CallbackResult(int result)
        {
            UI_Result_Tbx.Text = result.ToString();
        }
    }
}
