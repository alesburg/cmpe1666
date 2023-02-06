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
            this.UI_File_Lstbx = new System.Windows.Forms.ListBox();
            this.Ui_List_Lbl = new System.Windows.Forms.Label();
            this.UI_ChkFrom_GrpBx = new System.Windows.Forms.GroupBox();
            this.UI_File_RadBtn = new System.Windows.Forms.RadioButton();
            this.UI_TestVal_RadBtn = new System.Windows.Forms.RadioButton();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.UI_ChkFrom_GrpBx.SuspendLayout();
            this.SuspendLayout();
            // 
            // UI_TestVal_Tbx
            // 
            this.UI_TestVal_Tbx.Location = new System.Drawing.Point(207, 47);
            this.UI_TestVal_Tbx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UI_TestVal_Tbx.Name = "UI_TestVal_Tbx";
            this.UI_TestVal_Tbx.Size = new System.Drawing.Size(176, 20);
            this.UI_TestVal_Tbx.TabIndex = 0;
            // 
            // UI_TestValResult_Tbx
            // 
            this.UI_TestValResult_Tbx.Location = new System.Drawing.Point(207, 80);
            this.UI_TestValResult_Tbx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UI_TestValResult_Tbx.Name = "UI_TestValResult_Tbx";
            this.UI_TestValResult_Tbx.ReadOnly = true;
            this.UI_TestValResult_Tbx.Size = new System.Drawing.Size(176, 20);
            this.UI_TestValResult_Tbx.TabIndex = 1;
            // 
            // UI_CountFile_Tbx
            // 
            this.UI_CountFile_Tbx.Location = new System.Drawing.Point(146, 215);
            this.UI_CountFile_Tbx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UI_CountFile_Tbx.Name = "UI_CountFile_Tbx";
            this.UI_CountFile_Tbx.ReadOnly = true;
            this.UI_CountFile_Tbx.Size = new System.Drawing.Size(176, 20);
            this.UI_CountFile_Tbx.TabIndex = 2;
            this.UI_CountFile_Tbx.Visible = false;
            // 
            // UI_ExTime_Tbx
            // 
            this.UI_ExTime_Tbx.Location = new System.Drawing.Point(146, 266);
            this.UI_ExTime_Tbx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UI_ExTime_Tbx.Name = "UI_ExTime_Tbx";
            this.UI_ExTime_Tbx.ReadOnly = true;
            this.UI_ExTime_Tbx.Size = new System.Drawing.Size(176, 20);
            this.UI_ExTime_Tbx.TabIndex = 3;
            this.UI_ExTime_Tbx.Visible = false;
            // 
            // UI_TestVal_Lbl
            // 
            this.UI_TestVal_Lbl.AutoSize = true;
            this.UI_TestVal_Lbl.Location = new System.Drawing.Point(146, 50);
            this.UI_TestVal_Lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UI_TestVal_Lbl.Name = "UI_TestVal_Lbl";
            this.UI_TestVal_Lbl.Size = new System.Drawing.Size(61, 13);
            this.UI_TestVal_Lbl.TabIndex = 4;
            this.UI_TestVal_Lbl.Text = "Test Value:";
            // 
            // UI_TestResult_Lbl
            // 
            this.UI_TestResult_Lbl.AutoSize = true;
            this.UI_TestResult_Lbl.Location = new System.Drawing.Point(116, 83);
            this.UI_TestResult_Lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UI_TestResult_Lbl.Name = "UI_TestResult_Lbl";
            this.UI_TestResult_Lbl.Size = new System.Drawing.Size(94, 13);
            this.UI_TestResult_Lbl.TabIndex = 5;
            this.UI_TestResult_Lbl.Text = "Test Value Result:";
            // 
            // UI_CountFile_Lbl
            // 
            this.UI_CountFile_Lbl.AutoSize = true;
            this.UI_CountFile_Lbl.Location = new System.Drawing.Point(12, 218);
            this.UI_CountFile_Lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UI_CountFile_Lbl.Name = "UI_CountFile_Lbl";
            this.UI_CountFile_Lbl.Size = new System.Drawing.Size(138, 13);
            this.UI_CountFile_Lbl.TabIndex = 6;
            this.UI_CountFile_Lbl.Text = "Palindrome Count from File: ";
            this.UI_CountFile_Lbl.Visible = false;
            // 
            // UI_ExTime_Lbl
            // 
            this.UI_ExTime_Lbl.AutoSize = true;
            this.UI_ExTime_Lbl.Location = new System.Drawing.Point(38, 269);
            this.UI_ExTime_Lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UI_ExTime_Lbl.Name = "UI_ExTime_Lbl";
            this.UI_ExTime_Lbl.Size = new System.Drawing.Size(108, 13);
            this.UI_ExTime_Lbl.TabIndex = 7;
            this.UI_ExTime_Lbl.Text = "Execution Time (ms): ";
            this.UI_ExTime_Lbl.Visible = false;
            // 
            // UI_Find_Btn
            // 
            this.UI_Find_Btn.Location = new System.Drawing.Point(207, 121);
            this.UI_Find_Btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UI_Find_Btn.Name = "UI_Find_Btn";
            this.UI_Find_Btn.Size = new System.Drawing.Size(152, 50);
            this.UI_Find_Btn.TabIndex = 8;
            this.UI_Find_Btn.Text = "Find Palindrome(s)";
            this.UI_Find_Btn.UseVisualStyleBackColor = true;
            this.UI_Find_Btn.Click += new System.EventHandler(this.UI_Find_Btn_Click);
            // 
            // UI_File_Lstbx
            // 
            this.UI_File_Lstbx.FormattingEnabled = true;
            this.UI_File_Lstbx.Location = new System.Drawing.Point(392, 161);
            this.UI_File_Lstbx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UI_File_Lstbx.Name = "UI_File_Lstbx";
            this.UI_File_Lstbx.Size = new System.Drawing.Size(248, 186);
            this.UI_File_Lstbx.TabIndex = 9;
            this.UI_File_Lstbx.Visible = false;
            // 
            // Ui_List_Lbl
            // 
            this.Ui_List_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Ui_List_Lbl.Location = new System.Drawing.Point(417, 134);
            this.Ui_List_Lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Ui_List_Lbl.Name = "Ui_List_Lbl";
            this.Ui_List_Lbl.Size = new System.Drawing.Size(222, 18);
            this.Ui_List_Lbl.TabIndex = 10;
            this.Ui_List_Lbl.Text = "List of Palindromes From File";
            this.Ui_List_Lbl.Visible = false;
            // 
            // UI_ChkFrom_GrpBx
            // 
            this.UI_ChkFrom_GrpBx.Controls.Add(this.UI_File_RadBtn);
            this.UI_ChkFrom_GrpBx.Controls.Add(this.UI_TestVal_RadBtn);
            this.UI_ChkFrom_GrpBx.Location = new System.Drawing.Point(447, 32);
            this.UI_ChkFrom_GrpBx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UI_ChkFrom_GrpBx.Name = "UI_ChkFrom_GrpBx";
            this.UI_ChkFrom_GrpBx.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UI_ChkFrom_GrpBx.Size = new System.Drawing.Size(171, 89);
            this.UI_ChkFrom_GrpBx.TabIndex = 11;
            this.UI_ChkFrom_GrpBx.TabStop = false;
            this.UI_ChkFrom_GrpBx.Text = "Check Palindrome From";
            // 
            // UI_File_RadBtn
            // 
            this.UI_File_RadBtn.AutoSize = true;
            this.UI_File_RadBtn.Location = new System.Drawing.Point(25, 51);
            this.UI_File_RadBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UI_File_RadBtn.Name = "UI_File_RadBtn";
            this.UI_File_RadBtn.Size = new System.Drawing.Size(41, 17);
            this.UI_File_RadBtn.TabIndex = 1;
            this.UI_File_RadBtn.Text = "File";
            this.UI_File_RadBtn.UseVisualStyleBackColor = true;
            // 
            // UI_TestVal_RadBtn
            // 
            this.UI_TestVal_RadBtn.AutoSize = true;
            this.UI_TestVal_RadBtn.Checked = true;
            this.UI_TestVal_RadBtn.Location = new System.Drawing.Point(25, 26);
            this.UI_TestVal_RadBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UI_TestVal_RadBtn.Name = "UI_TestVal_RadBtn";
            this.UI_TestVal_RadBtn.Size = new System.Drawing.Size(76, 17);
            this.UI_TestVal_RadBtn.TabIndex = 0;
            this.UI_TestVal_RadBtn.TabStop = true;
            this.UI_TestVal_RadBtn.Text = "Test Value";
            this.UI_TestVal_RadBtn.UseVisualStyleBackColor = true;
            this.UI_TestVal_RadBtn.CheckedChanged += new System.EventHandler(this.UI_TestVal_RadBtn_CheckedChanged);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Title = "Choose Text File";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 366);
            this.Controls.Add(this.UI_ChkFrom_GrpBx);
            this.Controls.Add(this.Ui_List_Lbl);
            this.Controls.Add(this.UI_File_Lstbx);
            this.Controls.Add(this.UI_Find_Btn);
            this.Controls.Add(this.UI_ExTime_Lbl);
            this.Controls.Add(this.UI_TestVal_Lbl);
            this.Controls.Add(this.UI_ExTime_Tbx);
            this.Controls.Add(this.UI_CountFile_Tbx);
            this.Controls.Add(this.UI_TestValResult_Tbx);
            this.Controls.Add(this.UI_TestVal_Tbx);
            this.Controls.Add(this.UI_CountFile_Lbl);
            this.Controls.Add(this.UI_TestResult_Lbl);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "ICA05 Palindromes";
            this.UI_ChkFrom_GrpBx.ResumeLayout(false);
            this.UI_ChkFrom_GrpBx.PerformLayout();
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
        private System.Windows.Forms.ListBox UI_File_Lstbx;
        private System.Windows.Forms.Label Ui_List_Lbl;
        private System.Windows.Forms.GroupBox UI_ChkFrom_GrpBx;
        private System.Windows.Forms.RadioButton UI_File_RadBtn;
        private System.Windows.Forms.RadioButton UI_TestVal_RadBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

