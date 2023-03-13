namespace ICA11_ANNA
{
    partial class Format
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
            this.UI_OK_Btn = new System.Windows.Forms.Button();
            this.UI_Font_Btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UI_OK_Btn
            // 
            this.UI_OK_Btn.Location = new System.Drawing.Point(319, 98);
            this.UI_OK_Btn.Name = "UI_OK_Btn";
            this.UI_OK_Btn.Size = new System.Drawing.Size(99, 30);
            this.UI_OK_Btn.TabIndex = 0;
            this.UI_OK_Btn.Text = "OK";
            this.UI_OK_Btn.UseVisualStyleBackColor = true;
            // 
            // UI_Font_Btn
            // 
            this.UI_Font_Btn.Location = new System.Drawing.Point(12, 12);
            this.UI_Font_Btn.Name = "UI_Font_Btn";
            this.UI_Font_Btn.Size = new System.Drawing.Size(99, 30);
            this.UI_Font_Btn.TabIndex = 1;
            this.UI_Font_Btn.Text = "Select Font";
            this.UI_Font_Btn.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "Select Font";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Format
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 140);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.UI_Font_Btn);
            this.Controls.Add(this.UI_OK_Btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.Name = "Format";
            this.Text = "Select Font/Color";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button UI_OK_Btn;
        private System.Windows.Forms.Button UI_Font_Btn;
        private System.Windows.Forms.Button button1;
    }
}