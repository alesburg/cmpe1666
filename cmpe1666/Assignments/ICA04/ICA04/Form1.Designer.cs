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
            this.UI_Units_Grpbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // UI_Units_Grpbox
            // 
            this.UI_Units_Grpbox.Controls.Add(this.radioButton1);
            this.UI_Units_Grpbox.Controls.Add(this.UI_Mph_Radbtn);
            this.UI_Units_Grpbox.Location = new System.Drawing.Point(12, 23);
            this.UI_Units_Grpbox.Name = "UI_Units_Grpbox";
            this.UI_Units_Grpbox.Size = new System.Drawing.Size(316, 85);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 295);
            this.Controls.Add(this.UI_Units_Grpbox);
            this.Name = "Form1";
            this.Text = "Speed Conversion";
            this.UI_Units_Grpbox.ResumeLayout(false);
            this.UI_Units_Grpbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox UI_Units_Grpbox;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton UI_Mph_Radbtn;
    }
}

