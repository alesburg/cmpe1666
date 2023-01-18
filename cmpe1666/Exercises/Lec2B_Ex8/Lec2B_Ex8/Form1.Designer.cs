namespace Lec2B_Ex8
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
            this.UI_TaxRate_Grpbx = new System.Windows.Forms.GroupBox();
            this.UI_5_Radbtn = new System.Windows.Forms.RadioButton();
            this.UI_7_Radbtn = new System.Windows.Forms.RadioButton();
            this.UI_10_Radbtn = new System.Windows.Forms.RadioButton();
            this.UI_Price_Tbx = new System.Windows.Forms.TextBox();
            this.UI_Price_Lbl = new System.Windows.Forms.Label();
            this.UI_Total_Lbl = new System.Windows.Forms.Label();
            this.UI_Total_Tbx = new System.Windows.Forms.TextBox();
            this.UI_TaxRate_Grpbx.SuspendLayout();
            this.SuspendLayout();
            // 
            // UI_TaxRate_Grpbx
            // 
            this.UI_TaxRate_Grpbx.Controls.Add(this.UI_10_Radbtn);
            this.UI_TaxRate_Grpbx.Controls.Add(this.UI_7_Radbtn);
            this.UI_TaxRate_Grpbx.Controls.Add(this.UI_5_Radbtn);
            this.UI_TaxRate_Grpbx.Location = new System.Drawing.Point(60, 81);
            this.UI_TaxRate_Grpbx.Name = "UI_TaxRate_Grpbx";
            this.UI_TaxRate_Grpbx.Size = new System.Drawing.Size(258, 218);
            this.UI_TaxRate_Grpbx.TabIndex = 0;
            this.UI_TaxRate_Grpbx.TabStop = false;
            this.UI_TaxRate_Grpbx.Text = "Tax Rate";
            // 
            // UI_5_Radbtn
            // 
            this.UI_5_Radbtn.AutoSize = true;
            this.UI_5_Radbtn.Location = new System.Drawing.Point(34, 48);
            this.UI_5_Radbtn.Name = "UI_5_Radbtn";
            this.UI_5_Radbtn.Size = new System.Drawing.Size(47, 20);
            this.UI_5_Radbtn.TabIndex = 0;
            this.UI_5_Radbtn.TabStop = true;
            this.UI_5_Radbtn.Text = "5%";
            this.UI_5_Radbtn.UseVisualStyleBackColor = true;
            // 
            // UI_7_Radbtn
            // 
            this.UI_7_Radbtn.AutoSize = true;
            this.UI_7_Radbtn.Location = new System.Drawing.Point(34, 96);
            this.UI_7_Radbtn.Name = "UI_7_Radbtn";
            this.UI_7_Radbtn.Size = new System.Drawing.Size(47, 20);
            this.UI_7_Radbtn.TabIndex = 1;
            this.UI_7_Radbtn.TabStop = true;
            this.UI_7_Radbtn.Text = "7%";
            this.UI_7_Radbtn.UseVisualStyleBackColor = true;
            // 
            // UI_10_Radbtn
            // 
            this.UI_10_Radbtn.AutoSize = true;
            this.UI_10_Radbtn.Location = new System.Drawing.Point(34, 146);
            this.UI_10_Radbtn.Name = "UI_10_Radbtn";
            this.UI_10_Radbtn.Size = new System.Drawing.Size(54, 20);
            this.UI_10_Radbtn.TabIndex = 2;
            this.UI_10_Radbtn.TabStop = true;
            this.UI_10_Radbtn.Text = "10%";
            this.UI_10_Radbtn.UseVisualStyleBackColor = true;
            // 
            // UI_Price_Tbx
            // 
            this.UI_Price_Tbx.Location = new System.Drawing.Point(478, 127);
            this.UI_Price_Tbx.Name = "UI_Price_Tbx";
            this.UI_Price_Tbx.Size = new System.Drawing.Size(162, 22);
            this.UI_Price_Tbx.TabIndex = 1;
            this.UI_Price_Tbx.TextChanged += new System.EventHandler(this.UI_Price_Tbx_TextChanged);
            // 
            // UI_Price_Lbl
            // 
            this.UI_Price_Lbl.AutoSize = true;
            this.UI_Price_Lbl.Location = new System.Drawing.Point(400, 129);
            this.UI_Price_Lbl.Name = "UI_Price_Lbl";
            this.UI_Price_Lbl.Size = new System.Drawing.Size(72, 16);
            this.UI_Price_Lbl.TabIndex = 2;
            this.UI_Price_Lbl.Text = "Item Price: ";
            // 
            // UI_Total_Lbl
            // 
            this.UI_Total_Lbl.AutoSize = true;
            this.UI_Total_Lbl.Location = new System.Drawing.Point(385, 236);
            this.UI_Total_Lbl.Name = "UI_Total_Lbl";
            this.UI_Total_Lbl.Size = new System.Drawing.Size(124, 16);
            this.UI_Total_Lbl.TabIndex = 3;
            this.UI_Total_Lbl.Text = "Total Cost (with tax):";
            // 
            // UI_Total_Tbx
            // 
            this.UI_Total_Tbx.Location = new System.Drawing.Point(516, 236);
            this.UI_Total_Tbx.Name = "UI_Total_Tbx";
            this.UI_Total_Tbx.ReadOnly = true;
            this.UI_Total_Tbx.Size = new System.Drawing.Size(124, 22);
            this.UI_Total_Tbx.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UI_Total_Tbx);
            this.Controls.Add(this.UI_Total_Lbl);
            this.Controls.Add(this.UI_Price_Lbl);
            this.Controls.Add(this.UI_Price_Tbx);
            this.Controls.Add(this.UI_TaxRate_Grpbx);
            this.Name = "Form1";
            this.Text = "Form1";
            this.UI_TaxRate_Grpbx.ResumeLayout(false);
            this.UI_TaxRate_Grpbx.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox UI_TaxRate_Grpbx;
        private System.Windows.Forms.RadioButton UI_10_Radbtn;
        private System.Windows.Forms.RadioButton UI_7_Radbtn;
        private System.Windows.Forms.RadioButton UI_5_Radbtn;
        private System.Windows.Forms.TextBox UI_Price_Tbx;
        private System.Windows.Forms.Label UI_Price_Lbl;
        private System.Windows.Forms.Label UI_Total_Lbl;
        private System.Windows.Forms.TextBox UI_Total_Tbx;
    }
}

