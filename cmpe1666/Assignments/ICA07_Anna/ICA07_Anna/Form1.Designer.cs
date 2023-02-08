namespace ICA07_Anna
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
            this.UI_Name_Tbx = new System.Windows.Forms.TextBox();
            this.UI_Name_Lbl = new System.Windows.Forms.Label();
            this.UI_AddName_Button = new System.Windows.Forms.Button();
            this.UI_Search_Button = new System.Windows.Forms.Button();
            this.UI_Sorted_LstBx = new System.Windows.Forms.ListBox();
            this.UI_Unsorted_Listbx = new System.Windows.Forms.ListBox();
            this.UI_Unsorted_Lbl = new System.Windows.Forms.Label();
            this.UI_Sorted_Lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UI_Name_Tbx
            // 
            this.UI_Name_Tbx.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UI_Name_Tbx.Location = new System.Drawing.Point(316, 79);
            this.UI_Name_Tbx.Name = "UI_Name_Tbx";
            this.UI_Name_Tbx.Size = new System.Drawing.Size(168, 22);
            this.UI_Name_Tbx.TabIndex = 0;
            // 
            // UI_Name_Lbl
            // 
            this.UI_Name_Lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UI_Name_Lbl.AutoSize = true;
            this.UI_Name_Lbl.Location = new System.Drawing.Point(263, 82);
            this.UI_Name_Lbl.Name = "UI_Name_Lbl";
            this.UI_Name_Lbl.Size = new System.Drawing.Size(47, 16);
            this.UI_Name_Lbl.TabIndex = 1;
            this.UI_Name_Lbl.Text = "Name:";
            // 
            // UI_AddName_Button
            // 
            this.UI_AddName_Button.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UI_AddName_Button.Location = new System.Drawing.Point(337, 124);
            this.UI_AddName_Button.Name = "UI_AddName_Button";
            this.UI_AddName_Button.Size = new System.Drawing.Size(127, 43);
            this.UI_AddName_Button.TabIndex = 1;
            this.UI_AddName_Button.Text = "Add Name";
            this.UI_AddName_Button.UseVisualStyleBackColor = true;
            this.UI_AddName_Button.Click += new System.EventHandler(this.UI_AddName_Button_Click);
            // 
            // UI_Search_Button
            // 
            this.UI_Search_Button.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UI_Search_Button.Location = new System.Drawing.Point(337, 204);
            this.UI_Search_Button.Name = "UI_Search_Button";
            this.UI_Search_Button.Size = new System.Drawing.Size(127, 43);
            this.UI_Search_Button.TabIndex = 2;
            this.UI_Search_Button.Text = "Search";
            this.UI_Search_Button.UseVisualStyleBackColor = true;
            this.UI_Search_Button.Click += new System.EventHandler(this.UI_Search_Button_Click);
            // 
            // UI_Sorted_LstBx
            // 
            this.UI_Sorted_LstBx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_Sorted_LstBx.FormattingEnabled = true;
            this.UI_Sorted_LstBx.ItemHeight = 16;
            this.UI_Sorted_LstBx.Location = new System.Drawing.Point(576, 79);
            this.UI_Sorted_LstBx.Name = "UI_Sorted_LstBx";
            this.UI_Sorted_LstBx.Size = new System.Drawing.Size(161, 276);
            this.UI_Sorted_LstBx.TabIndex = 4;
            this.UI_Sorted_LstBx.TabStop = false;
            // 
            // UI_Unsorted_Listbx
            // 
            this.UI_Unsorted_Listbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.UI_Unsorted_Listbx.FormattingEnabled = true;
            this.UI_Unsorted_Listbx.ItemHeight = 16;
            this.UI_Unsorted_Listbx.Location = new System.Drawing.Point(47, 79);
            this.UI_Unsorted_Listbx.Name = "UI_Unsorted_Listbx";
            this.UI_Unsorted_Listbx.Size = new System.Drawing.Size(161, 276);
            this.UI_Unsorted_Listbx.TabIndex = 5;
            this.UI_Unsorted_Listbx.TabStop = false;
            // 
            // UI_Unsorted_Lbl
            // 
            this.UI_Unsorted_Lbl.AutoSize = true;
            this.UI_Unsorted_Lbl.Location = new System.Drawing.Point(44, 60);
            this.UI_Unsorted_Lbl.Name = "UI_Unsorted_Lbl";
            this.UI_Unsorted_Lbl.Size = new System.Drawing.Size(180, 16);
            this.UI_Unsorted_Lbl.TabIndex = 6;
            this.UI_Unsorted_Lbl.Text = "List of Names (Order of Entry)";
            // 
            // UI_Sorted_Lbl
            // 
            this.UI_Sorted_Lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_Sorted_Lbl.AutoSize = true;
            this.UI_Sorted_Lbl.Location = new System.Drawing.Point(588, 60);
            this.UI_Sorted_Lbl.Name = "UI_Sorted_Lbl";
            this.UI_Sorted_Lbl.Size = new System.Drawing.Size(139, 16);
            this.UI_Sorted_Lbl.TabIndex = 7;
            this.UI_Sorted_Lbl.Text = "List of Names (Sorted)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UI_Sorted_Lbl);
            this.Controls.Add(this.UI_Unsorted_Lbl);
            this.Controls.Add(this.UI_Unsorted_Listbx);
            this.Controls.Add(this.UI_Sorted_LstBx);
            this.Controls.Add(this.UI_Search_Button);
            this.Controls.Add(this.UI_AddName_Button);
            this.Controls.Add(this.UI_Name_Lbl);
            this.Controls.Add(this.UI_Name_Tbx);
            this.Name = "Form1";
            this.Text = "ICA07-Anna";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UI_Name_Tbx;
        private System.Windows.Forms.Label UI_Name_Lbl;
        private System.Windows.Forms.Button UI_AddName_Button;
        private System.Windows.Forms.Button UI_Search_Button;
        private System.Windows.Forms.ListBox UI_Sorted_LstBx;
        private System.Windows.Forms.ListBox UI_Unsorted_Listbx;
        private System.Windows.Forms.Label UI_Unsorted_Lbl;
        private System.Windows.Forms.Label UI_Sorted_Lbl;
    }
}

