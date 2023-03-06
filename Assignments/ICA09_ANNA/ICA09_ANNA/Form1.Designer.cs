namespace ICA09_ANNA
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
            this.UI_Unsorted_Lstbx = new System.Windows.Forms.ListBox();
            this.UI_Sorted_Lstbox = new System.Windows.Forms.ListBox();
            this.UI_Unsorted_Lbl = new System.Windows.Forms.Label();
            this.UI_Sorted_Lbl = new System.Windows.Forms.Label();
            this.UI_Ticks_Tbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UI_DisplayUnsorted_Btn = new System.Windows.Forms.Button();
            this.UI_ClearUnsorted_Btn = new System.Windows.Forms.Button();
            this.UI_N2Sorting_Btn = new System.Windows.Forms.Button();
            this.UI_QuickSort_Btn = new System.Windows.Forms.Button();
            this.UI_ClearSorted_Btn = new System.Windows.Forms.Button();
            this.UI_LoadFiles_Btn = new System.Windows.Forms.Button();
            this.UI_Rad_Grpbx = new System.Windows.Forms.GroupBox();
            this.UI_FileData_Radbtn = new System.Windows.Forms.RadioButton();
            this.UI_ProvList_Radbtn = new System.Windows.Forms.RadioButton();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.UI_Rad_Grpbx.SuspendLayout();
            this.SuspendLayout();
            // 
            // UI_Unsorted_Lstbx
            // 
            this.UI_Unsorted_Lstbx.FormattingEnabled = true;
            this.UI_Unsorted_Lstbx.ItemHeight = 16;
            this.UI_Unsorted_Lstbx.Location = new System.Drawing.Point(12, 45);
            this.UI_Unsorted_Lstbx.Name = "UI_Unsorted_Lstbx";
            this.UI_Unsorted_Lstbx.Size = new System.Drawing.Size(279, 436);
            this.UI_Unsorted_Lstbx.TabIndex = 0;
            // 
            // UI_Sorted_Lstbox
            // 
            this.UI_Sorted_Lstbox.FormattingEnabled = true;
            this.UI_Sorted_Lstbox.ItemHeight = 16;
            this.UI_Sorted_Lstbox.Location = new System.Drawing.Point(509, 45);
            this.UI_Sorted_Lstbox.Name = "UI_Sorted_Lstbox";
            this.UI_Sorted_Lstbox.Size = new System.Drawing.Size(279, 436);
            this.UI_Sorted_Lstbox.TabIndex = 1;
            // 
            // UI_Unsorted_Lbl
            // 
            this.UI_Unsorted_Lbl.AutoSize = true;
            this.UI_Unsorted_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_Unsorted_Lbl.Location = new System.Drawing.Point(85, 9);
            this.UI_Unsorted_Lbl.Name = "UI_Unsorted_Lbl";
            this.UI_Unsorted_Lbl.Size = new System.Drawing.Size(131, 20);
            this.UI_Unsorted_Lbl.TabIndex = 2;
            this.UI_Unsorted_Lbl.Text = "Unsorted Data";
            // 
            // UI_Sorted_Lbl
            // 
            this.UI_Sorted_Lbl.AutoSize = true;
            this.UI_Sorted_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_Sorted_Lbl.Location = new System.Drawing.Point(596, 9);
            this.UI_Sorted_Lbl.Name = "UI_Sorted_Lbl";
            this.UI_Sorted_Lbl.Size = new System.Drawing.Size(110, 20);
            this.UI_Sorted_Lbl.TabIndex = 3;
            this.UI_Sorted_Lbl.Text = "Sorted Data";
            // 
            // UI_Ticks_Tbx
            // 
            this.UI_Ticks_Tbx.Location = new System.Drawing.Point(688, 497);
            this.UI_Ticks_Tbx.Name = "UI_Ticks_Tbx";
            this.UI_Ticks_Tbx.ReadOnly = true;
            this.UI_Ticks_Tbx.Size = new System.Drawing.Size(100, 22);
            this.UI_Ticks_Tbx.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(456, 500);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Time Taken (Elapsed Ticks):";
            // 
            // UI_DisplayUnsorted_Btn
            // 
            this.UI_DisplayUnsorted_Btn.Location = new System.Drawing.Point(333, 46);
            this.UI_DisplayUnsorted_Btn.Name = "UI_DisplayUnsorted_Btn";
            this.UI_DisplayUnsorted_Btn.Size = new System.Drawing.Size(136, 47);
            this.UI_DisplayUnsorted_Btn.TabIndex = 6;
            this.UI_DisplayUnsorted_Btn.Text = "Display Unsorted List";
            this.UI_DisplayUnsorted_Btn.UseVisualStyleBackColor = true;
            this.UI_DisplayUnsorted_Btn.Click += new System.EventHandler(this.UI_DisplayUnsorted_Btn_Click);
            // 
            // UI_ClearUnsorted_Btn
            // 
            this.UI_ClearUnsorted_Btn.Location = new System.Drawing.Point(333, 108);
            this.UI_ClearUnsorted_Btn.Name = "UI_ClearUnsorted_Btn";
            this.UI_ClearUnsorted_Btn.Size = new System.Drawing.Size(136, 47);
            this.UI_ClearUnsorted_Btn.TabIndex = 7;
            this.UI_ClearUnsorted_Btn.Text = "Clear Unsorted Listbox";
            this.UI_ClearUnsorted_Btn.UseVisualStyleBackColor = true;
            this.UI_ClearUnsorted_Btn.Click += new System.EventHandler(this.UI_ClearUnsorted_Btn_Click);
            // 
            // UI_N2Sorting_Btn
            // 
            this.UI_N2Sorting_Btn.Location = new System.Drawing.Point(333, 254);
            this.UI_N2Sorting_Btn.Name = "UI_N2Sorting_Btn";
            this.UI_N2Sorting_Btn.Size = new System.Drawing.Size(136, 47);
            this.UI_N2Sorting_Btn.TabIndex = 8;
            this.UI_N2Sorting_Btn.Text = "N^2 Sorting";
            this.UI_N2Sorting_Btn.UseVisualStyleBackColor = true;
            this.UI_N2Sorting_Btn.Click += new System.EventHandler(this.UI_N2Sorting_Btn_Click);
            // 
            // UI_QuickSort_Btn
            // 
            this.UI_QuickSort_Btn.Location = new System.Drawing.Point(333, 314);
            this.UI_QuickSort_Btn.Name = "UI_QuickSort_Btn";
            this.UI_QuickSort_Btn.Size = new System.Drawing.Size(136, 47);
            this.UI_QuickSort_Btn.TabIndex = 9;
            this.UI_QuickSort_Btn.Text = "Quick Sort";
            this.UI_QuickSort_Btn.UseVisualStyleBackColor = true;
            this.UI_QuickSort_Btn.Click += new System.EventHandler(this.UI_QuickSort_Btn_Click);
            // 
            // UI_ClearSorted_Btn
            // 
            this.UI_ClearSorted_Btn.Location = new System.Drawing.Point(333, 374);
            this.UI_ClearSorted_Btn.Name = "UI_ClearSorted_Btn";
            this.UI_ClearSorted_Btn.Size = new System.Drawing.Size(136, 47);
            this.UI_ClearSorted_Btn.TabIndex = 10;
            this.UI_ClearSorted_Btn.Text = "Clear Sorted Listbox";
            this.UI_ClearSorted_Btn.UseVisualStyleBackColor = true;
            this.UI_ClearSorted_Btn.Click += new System.EventHandler(this.UI_ClearSorted_Btn_Click);
            // 
            // UI_LoadFiles_Btn
            // 
            this.UI_LoadFiles_Btn.Location = new System.Drawing.Point(333, 434);
            this.UI_LoadFiles_Btn.Name = "UI_LoadFiles_Btn";
            this.UI_LoadFiles_Btn.Size = new System.Drawing.Size(136, 47);
            this.UI_LoadFiles_Btn.TabIndex = 11;
            this.UI_LoadFiles_Btn.Text = "Load Files";
            this.UI_LoadFiles_Btn.UseVisualStyleBackColor = true;
            this.UI_LoadFiles_Btn.Click += new System.EventHandler(this.UI_LoadFiles_Btn_Click);
            // 
            // UI_Rad_Grpbx
            // 
            this.UI_Rad_Grpbx.Controls.Add(this.UI_FileData_Radbtn);
            this.UI_Rad_Grpbx.Controls.Add(this.UI_ProvList_Radbtn);
            this.UI_Rad_Grpbx.Location = new System.Drawing.Point(333, 161);
            this.UI_Rad_Grpbx.Name = "UI_Rad_Grpbx";
            this.UI_Rad_Grpbx.Size = new System.Drawing.Size(136, 87);
            this.UI_Rad_Grpbx.TabIndex = 12;
            this.UI_Rad_Grpbx.TabStop = false;
            // 
            // UI_FileData_Radbtn
            // 
            this.UI_FileData_Radbtn.AutoSize = true;
            this.UI_FileData_Radbtn.Location = new System.Drawing.Point(6, 47);
            this.UI_FileData_Radbtn.Name = "UI_FileData_Radbtn";
            this.UI_FileData_Radbtn.Size = new System.Drawing.Size(82, 20);
            this.UI_FileData_Radbtn.TabIndex = 1;
            this.UI_FileData_Radbtn.Text = "File Data";
            this.UI_FileData_Radbtn.UseVisualStyleBackColor = true;
            // 
            // UI_ProvList_Radbtn
            // 
            this.UI_ProvList_Radbtn.AutoSize = true;
            this.UI_ProvList_Radbtn.Checked = true;
            this.UI_ProvList_Radbtn.Location = new System.Drawing.Point(6, 21);
            this.UI_ProvList_Radbtn.Name = "UI_ProvList_Radbtn";
            this.UI_ProvList_Radbtn.Size = new System.Drawing.Size(106, 20);
            this.UI_ProvList_Radbtn.TabIndex = 0;
            this.UI_ProvList_Radbtn.TabStop = true;
            this.UI_ProvList_Radbtn.Text = "Provided List";
            this.UI_ProvList_Radbtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 540);
            this.Controls.Add(this.UI_Rad_Grpbx);
            this.Controls.Add(this.UI_LoadFiles_Btn);
            this.Controls.Add(this.UI_ClearSorted_Btn);
            this.Controls.Add(this.UI_QuickSort_Btn);
            this.Controls.Add(this.UI_N2Sorting_Btn);
            this.Controls.Add(this.UI_ClearUnsorted_Btn);
            this.Controls.Add(this.UI_DisplayUnsorted_Btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UI_Ticks_Tbx);
            this.Controls.Add(this.UI_Sorted_Lbl);
            this.Controls.Add(this.UI_Unsorted_Lbl);
            this.Controls.Add(this.UI_Sorted_Lstbox);
            this.Controls.Add(this.UI_Unsorted_Lstbx);
            this.Name = "Form1";
            this.Text = "ICA08-Sorting Structs";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.UI_Rad_Grpbx.ResumeLayout(false);
            this.UI_Rad_Grpbx.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox UI_Unsorted_Lstbx;
        private System.Windows.Forms.ListBox UI_Sorted_Lstbox;
        private System.Windows.Forms.Label UI_Unsorted_Lbl;
        private System.Windows.Forms.Label UI_Sorted_Lbl;
        private System.Windows.Forms.TextBox UI_Ticks_Tbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button UI_DisplayUnsorted_Btn;
        private System.Windows.Forms.Button UI_ClearUnsorted_Btn;
        private System.Windows.Forms.Button UI_N2Sorting_Btn;
        private System.Windows.Forms.Button UI_QuickSort_Btn;
        private System.Windows.Forms.Button UI_ClearSorted_Btn;
        private System.Windows.Forms.Button UI_LoadFiles_Btn;
        private System.Windows.Forms.GroupBox UI_Rad_Grpbx;
        private System.Windows.Forms.RadioButton UI_FileData_Radbtn;
        private System.Windows.Forms.RadioButton UI_ProvList_Radbtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

