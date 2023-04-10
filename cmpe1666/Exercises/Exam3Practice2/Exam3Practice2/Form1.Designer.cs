namespace Exam3Practice2
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
            this.UI_Fixed_Lbl = new System.Windows.Forms.Label();
            this.UI_Fixed_Lstbx = new System.Windows.Forms.ListBox();
            this.UI_GenerateFixed_Btn = new System.Windows.Forms.Button();
            this.UI_Variable_Lbl = new System.Windows.Forms.Label();
            this.UI_Variable_Lstbx = new System.Windows.Forms.ListBox();
            this.UI_Min_Tbx = new System.Windows.Forms.TextBox();
            this.UI_Max_Tbx = new System.Windows.Forms.TextBox();
            this.UI_Qty_Tbx = new System.Windows.Forms.TextBox();
            this.UI_GenerateVariable_Btn = new System.Windows.Forms.Button();
            this.UI_Min_Lbl = new System.Windows.Forms.Label();
            this.UI_Max_Lbl = new System.Windows.Forms.Label();
            this.UI_Qty_Lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UI_Fixed_Lbl
            // 
            this.UI_Fixed_Lbl.AutoSize = true;
            this.UI_Fixed_Lbl.Location = new System.Drawing.Point(59, 9);
            this.UI_Fixed_Lbl.Name = "UI_Fixed_Lbl";
            this.UI_Fixed_Lbl.Size = new System.Drawing.Size(129, 16);
            this.UI_Fixed_Lbl.TabIndex = 0;
            this.UI_Fixed_Lbl.Text = "Fixed Range Values";
            // 
            // UI_Fixed_Lstbx
            // 
            this.UI_Fixed_Lstbx.FormattingEnabled = true;
            this.UI_Fixed_Lstbx.ItemHeight = 16;
            this.UI_Fixed_Lstbx.Location = new System.Drawing.Point(12, 28);
            this.UI_Fixed_Lstbx.Name = "UI_Fixed_Lstbx";
            this.UI_Fixed_Lstbx.Size = new System.Drawing.Size(238, 164);
            this.UI_Fixed_Lstbx.TabIndex = 1;
            // 
            // UI_GenerateFixed_Btn
            // 
            this.UI_GenerateFixed_Btn.Location = new System.Drawing.Point(31, 207);
            this.UI_GenerateFixed_Btn.Name = "UI_GenerateFixed_Btn";
            this.UI_GenerateFixed_Btn.Size = new System.Drawing.Size(167, 53);
            this.UI_GenerateFixed_Btn.TabIndex = 2;
            this.UI_GenerateFixed_Btn.Text = "Generate Fixed Range";
            this.UI_GenerateFixed_Btn.UseVisualStyleBackColor = true;
            // 
            // UI_Variable_Lbl
            // 
            this.UI_Variable_Lbl.AutoSize = true;
            this.UI_Variable_Lbl.Location = new System.Drawing.Point(458, 9);
            this.UI_Variable_Lbl.Name = "UI_Variable_Lbl";
            this.UI_Variable_Lbl.Size = new System.Drawing.Size(147, 16);
            this.UI_Variable_Lbl.TabIndex = 3;
            this.UI_Variable_Lbl.Text = "Variable Range Values";
            // 
            // UI_Variable_Lstbx
            // 
            this.UI_Variable_Lstbx.FormattingEnabled = true;
            this.UI_Variable_Lstbx.ItemHeight = 16;
            this.UI_Variable_Lstbx.Location = new System.Drawing.Point(396, 28);
            this.UI_Variable_Lstbx.Name = "UI_Variable_Lstbx";
            this.UI_Variable_Lstbx.Size = new System.Drawing.Size(256, 164);
            this.UI_Variable_Lstbx.TabIndex = 4;
            // 
            // UI_Min_Tbx
            // 
            this.UI_Min_Tbx.Location = new System.Drawing.Point(505, 222);
            this.UI_Min_Tbx.Name = "UI_Min_Tbx";
            this.UI_Min_Tbx.Size = new System.Drawing.Size(100, 22);
            this.UI_Min_Tbx.TabIndex = 5;
            // 
            // UI_Max_Tbx
            // 
            this.UI_Max_Tbx.Location = new System.Drawing.Point(505, 263);
            this.UI_Max_Tbx.Name = "UI_Max_Tbx";
            this.UI_Max_Tbx.Size = new System.Drawing.Size(100, 22);
            this.UI_Max_Tbx.TabIndex = 6;
            // 
            // UI_Qty_Tbx
            // 
            this.UI_Qty_Tbx.Location = new System.Drawing.Point(505, 304);
            this.UI_Qty_Tbx.Name = "UI_Qty_Tbx";
            this.UI_Qty_Tbx.Size = new System.Drawing.Size(100, 22);
            this.UI_Qty_Tbx.TabIndex = 7;
            // 
            // UI_GenerateVariable_Btn
            // 
            this.UI_GenerateVariable_Btn.Location = new System.Drawing.Point(396, 336);
            this.UI_GenerateVariable_Btn.Name = "UI_GenerateVariable_Btn";
            this.UI_GenerateVariable_Btn.Size = new System.Drawing.Size(167, 53);
            this.UI_GenerateVariable_Btn.TabIndex = 8;
            this.UI_GenerateVariable_Btn.Text = "Generate Fixed Range";
            this.UI_GenerateVariable_Btn.UseVisualStyleBackColor = true;
            // 
            // UI_Min_Lbl
            // 
            this.UI_Min_Lbl.AutoSize = true;
            this.UI_Min_Lbl.Location = new System.Drawing.Point(350, 228);
            this.UI_Min_Lbl.Name = "UI_Min_Lbl";
            this.UI_Min_Lbl.Size = new System.Drawing.Size(145, 16);
            this.UI_Min_Lbl.TabIndex = 9;
            this.UI_Min_Lbl.Text = "Minimum Range Value:";
            // 
            // UI_Max_Lbl
            // 
            this.UI_Max_Lbl.AutoSize = true;
            this.UI_Max_Lbl.Location = new System.Drawing.Point(350, 266);
            this.UI_Max_Lbl.Name = "UI_Max_Lbl";
            this.UI_Max_Lbl.Size = new System.Drawing.Size(149, 16);
            this.UI_Max_Lbl.TabIndex = 10;
            this.UI_Max_Lbl.Text = "Maximum Range Value:";
            // 
            // UI_Qty_Lbl
            // 
            this.UI_Qty_Lbl.AutoSize = true;
            this.UI_Qty_Lbl.Location = new System.Drawing.Point(350, 304);
            this.UI_Qty_Lbl.Name = "UI_Qty_Lbl";
            this.UI_Qty_Lbl.Size = new System.Drawing.Size(117, 16);
            this.UI_Qty_Lbl.TabIndex = 11;
            this.UI_Qty_Lbl.Text = "Number of Values:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 401);
            this.Controls.Add(this.UI_Qty_Lbl);
            this.Controls.Add(this.UI_Max_Lbl);
            this.Controls.Add(this.UI_Min_Lbl);
            this.Controls.Add(this.UI_GenerateVariable_Btn);
            this.Controls.Add(this.UI_Qty_Tbx);
            this.Controls.Add(this.UI_Max_Tbx);
            this.Controls.Add(this.UI_Min_Tbx);
            this.Controls.Add(this.UI_Variable_Lstbx);
            this.Controls.Add(this.UI_Variable_Lbl);
            this.Controls.Add(this.UI_GenerateFixed_Btn);
            this.Controls.Add(this.UI_Fixed_Lstbx);
            this.Controls.Add(this.UI_Fixed_Lbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UI_Fixed_Lbl;
        private System.Windows.Forms.ListBox UI_Fixed_Lstbx;
        private System.Windows.Forms.Button UI_GenerateFixed_Btn;
        private System.Windows.Forms.Label UI_Variable_Lbl;
        private System.Windows.Forms.ListBox UI_Variable_Lstbx;
        private System.Windows.Forms.TextBox UI_Min_Tbx;
        private System.Windows.Forms.TextBox UI_Max_Tbx;
        private System.Windows.Forms.TextBox UI_Qty_Tbx;
        private System.Windows.Forms.Button UI_GenerateVariable_Btn;
        private System.Windows.Forms.Label UI_Min_Lbl;
        private System.Windows.Forms.Label UI_Max_Lbl;
        private System.Windows.Forms.Label UI_Qty_Lbl;
    }
}

