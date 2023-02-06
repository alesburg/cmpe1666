namespace LAB02_ANNA
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
            this.UI_Pic_Picbx = new System.Windows.Forms.PictureBox();
            this.UI_Operation_Progbar = new System.Windows.Forms.ProgressBar();
            this.UI_LoadPic_Btn = new System.Windows.Forms.Button();
            this.UI_Transform_Btn = new System.Windows.Forms.Button();
            this.UI_Modtype_Grpbx = new System.Windows.Forms.GroupBox();
            this.UI_Noise_Radbtn = new System.Windows.Forms.RadioButton();
            this.UI_Tint_Radbtn = new System.Windows.Forms.RadioButton();
            this.UI_BW_Radbtn = new System.Windows.Forms.RadioButton();
            this.UI_Contrast_RadBtn = new System.Windows.Forms.RadioButton();
            this.UI_Intensity_Trckbar = new System.Windows.Forms.TrackBar();
            this.UI_Value_Lbl = new System.Windows.Forms.Label();
            this.UI_Left_Lbl = new System.Windows.Forms.Label();
            this.UI_Right_Lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UI_Pic_Picbx)).BeginInit();
            this.UI_Modtype_Grpbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UI_Intensity_Trckbar)).BeginInit();
            this.SuspendLayout();
            // 
            // UI_Pic_Picbx
            // 
            this.UI_Pic_Picbx.Location = new System.Drawing.Point(12, 12);
            this.UI_Pic_Picbx.Name = "UI_Pic_Picbx";
            this.UI_Pic_Picbx.Size = new System.Drawing.Size(776, 362);
            this.UI_Pic_Picbx.TabIndex = 0;
            this.UI_Pic_Picbx.TabStop = false;
            // 
            // UI_Operation_Progbar
            // 
            this.UI_Operation_Progbar.Location = new System.Drawing.Point(12, 381);
            this.UI_Operation_Progbar.Name = "UI_Operation_Progbar";
            this.UI_Operation_Progbar.Size = new System.Drawing.Size(776, 23);
            this.UI_Operation_Progbar.TabIndex = 1;
            // 
            // UI_LoadPic_Btn
            // 
            this.UI_LoadPic_Btn.Location = new System.Drawing.Point(12, 410);
            this.UI_LoadPic_Btn.Name = "UI_LoadPic_Btn";
            this.UI_LoadPic_Btn.Size = new System.Drawing.Size(111, 33);
            this.UI_LoadPic_Btn.TabIndex = 2;
            this.UI_LoadPic_Btn.Text = "LoadPicture";
            this.UI_LoadPic_Btn.UseVisualStyleBackColor = true;
            // 
            // UI_Transform_Btn
            // 
            this.UI_Transform_Btn.Location = new System.Drawing.Point(678, 410);
            this.UI_Transform_Btn.Name = "UI_Transform_Btn";
            this.UI_Transform_Btn.Size = new System.Drawing.Size(110, 33);
            this.UI_Transform_Btn.TabIndex = 3;
            this.UI_Transform_Btn.Text = "Transform!";
            this.UI_Transform_Btn.UseVisualStyleBackColor = true;
            // 
            // UI_Modtype_Grpbx
            // 
            this.UI_Modtype_Grpbx.Controls.Add(this.UI_Noise_Radbtn);
            this.UI_Modtype_Grpbx.Controls.Add(this.UI_Tint_Radbtn);
            this.UI_Modtype_Grpbx.Controls.Add(this.UI_BW_Radbtn);
            this.UI_Modtype_Grpbx.Controls.Add(this.UI_Contrast_RadBtn);
            this.UI_Modtype_Grpbx.Location = new System.Drawing.Point(129, 410);
            this.UI_Modtype_Grpbx.Name = "UI_Modtype_Grpbx";
            this.UI_Modtype_Grpbx.Size = new System.Drawing.Size(243, 107);
            this.UI_Modtype_Grpbx.TabIndex = 4;
            this.UI_Modtype_Grpbx.TabStop = false;
            this.UI_Modtype_Grpbx.Text = "Modification Type";
            // 
            // UI_Noise_Radbtn
            // 
            this.UI_Noise_Radbtn.AutoSize = true;
            this.UI_Noise_Radbtn.Location = new System.Drawing.Point(173, 70);
            this.UI_Noise_Radbtn.Name = "UI_Noise_Radbtn";
            this.UI_Noise_Radbtn.Size = new System.Drawing.Size(64, 20);
            this.UI_Noise_Radbtn.TabIndex = 3;
            this.UI_Noise_Radbtn.Text = "Noise";
            this.UI_Noise_Radbtn.UseVisualStyleBackColor = true;
            // 
            // UI_Tint_Radbtn
            // 
            this.UI_Tint_Radbtn.AutoSize = true;
            this.UI_Tint_Radbtn.Location = new System.Drawing.Point(173, 33);
            this.UI_Tint_Radbtn.Name = "UI_Tint_Radbtn";
            this.UI_Tint_Radbtn.Size = new System.Drawing.Size(50, 20);
            this.UI_Tint_Radbtn.TabIndex = 2;
            this.UI_Tint_Radbtn.Text = "Tint";
            this.UI_Tint_Radbtn.UseVisualStyleBackColor = true;
            // 
            // UI_BW_Radbtn
            // 
            this.UI_BW_Radbtn.AutoSize = true;
            this.UI_BW_Radbtn.Location = new System.Drawing.Point(6, 70);
            this.UI_BW_Radbtn.Name = "UI_BW_Radbtn";
            this.UI_BW_Radbtn.Size = new System.Drawing.Size(125, 20);
            this.UI_BW_Radbtn.TabIndex = 1;
            this.UI_BW_Radbtn.Text = "Black and White";
            this.UI_BW_Radbtn.UseVisualStyleBackColor = true;
            // 
            // UI_Contrast_RadBtn
            // 
            this.UI_Contrast_RadBtn.AutoSize = true;
            this.UI_Contrast_RadBtn.Checked = true;
            this.UI_Contrast_RadBtn.Location = new System.Drawing.Point(6, 33);
            this.UI_Contrast_RadBtn.Name = "UI_Contrast_RadBtn";
            this.UI_Contrast_RadBtn.Size = new System.Drawing.Size(77, 20);
            this.UI_Contrast_RadBtn.TabIndex = 0;
            this.UI_Contrast_RadBtn.TabStop = true;
            this.UI_Contrast_RadBtn.Text = "Contrast";
            this.UI_Contrast_RadBtn.UseVisualStyleBackColor = true;
            this.UI_Contrast_RadBtn.CheckedChanged += new System.EventHandler(this.UI_Contrast_RadBtn_CheckedChanged);
            // 
            // UI_Intensity_Trckbar
            // 
            this.UI_Intensity_Trckbar.Location = new System.Drawing.Point(378, 410);
            this.UI_Intensity_Trckbar.Maximum = 100;
            this.UI_Intensity_Trckbar.Name = "UI_Intensity_Trckbar";
            this.UI_Intensity_Trckbar.Size = new System.Drawing.Size(294, 56);
            this.UI_Intensity_Trckbar.TabIndex = 5;
            this.UI_Intensity_Trckbar.TickFrequency = 10;
            this.UI_Intensity_Trckbar.Value = 50;
            this.UI_Intensity_Trckbar.Scroll += new System.EventHandler(this.UI_Intensity_Trckbar_Scroll);
            // 
            // UI_Value_Lbl
            // 
            this.UI_Value_Lbl.AutoSize = true;
            this.UI_Value_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_Value_Lbl.ForeColor = System.Drawing.Color.Blue;
            this.UI_Value_Lbl.Location = new System.Drawing.Point(509, 450);
            this.UI_Value_Lbl.Name = "UI_Value_Lbl";
            this.UI_Value_Lbl.Size = new System.Drawing.Size(27, 20);
            this.UI_Value_Lbl.TabIndex = 6;
            this.UI_Value_Lbl.Text = "50";
            // 
            // UI_Left_Lbl
            // 
            this.UI_Left_Lbl.AutoSize = true;
            this.UI_Left_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_Left_Lbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.UI_Left_Lbl.Location = new System.Drawing.Point(385, 450);
            this.UI_Left_Lbl.Name = "UI_Left_Lbl";
            this.UI_Left_Lbl.Size = new System.Drawing.Size(36, 16);
            this.UI_Left_Lbl.TabIndex = 7;
            this.UI_Left_Lbl.Text = "Less";
            // 
            // UI_Right_Lbl
            // 
            this.UI_Right_Lbl.AutoSize = true;
            this.UI_Right_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_Right_Lbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.UI_Right_Lbl.Location = new System.Drawing.Point(622, 450);
            this.UI_Right_Lbl.Name = "UI_Right_Lbl";
            this.UI_Right_Lbl.Size = new System.Drawing.Size(38, 16);
            this.UI_Right_Lbl.TabIndex = 8;
            this.UI_Right_Lbl.Text = "More";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 527);
            this.Controls.Add(this.UI_Right_Lbl);
            this.Controls.Add(this.UI_Left_Lbl);
            this.Controls.Add(this.UI_Value_Lbl);
            this.Controls.Add(this.UI_Intensity_Trckbar);
            this.Controls.Add(this.UI_Modtype_Grpbx);
            this.Controls.Add(this.UI_Transform_Btn);
            this.Controls.Add(this.UI_LoadPic_Btn);
            this.Controls.Add(this.UI_Operation_Progbar);
            this.Controls.Add(this.UI_Pic_Picbx);
            this.Name = "Form1";
            this.Text = "PicBender";
            ((System.ComponentModel.ISupportInitialize)(this.UI_Pic_Picbx)).EndInit();
            this.UI_Modtype_Grpbx.ResumeLayout(false);
            this.UI_Modtype_Grpbx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UI_Intensity_Trckbar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox UI_Pic_Picbx;
        private System.Windows.Forms.ProgressBar UI_Operation_Progbar;
        private System.Windows.Forms.Button UI_LoadPic_Btn;
        private System.Windows.Forms.Button UI_Transform_Btn;
        private System.Windows.Forms.GroupBox UI_Modtype_Grpbx;
        private System.Windows.Forms.RadioButton UI_Noise_Radbtn;
        private System.Windows.Forms.RadioButton UI_Tint_Radbtn;
        private System.Windows.Forms.RadioButton UI_BW_Radbtn;
        private System.Windows.Forms.RadioButton UI_Contrast_RadBtn;
        private System.Windows.Forms.TrackBar UI_Intensity_Trckbar;
        private System.Windows.Forms.Label UI_Value_Lbl;
        private System.Windows.Forms.Label UI_Left_Lbl;
        private System.Windows.Forms.Label UI_Right_Lbl;
    }
}

