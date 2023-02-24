namespace ICA08_ANNA
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
            this.UI_Sorted_Tbx = new System.Windows.Forms.TextBox();
            this.UI_Unsorted_Tbx = new System.Windows.Forms.TextBox();
            this.UI_Numval_Tbx = new System.Windows.Forms.TextBox();
            this.UI_Minval_Tbx = new System.Windows.Forms.TextBox();
            this.UI_Maxval_Tbx = new System.Windows.Forms.TextBox();
            this.UI_Genval_Btn = new System.Windows.Forms.Button();
            this.UI_Sort_Btn = new System.Windows.Forms.Button();
            this.UI_Time_Tbx = new System.Windows.Forms.TextBox();
            this.UI_Clearsort_Btn = new System.Windows.Forms.Button();
            this.UI_Clearraw_Btn = new System.Windows.Forms.Button();
            this.UI_Redisplay_Btn = new System.Windows.Forms.Button();
            this.UI_Sorted_Lbl = new System.Windows.Forms.Label();
            this.UI_Generated_Lbl = new System.Windows.Forms.Label();
            this.UI_Numval_Lbl = new System.Windows.Forms.Label();
            this.UI_Minval_Lbl = new System.Windows.Forms.Label();
            this.UI_Maxval_Lbl = new System.Windows.Forms.Label();
            this.UI_Method_Grpbx = new System.Windows.Forms.GroupBox();
            this.UI_Quick_Radbtn = new System.Windows.Forms.RadioButton();
            this.UI_Insertion_Radbtn = new System.Windows.Forms.RadioButton();
            this.UI_Selection_Radbtn = new System.Windows.Forms.RadioButton();
            this.UI_Bubble_Radbtn = new System.Windows.Forms.RadioButton();
            this.UI_Ticks_Lbl = new System.Windows.Forms.Label();
            this.UI_Method_Grpbx.SuspendLayout();
            this.SuspendLayout();
            // 
            // UI_Sorted_Tbx
            // 
            this.UI_Sorted_Tbx.Location = new System.Drawing.Point(531, 80);
            this.UI_Sorted_Tbx.Multiline = true;
            this.UI_Sorted_Tbx.Name = "UI_Sorted_Tbx";
            this.UI_Sorted_Tbx.ReadOnly = true;
            this.UI_Sorted_Tbx.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.UI_Sorted_Tbx.Size = new System.Drawing.Size(257, 320);
            this.UI_Sorted_Tbx.TabIndex = 0;
            this.UI_Sorted_Tbx.TabStop = false;
            // 
            // UI_Unsorted_Tbx
            // 
            this.UI_Unsorted_Tbx.Location = new System.Drawing.Point(12, 80);
            this.UI_Unsorted_Tbx.Multiline = true;
            this.UI_Unsorted_Tbx.Name = "UI_Unsorted_Tbx";
            this.UI_Unsorted_Tbx.ReadOnly = true;
            this.UI_Unsorted_Tbx.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.UI_Unsorted_Tbx.Size = new System.Drawing.Size(257, 320);
            this.UI_Unsorted_Tbx.TabIndex = 1;
            this.UI_Unsorted_Tbx.TabStop = false;
            // 
            // UI_Numval_Tbx
            // 
            this.UI_Numval_Tbx.Location = new System.Drawing.Point(388, 57);
            this.UI_Numval_Tbx.Name = "UI_Numval_Tbx";
            this.UI_Numval_Tbx.Size = new System.Drawing.Size(89, 20);
            this.UI_Numval_Tbx.TabIndex = 0;
            // 
            // UI_Minval_Tbx
            // 
            this.UI_Minval_Tbx.Location = new System.Drawing.Point(388, 99);
            this.UI_Minval_Tbx.Name = "UI_Minval_Tbx";
            this.UI_Minval_Tbx.Size = new System.Drawing.Size(89, 20);
            this.UI_Minval_Tbx.TabIndex = 1;
            // 
            // UI_Maxval_Tbx
            // 
            this.UI_Maxval_Tbx.Location = new System.Drawing.Point(388, 143);
            this.UI_Maxval_Tbx.Name = "UI_Maxval_Tbx";
            this.UI_Maxval_Tbx.Size = new System.Drawing.Size(89, 20);
            this.UI_Maxval_Tbx.TabIndex = 2;
            // 
            // UI_Genval_Btn
            // 
            this.UI_Genval_Btn.Location = new System.Drawing.Point(352, 178);
            this.UI_Genval_Btn.Name = "UI_Genval_Btn";
            this.UI_Genval_Btn.Size = new System.Drawing.Size(97, 27);
            this.UI_Genval_Btn.TabIndex = 3;
            this.UI_Genval_Btn.Text = "Generate Values";
            this.UI_Genval_Btn.UseVisualStyleBackColor = true;
            this.UI_Genval_Btn.Click += new System.EventHandler(this.UI_Genval_Btn_Click);
            // 
            // UI_Sort_Btn
            // 
            this.UI_Sort_Btn.Enabled = false;
            this.UI_Sort_Btn.Location = new System.Drawing.Point(363, 343);
            this.UI_Sort_Btn.Name = "UI_Sort_Btn";
            this.UI_Sort_Btn.Size = new System.Drawing.Size(86, 27);
            this.UI_Sort_Btn.TabIndex = 5;
            this.UI_Sort_Btn.Text = "Sort Values";
            this.UI_Sort_Btn.UseVisualStyleBackColor = true;
            this.UI_Sort_Btn.Click += new System.EventHandler(this.UI_Sort_Btn_Click);
            // 
            // UI_Time_Tbx
            // 
            this.UI_Time_Tbx.Location = new System.Drawing.Point(388, 380);
            this.UI_Time_Tbx.Name = "UI_Time_Tbx";
            this.UI_Time_Tbx.ReadOnly = true;
            this.UI_Time_Tbx.Size = new System.Drawing.Size(89, 20);
            this.UI_Time_Tbx.TabIndex = 7;
            this.UI_Time_Tbx.TabStop = false;
            // 
            // UI_Clearsort_Btn
            // 
            this.UI_Clearsort_Btn.Location = new System.Drawing.Point(615, 407);
            this.UI_Clearsort_Btn.Name = "UI_Clearsort_Btn";
            this.UI_Clearsort_Btn.Size = new System.Drawing.Size(88, 31);
            this.UI_Clearsort_Btn.TabIndex = 8;
            this.UI_Clearsort_Btn.Text = "Clear Sorted";
            this.UI_Clearsort_Btn.UseVisualStyleBackColor = true;
            this.UI_Clearsort_Btn.Click += new System.EventHandler(this.UI_Clearsort_Btn_Click);
            // 
            // UI_Clearraw_Btn
            // 
            this.UI_Clearraw_Btn.Location = new System.Drawing.Point(38, 407);
            this.UI_Clearraw_Btn.Name = "UI_Clearraw_Btn";
            this.UI_Clearraw_Btn.Size = new System.Drawing.Size(88, 31);
            this.UI_Clearraw_Btn.TabIndex = 6;
            this.UI_Clearraw_Btn.Text = "Clear Raw";
            this.UI_Clearraw_Btn.UseVisualStyleBackColor = true;
            this.UI_Clearraw_Btn.Click += new System.EventHandler(this.UI_Clearraw_Btn_Click);
            // 
            // UI_Redisplay_Btn
            // 
            this.UI_Redisplay_Btn.Location = new System.Drawing.Point(132, 407);
            this.UI_Redisplay_Btn.Name = "UI_Redisplay_Btn";
            this.UI_Redisplay_Btn.Size = new System.Drawing.Size(88, 31);
            this.UI_Redisplay_Btn.TabIndex = 7;
            this.UI_Redisplay_Btn.Text = "Redisplay";
            this.UI_Redisplay_Btn.UseVisualStyleBackColor = true;
            this.UI_Redisplay_Btn.Click += new System.EventHandler(this.UI_Redisplay_Btn_Click);
            // 
            // UI_Sorted_Lbl
            // 
            this.UI_Sorted_Lbl.AutoSize = true;
            this.UI_Sorted_Lbl.Location = new System.Drawing.Point(613, 57);
            this.UI_Sorted_Lbl.Name = "UI_Sorted_Lbl";
            this.UI_Sorted_Lbl.Size = new System.Drawing.Size(73, 13);
            this.UI_Sorted_Lbl.TabIndex = 11;
            this.UI_Sorted_Lbl.Text = "Sorted Values";
            this.UI_Sorted_Lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // UI_Generated_Lbl
            // 
            this.UI_Generated_Lbl.AutoSize = true;
            this.UI_Generated_Lbl.Location = new System.Drawing.Point(94, 57);
            this.UI_Generated_Lbl.Name = "UI_Generated_Lbl";
            this.UI_Generated_Lbl.Size = new System.Drawing.Size(92, 13);
            this.UI_Generated_Lbl.TabIndex = 12;
            this.UI_Generated_Lbl.Text = "Generated Values";
            this.UI_Generated_Lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // UI_Numval_Lbl
            // 
            this.UI_Numval_Lbl.AutoSize = true;
            this.UI_Numval_Lbl.Location = new System.Drawing.Point(285, 60);
            this.UI_Numval_Lbl.Name = "UI_Numval_Lbl";
            this.UI_Numval_Lbl.Size = new System.Drawing.Size(97, 13);
            this.UI_Numval_Lbl.TabIndex = 13;
            this.UI_Numval_Lbl.Text = "Number of Values: ";
            this.UI_Numval_Lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // UI_Minval_Lbl
            // 
            this.UI_Minval_Lbl.AutoSize = true;
            this.UI_Minval_Lbl.Location = new System.Drawing.Point(301, 102);
            this.UI_Minval_Lbl.Name = "UI_Minval_Lbl";
            this.UI_Minval_Lbl.Size = new System.Drawing.Size(81, 13);
            this.UI_Minval_Lbl.TabIndex = 14;
            this.UI_Minval_Lbl.Text = "Minimum Value:";
            this.UI_Minval_Lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // UI_Maxval_Lbl
            // 
            this.UI_Maxval_Lbl.AutoSize = true;
            this.UI_Maxval_Lbl.Location = new System.Drawing.Point(301, 146);
            this.UI_Maxval_Lbl.Name = "UI_Maxval_Lbl";
            this.UI_Maxval_Lbl.Size = new System.Drawing.Size(84, 13);
            this.UI_Maxval_Lbl.TabIndex = 15;
            this.UI_Maxval_Lbl.Text = "Maximum Value:";
            this.UI_Maxval_Lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // UI_Method_Grpbx
            // 
            this.UI_Method_Grpbx.Controls.Add(this.UI_Quick_Radbtn);
            this.UI_Method_Grpbx.Controls.Add(this.UI_Insertion_Radbtn);
            this.UI_Method_Grpbx.Controls.Add(this.UI_Selection_Radbtn);
            this.UI_Method_Grpbx.Controls.Add(this.UI_Bubble_Radbtn);
            this.UI_Method_Grpbx.Location = new System.Drawing.Point(340, 211);
            this.UI_Method_Grpbx.Name = "UI_Method_Grpbx";
            this.UI_Method_Grpbx.Size = new System.Drawing.Size(132, 126);
            this.UI_Method_Grpbx.TabIndex = 4;
            this.UI_Method_Grpbx.TabStop = false;
            this.UI_Method_Grpbx.Text = "Sorting Method";
            // 
            // UI_Quick_Radbtn
            // 
            this.UI_Quick_Radbtn.AutoSize = true;
            this.UI_Quick_Radbtn.Location = new System.Drawing.Point(12, 88);
            this.UI_Quick_Radbtn.Name = "UI_Quick_Radbtn";
            this.UI_Quick_Radbtn.Size = new System.Drawing.Size(75, 17);
            this.UI_Quick_Radbtn.TabIndex = 3;
            this.UI_Quick_Radbtn.TabStop = true;
            this.UI_Quick_Radbtn.Text = "Quick Sort";
            this.UI_Quick_Radbtn.UseVisualStyleBackColor = true;
            // 
            // UI_Insertion_Radbtn
            // 
            this.UI_Insertion_Radbtn.AutoSize = true;
            this.UI_Insertion_Radbtn.Location = new System.Drawing.Point(12, 65);
            this.UI_Insertion_Radbtn.Name = "UI_Insertion_Radbtn";
            this.UI_Insertion_Radbtn.Size = new System.Drawing.Size(65, 17);
            this.UI_Insertion_Radbtn.TabIndex = 2;
            this.UI_Insertion_Radbtn.TabStop = true;
            this.UI_Insertion_Radbtn.Text = "Insertion";
            this.UI_Insertion_Radbtn.UseVisualStyleBackColor = true;
            // 
            // UI_Selection_Radbtn
            // 
            this.UI_Selection_Radbtn.AutoSize = true;
            this.UI_Selection_Radbtn.Location = new System.Drawing.Point(12, 42);
            this.UI_Selection_Radbtn.Name = "UI_Selection_Radbtn";
            this.UI_Selection_Radbtn.Size = new System.Drawing.Size(91, 17);
            this.UI_Selection_Radbtn.TabIndex = 1;
            this.UI_Selection_Radbtn.TabStop = true;
            this.UI_Selection_Radbtn.Text = "Selection Sort";
            this.UI_Selection_Radbtn.UseVisualStyleBackColor = true;
            // 
            // UI_Bubble_Radbtn
            // 
            this.UI_Bubble_Radbtn.AutoSize = true;
            this.UI_Bubble_Radbtn.Checked = true;
            this.UI_Bubble_Radbtn.Location = new System.Drawing.Point(12, 19);
            this.UI_Bubble_Radbtn.Name = "UI_Bubble_Radbtn";
            this.UI_Bubble_Radbtn.Size = new System.Drawing.Size(80, 17);
            this.UI_Bubble_Radbtn.TabIndex = 0;
            this.UI_Bubble_Radbtn.TabStop = true;
            this.UI_Bubble_Radbtn.Text = "Bubble Sort";
            this.UI_Bubble_Radbtn.UseVisualStyleBackColor = true;
            // 
            // UI_Ticks_Lbl
            // 
            this.UI_Ticks_Lbl.AutoSize = true;
            this.UI_Ticks_Lbl.Location = new System.Drawing.Point(282, 383);
            this.UI_Ticks_Lbl.Name = "UI_Ticks_Lbl";
            this.UI_Ticks_Lbl.Size = new System.Drawing.Size(103, 13);
            this.UI_Ticks_Lbl.TabIndex = 17;
            this.UI_Ticks_Lbl.Text = "Sorting Time (ticks): ";
            this.UI_Ticks_Lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UI_Ticks_Lbl);
            this.Controls.Add(this.UI_Method_Grpbx);
            this.Controls.Add(this.UI_Maxval_Lbl);
            this.Controls.Add(this.UI_Minval_Lbl);
            this.Controls.Add(this.UI_Numval_Lbl);
            this.Controls.Add(this.UI_Generated_Lbl);
            this.Controls.Add(this.UI_Sorted_Lbl);
            this.Controls.Add(this.UI_Redisplay_Btn);
            this.Controls.Add(this.UI_Clearraw_Btn);
            this.Controls.Add(this.UI_Clearsort_Btn);
            this.Controls.Add(this.UI_Time_Tbx);
            this.Controls.Add(this.UI_Sort_Btn);
            this.Controls.Add(this.UI_Genval_Btn);
            this.Controls.Add(this.UI_Maxval_Tbx);
            this.Controls.Add(this.UI_Minval_Tbx);
            this.Controls.Add(this.UI_Numval_Tbx);
            this.Controls.Add(this.UI_Unsorted_Tbx);
            this.Controls.Add(this.UI_Sorted_Tbx);
            this.Name = "Form1";
            this.Text = "ICA08";
            this.UI_Method_Grpbx.ResumeLayout(false);
            this.UI_Method_Grpbx.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UI_Sorted_Tbx;
        private System.Windows.Forms.TextBox UI_Unsorted_Tbx;
        private System.Windows.Forms.TextBox UI_Numval_Tbx;
        private System.Windows.Forms.TextBox UI_Minval_Tbx;
        private System.Windows.Forms.TextBox UI_Maxval_Tbx;
        private System.Windows.Forms.Button UI_Genval_Btn;
        private System.Windows.Forms.Button UI_Sort_Btn;
        private System.Windows.Forms.TextBox UI_Time_Tbx;
        private System.Windows.Forms.Button UI_Clearsort_Btn;
        private System.Windows.Forms.Button UI_Clearraw_Btn;
        private System.Windows.Forms.Button UI_Redisplay_Btn;
        private System.Windows.Forms.Label UI_Sorted_Lbl;
        private System.Windows.Forms.Label UI_Generated_Lbl;
        private System.Windows.Forms.Label UI_Numval_Lbl;
        private System.Windows.Forms.Label UI_Minval_Lbl;
        private System.Windows.Forms.Label UI_Maxval_Lbl;
        private System.Windows.Forms.GroupBox UI_Method_Grpbx;
        private System.Windows.Forms.RadioButton UI_Quick_Radbtn;
        private System.Windows.Forms.RadioButton UI_Insertion_Radbtn;
        private System.Windows.Forms.RadioButton UI_Selection_Radbtn;
        private System.Windows.Forms.RadioButton UI_Bubble_Radbtn;
        private System.Windows.Forms.Label UI_Ticks_Lbl;
    }
}

