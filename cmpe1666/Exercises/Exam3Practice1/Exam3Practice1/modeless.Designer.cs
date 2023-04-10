namespace Exam3Practice1
{
    partial class modeless
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
            this.UI_Val1_Txtbx = new System.Windows.Forms.TextBox();
            this.UI_Val1_Lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UI_Val1_Txtbx
            // 
            this.UI_Val1_Txtbx.Location = new System.Drawing.Point(151, 44);
            this.UI_Val1_Txtbx.Name = "UI_Val1_Txtbx";
            this.UI_Val1_Txtbx.Size = new System.Drawing.Size(100, 22);
            this.UI_Val1_Txtbx.TabIndex = 0;
            // 
            // UI_Val1_Lbl
            // 
            this.UI_Val1_Lbl.AutoSize = true;
            this.UI_Val1_Lbl.Location = new System.Drawing.Point(90, 47);
            this.UI_Val1_Lbl.Name = "UI_Val1_Lbl";
            this.UI_Val1_Lbl.Size = new System.Drawing.Size(55, 16);
            this.UI_Val1_Lbl.TabIndex = 1;
            this.UI_Val1_Lbl.Text = "Value 1:";
            // 
            // modeless
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 210);
            this.Controls.Add(this.UI_Val1_Lbl);
            this.Controls.Add(this.UI_Val1_Txtbx);
            this.Name = "modeless";
            this.Text = "modeless";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UI_Val1_Txtbx;
        private System.Windows.Forms.Label UI_Val1_Lbl;
    }
}