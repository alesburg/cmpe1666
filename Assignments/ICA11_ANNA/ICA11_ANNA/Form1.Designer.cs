namespace ICA11_ANNA
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
            this.UI_FontSample_Lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UI_FontSample_Lbl
            // 
            this.UI_FontSample_Lbl.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_FontSample_Lbl.ForeColor = System.Drawing.Color.Navy;
            this.UI_FontSample_Lbl.Location = new System.Drawing.Point(12, 9);
            this.UI_FontSample_Lbl.Name = "UI_FontSample_Lbl";
            this.UI_FontSample_Lbl.Size = new System.Drawing.Size(406, 341);
            this.UI_FontSample_Lbl.TabIndex = 0;
            this.UI_FontSample_Lbl.Text = "This is the selected font!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 359);
            this.Controls.Add(this.UI_FontSample_Lbl);
            this.Name = "Form1";
            this.Text = "Fontify";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label UI_FontSample_Lbl;
    }
}

