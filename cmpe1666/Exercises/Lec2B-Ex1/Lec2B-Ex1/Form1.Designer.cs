namespace Lec2B_Ex1
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
            this.UI_Display_Lbl = new System.Windows.Forms.Label();
            this.UI_Change_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UI_Display_Lbl
            // 
            this.UI_Display_Lbl.AutoSize = true;
            this.UI_Display_Lbl.Location = new System.Drawing.Point(331, 134);
            this.UI_Display_Lbl.Name = "UI_Display_Lbl";
            this.UI_Display_Lbl.Size = new System.Drawing.Size(112, 16);
            this.UI_Display_Lbl.TabIndex = 0;
            this.UI_Display_Lbl.Text = "Initial Label Value";
            // 
            // UI_Change_Button
            // 
            this.UI_Change_Button.Location = new System.Drawing.Point(290, 202);
            this.UI_Change_Button.Name = "UI_Change_Button";
            this.UI_Change_Button.Size = new System.Drawing.Size(211, 47);
            this.UI_Change_Button.TabIndex = 1;
            this.UI_Change_Button.Text = "Change Label Value";
            this.UI_Change_Button.UseVisualStyleBackColor = true;
            this.UI_Change_Button.Click += new System.EventHandler(this.UI_Change_Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UI_Change_Button);
            this.Controls.Add(this.UI_Display_Lbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UI_Display_Lbl;
        private System.Windows.Forms.Button UI_Change_Button;
    }
}

