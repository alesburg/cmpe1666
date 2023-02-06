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
            ((System.ComponentModel.ISupportInitialize)(this.UI_Pic_Picbx)).BeginInit();
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 547);
            this.Controls.Add(this.UI_Transform_Btn);
            this.Controls.Add(this.UI_LoadPic_Btn);
            this.Controls.Add(this.UI_Operation_Progbar);
            this.Controls.Add(this.UI_Pic_Picbx);
            this.Name = "Form1";
            this.Text = "PicBender";
            ((System.ComponentModel.ISupportInitialize)(this.UI_Pic_Picbx)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox UI_Pic_Picbx;
        private System.Windows.Forms.ProgressBar UI_Operation_Progbar;
        private System.Windows.Forms.Button UI_LoadPic_Btn;
        private System.Windows.Forms.Button UI_Transform_Btn;
    }
}

