using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICA11_ANNA
{
    public partial class Format : Form
    {

        //properties
        public Font dialogFont
        {
            get
            {
                return fontDialog.Font;
            }
            set
            {
                fontDialog.Font = value;
            }
        }
        public Color dialogColor
        {
            get
            {
                return colorDialog.Color;
            }
            set
            {
                colorDialog.Color = value;
            }
        }
        public Format()
        {
            InitializeComponent();
        }

        private void UI_FormatOK_Btn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void UI_Font_Btn_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.Font = dialogFont;

            //when ok button clicked set textbox and label
            if(fontDialog.ShowDialog() == DialogResult.OK)
            {
                UI_Font_Txtbx.Text = fontDialog.Font.ToString();
                dialogFont = fontDialog.Font;
            }
        }

        private void UI_Color_Btn_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            fontDialog.Color = dialogColor;
             
            //when ok button clicked set textbox and label
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                UI_Color_Txtbx.Text = colorDialog.Color.ToString();
                dialogColor = colorDialog.Color;
            }
        }

        //on load get preview label properties in textboxes
        private void Format_Load(object sender, EventArgs e)
        {
            UI_Color_Txtbx.Text = dialogColor.ToString();
            UI_Font_Txtbx.Text = dialogFont.ToString();
        }
    }
}
