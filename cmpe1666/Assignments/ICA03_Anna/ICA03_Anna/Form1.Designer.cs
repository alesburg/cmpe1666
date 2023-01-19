namespace ICA03_Anna
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
            this.UI_Timer_Lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UI_Timer_Lbl
            // 
            this.UI_Timer_Lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UI_Timer_Lbl.AutoSize = true;
            this.UI_Timer_Lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UI_Timer_Lbl.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_Timer_Lbl.Location = new System.Drawing.Point(38, 9);
            this.UI_Timer_Lbl.Name = "UI_Timer_Lbl";
            this.UI_Timer_Lbl.Size = new System.Drawing.Size(242, 35);
            this.UI_Timer_Lbl.TabIndex = 0;
            this.UI_Timer_Lbl.Text = "(0) 00:00:00.00";
            this.UI_Timer_Lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 450);
            this.Controls.Add(this.UI_Timer_Lbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UI_Timer_Lbl;
    }
}

