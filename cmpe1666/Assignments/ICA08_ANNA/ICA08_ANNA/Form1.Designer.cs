namespace ICA08_ANNA
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
            this.UI_Sorted_Tbx = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // UI_Sorted_Tbx
            // 
            this.UI_Sorted_Tbx.Location = new System.Drawing.Point(531, 74);
            this.UI_Sorted_Tbx.Multiline = true;
            this.UI_Sorted_Tbx.Name = "UI_Sorted_Tbx";
            this.UI_Sorted_Tbx.ReadOnly = true;
            this.UI_Sorted_Tbx.Size = new System.Drawing.Size(257, 320);
            this.UI_Sorted_Tbx.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UI_Sorted_Tbx);
            this.Name = "Form1";
            this.Text = "ICA08";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UI_Sorted_Tbx;
    }
}

