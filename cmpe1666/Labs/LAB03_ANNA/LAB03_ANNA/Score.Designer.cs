namespace LAB03_ANNA
{
    partial class Score
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
            this.UI_ScoreText_Lbl = new System.Windows.Forms.Label();
            this.UI_Score_Lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UI_ScoreText_Lbl
            // 
            this.UI_ScoreText_Lbl.AutoSize = true;
            this.UI_ScoreText_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_ScoreText_Lbl.Location = new System.Drawing.Point(12, 49);
            this.UI_ScoreText_Lbl.Name = "UI_ScoreText_Lbl";
            this.UI_ScoreText_Lbl.Size = new System.Drawing.Size(83, 29);
            this.UI_ScoreText_Lbl.TabIndex = 0;
            this.UI_ScoreText_Lbl.Text = "Score:";
            // 
            // UI_Score_Lbl
            // 
            this.UI_Score_Lbl.AutoSize = true;
            this.UI_Score_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_Score_Lbl.Location = new System.Drawing.Point(146, 49);
            this.UI_Score_Lbl.Name = "UI_Score_Lbl";
            this.UI_Score_Lbl.Size = new System.Drawing.Size(26, 29);
            this.UI_Score_Lbl.TabIndex = 1;
            this.UI_Score_Lbl.Text = "0";
            // 
            // Score
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 127);
            this.Controls.Add(this.UI_Score_Lbl);
            this.Controls.Add(this.UI_ScoreText_Lbl);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(312, 174);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(312, 174);
            this.Name = "Score";
            this.Text = "Score";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Score_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UI_ScoreText_Lbl;
        private System.Windows.Forms.Label UI_Score_Lbl;
    }
}