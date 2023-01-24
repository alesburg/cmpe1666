namespace ICA04
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
            this.UI_Units_Grpbox = new System.Windows.Forms.GroupBox();
            this.UI_Mph_Radbtn = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.UI_output_Txtbx = new System.Windows.Forms.TextBox();
            this.UI_input_Txtbx = new System.Windows.Forms.TextBox();
            this.UI_input_Lbl = new System.Windows.Forms.Label();
            this.UI_output_Lbl = new System.Windows.Forms.Label();
            this.UI_Units_Grpbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // UI_Units_Grpbox
            // 
            this.UI_Units_Grpbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_Units_Grpbox.Controls.Add(this.radioButton1);
            this.UI_Units_Grpbox.Controls.Add(this.UI_Mph_Radbtn);
            this.UI_Units_Grpbox.Location = new System.Drawing.Point(12, 7);
            this.UI_Units_Grpbox.Name = "UI_Units_Grpbox";
            this.UI_Units_Grpbox.Size = new System.Drawing.Size(335, 85);
            this.UI_Units_Grpbox.TabIndex = 0;
            this.UI_Units_Grpbox.TabStop = false;
            this.UI_Units_Grpbox.Text = "Input Units";
            // 
            // UI_Mph_Radbtn
            // 
            this.UI_Mph_Radbtn.AutoSize = true;
            this.UI_Mph_Radbtn.Location = new System.Drawing.Point(7, 22);
            this.UI_Mph_Radbtn.Name = "UI_Mph_Radbtn";
            this.UI_Mph_Radbtn.Size = new System.Drawing.Size(153, 20);
            this.UI_Mph_Radbtn.TabIndex = 0;
            this.UI_Mph_Radbtn.TabStop = true;
            this.UI_Mph_Radbtn.Text = "Miles Per Hour (mph)";
            this.UI_Mph_Radbtn.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 48);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(187, 20);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Kilometres Per Hour (km/h)";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // UI_output_Txtbx
            // 
            this.UI_output_Txtbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_output_Txtbx.Location = new System.Drawing.Point(12, 192);
            this.UI_output_Txtbx.Name = "UI_output_Txtbx";
            this.UI_output_Txtbx.ReadOnly = true;
            this.UI_output_Txtbx.Size = new System.Drawing.Size(335, 22);
            this.UI_output_Txtbx.TabIndex = 1;
            // 
            // UI_input_Txtbx
            // 
            this.UI_input_Txtbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_input_Txtbx.Location = new System.Drawing.Point(12, 129);
            this.UI_input_Txtbx.Name = "UI_input_Txtbx";
            this.UI_input_Txtbx.Size = new System.Drawing.Size(335, 22);
            this.UI_input_Txtbx.TabIndex = 2;
            // 
            // UI_input_Lbl
            // 
            this.UI_input_Lbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.UI_input_Lbl.AutoSize = true;
            this.UI_input_Lbl.Location = new System.Drawing.Point(12, 107);
            this.UI_input_Lbl.Name = "UI_input_Lbl";
            this.UI_input_Lbl.Size = new System.Drawing.Size(82, 16);
            this.UI_input_Lbl.TabIndex = 3;
            this.UI_input_Lbl.Text = "Input Speed:";
            // 
            // UI_output_Lbl
            // 
            this.UI_output_Lbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.UI_output_Lbl.AutoSize = true;
            this.UI_output_Lbl.Location = new System.Drawing.Point(12, 173);
            this.UI_output_Lbl.Name = "UI_output_Lbl";
            this.UI_output_Lbl.Size = new System.Drawing.Size(92, 16);
            this.UI_output_Lbl.TabIndex = 4;
            this.UI_output_Lbl.Text = "Output Speed:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 252);
            this.Controls.Add(this.UI_output_Lbl);
            this.Controls.Add(this.UI_input_Lbl);
            this.Controls.Add(this.UI_input_Txtbx);
            this.Controls.Add(this.UI_output_Txtbx);
            this.Controls.Add(this.UI_Units_Grpbox);
            this.Name = "Form1";
            this.Text = "Speed Conversion";
            this.UI_Units_Grpbox.ResumeLayout(false);
            this.UI_Units_Grpbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox UI_Units_Grpbox;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton UI_Mph_Radbtn;
        private System.Windows.Forms.TextBox UI_output_Txtbx;
        private System.Windows.Forms.TextBox UI_input_Txtbx;
        private System.Windows.Forms.Label UI_input_Lbl;
        private System.Windows.Forms.Label UI_output_Lbl;
    }
}

