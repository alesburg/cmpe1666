namespace ICA19_ANNA
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
            this.UI_RawData_Lbl = new System.Windows.Forms.Label();
            this.UI_DataSorted_Lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UI_RawData_Lbl
            // 
            this.UI_RawData_Lbl.AutoSize = true;
            this.UI_RawData_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_RawData_Lbl.Location = new System.Drawing.Point(33, 9);
            this.UI_RawData_Lbl.Name = "UI_RawData_Lbl";
            this.UI_RawData_Lbl.Size = new System.Drawing.Size(129, 20);
            this.UI_RawData_Lbl.TabIndex = 0;
            this.UI_RawData_Lbl.Text = "Raw Data List";
            this.UI_RawData_Lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // UI_DataSorted_Lbl
            // 
            this.UI_DataSorted_Lbl.AutoSize = true;
            this.UI_DataSorted_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_DataSorted_Lbl.Location = new System.Drawing.Point(288, 9);
            this.UI_DataSorted_Lbl.Name = "UI_DataSorted_Lbl";
            this.UI_DataSorted_Lbl.Size = new System.Drawing.Size(140, 20);
            this.UI_DataSorted_Lbl.TabIndex = 1;
            this.UI_DataSorted_Lbl.Text = "Data Sorted On";
            this.UI_DataSorted_Lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(362, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Data Sorted On";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 554);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UI_DataSorted_Lbl);
            this.Controls.Add(this.UI_RawData_Lbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UI_RawData_Lbl;
        private System.Windows.Forms.Label UI_DataSorted_Lbl;
        private System.Windows.Forms.Label label1;
    }
}

