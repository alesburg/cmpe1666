namespace Lec2B_Ex5
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
            this.UI_Val1_Tbx = new System.Windows.Forms.TextBox();
            this.UI_Val2_Tbx = new System.Windows.Forms.TextBox();
            this.UI_Val1_Lbl = new System.Windows.Forms.Label();
            this.UI_Val2_Lbl = new System.Windows.Forms.Label();
            this.UI_Sum_Lbl = new System.Windows.Forms.Label();
            this.UI_Sum_Tbx = new System.Windows.Forms.TextBox();
            this.UI_Sum_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UI_Val1_Tbx
            // 
            this.UI_Val1_Tbx.Location = new System.Drawing.Point(260, 109);
            this.UI_Val1_Tbx.Name = "UI_Val1_Tbx";
            this.UI_Val1_Tbx.Size = new System.Drawing.Size(100, 22);
            this.UI_Val1_Tbx.TabIndex = 0;
            // 
            // UI_Val2_Tbx
            // 
            this.UI_Val2_Tbx.Location = new System.Drawing.Point(260, 173);
            this.UI_Val2_Tbx.Name = "UI_Val2_Tbx";
            this.UI_Val2_Tbx.Size = new System.Drawing.Size(100, 22);
            this.UI_Val2_Tbx.TabIndex = 1;
            // 
            // UI_Val1_Lbl
            // 
            this.UI_Val1_Lbl.AutoSize = true;
            this.UI_Val1_Lbl.Location = new System.Drawing.Point(194, 114);
            this.UI_Val1_Lbl.Name = "UI_Val1_Lbl";
            this.UI_Val1_Lbl.Size = new System.Drawing.Size(55, 16);
            this.UI_Val1_Lbl.TabIndex = 2;
            this.UI_Val1_Lbl.Text = "Value 1:";
            // 
            // UI_Val2_Lbl
            // 
            this.UI_Val2_Lbl.AutoSize = true;
            this.UI_Val2_Lbl.Location = new System.Drawing.Point(194, 176);
            this.UI_Val2_Lbl.Name = "UI_Val2_Lbl";
            this.UI_Val2_Lbl.Size = new System.Drawing.Size(55, 16);
            this.UI_Val2_Lbl.TabIndex = 3;
            this.UI_Val2_Lbl.Text = "Value 2:";
            // 
            // UI_Sum_Lbl
            // 
            this.UI_Sum_Lbl.AutoSize = true;
            this.UI_Sum_Lbl.Location = new System.Drawing.Point(212, 330);
            this.UI_Sum_Lbl.Name = "UI_Sum_Lbl";
            this.UI_Sum_Lbl.Size = new System.Drawing.Size(37, 16);
            this.UI_Sum_Lbl.TabIndex = 4;
            this.UI_Sum_Lbl.Text = "Sum:";
            // 
            // UI_Sum_Tbx
            // 
            this.UI_Sum_Tbx.Location = new System.Drawing.Point(260, 330);
            this.UI_Sum_Tbx.Name = "UI_Sum_Tbx";
            this.UI_Sum_Tbx.ReadOnly = true;
            this.UI_Sum_Tbx.Size = new System.Drawing.Size(100, 22);
            this.UI_Sum_Tbx.TabIndex = 5;
            // 
            // UI_Sum_Btn
            // 
            this.UI_Sum_Btn.Location = new System.Drawing.Point(247, 241);
            this.UI_Sum_Btn.Name = "UI_Sum_Btn";
            this.UI_Sum_Btn.Size = new System.Drawing.Size(128, 53);
            this.UI_Sum_Btn.TabIndex = 6;
            this.UI_Sum_Btn.Text = "Calculate Sum";
            this.UI_Sum_Btn.UseVisualStyleBackColor = true;
            this.UI_Sum_Btn.Click += new System.EventHandler(this.UI_Sum_Btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UI_Sum_Btn);
            this.Controls.Add(this.UI_Sum_Tbx);
            this.Controls.Add(this.UI_Sum_Lbl);
            this.Controls.Add(this.UI_Val2_Lbl);
            this.Controls.Add(this.UI_Val1_Lbl);
            this.Controls.Add(this.UI_Val2_Tbx);
            this.Controls.Add(this.UI_Val1_Tbx);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UI_Val1_Tbx;
        private System.Windows.Forms.TextBox UI_Val2_Tbx;
        private System.Windows.Forms.Label UI_Val1_Lbl;
        private System.Windows.Forms.Label UI_Val2_Lbl;
        private System.Windows.Forms.Label UI_Sum_Lbl;
        private System.Windows.Forms.TextBox UI_Sum_Tbx;
        private System.Windows.Forms.Button UI_Sum_Btn;
    }
}

