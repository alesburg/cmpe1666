namespace LAB03_ANNA
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
            this.UI_ShowScore_Chkbx = new System.Windows.Forms.CheckBox();
            this.UI_ShowSpeed_Chkbx = new System.Windows.Forms.CheckBox();
            this.UI_Play_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UI_ShowScore_Chkbx
            // 
            this.UI_ShowScore_Chkbx.AutoSize = true;
            this.UI_ShowScore_Chkbx.Location = new System.Drawing.Point(100, 28);
            this.UI_ShowScore_Chkbx.Name = "UI_ShowScore_Chkbx";
            this.UI_ShowScore_Chkbx.Size = new System.Drawing.Size(101, 20);
            this.UI_ShowScore_Chkbx.TabIndex = 0;
            this.UI_ShowScore_Chkbx.Text = "Show Score";
            this.UI_ShowScore_Chkbx.UseVisualStyleBackColor = true;
            // 
            // UI_ShowSpeed_Chkbx
            // 
            this.UI_ShowSpeed_Chkbx.AutoSize = true;
            this.UI_ShowSpeed_Chkbx.Location = new System.Drawing.Point(100, 76);
            this.UI_ShowSpeed_Chkbx.Name = "UI_ShowSpeed_Chkbx";
            this.UI_ShowSpeed_Chkbx.Size = new System.Drawing.Size(168, 20);
            this.UI_ShowSpeed_Chkbx.TabIndex = 1;
            this.UI_ShowSpeed_Chkbx.Text = "Show Animation Speed";
            this.UI_ShowSpeed_Chkbx.UseVisualStyleBackColor = true;
            // 
            // UI_Play_Btn
            // 
            this.UI_Play_Btn.Location = new System.Drawing.Point(129, 120);
            this.UI_Play_Btn.Name = "UI_Play_Btn";
            this.UI_Play_Btn.Size = new System.Drawing.Size(111, 40);
            this.UI_Play_Btn.TabIndex = 2;
            this.UI_Play_Btn.Text = "Play";
            this.UI_Play_Btn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 172);
            this.Controls.Add(this.UI_Play_Btn);
            this.Controls.Add(this.UI_ShowSpeed_Chkbx);
            this.Controls.Add(this.UI_ShowScore_Chkbx);
            this.MaximumSize = new System.Drawing.Size(387, 219);
            this.MinimumSize = new System.Drawing.Size(387, 219);
            this.Name = "Form1";
            this.Text = "LAB03 Ballz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox UI_ShowScore_Chkbx;
        private System.Windows.Forms.CheckBox UI_ShowSpeed_Chkbx;
        private System.Windows.Forms.Button UI_Play_Btn;
    }
}

