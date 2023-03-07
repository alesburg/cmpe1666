namespace ICA10_ANNA
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
            this.components = new System.ComponentModel.Container();
            this.MouseTimer = new System.Windows.Forms.Timer(this.components);
            this.UI_State_Lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MouseTimer
            // 
            this.MouseTimer.Enabled = true;
            this.MouseTimer.Interval = 50;
            this.MouseTimer.Tick += new System.EventHandler(this.MouseTimer_Tick);
            // 
            // UI_State_Lbl
            // 
            this.UI_State_Lbl.AutoSize = true;
            this.UI_State_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_State_Lbl.ForeColor = System.Drawing.Color.RoyalBlue;
            this.UI_State_Lbl.Location = new System.Drawing.Point(101, 67);
            this.UI_State_Lbl.Name = "UI_State_Lbl";
            this.UI_State_Lbl.Size = new System.Drawing.Size(167, 69);
            this.UI_State_Lbl.TabIndex = 0;
            this.UI_State_Lbl.Text = "IDLE";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 203);
            this.Controls.Add(this.UI_State_Lbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer MouseTimer;
        private System.Windows.Forms.Label UI_State_Lbl;
    }
}

