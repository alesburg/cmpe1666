namespace LAB04_ANNA
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
            this.UI_UndoLine_Btn = new System.Windows.Forms.Button();
            this.UI_UndoSeg_Btn = new System.Windows.Forms.Button();
            this.UI_Reduce_Btn = new System.Windows.Forms.Button();
            this.UI_Color_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UI_UndoLine_Btn
            // 
            this.UI_UndoLine_Btn.Location = new System.Drawing.Point(12, 52);
            this.UI_UndoLine_Btn.Name = "UI_UndoLine_Btn";
            this.UI_UndoLine_Btn.Size = new System.Drawing.Size(409, 28);
            this.UI_UndoLine_Btn.TabIndex = 0;
            this.UI_UndoLine_Btn.Text = "Undo Line...";
            this.UI_UndoLine_Btn.UseVisualStyleBackColor = true;
            // 
            // UI_UndoSeg_Btn
            // 
            this.UI_UndoSeg_Btn.Location = new System.Drawing.Point(12, 86);
            this.UI_UndoSeg_Btn.Name = "UI_UndoSeg_Btn";
            this.UI_UndoSeg_Btn.Size = new System.Drawing.Size(409, 28);
            this.UI_UndoSeg_Btn.TabIndex = 1;
            this.UI_UndoSeg_Btn.Text = "Undo Segment...";
            this.UI_UndoSeg_Btn.UseVisualStyleBackColor = true;
            // 
            // UI_Reduce_Btn
            // 
            this.UI_Reduce_Btn.Location = new System.Drawing.Point(12, 120);
            this.UI_Reduce_Btn.Name = "UI_Reduce_Btn";
            this.UI_Reduce_Btn.Size = new System.Drawing.Size(409, 28);
            this.UI_Reduce_Btn.TabIndex = 2;
            this.UI_Reduce_Btn.Text = "Reduce Complexity...";
            this.UI_Reduce_Btn.UseVisualStyleBackColor = true;
            // 
            // UI_Color_Btn
            // 
            this.UI_Color_Btn.Location = new System.Drawing.Point(12, 154);
            this.UI_Color_Btn.Name = "UI_Color_Btn";
            this.UI_Color_Btn.Size = new System.Drawing.Size(409, 28);
            this.UI_Color_Btn.TabIndex = 3;
            this.UI_Color_Btn.Text = "Color";
            this.UI_Color_Btn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 291);
            this.Controls.Add(this.UI_Color_Btn);
            this.Controls.Add(this.UI_Reduce_Btn);
            this.Controls.Add(this.UI_UndoSeg_Btn);
            this.Controls.Add(this.UI_UndoLine_Btn);
            this.Name = "Form1";
            this.Text = "StackyListDraw";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button UI_UndoLine_Btn;
        private System.Windows.Forms.Button UI_UndoSeg_Btn;
        private System.Windows.Forms.Button UI_Reduce_Btn;
        private System.Windows.Forms.Button UI_Color_Btn;
    }
}

