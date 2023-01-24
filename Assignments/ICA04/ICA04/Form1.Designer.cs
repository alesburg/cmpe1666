namespace ICA04
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
            this.UI_Units_Grpbox = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // UI_Units_Grpbox
            // 
            this.UI_Units_Grpbox.Location = new System.Drawing.Point(12, 12);
            this.UI_Units_Grpbox.Name = "UI_Units_Grpbox";
            this.UI_Units_Grpbox.Size = new System.Drawing.Size(316, 100);
            this.UI_Units_Grpbox.TabIndex = 0;
            this.UI_Units_Grpbox.TabStop = false;
            this.UI_Units_Grpbox.Text = "Input Units";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 295);
            this.Controls.Add(this.UI_Units_Grpbox);
            this.Name = "Form1";
            this.Text = "Speed Conversion";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox UI_Units_Grpbox;
    }
}

