namespace ICA13_ANNA
{
    partial class colorForm
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
            this.UI_R_Trckbar = new System.Windows.Forms.TrackBar();
            this.UI_RGB_Grpbx = new System.Windows.Forms.GroupBox();
            this.UI_G_Trckbar = new System.Windows.Forms.TrackBar();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.UI_Opacity_Grpbx = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.UI_R_Trckbar)).BeginInit();
            this.UI_RGB_Grpbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UI_G_Trckbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // UI_R_Trckbar
            // 
            this.UI_R_Trckbar.Location = new System.Drawing.Point(6, 21);
            this.UI_R_Trckbar.Maximum = 255;
            this.UI_R_Trckbar.Name = "UI_R_Trckbar";
            this.UI_R_Trckbar.Size = new System.Drawing.Size(824, 56);
            this.UI_R_Trckbar.TabIndex = 0;
            this.UI_R_Trckbar.TickFrequency = 16;
            // 
            // UI_RGB_Grpbx
            // 
            this.UI_RGB_Grpbx.Controls.Add(this.trackBar1);
            this.UI_RGB_Grpbx.Controls.Add(this.UI_G_Trckbar);
            this.UI_RGB_Grpbx.Controls.Add(this.UI_R_Trckbar);
            this.UI_RGB_Grpbx.Location = new System.Drawing.Point(12, 12);
            this.UI_RGB_Grpbx.Name = "UI_RGB_Grpbx";
            this.UI_RGB_Grpbx.Size = new System.Drawing.Size(836, 197);
            this.UI_RGB_Grpbx.TabIndex = 1;
            this.UI_RGB_Grpbx.TabStop = false;
            this.UI_RGB_Grpbx.Text = "Color";
            // 
            // UI_G_Trckbar
            // 
            this.UI_G_Trckbar.Location = new System.Drawing.Point(6, 77);
            this.UI_G_Trckbar.Maximum = 255;
            this.UI_G_Trckbar.Name = "UI_G_Trckbar";
            this.UI_G_Trckbar.Size = new System.Drawing.Size(824, 56);
            this.UI_G_Trckbar.TabIndex = 1;
            this.UI_G_Trckbar.TickFrequency = 16;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(6, 133);
            this.trackBar1.Maximum = 255;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(824, 56);
            this.trackBar1.TabIndex = 2;
            this.trackBar1.TickFrequency = 16;
            // 
            // UI_Opacity_Grpbx
            // 
            this.UI_Opacity_Grpbx.Location = new System.Drawing.Point(12, 225);
            this.UI_Opacity_Grpbx.Name = "UI_Opacity_Grpbx";
            this.UI_Opacity_Grpbx.Size = new System.Drawing.Size(830, 94);
            this.UI_Opacity_Grpbx.TabIndex = 2;
            this.UI_Opacity_Grpbx.TabStop = false;
            this.UI_Opacity_Grpbx.Text = "groupBox1";
            // 
            // colorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 331);
            this.Controls.Add(this.UI_Opacity_Grpbx);
            this.Controls.Add(this.UI_RGB_Grpbx);
            this.Name = "colorForm";
            this.Text = "colorForm";
            ((System.ComponentModel.ISupportInitialize)(this.UI_R_Trckbar)).EndInit();
            this.UI_RGB_Grpbx.ResumeLayout(false);
            this.UI_RGB_Grpbx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UI_G_Trckbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TrackBar UI_R_Trckbar;
        private System.Windows.Forms.GroupBox UI_RGB_Grpbx;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar UI_G_Trckbar;
        private System.Windows.Forms.GroupBox UI_Opacity_Grpbx;
    }
}