namespace Exam3Practice1
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
            this.UI_Result_Tbx = new System.Windows.Forms.TextBox();
            this.UI_Result_Lbl = new System.Windows.Forms.Label();
            this.UI_Show_Btn = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // UI_Result_Tbx
            // 
            this.UI_Result_Tbx.Location = new System.Drawing.Point(209, 172);
            this.UI_Result_Tbx.Name = "UI_Result_Tbx";
            this.UI_Result_Tbx.ReadOnly = true;
            this.UI_Result_Tbx.Size = new System.Drawing.Size(100, 22);
            this.UI_Result_Tbx.TabIndex = 0;
            // 
            // UI_Result_Lbl
            // 
            this.UI_Result_Lbl.AutoSize = true;
            this.UI_Result_Lbl.Location = new System.Drawing.Point(152, 175);
            this.UI_Result_Lbl.Name = "UI_Result_Lbl";
            this.UI_Result_Lbl.Size = new System.Drawing.Size(51, 16);
            this.UI_Result_Lbl.TabIndex = 1;
            this.UI_Result_Lbl.Text = "Result: ";
            // 
            // UI_Show_Btn
            // 
            this.UI_Show_Btn.AutoSize = true;
            this.UI_Show_Btn.Location = new System.Drawing.Point(184, 81);
            this.UI_Show_Btn.Name = "UI_Show_Btn";
            this.UI_Show_Btn.Size = new System.Drawing.Size(125, 20);
            this.UI_Show_Btn.TabIndex = 2;
            this.UI_Show_Btn.Text = "Show Modeless";
            this.UI_Show_Btn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 259);
            this.Controls.Add(this.UI_Show_Btn);
            this.Controls.Add(this.UI_Result_Lbl);
            this.Controls.Add(this.UI_Result_Tbx);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UI_Result_Tbx;
        private System.Windows.Forms.Label UI_Result_Lbl;
        private System.Windows.Forms.CheckBox UI_Show_Btn;
    }
}

