namespace Lec2B_Ex2
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
            this.UI_Lbl_Tbx = new System.Windows.Forms.TextBox();
            this.UI_Display_Lbl = new System.Windows.Forms.Label();
            this.UI_Transfer_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UI_Lbl_Tbx
            // 
            this.UI_Lbl_Tbx.Location = new System.Drawing.Point(316, 96);
            this.UI_Lbl_Tbx.Name = "UI_Lbl_Tbx";
            this.UI_Lbl_Tbx.Size = new System.Drawing.Size(100, 22);
            this.UI_Lbl_Tbx.TabIndex = 0;
            // 
            // UI_Display_Lbl
            // 
            this.UI_Display_Lbl.AutoSize = true;
            this.UI_Display_Lbl.Location = new System.Drawing.Point(349, 157);
            this.UI_Display_Lbl.Name = "UI_Display_Lbl";
            this.UI_Display_Lbl.Size = new System.Drawing.Size(44, 16);
            this.UI_Display_Lbl.TabIndex = 1;
            this.UI_Display_Lbl.Text = "label1";
            // 
            // UI_Transfer_Btn
            // 
            this.UI_Transfer_Btn.Location = new System.Drawing.Point(288, 209);
            this.UI_Transfer_Btn.Name = "UI_Transfer_Btn";
            this.UI_Transfer_Btn.Size = new System.Drawing.Size(180, 63);
            this.UI_Transfer_Btn.TabIndex = 2;
            this.UI_Transfer_Btn.Text = "button1";
            this.UI_Transfer_Btn.UseVisualStyleBackColor = true;
            this.UI_Transfer_Btn.Click += new System.EventHandler(this.UI_Transfer_Btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UI_Transfer_Btn);
            this.Controls.Add(this.UI_Display_Lbl);
            this.Controls.Add(this.UI_Lbl_Tbx);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UI_Lbl_Tbx;
        private System.Windows.Forms.Label UI_Display_Lbl;
        private System.Windows.Forms.Button UI_Transfer_Btn;
    }
}

