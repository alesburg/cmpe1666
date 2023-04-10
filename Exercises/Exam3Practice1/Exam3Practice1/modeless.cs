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
    public delegate void delShow(bool show);
    public delegate void delResult(int result);
    public partial class modeless : Form
    {
        public delShow _Show = null;
        public delResult _Result = null;
        public modeless()
        {
            InitializeComponent();
        }

        private void modeless_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                _Show.Invoke(false);
                e.Cancel = true;
                Hide();
            }
        }

        private int Calc()
        {
            int val1;
            int val2;
            bool success = false;
            if (UI_Val1_Txtbx.Text == "" || UI_Val2_Tbx.Text == "") return 0;

            success = int.TryParse(UI_Val1_Txtbx.Text, out val1);
            success = int.TryParse(UI_Val2_Tbx.Text, out val2);
            if (success)
            {
                if (UI_Add_RadBtn.Checked) return (val1 + val2);
                else if (UI_Subtract_RadBtn.Checked) return (val1 - val2);
                else return (val1 * val2);
            }
            else
            {
                return 0;
            }
        }

        private void UI_Changed(object sender, EventArgs e)
        {
            _Result.Invoke(Calc());
        }
    }
}
