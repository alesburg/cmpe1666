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
            this.SuspendLayout();
            // 
            // UI_Unsorted_Lstbx
            // 
            this.UI_Unsorted_Lstbx.FormattingEnabled = true;
            this.UI_Unsorted_Lstbx.ItemHeight = 16;
            this.UI_Unsorted_Lstbx.Location = new System.Drawing.Point(509, 46);
            this.UI_Unsorted_Lstbx.Name = "UI_Unsorted_Lstbx";
            this.UI_Unsorted_Lstbx.Size = new System.Drawing.Size(279, 436);
            this.UI_Unsorted_Lstbx.TabIndex = 0;
            // 
            // UI_Sorted_Lstbox
            // 
            this.UI_Sorted_Lstbox.FormattingEnabled = true;
            this.UI_Sorted_Lstbox.ItemHeight = 16;
            this.UI_Sorted_Lstbox.Location = new System.Drawing.Point(12, 46);
            this.UI_Sorted_Lstbox.Name = "UI_Sorted_Lstbox";
            this.UI_Sorted_Lstbox.Size = new System.Drawing.Size(279, 436);
            this.UI_Sorted_Lstbox.TabIndex = 1;
            // 
            // UI_Unsorted_Lbl
            // 
            this.UI_Unsorted_Lbl.AutoSize = true;
            this.UI_Unsorted_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_Unsorted_Lbl.Location = new System.Drawing.Point(86, 23);
            this.UI_Unsorted_Lbl.Name = "UI_Unsorted_Lbl";
            this.UI_Unsorted_Lbl.Size = new System.Drawing.Size(131, 20);
            this.UI_Unsorted_Lbl.TabIndex = 2;
            this.UI_Unsorted_Lbl.Text = "Unsorted Data";
            // 
            // UI_Sorted_Lbl
            // 
            this.UI_Sorted_Lbl.AutoSize = true;
            this.UI_Sorted_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_Sorted_Lbl.Location = new System.Drawing.Point(593, 23);
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
            this.label1.Location = new System.Drawing.Point(466, 500);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Time Taken (Elapsed Ticks):";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 540);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UI_Ticks_Tbx);
            this.Controls.Add(this.UI_Sorted_Lbl);
            this.Controls.Add(this.UI_Unsorted_Lbl);
            this.Controls.Add(this.UI_Sorted_Lstbox);
            this.Controls.Add(this.UI_Unsorted_Lstbx);
            this.Name = "Form1";
            this.Text = "ICA08-Sorting Structs";
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
    }
}

