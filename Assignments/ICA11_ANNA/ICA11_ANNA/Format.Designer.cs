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
            this.UI_Color_Btn = new System.Windows.Forms.Button();
            this.UI_Font_Txtbx = new System.Windows.Forms.TextBox();
            this.UI_Color_Txtbx = new System.Windows.Forms.TextBox();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.SuspendLayout();
            // 
            // UI_OK_Btn
            // 
            this.UI_OK_Btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.UI_OK_Btn.Location = new System.Drawing.Point(319, 98);
            this.UI_OK_Btn.Name = "UI_OK_Btn";
            this.UI_OK_Btn.Size = new System.Drawing.Size(99, 30);
            this.UI_OK_Btn.TabIndex = 0;
            this.UI_OK_Btn.Text = "OK";
            this.UI_OK_Btn.UseVisualStyleBackColor = true;
            this.UI_OK_Btn.Click += new System.EventHandler(this.UI_OK_Btn_Click);
            // 
            // UI_Font_Btn
            // 
            this.UI_Font_Btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.UI_Font_Btn.Location = new System.Drawing.Point(12, 12);
            this.UI_Font_Btn.Name = "UI_Font_Btn";
            this.UI_Font_Btn.Size = new System.Drawing.Size(99, 30);
            this.UI_Font_Btn.TabIndex = 1;
            this.UI_Font_Btn.Text = "Select Font";
            this.UI_Font_Btn.UseVisualStyleBackColor = true;
            this.UI_Font_Btn.Click += new System.EventHandler(this.UI_Font_Btn_Click);
            // 
            // UI_Color_Btn
            // 
            this.UI_Color_Btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.UI_Color_Btn.Location = new System.Drawing.Point(12, 55);
            this.UI_Color_Btn.Name = "UI_Color_Btn";
            this.UI_Color_Btn.Size = new System.Drawing.Size(99, 30);
            this.UI_Color_Btn.TabIndex = 2;
            this.UI_Color_Btn.Text = "Select Color";
            this.UI_Color_Btn.UseVisualStyleBackColor = true;
            this.UI_Color_Btn.Click += new System.EventHandler(this.UI_Color_Btn_Click);
            // 
            // UI_Font_Txtbx
            // 
            this.UI_Font_Txtbx.Location = new System.Drawing.Point(118, 16);
            this.UI_Font_Txtbx.Name = "UI_Font_Txtbx";
            this.UI_Font_Txtbx.ReadOnly = true;
            this.UI_Font_Txtbx.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.UI_Font_Txtbx.Size = new System.Drawing.Size(606, 22);
            this.UI_Font_Txtbx.TabIndex = 3;
            // 
            // UI_Color_Txtbx
            // 
            this.UI_Color_Txtbx.Location = new System.Drawing.Point(118, 59);
            this.UI_Color_Txtbx.Name = "UI_Color_Txtbx";
            this.UI_Color_Txtbx.ReadOnly = true;
            this.UI_Color_Txtbx.Size = new System.Drawing.Size(606, 22);
            this.UI_Color_Txtbx.TabIndex = 4;
            // 
            // Format
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 138);
            this.Controls.Add(this.UI_Color_Txtbx);
            this.Controls.Add(this.UI_Font_Txtbx);
            this.Controls.Add(this.UI_Color_Btn);
            this.Controls.Add(this.UI_Font_Btn);
            this.Controls.Add(this.UI_OK_Btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.Name = "Format";
            this.Text = "Select Font/Color";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UI_OK_Btn;
        private System.Windows.Forms.Button UI_Font_Btn;
        private System.Windows.Forms.Button UI_Color_Btn;
        private System.Windows.Forms.TextBox UI_Font_Txtbx;
        private System.Windows.Forms.TextBox UI_Color_Txtbx;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.FontDialog fontDialog;
    }
}