namespace ICA05_Anna
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
            this.UI_TestVal_Tbx = new System.Windows.Forms.TextBox();
            this.UI_TestValResult_Tbx = new System.Windows.Forms.TextBox();
            this.UI_CountFile_Tbx = new System.Windows.Forms.TextBox();
            this.UI_ExTime_Tbx = new System.Windows.Forms.TextBox();
            this.UI_TestVal_Lbl = new System.Windows.Forms.Label();
            this.UI_TestResult_Lbl = new System.Windows.Forms.Label();
            this.UI_CountFile_Lbl = new System.Windows.Forms.Label();
            this.UI_ExTime_Lbl = new System.Windows.Forms.Label();
            this.UI_Find_Btn = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // UI_TestVal_Tbx
            // 
            this.UI_TestVal_Tbx.Location = new System.Drawing.Point(276, 58);
            this.UI_TestVal_Tbx.Name = "UI_TestVal_Tbx";
            this.UI_TestVal_Tbx.Size = new System.Drawing.Size(234, 22);
            this.UI_TestVal_Tbx.TabIndex = 0;
            // 
            // UI_TestValResult_Tbx
            // 
            this.UI_TestValResult_Tbx.Location = new System.Drawing.Point(276, 99);
            this.UI_TestValResult_Tbx.Name = "UI_TestValResult_Tbx";
            this.UI_TestValResult_Tbx.ReadOnly = true;
            this.UI_TestValResult_Tbx.Size = new System.Drawing.Size(234, 22);
            this.UI_TestValResult_Tbx.TabIndex = 1;
            // 
            // UI_CountFile_Tbx
            // 
            this.UI_CountFile_Tbx.Location = new System.Drawing.Point(195, 265);
            this.UI_CountFile_Tbx.Name = "UI_CountFile_Tbx";
            this.UI_CountFile_Tbx.ReadOnly = true;
            this.UI_CountFile_Tbx.Size = new System.Drawing.Size(234, 22);
            this.UI_CountFile_Tbx.TabIndex = 2;
            // 
            // UI_ExTime_Tbx
            // 
            this.UI_ExTime_Tbx.Location = new System.Drawing.Point(195, 328);
            this.UI_ExTime_Tbx.Name = "UI_ExTime_Tbx";
            this.UI_ExTime_Tbx.ReadOnly = true;
            this.UI_ExTime_Tbx.Size = new System.Drawing.Size(234, 22);
            this.UI_ExTime_Tbx.TabIndex = 3;
            // 
            // UI_TestVal_Lbl
            // 
            this.UI_TestVal_Lbl.AutoSize = true;
            this.UI_TestVal_Lbl.Location = new System.Drawing.Point(195, 61);
            this.UI_TestVal_Lbl.Name = "UI_TestVal_Lbl";
            this.UI_TestVal_Lbl.Size = new System.Drawing.Size(75, 16);
            this.UI_TestVal_Lbl.TabIndex = 4;
            this.UI_TestVal_Lbl.Text = "Test Value:";
            // 
            // UI_TestResult_Lbl
            // 
            this.UI_TestResult_Lbl.AutoSize = true;
            this.UI_TestResult_Lbl.Location = new System.Drawing.Point(154, 102);
            this.UI_TestResult_Lbl.Name = "UI_TestResult_Lbl";
            this.UI_TestResult_Lbl.Size = new System.Drawing.Size(116, 16);
            this.UI_TestResult_Lbl.TabIndex = 5;
            this.UI_TestResult_Lbl.Text = "Test Value Result:";
            // 
            // UI_CountFile_Lbl
            // 
            this.UI_CountFile_Lbl.AutoSize = true;
            this.UI_CountFile_Lbl.Location = new System.Drawing.Point(16, 271);
            this.UI_CountFile_Lbl.Name = "UI_CountFile_Lbl";
            this.UI_CountFile_Lbl.Size = new System.Drawing.Size(173, 16);
            this.UI_CountFile_Lbl.TabIndex = 6;
            this.UI_CountFile_Lbl.Text = "Palindrome Count from File: ";
            // 
            // UI_ExTime_Lbl
            // 
            this.UI_ExTime_Lbl.AutoSize = true;
            this.UI_ExTime_Lbl.Location = new System.Drawing.Point(55, 331);
            this.UI_ExTime_Lbl.Name = "UI_ExTime_Lbl";
            this.UI_ExTime_Lbl.Size = new System.Drawing.Size(134, 16);
            this.UI_ExTime_Lbl.TabIndex = 7;
            this.UI_ExTime_Lbl.Text = "Execution Time (ms): ";
            // 
            // UI_Find_Btn
            // 
            this.UI_Find_Btn.Location = new System.Drawing.Point(276, 149);
            this.UI_Find_Btn.Name = "UI_Find_Btn";
            this.UI_Find_Btn.Size = new System.Drawing.Size(203, 62);
            this.UI_Find_Btn.TabIndex = 8;
            this.UI_Find_Btn.Text = "Find Palindrome(s)";
            this.UI_Find_Btn.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(523, 198);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(329, 228);
            this.listBox1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.UI_Find_Btn);
            this.Controls.Add(this.UI_ExTime_Lbl);
            this.Controls.Add(this.UI_CountFile_Lbl);
            this.Controls.Add(this.UI_TestResult_Lbl);
            this.Controls.Add(this.UI_TestVal_Lbl);
            this.Controls.Add(this.UI_ExTime_Tbx);
            this.Controls.Add(this.UI_CountFile_Tbx);
            this.Controls.Add(this.UI_TestValResult_Tbx);
            this.Controls.Add(this.UI_TestVal_Tbx);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UI_TestVal_Tbx;
        private System.Windows.Forms.TextBox UI_TestValResult_Tbx;
        private System.Windows.Forms.TextBox UI_CountFile_Tbx;
        private System.Windows.Forms.TextBox UI_ExTime_Tbx;
        private System.Windows.Forms.Label UI_TestVal_Lbl;
        private System.Windows.Forms.Label UI_TestResult_Lbl;
        private System.Windows.Forms.Label UI_CountFile_Lbl;
        private System.Windows.Forms.Label UI_ExTime_Lbl;
        private System.Windows.Forms.Button UI_Find_Btn;
        private System.Windows.Forms.ListBox listBox1;
    }
}

