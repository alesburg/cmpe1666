namespace ICA13_ANNA
{
    partial class Color
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
            this.UI_Color_Grpbx = new System.Windows.Forms.GroupBox();
            this.UI_Opacity_Grpbx = new System.Windows.Forms.GroupBox();
            this.UI_R_Trckbar = new System.Windows.Forms.TrackBar();
            this.UI_G_Trckbar = new System.Windows.Forms.TrackBar();
            this.UI_B_Trckbar = new System.Windows.Forms.TrackBar();
            this.UI_A_Trckbar = new System.Windows.Forms.TrackBar();
            this.UI_Color_Grpbx.SuspendLayout();
            this.UI_Opacity_Grpbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UI_R_Trckbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UI_G_Trckbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UI_B_Trckbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UI_A_Trckbar)).BeginInit();
            this.SuspendLayout();
            // 
            // UI_Color_Grpbx
            // 
            this.UI_Color_Grpbx.Controls.Add(this.UI_B_Trckbar);
            this.UI_Color_Grpbx.Controls.Add(this.UI_G_Trckbar);
            this.UI_Color_Grpbx.Controls.Add(this.UI_R_Trckbar);
            this.UI_Color_Grpbx.Location = new System.Drawing.Point(12, 12);
            this.UI_Color_Grpbx.Name = "UI_Color_Grpbx";
            this.UI_Color_Grpbx.Size = new System.Drawing.Size(786, 202);
            this.UI_Color_Grpbx.TabIndex = 0;
            this.UI_Color_Grpbx.TabStop = false;
            this.UI_Color_Grpbx.Text = "Color";
            // 
            // UI_Opacity_Grpbx
            // 
            this.UI_Opacity_Grpbx.Controls.Add(this.UI_A_Trckbar);
            this.UI_Opacity_Grpbx.Location = new System.Drawing.Point(12, 220);
            this.UI_Opacity_Grpbx.Name = "UI_Opacity_Grpbx";
            this.UI_Opacity_Grpbx.Size = new System.Drawing.Size(786, 88);
            this.UI_Opacity_Grpbx.TabIndex = 1;
            this.UI_Opacity_Grpbx.TabStop = false;
            this.UI_Opacity_Grpbx.Text = "Opacity";
            // 
            // UI_R_Trckbar
            // 
            this.UI_R_Trckbar.Location = new System.Drawing.Point(6, 21);
            this.UI_R_Trckbar.Maximum = 255;
            this.UI_R_Trckbar.Name = "UI_R_Trckbar";
            this.UI_R_Trckbar.Size = new System.Drawing.Size(774, 56);
            this.UI_R_Trckbar.TabIndex = 0;
            this.UI_R_Trckbar.TickFrequency = 16;
            // 
            // UI_G_Trckbar
            // 
            this.UI_G_Trckbar.Location = new System.Drawing.Point(6, 77);
            this.UI_G_Trckbar.Maximum = 255;
            this.UI_G_Trckbar.Name = "UI_G_Trckbar";
            this.UI_G_Trckbar.Size = new System.Drawing.Size(774, 56);
            this.UI_G_Trckbar.TabIndex = 1;
            this.UI_G_Trckbar.TickFrequency = 16;
            // 
            // UI_B_Trckbar
            // 
            this.UI_B_Trckbar.Location = new System.Drawing.Point(6, 133);
            this.UI_B_Trckbar.Maximum = 255;
            this.UI_B_Trckbar.Name = "UI_B_Trckbar";
            this.UI_B_Trckbar.Size = new System.Drawing.Size(774, 56);
            this.UI_B_Trckbar.TabIndex = 2;
            this.UI_B_Trckbar.TickFrequency = 16;
            // 
            // UI_A_Trckbar
            // 
            this.UI_A_Trckbar.Location = new System.Drawing.Point(6, 26);
            this.UI_A_Trckbar.Maximum = 100;
            this.UI_A_Trckbar.Name = "UI_A_Trckbar";
            this.UI_A_Trckbar.Size = new System.Drawing.Size(774, 56);
            this.UI_A_Trckbar.TabIndex = 3;
            this.UI_A_Trckbar.TickFrequency = 0;
            this.UI_A_Trckbar.Value = 100;
            // 
            // Color
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 320);
            this.Controls.Add(this.UI_Opacity_Grpbx);
            this.Controls.Add(this.UI_Color_Grpbx);
            this.Name = "Color";
            this.Text = "Color";
            this.UI_Color_Grpbx.ResumeLayout(false);
            this.UI_Color_Grpbx.PerformLayout();
            this.UI_Opacity_Grpbx.ResumeLayout(false);
            this.UI_Opacity_Grpbx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UI_R_Trckbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UI_G_Trckbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UI_B_Trckbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UI_A_Trckbar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox UI_Color_Grpbx;
        private System.Windows.Forms.TrackBar UI_B_Trckbar;
        private System.Windows.Forms.TrackBar UI_G_Trckbar;
        private System.Windows.Forms.TrackBar UI_R_Trckbar;
        private System.Windows.Forms.GroupBox UI_Opacity_Grpbx;
        private System.Windows.Forms.TrackBar UI_A_Trckbar;
    }
}