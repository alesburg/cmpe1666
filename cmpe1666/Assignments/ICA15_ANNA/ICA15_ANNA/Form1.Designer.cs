namespace ICA15_ANNA
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
            this.components = new System.ComponentModel.Container();
            this.UI_Listbx = new System.Windows.Forms.ListBox();
            this.UI_Go_Btn = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // UI_Listbx
            // 
            this.UI_Listbx.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_Listbx.FormattingEnabled = true;
            this.UI_Listbx.ItemHeight = 16;
            this.UI_Listbx.Location = new System.Drawing.Point(12, 12);
            this.UI_Listbx.Name = "UI_Listbx";
            this.UI_Listbx.Size = new System.Drawing.Size(632, 228);
            this.UI_Listbx.TabIndex = 0;
            // 
            // UI_Go_Btn
            // 
            this.UI_Go_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_Go_Btn.Location = new System.Drawing.Point(555, 246);
            this.UI_Go_Btn.Name = "UI_Go_Btn";
            this.UI_Go_Btn.Size = new System.Drawing.Size(89, 34);
            this.UI_Go_Btn.TabIndex = 1;
            this.UI_Go_Btn.Text = "Go!";
            this.UI_Go_Btn.UseVisualStyleBackColor = true;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 288);
            this.Controls.Add(this.UI_Go_Btn);
            this.Controls.Add(this.UI_Listbx);
            this.Name = "Form1";
            this.Text = "Image Scanner";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox UI_Listbx;
        private System.Windows.Forms.Button UI_Go_Btn;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

