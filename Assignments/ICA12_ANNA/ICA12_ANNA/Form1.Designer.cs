namespace ICA12_ANNA
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
            this.UI_Input_Lbl = new System.Windows.Forms.Label();
            this.UI_Input_Txtbx = new System.Windows.Forms.TextBox();
            this.UI_ModType_Grpbox = new System.Windows.Forms.GroupBox();
            this.UI_Output_Lbl = new System.Windows.Forms.Label();
            this.UI_Output_Txtbx = new System.Windows.Forms.TextBox();
            this.UI_Uppercase_Radbtn = new System.Windows.Forms.RadioButton();
            this.UI_Lowercase_Radbtn = new System.Windows.Forms.RadioButton();
            this.UI_Flipcase_Radbtn = new System.Windows.Forms.RadioButton();
            this.UI_ModType_Grpbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // UI_Input_Lbl
            // 
            this.UI_Input_Lbl.AutoSize = true;
            this.UI_Input_Lbl.Location = new System.Drawing.Point(12, 9);
            this.UI_Input_Lbl.Name = "UI_Input_Lbl";
            this.UI_Input_Lbl.Size = new System.Drawing.Size(75, 16);
            this.UI_Input_Lbl.TabIndex = 0;
            this.UI_Input_Lbl.Text = "Input String:";
            // 
            // UI_Input_Txtbx
            // 
            this.UI_Input_Txtbx.Location = new System.Drawing.Point(12, 28);
            this.UI_Input_Txtbx.Name = "UI_Input_Txtbx";
            this.UI_Input_Txtbx.Size = new System.Drawing.Size(625, 22);
            this.UI_Input_Txtbx.TabIndex = 1;
            // 
            // UI_ModType_Grpbox
            // 
            this.UI_ModType_Grpbox.Controls.Add(this.UI_Flipcase_Radbtn);
            this.UI_ModType_Grpbox.Controls.Add(this.UI_Lowercase_Radbtn);
            this.UI_ModType_Grpbox.Controls.Add(this.UI_Uppercase_Radbtn);
            this.UI_ModType_Grpbox.Location = new System.Drawing.Point(15, 66);
            this.UI_ModType_Grpbox.Name = "UI_ModType_Grpbox";
            this.UI_ModType_Grpbox.Size = new System.Drawing.Size(622, 93);
            this.UI_ModType_Grpbox.TabIndex = 2;
            this.UI_ModType_Grpbox.TabStop = false;
            this.UI_ModType_Grpbox.Text = "Modification Type:";
            // 
            // UI_Output_Lbl
            // 
            this.UI_Output_Lbl.AutoSize = true;
            this.UI_Output_Lbl.Location = new System.Drawing.Point(12, 171);
            this.UI_Output_Lbl.Name = "UI_Output_Lbl";
            this.UI_Output_Lbl.Size = new System.Drawing.Size(85, 16);
            this.UI_Output_Lbl.TabIndex = 3;
            this.UI_Output_Lbl.Text = "Output String:";
            // 
            // UI_Output_Txtbx
            // 
            this.UI_Output_Txtbx.Location = new System.Drawing.Point(12, 190);
            this.UI_Output_Txtbx.Name = "UI_Output_Txtbx";
            this.UI_Output_Txtbx.ReadOnly = true;
            this.UI_Output_Txtbx.Size = new System.Drawing.Size(625, 22);
            this.UI_Output_Txtbx.TabIndex = 4;
            // 
            // UI_Uppercase_Radbtn
            // 
            this.UI_Uppercase_Radbtn.AutoSize = true;
            this.UI_Uppercase_Radbtn.Location = new System.Drawing.Point(6, 38);
            this.UI_Uppercase_Radbtn.Name = "UI_Uppercase_Radbtn";
            this.UI_Uppercase_Radbtn.Size = new System.Drawing.Size(96, 20);
            this.UI_Uppercase_Radbtn.TabIndex = 0;
            this.UI_Uppercase_Radbtn.TabStop = true;
            this.UI_Uppercase_Radbtn.Text = "Uppercase";
            this.UI_Uppercase_Radbtn.UseVisualStyleBackColor = true;
            // 
            // UI_Lowercase_Radbtn
            // 
            this.UI_Lowercase_Radbtn.AutoSize = true;
            this.UI_Lowercase_Radbtn.Location = new System.Drawing.Point(263, 38);
            this.UI_Lowercase_Radbtn.Name = "UI_Lowercase_Radbtn";
            this.UI_Lowercase_Radbtn.Size = new System.Drawing.Size(94, 20);
            this.UI_Lowercase_Radbtn.TabIndex = 1;
            this.UI_Lowercase_Radbtn.TabStop = true;
            this.UI_Lowercase_Radbtn.Text = "Lowercase";
            this.UI_Lowercase_Radbtn.UseVisualStyleBackColor = true;
            // 
            // UI_Flipcase_Radbtn
            // 
            this.UI_Flipcase_Radbtn.AutoSize = true;
            this.UI_Flipcase_Radbtn.Location = new System.Drawing.Point(522, 38);
            this.UI_Flipcase_Radbtn.Name = "UI_Flipcase_Radbtn";
            this.UI_Flipcase_Radbtn.Size = new System.Drawing.Size(80, 20);
            this.UI_Flipcase_Radbtn.TabIndex = 2;
            this.UI_Flipcase_Radbtn.TabStop = true;
            this.UI_Flipcase_Radbtn.Text = "Flipcase";
            this.UI_Flipcase_Radbtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 232);
            this.Controls.Add(this.UI_Output_Txtbx);
            this.Controls.Add(this.UI_Output_Lbl);
            this.Controls.Add(this.UI_ModType_Grpbox);
            this.Controls.Add(this.UI_Input_Txtbx);
            this.Controls.Add(this.UI_Input_Lbl);
            this.Name = "Form1";
            this.Text = "StringBender";
            this.UI_ModType_Grpbox.ResumeLayout(false);
            this.UI_ModType_Grpbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UI_Input_Lbl;
        private System.Windows.Forms.TextBox UI_Input_Txtbx;
        private System.Windows.Forms.GroupBox UI_ModType_Grpbox;
        private System.Windows.Forms.Label UI_Output_Lbl;
        private System.Windows.Forms.TextBox UI_Output_Txtbx;
        private System.Windows.Forms.RadioButton UI_Flipcase_Radbtn;
        private System.Windows.Forms.RadioButton UI_Lowercase_Radbtn;
        private System.Windows.Forms.RadioButton UI_Uppercase_Radbtn;
    }
}

