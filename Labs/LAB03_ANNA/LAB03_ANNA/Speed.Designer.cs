namespace LAB03_ANNA
{
    partial class Speed
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
            this.UI_Speed_Trckbar = new System.Windows.Forms.TrackBar();
            this.UI_Min_Lbl = new System.Windows.Forms.Label();
            this.UI_Max_Lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UI_Speed_Trckbar)).BeginInit();
            this.SuspendLayout();
            // 
            // UI_Speed_Trckbar
            // 
            this.UI_Speed_Trckbar.Location = new System.Drawing.Point(12, 12);
            this.UI_Speed_Trckbar.Name = "UI_Speed_Trckbar";
            this.UI_Speed_Trckbar.Size = new System.Drawing.Size(338, 56);
            this.UI_Speed_Trckbar.TabIndex = 0;
            // 
            // UI_Min_Lbl
            // 
            this.UI_Min_Lbl.AutoSize = true;
            this.UI_Min_Lbl.Location = new System.Drawing.Point(13, 51);
            this.UI_Min_Lbl.Name = "UI_Min_Lbl";
            this.UI_Min_Lbl.Size = new System.Drawing.Size(42, 16);
            this.UI_Min_Lbl.TabIndex = 1;
            this.UI_Min_Lbl.Text = "10 ms";
            // 
            // UI_Max_Lbl
            // 
            this.UI_Max_Lbl.AutoSize = true;
            this.UI_Max_Lbl.Location = new System.Drawing.Point(301, 52);
            this.UI_Max_Lbl.Name = "UI_Max_Lbl";
            this.UI_Max_Lbl.Size = new System.Drawing.Size(49, 16);
            this.UI_Max_Lbl.TabIndex = 2;
            this.UI_Max_Lbl.Text = "200 ms";
            // 
            // Speed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 78);
            this.Controls.Add(this.UI_Max_Lbl);
            this.Controls.Add(this.UI_Min_Lbl);
            this.Controls.Add(this.UI_Speed_Trckbar);
            this.Name = "Speed";
            this.Text = "Animation Speed";
            ((System.ComponentModel.ISupportInitialize)(this.UI_Speed_Trckbar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar UI_Speed_Trckbar;
        private System.Windows.Forms.Label UI_Min_Lbl;
        private System.Windows.Forms.Label UI_Max_Lbl;
    }
}