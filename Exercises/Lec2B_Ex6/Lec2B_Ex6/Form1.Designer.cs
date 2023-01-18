namespace Lec2B_Ex6
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UI_Name_Tbx = new System.Windows.Forms.TextBox();
            this.UI_Display_Tbx = new System.Windows.Forms.TextBox();
            this.UI_Name_Lbl = new System.Windows.Forms.Label();
            this.UI_Display_Lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UI_Name_Tbx
            // 
            this.UI_Name_Tbx.Location = new System.Drawing.Point(325, 98);
            this.UI_Name_Tbx.Name = "UI_Name_Tbx";
            this.UI_Name_Tbx.Size = new System.Drawing.Size(100, 22);
            this.UI_Name_Tbx.TabIndex = 0;
            this.UI_Name_Tbx.TextChanged += new System.EventHandler(this.UI_Name_Tbx_TextChanged);
            // 
            // UI_Display_Tbx
            // 
            this.UI_Display_Tbx.Location = new System.Drawing.Point(325, 172);
            this.UI_Display_Tbx.Name = "UI_Display_Tbx";
            this.UI_Display_Tbx.ReadOnly = true;
            this.UI_Display_Tbx.Size = new System.Drawing.Size(100, 22);
            this.UI_Display_Tbx.TabIndex = 1;
            // 
            // UI_Name_Lbl
            // 
            this.UI_Name_Lbl.AutoSize = true;
            this.UI_Name_Lbl.Location = new System.Drawing.Point(272, 104);
            this.UI_Name_Lbl.Name = "UI_Name_Lbl";
            this.UI_Name_Lbl.Size = new System.Drawing.Size(47, 16);
            this.UI_Name_Lbl.TabIndex = 2;
            this.UI_Name_Lbl.Text = "Name:";
            // 
            // UI_Display_Lbl
            // 
            this.UI_Display_Lbl.AutoSize = true;
            this.UI_Display_Lbl.Location = new System.Drawing.Point(234, 175);
            this.UI_Display_Lbl.Name = "UI_Display_Lbl";
            this.UI_Display_Lbl.Size = new System.Drawing.Size(85, 16);
            this.UI_Display_Lbl.TabIndex = 3;
            this.UI_Display_Lbl.Text = "Name Given:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UI_Display_Lbl);
            this.Controls.Add(this.UI_Name_Lbl);
            this.Controls.Add(this.UI_Display_Tbx);
            this.Controls.Add(this.UI_Name_Tbx);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UI_Name_Tbx;
        private System.Windows.Forms.TextBox UI_Display_Tbx;
        private System.Windows.Forms.Label UI_Name_Lbl;
        private System.Windows.Forms.Label UI_Display_Lbl;
    }
}

