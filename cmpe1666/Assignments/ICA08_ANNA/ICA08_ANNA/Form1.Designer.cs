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
            // 
            // UI_Numval_Tbx
            // 
            this.UI_Numval_Tbx.Location = new System.Drawing.Point(388, 57);
            this.UI_Numval_Tbx.Name = "UI_Numval_Tbx";
            this.UI_Numval_Tbx.Size = new System.Drawing.Size(89, 20);
            this.UI_Numval_Tbx.TabIndex = 2;
            // 
            // UI_Minval_Tbx
            // 
            this.UI_Minval_Tbx.Location = new System.Drawing.Point(388, 99);
            this.UI_Minval_Tbx.Name = "UI_Minval_Tbx";
            this.UI_Minval_Tbx.Size = new System.Drawing.Size(89, 20);
            this.UI_Minval_Tbx.TabIndex = 3;
            // 
            // UI_Maxval_Tbx
            // 
            this.UI_Maxval_Tbx.Location = new System.Drawing.Point(388, 143);
            this.UI_Maxval_Tbx.Name = "UI_Maxval_Tbx";
            this.UI_Maxval_Tbx.Size = new System.Drawing.Size(89, 20);
            this.UI_Maxval_Tbx.TabIndex = 4;
            // 
            // UI_Genval_Btn
            // 
            this.UI_Genval_Btn.Location = new System.Drawing.Point(352, 178);
            this.UI_Genval_Btn.Name = "UI_Genval_Btn";
            this.UI_Genval_Btn.Size = new System.Drawing.Size(97, 27);
            this.UI_Genval_Btn.TabIndex = 5;
            this.UI_Genval_Btn.Text = "Generate Values";
            this.UI_Genval_Btn.UseVisualStyleBackColor = true;
            // 
            // UI_Sort_Btn
            // 
            this.UI_Sort_Btn.Location = new System.Drawing.Point(363, 327);
            this.UI_Sort_Btn.Name = "UI_Sort_Btn";
            this.UI_Sort_Btn.Size = new System.Drawing.Size(86, 27);
            this.UI_Sort_Btn.TabIndex = 6;
            this.UI_Sort_Btn.Text = "Sort Values";
            this.UI_Sort_Btn.UseVisualStyleBackColor = true;
            // 
            // UI_Time_Tbx
            // 
            this.UI_Time_Tbx.Location = new System.Drawing.Point(388, 380);
            this.UI_Time_Tbx.Name = "UI_Time_Tbx";
            this.UI_Time_Tbx.ReadOnly = true;
            this.UI_Time_Tbx.Size = new System.Drawing.Size(89, 20);
            this.UI_Time_Tbx.TabIndex = 7;
            // 
            // UI_Clearsort_Btn
            // 
            this.UI_Clearsort_Btn.Location = new System.Drawing.Point(615, 407);
            this.UI_Clearsort_Btn.Name = "UI_Clearsort_Btn";
            this.UI_Clearsort_Btn.Size = new System.Drawing.Size(88, 31);
            this.UI_Clearsort_Btn.TabIndex = 8;
            this.UI_Clearsort_Btn.Text = "Clear Sorted";
            this.UI_Clearsort_Btn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

