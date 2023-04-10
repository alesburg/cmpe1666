namespace Exam3Practice1
{
    partial class modeless
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
            this.UI_Val1_Txtbx = new System.Windows.Forms.TextBox();
            this.UI_Val1_Lbl = new System.Windows.Forms.Label();
            this.UI_Val2_Lbl = new System.Windows.Forms.Label();
            this.UI_Val2_Tbx = new System.Windows.Forms.TextBox();
            this.UI_Operation_Grpbx = new System.Windows.Forms.GroupBox();
            this.UI_Add_RadBtn = new System.Windows.Forms.RadioButton();
            this.UI_Subtract_RadBtn = new System.Windows.Forms.RadioButton();
            this.UI_Multiply_RadBtn = new System.Windows.Forms.RadioButton();
            this.UI_Operation_Grpbx.SuspendLayout();
            this.SuspendLayout();
            // 
            // UI_Val1_Txtbx
            // 
            this.UI_Val1_Txtbx.Location = new System.Drawing.Point(151, 44);
            this.UI_Val1_Txtbx.Name = "UI_Val1_Txtbx";
            this.UI_Val1_Txtbx.Size = new System.Drawing.Size(100, 22);
            this.UI_Val1_Txtbx.TabIndex = 0;
            this.UI_Val1_Txtbx.TextChanged += new System.EventHandler(this.UI_Changed);
            // 
            // UI_Val1_Lbl
            // 
            this.UI_Val1_Lbl.AutoSize = true;
            this.UI_Val1_Lbl.Location = new System.Drawing.Point(90, 47);
            this.UI_Val1_Lbl.Name = "UI_Val1_Lbl";
            this.UI_Val1_Lbl.Size = new System.Drawing.Size(55, 16);
            this.UI_Val1_Lbl.TabIndex = 1;
            this.UI_Val1_Lbl.Text = "Value 1:";
            // 
            // UI_Val2_Lbl
            // 
            this.UI_Val2_Lbl.AutoSize = true;
            this.UI_Val2_Lbl.Location = new System.Drawing.Point(90, 93);
            this.UI_Val2_Lbl.Name = "UI_Val2_Lbl";
            this.UI_Val2_Lbl.Size = new System.Drawing.Size(55, 16);
            this.UI_Val2_Lbl.TabIndex = 3;
            this.UI_Val2_Lbl.Text = "Value 2:";
            // 
            // UI_Val2_Tbx
            // 
            this.UI_Val2_Tbx.Location = new System.Drawing.Point(151, 90);
            this.UI_Val2_Tbx.Name = "UI_Val2_Tbx";
            this.UI_Val2_Tbx.Size = new System.Drawing.Size(100, 22);
            this.UI_Val2_Tbx.TabIndex = 2;
            this.UI_Val2_Tbx.TextChanged += new System.EventHandler(this.UI_Changed);
            // 
            // UI_Operation_Grpbx
            // 
            this.UI_Operation_Grpbx.Controls.Add(this.UI_Multiply_RadBtn);
            this.UI_Operation_Grpbx.Controls.Add(this.UI_Subtract_RadBtn);
            this.UI_Operation_Grpbx.Controls.Add(this.UI_Add_RadBtn);
            this.UI_Operation_Grpbx.Location = new System.Drawing.Point(93, 139);
            this.UI_Operation_Grpbx.Name = "UI_Operation_Grpbx";
            this.UI_Operation_Grpbx.Size = new System.Drawing.Size(200, 104);
            this.UI_Operation_Grpbx.TabIndex = 4;
            this.UI_Operation_Grpbx.TabStop = false;
            this.UI_Operation_Grpbx.Text = "Operation";
            // 
            // UI_Add_RadBtn
            // 
            this.UI_Add_RadBtn.AutoSize = true;
            this.UI_Add_RadBtn.Checked = true;
            this.UI_Add_RadBtn.Location = new System.Drawing.Point(6, 21);
            this.UI_Add_RadBtn.Name = "UI_Add_RadBtn";
            this.UI_Add_RadBtn.Size = new System.Drawing.Size(77, 20);
            this.UI_Add_RadBtn.TabIndex = 0;
            this.UI_Add_RadBtn.TabStop = true;
            this.UI_Add_RadBtn.Text = "Addition";
            this.UI_Add_RadBtn.UseVisualStyleBackColor = true;
            this.UI_Add_RadBtn.CheckedChanged += new System.EventHandler(this.UI_Changed);
            // 
            // UI_Subtract_RadBtn
            // 
            this.UI_Subtract_RadBtn.AutoSize = true;
            this.UI_Subtract_RadBtn.Location = new System.Drawing.Point(6, 47);
            this.UI_Subtract_RadBtn.Name = "UI_Subtract_RadBtn";
            this.UI_Subtract_RadBtn.Size = new System.Drawing.Size(95, 20);
            this.UI_Subtract_RadBtn.TabIndex = 1;
            this.UI_Subtract_RadBtn.Text = "Subtraction";
            this.UI_Subtract_RadBtn.UseVisualStyleBackColor = true;
            this.UI_Subtract_RadBtn.CheckedChanged += new System.EventHandler(this.UI_Changed);
            // 
            // UI_Multiply_RadBtn
            // 
            this.UI_Multiply_RadBtn.AutoSize = true;
            this.UI_Multiply_RadBtn.Location = new System.Drawing.Point(6, 73);
            this.UI_Multiply_RadBtn.Name = "UI_Multiply_RadBtn";
            this.UI_Multiply_RadBtn.Size = new System.Drawing.Size(105, 20);
            this.UI_Multiply_RadBtn.TabIndex = 2;
            this.UI_Multiply_RadBtn.Text = "Multiplication";
            this.UI_Multiply_RadBtn.UseVisualStyleBackColor = true;
            this.UI_Multiply_RadBtn.CheckedChanged += new System.EventHandler(this.UI_Changed);
            // 
            // modeless
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 268);
            this.Controls.Add(this.UI_Operation_Grpbx);
            this.Controls.Add(this.UI_Val2_Lbl);
            this.Controls.Add(this.UI_Val2_Tbx);
            this.Controls.Add(this.UI_Val1_Lbl);
            this.Controls.Add(this.UI_Val1_Txtbx);
            this.Name = "modeless";
            this.Text = "modeless";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.modeless_FormClosing);
            this.UI_Operation_Grpbx.ResumeLayout(false);
            this.UI_Operation_Grpbx.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UI_Val1_Txtbx;
        private System.Windows.Forms.Label UI_Val1_Lbl;
        private System.Windows.Forms.Label UI_Val2_Lbl;
        private System.Windows.Forms.TextBox UI_Val2_Tbx;
        private System.Windows.Forms.GroupBox UI_Operation_Grpbx;
        private System.Windows.Forms.RadioButton UI_Multiply_RadBtn;
        private System.Windows.Forms.RadioButton UI_Subtract_RadBtn;
        private System.Windows.Forms.RadioButton UI_Add_RadBtn;
    }
}