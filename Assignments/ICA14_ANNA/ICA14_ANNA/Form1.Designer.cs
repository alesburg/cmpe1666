namespace ICA14_ANNA
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
            this.UI_Load_Btn = new System.Windows.Forms.Button();
            this.UI_Find_Btn = new System.Windows.Forms.Button();
            this.UI_Test_Btn = new System.Windows.Forms.Button();
            this.UI_Test_Tbx = new System.Windows.Forms.TextBox();
            this.UI_Result_Tbx = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // UI_Load_Btn
            // 
            this.UI_Load_Btn.Location = new System.Drawing.Point(12, 12);
            this.UI_Load_Btn.Name = "UI_Load_Btn";
            this.UI_Load_Btn.Size = new System.Drawing.Size(94, 30);
            this.UI_Load_Btn.TabIndex = 0;
            this.UI_Load_Btn.Text = "Load File";
            this.UI_Load_Btn.UseVisualStyleBackColor = true;
            this.UI_Load_Btn.Click += new System.EventHandler(this.UI_Load_Btn_Click);
            // 
            // UI_Find_Btn
            // 
            this.UI_Find_Btn.Location = new System.Drawing.Point(112, 12);
            this.UI_Find_Btn.Name = "UI_Find_Btn";
            this.UI_Find_Btn.Size = new System.Drawing.Size(94, 30);
            this.UI_Find_Btn.TabIndex = 1;
            this.UI_Find_Btn.Text = "Find";
            this.UI_Find_Btn.UseVisualStyleBackColor = true;
            // 
            // UI_Test_Btn
            // 
            this.UI_Test_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_Test_Btn.Location = new System.Drawing.Point(615, 12);
            this.UI_Test_Btn.Name = "UI_Test_Btn";
            this.UI_Test_Btn.Size = new System.Drawing.Size(94, 30);
            this.UI_Test_Btn.TabIndex = 2;
            this.UI_Test_Btn.Text = "Simple Test";
            this.UI_Test_Btn.UseVisualStyleBackColor = true;
            this.UI_Test_Btn.Click += new System.EventHandler(this.UI_Test_Btn_Click);
            // 
            // UI_Test_Tbx
            // 
            this.UI_Test_Tbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_Test_Tbx.Location = new System.Drawing.Point(374, 16);
            this.UI_Test_Tbx.Name = "UI_Test_Tbx";
            this.UI_Test_Tbx.Size = new System.Drawing.Size(235, 22);
            this.UI_Test_Tbx.TabIndex = 3;
            // 
            // UI_Result_Tbx
            // 
            this.UI_Result_Tbx.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_Result_Tbx.Location = new System.Drawing.Point(12, 48);
            this.UI_Result_Tbx.Multiline = true;
            this.UI_Result_Tbx.Name = "UI_Result_Tbx";
            this.UI_Result_Tbx.Size = new System.Drawing.Size(697, 228);
            this.UI_Result_Tbx.TabIndex = 4;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 288);
            this.Controls.Add(this.UI_Result_Tbx);
            this.Controls.Add(this.UI_Test_Tbx);
            this.Controls.Add(this.UI_Test_Btn);
            this.Controls.Add(this.UI_Find_Btn);
            this.Controls.Add(this.UI_Load_Btn);
            this.Name = "Form1";
            this.Text = "Palindrome Hunter!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UI_Load_Btn;
        private System.Windows.Forms.Button UI_Find_Btn;
        private System.Windows.Forms.Button UI_Test_Btn;
        private System.Windows.Forms.TextBox UI_Test_Tbx;
        private System.Windows.Forms.TextBox UI_Result_Tbx;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

