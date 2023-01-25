namespace ICA04_Anna
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
            this.UI_Kmph_RadBtn = new System.Windows.Forms.RadioButton();
            this.UI_Mph_Radbtn = new System.Windows.Forms.RadioButton();
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
            this.UI_Units_Grpbox.Controls.Add(this.UI_Kmph_RadBtn);
            this.UI_Units_Grpbox.Controls.Add(this.UI_Mph_Radbtn);
            this.UI_Units_Grpbox.Location = new System.Drawing.Point(12, 7);
            this.UI_Units_Grpbox.Name = "UI_Units_Grpbox";
            this.UI_Units_Grpbox.Size = new System.Drawing.Size(335, 85);
            this.UI_Units_Grpbox.TabIndex = 0;
            this.UI_Units_Grpbox.TabStop = false;
            this.UI_Units_Grpbox.Text = "Input Units";
            // 
            // UI_Kmph_RadBtn
            // 
            this.UI_Kmph_RadBtn.AutoSize = true;
            this.UI_Kmph_RadBtn.Location = new System.Drawing.Point(7, 48);
            this.UI_Kmph_RadBtn.Name = "UI_Kmph_RadBtn";
            this.UI_Kmph_RadBtn.Size = new System.Drawing.Size(191, 20);
            this.UI_Kmph_RadBtn.TabIndex = 1;
            this.UI_Kmph_RadBtn.TabStop = true;
            this.UI_Kmph_RadBtn.Text = "Kilometres Per Hour (kmph)";
            this.UI_Kmph_RadBtn.UseVisualStyleBackColor = true;
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
            this.UI_Mph_Radbtn.CheckedChanged += new System.EventHandler(this.UI_Radbtn_CheckedChanged);
            // 
            // UI_output_Txtbx
            // 
            this.UI_output_Txtbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_output_Txtbx.Location = new System.Drawing.Point(12, 192);
            this.UI_output_Txtbx.Name = "UI_output_Txtbx";
            this.UI_output_Txtbx.ReadOnly = true;
            this.UI_output_Txtbx.Size = new System.Drawing.Size(335, 22);
            this.UI_output_Txtbx.TabIndex = 1;
            this.UI_output_Txtbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // UI_input_Txtbx
            // 
            this.UI_input_Txtbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_input_Txtbx.Location = new System.Drawing.Point(12, 129);
            this.UI_input_Txtbx.Name = "UI_input_Txtbx";
            this.UI_input_Txtbx.Size = new System.Drawing.Size(335, 22);
            this.UI_input_Txtbx.TabIndex = 2;
            this.UI_input_Txtbx.Text = "0";
            this.UI_input_Txtbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.UI_input_Txtbx.TextChanged += new System.EventHandler(this.UI_input_Txtbx_TextChanged);
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
            this.MinimumSize = new System.Drawing.Size(377, 299);
            this.Name = "Form1";
            this.Text = "Speed Conversion";
            this.UI_Units_Grpbox.ResumeLayout(false);
            this.UI_Units_Grpbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox UI_Units_Grpbox;
        private System.Windows.Forms.RadioButton UI_Kmph_RadBtn;
        private System.Windows.Forms.RadioButton UI_Mph_Radbtn;
        private System.Windows.Forms.TextBox UI_output_Txtbx;
        private System.Windows.Forms.TextBox UI_input_Txtbx;
        private System.Windows.Forms.Label UI_input_Lbl;
        private System.Windows.Forms.Label UI_output_Lbl;
    }
}

