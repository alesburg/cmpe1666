namespace LAB03_ANNA
{
    partial class HighScore
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
            this.UI_PlayerName_Tbx = new System.Windows.Forms.TextBox();
            this.UI_PlayerName_Lbl = new System.Windows.Forms.Label();
            this.UI_OK_Btn = new System.Windows.Forms.Button();
            this.UI_Cancel_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UI_PlayerName_Tbx
            // 
            this.UI_PlayerName_Tbx.Location = new System.Drawing.Point(138, 34);
            this.UI_PlayerName_Tbx.Name = "UI_PlayerName_Tbx";
            this.UI_PlayerName_Tbx.Size = new System.Drawing.Size(168, 22);
            this.UI_PlayerName_Tbx.TabIndex = 0;
            // 
            // UI_PlayerName_Lbl
            // 
            this.UI_PlayerName_Lbl.AutoSize = true;
            this.UI_PlayerName_Lbl.Location = new System.Drawing.Point(40, 37);
            this.UI_PlayerName_Lbl.Name = "UI_PlayerName_Lbl";
            this.UI_PlayerName_Lbl.Size = new System.Drawing.Size(92, 16);
            this.UI_PlayerName_Lbl.TabIndex = 1;
            this.UI_PlayerName_Lbl.Text = "Player Name: ";
            // 
            // UI_OK_Btn
            // 
            this.UI_OK_Btn.Location = new System.Drawing.Point(34, 76);
            this.UI_OK_Btn.Name = "UI_OK_Btn";
            this.UI_OK_Btn.Size = new System.Drawing.Size(98, 29);
            this.UI_OK_Btn.TabIndex = 2;
            this.UI_OK_Btn.Text = "OK";
            this.UI_OK_Btn.UseVisualStyleBackColor = true;
            this.UI_OK_Btn.Click += new System.EventHandler(this.UI_OK_Btn_Click);
            // 
            // UI_Cancel_Btn
            // 
            this.UI_Cancel_Btn.Location = new System.Drawing.Point(208, 76);
            this.UI_Cancel_Btn.Name = "UI_Cancel_Btn";
            this.UI_Cancel_Btn.Size = new System.Drawing.Size(98, 29);
            this.UI_Cancel_Btn.TabIndex = 3;
            this.UI_Cancel_Btn.Text = "Cancel";
            this.UI_Cancel_Btn.UseVisualStyleBackColor = true;
            // 
            // HighScore
            // 
            this.AcceptButton = this.UI_OK_Btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.UI_Cancel_Btn;
            this.ClientSize = new System.Drawing.Size(347, 117);
            this.ControlBox = false;
            this.Controls.Add(this.UI_Cancel_Btn);
            this.Controls.Add(this.UI_OK_Btn);
            this.Controls.Add(this.UI_PlayerName_Lbl);
            this.Controls.Add(this.UI_PlayerName_Tbx);
            this.MaximumSize = new System.Drawing.Size(365, 164);
            this.MinimumSize = new System.Drawing.Size(365, 164);
            this.Name = "HighScore";
            this.Text = "High Score";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UI_PlayerName_Tbx;
        private System.Windows.Forms.Label UI_PlayerName_Lbl;
        private System.Windows.Forms.Button UI_OK_Btn;
        private System.Windows.Forms.Button UI_Cancel_Btn;
    }
}