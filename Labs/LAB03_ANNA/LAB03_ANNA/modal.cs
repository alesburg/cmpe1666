using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace LAB03_ANNA
{
    public partial class modal : Form
    {
        int selection = 3;
        public int difficulty
        {
            get
            {
                return selection;
            }
            set
            {
                selection = value;
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
            DialogResult = DialogResult.Cancel;  
        }

        private void UI_Radbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (UI_Easy_Radbtn.Checked) selection = 3;
            else if (UI_Med_RadBtn.Checked) selection = 4;
            else if (UI_Hard_Radbtn.Checked) selection = 5;
        }
    }
}
