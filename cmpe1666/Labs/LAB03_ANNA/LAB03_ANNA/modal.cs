using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace LAB03_ANNA
{
    public partial class modal : Form
    {
        public int difficulty
        {
            get
            {
                if (UI_Easy_Radbtn.Checked) return 3;
                else if (UI_Med_RadBtn.Checked) return 4;
                else return 5;
            }
        }

        public modal()
        {
            InitializeComponent();
        }

        private void UI_OK_Btn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void UI_Cancel_Btn_Click(object sender, EventArgs e)
        {
            DialogResult= DialogResult.Cancel;  
        }
    }
}
