namespace LAB03_ANNA
{
    partial class modal
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
            this.UI_Difficulty_Grpbx = new System.Windows.Forms.GroupBox();
            this.UI_Hard_Radbtn = new System.Windows.Forms.RadioButton();
            this.UI_Med_RadBtn = new System.Windows.Forms.RadioButton();
            this.UI_Easy_Radbtn = new System.Windows.Forms.RadioButton();
            this.UI_OK_Btn = new System.Windows.Forms.Button();
            this.UI_Cancel_Btn = new System.Windows.Forms.Button();
            this.UI_Difficulty_Grpbx.SuspendLayout();
            this.SuspendLayout();
            // 
            // UI_Difficulty_Grpbx
            // 
            this.UI_Difficulty_Grpbx.Controls.Add(this.UI_Hard_Radbtn);
            this.UI_Difficulty_Grpbx.Controls.Add(this.UI_Med_RadBtn);
            this.UI_Difficulty_Grpbx.Controls.Add(this.UI_Easy_Radbtn);
            this.UI_Difficulty_Grpbx.Location = new System.Drawing.Point(46, 12);
            this.UI_Difficulty_Grpbx.Name = "UI_Difficulty_Grpbx";
            this.UI_Difficulty_Grpbx.Size = new System.Drawing.Size(236, 149);
            this.UI_Difficulty_Grpbx.TabIndex = 0;
            this.UI_Difficulty_Grpbx.TabStop = false;
            this.UI_Difficulty_Grpbx.Text = "Difficulty";
            // 
            // UI_Hard_Radbtn
            // 
            this.UI_Hard_Radbtn.AutoSize = true;
            this.UI_Hard_Radbtn.Location = new System.Drawing.Point(15, 106);
            this.UI_Hard_Radbtn.Name = "UI_Hard_Radbtn";
            this.UI_Hard_Radbtn.Size = new System.Drawing.Size(58, 20);
            this.UI_Hard_Radbtn.TabIndex = 2;
            this.UI_Hard_Radbtn.TabStop = true;
            this.UI_Hard_Radbtn.Text = "Hard";
            this.UI_Hard_Radbtn.UseVisualStyleBackColor = true;
            // 
            // UI_Med_RadBtn
            // 
            this.UI_Med_RadBtn.AutoSize = true;
            this.UI_Med_RadBtn.Checked = true;
            this.UI_Med_RadBtn.Location = new System.Drawing.Point(15, 68);
            this.UI_Med_RadBtn.Name = "UI_Med_RadBtn";
            this.UI_Med_RadBtn.Size = new System.Drawing.Size(76, 20);
            this.UI_Med_RadBtn.TabIndex = 1;
            this.UI_Med_RadBtn.TabStop = true;
            this.UI_Med_RadBtn.Text = "Medium";
            this.UI_Med_RadBtn.UseVisualStyleBackColor = true;
            // 
            // UI_Easy_Radbtn
            // 
            this.UI_Easy_Radbtn.AutoSize = true;
            this.UI_Easy_Radbtn.Location = new System.Drawing.Point(15, 30);
            this.UI_Easy_Radbtn.Name = "UI_Easy_Radbtn";
            this.UI_Easy_Radbtn.Size = new System.Drawing.Size(59, 20);
            this.UI_Easy_Radbtn.TabIndex = 0;
            this.UI_Easy_Radbtn.TabStop = true;
            this.UI_Easy_Radbtn.Text = "Easy";
            this.UI_Easy_Radbtn.UseVisualStyleBackColor = true;
            // 
            // UI_OK_Btn
            // 
            this.UI_OK_Btn.Location = new System.Drawing.Point(46, 178);
            this.UI_OK_Btn.Name = "UI_OK_Btn";
            this.UI_OK_Btn.Size = new System.Drawing.Size(92, 37);
            this.UI_OK_Btn.TabIndex = 3;
            this.UI_OK_Btn.Text = "OK";
            this.UI_OK_Btn.UseVisualStyleBackColor = true;
            this.UI_OK_Btn.Click += new System.EventHandler(this.UI_OK_Btn_Click);
            // 
            // UI_Cancel_Btn
            // 
            this.UI_Cancel_Btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.UI_Cancel_Btn.Location = new System.Drawing.Point(190, 178);
            this.UI_Cancel_Btn.Name = "UI_Cancel_Btn";
            this.UI_Cancel_Btn.Size = new System.Drawing.Size(92, 37);
            this.UI_Cancel_Btn.TabIndex = 4;
            this.UI_Cancel_Btn.Text = "Cancel";
            this.UI_Cancel_Btn.UseVisualStyleBackColor = true;
            this.UI_Cancel_Btn.Click += new System.EventHandler(this.UI_Cancel_Btn_Click);
            // 
            // modal
            // 
            this.AcceptButton = this.UI_OK_Btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.UI_Cancel_Btn;
            this.ClientSize = new System.Drawing.Size(328, 241);
            this.ControlBox = false;
            this.Controls.Add(this.UI_Cancel_Btn);
            this.Controls.Add(this.UI_OK_Btn);
            this.Controls.Add(this.UI_Difficulty_Grpbx);
            this.MaximumSize = new System.Drawing.Size(346, 288);
            this.MinimumSize = new System.Drawing.Size(346, 288);
            this.Name = "modal";
            this.Text = "Select Difficulty";
            this.UI_Difficulty_Grpbx.ResumeLayout(false);
            this.UI_Difficulty_Grpbx.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox UI_Difficulty_Grpbx;
        private System.Windows.Forms.RadioButton UI_Hard_Radbtn;
        private System.Windows.Forms.RadioButton UI_Med_RadBtn;
        private System.Windows.Forms.RadioButton UI_Easy_Radbtn;
        private System.Windows.Forms.Button UI_OK_Btn;
        private System.Windows.Forms.Button UI_Cancel_Btn;
    }
}