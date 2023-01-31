namespace ICA06_Anna
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.UI_Generate_Btn = new System.Windows.Forms.Button();
            this.UI_Fill_Btn = new System.Windows.Forms.Button();
            this.UI_FillColor_Btn = new System.Windows.Forms.Button();
            this.UI_NumBlocks_Lbl = new System.Windows.Forms.Label();
            this.UI_FillClr_Lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UI_Generate_Btn
            // 
            this.UI_Generate_Btn.Location = new System.Drawing.Point(12, 245);
            this.UI_Generate_Btn.Name = "UI_Generate_Btn";
            this.UI_Generate_Btn.Size = new System.Drawing.Size(107, 34);
            this.UI_Generate_Btn.TabIndex = 0;
            this.UI_Generate_Btn.Text = "Generate";
            this.UI_Generate_Btn.UseVisualStyleBackColor = true;
            // 
            // UI_Fill_Btn
            // 
            this.UI_Fill_Btn.Location = new System.Drawing.Point(296, 245);
            this.UI_Fill_Btn.Name = "UI_Fill_Btn";
            this.UI_Fill_Btn.Size = new System.Drawing.Size(107, 34);
            this.UI_Fill_Btn.TabIndex = 1;
            this.UI_Fill_Btn.Text = "Fill";
            this.UI_Fill_Btn.UseVisualStyleBackColor = true;
            // 
            // UI_FillColor_Btn
            // 
            this.UI_FillColor_Btn.Location = new System.Drawing.Point(154, 245);
            this.UI_FillColor_Btn.Name = "UI_FillColor_Btn";
            this.UI_FillColor_Btn.Size = new System.Drawing.Size(107, 34);
            this.UI_FillColor_Btn.TabIndex = 2;
            this.UI_FillColor_Btn.Text = "Fill Color";
            this.UI_FillColor_Btn.UseVisualStyleBackColor = true;
            // 
            // UI_NumBlocks_Lbl
            // 
            this.UI_NumBlocks_Lbl.AutoSize = true;
            this.UI_NumBlocks_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.UI_NumBlocks_Lbl.Location = new System.Drawing.Point(125, 9);
            this.UI_NumBlocks_Lbl.Name = "UI_NumBlocks_Lbl";
            this.UI_NumBlocks_Lbl.Size = new System.Drawing.Size(165, 25);
            this.UI_NumBlocks_Lbl.TabIndex = 3;
            this.UI_NumBlocks_Lbl.Text = "Number of Blocks";
            this.UI_NumBlocks_Lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // UI_FillClr_Lbl
            // 
            this.UI_FillClr_Lbl.AutoSize = true;
            this.UI_FillClr_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.UI_FillClr_Lbl.Location = new System.Drawing.Point(110, 159);
            this.UI_FillClr_Lbl.Name = "UI_FillClr_Lbl";
            this.UI_FillClr_Lbl.Size = new System.Drawing.Size(88, 25);
            this.UI_FillClr_Lbl.TabIndex = 4;
            this.UI_FillClr_Lbl.Text = "Fill Color";
            this.UI_FillClr_Lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 291);
            this.Controls.Add(this.UI_FillClr_Lbl);
            this.Controls.Add(this.UI_NumBlocks_Lbl);
            this.Controls.Add(this.UI_FillColor_Btn);
            this.Controls.Add(this.UI_Fill_Btn);
            this.Controls.Add(this.UI_Generate_Btn);
            this.MaximumSize = new System.Drawing.Size(433, 338);
            this.MinimumSize = new System.Drawing.Size(433, 338);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button UI_Generate_Btn;
        private System.Windows.Forms.Button UI_Fill_Btn;
        private System.Windows.Forms.Button UI_FillColor_Btn;
        private System.Windows.Forms.Label UI_NumBlocks_Lbl;
        private System.Windows.Forms.Label UI_FillClr_Lbl;
    }
}

