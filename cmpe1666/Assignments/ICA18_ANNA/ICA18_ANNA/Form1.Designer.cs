namespace ICA18_ANNA
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
            this.UI_CustLinfo_Lstbx = new System.Windows.Forms.ListBox();
            this.UI_Selected_Lstbx = new System.Windows.Forms.ListBox();
            this.UI_ClearAll_Btn = new System.Windows.Forms.Button();
            this.UI_AddAmt_Btn = new System.Windows.Forms.Button();
            this.UI_Display_Btn = new System.Windows.Forms.Button();
            this.UI_DisplaySum_Btn = new System.Windows.Forms.Button();
            this.UI_CustInfo_Lbl = new System.Windows.Forms.Label();
            this.UI_Selected_Lbl = new System.Windows.Forms.Label();
            this.UI_CustID_Lbl = new System.Windows.Forms.Label();
            this.UI_CustID_UpDown = new System.Windows.Forms.NumericUpDown();
            this.UI_MinAmt_Lbl = new System.Windows.Forms.Label();
            this.UI_MinAmt_UpDown = new System.Windows.Forms.NumericUpDown();
            this.UI_Sum_Lbl = new System.Windows.Forms.Label();
            this.UI_MinSum_Lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UI_CustID_UpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UI_MinAmt_UpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // UI_CustLinfo_Lstbx
            // 
            this.UI_CustLinfo_Lstbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.UI_CustLinfo_Lstbx.FormattingEnabled = true;
            this.UI_CustLinfo_Lstbx.ItemHeight = 16;
            this.UI_CustLinfo_Lstbx.Location = new System.Drawing.Point(12, 75);
            this.UI_CustLinfo_Lstbx.Name = "UI_CustLinfo_Lstbx";
            this.UI_CustLinfo_Lstbx.Size = new System.Drawing.Size(265, 484);
            this.UI_CustLinfo_Lstbx.TabIndex = 0;
            this.UI_CustLinfo_Lstbx.TabStop = false;
            // 
            // UI_Selected_Lstbx
            // 
            this.UI_Selected_Lstbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_Selected_Lstbx.FormattingEnabled = true;
            this.UI_Selected_Lstbx.ItemHeight = 16;
            this.UI_Selected_Lstbx.Location = new System.Drawing.Point(688, 75);
            this.UI_Selected_Lstbx.Name = "UI_Selected_Lstbx";
            this.UI_Selected_Lstbx.Size = new System.Drawing.Size(265, 484);
            this.UI_Selected_Lstbx.TabIndex = 1;
            this.UI_Selected_Lstbx.TabStop = false;
            // 
            // UI_ClearAll_Btn
            // 
            this.UI_ClearAll_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_ClearAll_Btn.Location = new System.Drawing.Point(333, 75);
            this.UI_ClearAll_Btn.Name = "UI_ClearAll_Btn";
            this.UI_ClearAll_Btn.Size = new System.Drawing.Size(298, 53);
            this.UI_ClearAll_Btn.TabIndex = 2;
            this.UI_ClearAll_Btn.Text = "Clear All Customer Data";
            this.UI_ClearAll_Btn.UseVisualStyleBackColor = true;
            this.UI_ClearAll_Btn.Click += new System.EventHandler(this.UI_ClearAll_Btn_Click);
            // 
            // UI_AddAmt_Btn
            // 
            this.UI_AddAmt_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_AddAmt_Btn.Location = new System.Drawing.Point(333, 224);
            this.UI_AddAmt_Btn.Name = "UI_AddAmt_Btn";
            this.UI_AddAmt_Btn.Size = new System.Drawing.Size(298, 53);
            this.UI_AddAmt_Btn.TabIndex = 4;
            this.UI_AddAmt_Btn.Text = "Add Customer Amount";
            this.UI_AddAmt_Btn.UseVisualStyleBackColor = true;
            this.UI_AddAmt_Btn.Click += new System.EventHandler(this.UI_AddAmt_Btn_Click);
            // 
            // UI_Display_Btn
            // 
            this.UI_Display_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_Display_Btn.Location = new System.Drawing.Point(333, 306);
            this.UI_Display_Btn.Name = "UI_Display_Btn";
            this.UI_Display_Btn.Size = new System.Drawing.Size(298, 53);
            this.UI_Display_Btn.TabIndex = 5;
            this.UI_Display_Btn.Text = "Display Amounts and Sum for Customer";
            this.UI_Display_Btn.UseVisualStyleBackColor = true;
            this.UI_Display_Btn.Click += new System.EventHandler(this.UI_Display_Btn_Click);
            // 
            // UI_DisplaySum_Btn
            // 
            this.UI_DisplaySum_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_DisplaySum_Btn.Location = new System.Drawing.Point(333, 443);
            this.UI_DisplaySum_Btn.Name = "UI_DisplaySum_Btn";
            this.UI_DisplaySum_Btn.Size = new System.Drawing.Size(298, 53);
            this.UI_DisplaySum_Btn.TabIndex = 7;
            this.UI_DisplaySum_Btn.Text = "Display Amounts Above Minimum and Sum";
            this.UI_DisplaySum_Btn.UseVisualStyleBackColor = true;
            this.UI_DisplaySum_Btn.Click += new System.EventHandler(this.UI_DisplaySum_Btn_Click);
            // 
            // UI_CustInfo_Lbl
            // 
            this.UI_CustInfo_Lbl.Location = new System.Drawing.Point(12, 35);
            this.UI_CustInfo_Lbl.Name = "UI_CustInfo_Lbl";
            this.UI_CustInfo_Lbl.Size = new System.Drawing.Size(126, 37);
            this.UI_CustInfo_Lbl.TabIndex = 6;
            this.UI_CustInfo_Lbl.Text = " All Customers Info (In Order Added)";
            // 
            // UI_Selected_Lbl
            // 
            this.UI_Selected_Lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_Selected_Lbl.Location = new System.Drawing.Point(685, 39);
            this.UI_Selected_Lbl.Name = "UI_Selected_Lbl";
            this.UI_Selected_Lbl.Size = new System.Drawing.Size(218, 33);
            this.UI_Selected_Lbl.TabIndex = 7;
            this.UI_Selected_Lbl.Text = "Selected Customers Info (Descending Amount from LL)";
            // 
            // UI_CustID_Lbl
            // 
            this.UI_CustID_Lbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_CustID_Lbl.AutoSize = true;
            this.UI_CustID_Lbl.Location = new System.Drawing.Point(330, 169);
            this.UI_CustID_Lbl.Name = "UI_CustID_Lbl";
            this.UI_CustID_Lbl.Size = new System.Drawing.Size(83, 16);
            this.UI_CustID_Lbl.TabIndex = 8;
            this.UI_CustID_Lbl.Text = "Customer ID:";
            // 
            // UI_CustID_UpDown
            // 
            this.UI_CustID_UpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_CustID_UpDown.Location = new System.Drawing.Point(461, 169);
            this.UI_CustID_UpDown.Name = "UI_CustID_UpDown";
            this.UI_CustID_UpDown.Size = new System.Drawing.Size(120, 22);
            this.UI_CustID_UpDown.TabIndex = 3;
            this.UI_CustID_UpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // UI_MinAmt_Lbl
            // 
            this.UI_MinAmt_Lbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_MinAmt_Lbl.AutoSize = true;
            this.UI_MinAmt_Lbl.Location = new System.Drawing.Point(330, 412);
            this.UI_MinAmt_Lbl.Name = "UI_MinAmt_Lbl";
            this.UI_MinAmt_Lbl.Size = new System.Drawing.Size(111, 16);
            this.UI_MinAmt_Lbl.TabIndex = 10;
            this.UI_MinAmt_Lbl.Text = "Minimum Amount:";
            // 
            // UI_MinAmt_UpDown
            // 
            this.UI_MinAmt_UpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_MinAmt_UpDown.DecimalPlaces = 2;
            this.UI_MinAmt_UpDown.Location = new System.Drawing.Point(461, 410);
            this.UI_MinAmt_UpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.UI_MinAmt_UpDown.Name = "UI_MinAmt_UpDown";
            this.UI_MinAmt_UpDown.Size = new System.Drawing.Size(120, 22);
            this.UI_MinAmt_UpDown.TabIndex = 6;
            // 
            // UI_Sum_Lbl
            // 
            this.UI_Sum_Lbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_Sum_Lbl.AutoSize = true;
            this.UI_Sum_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_Sum_Lbl.Location = new System.Drawing.Point(449, 366);
            this.UI_Sum_Lbl.Name = "UI_Sum_Lbl";
            this.UI_Sum_Lbl.Size = new System.Drawing.Size(66, 25);
            this.UI_Sum_Lbl.TabIndex = 12;
            this.UI_Sum_Lbl.Text = "$0.00";
            this.UI_Sum_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UI_MinSum_Lbl
            // 
            this.UI_MinSum_Lbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_MinSum_Lbl.AutoSize = true;
            this.UI_MinSum_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_MinSum_Lbl.Location = new System.Drawing.Point(449, 525);
            this.UI_MinSum_Lbl.Name = "UI_MinSum_Lbl";
            this.UI_MinSum_Lbl.Size = new System.Drawing.Size(66, 25);
            this.UI_MinSum_Lbl.TabIndex = 13;
            this.UI_MinSum_Lbl.Text = "$0.00";
            this.UI_MinSum_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 581);
            this.Controls.Add(this.UI_MinSum_Lbl);
            this.Controls.Add(this.UI_Sum_Lbl);
            this.Controls.Add(this.UI_MinAmt_UpDown);
            this.Controls.Add(this.UI_MinAmt_Lbl);
            this.Controls.Add(this.UI_CustID_UpDown);
            this.Controls.Add(this.UI_CustID_Lbl);
            this.Controls.Add(this.UI_Selected_Lbl);
            this.Controls.Add(this.UI_CustInfo_Lbl);
            this.Controls.Add(this.UI_DisplaySum_Btn);
            this.Controls.Add(this.UI_Display_Btn);
            this.Controls.Add(this.UI_AddAmt_Btn);
            this.Controls.Add(this.UI_ClearAll_Btn);
            this.Controls.Add(this.UI_Selected_Lstbx);
            this.Controls.Add(this.UI_CustLinfo_Lstbx);
            this.Name = "Form1";
            this.Text = "Linked Lists";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UI_CustID_UpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UI_MinAmt_UpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox UI_CustLinfo_Lstbx;
        private System.Windows.Forms.ListBox UI_Selected_Lstbx;
        private System.Windows.Forms.Button UI_ClearAll_Btn;
        private System.Windows.Forms.Button UI_AddAmt_Btn;
        private System.Windows.Forms.Button UI_Display_Btn;
        private System.Windows.Forms.Button UI_DisplaySum_Btn;
        private System.Windows.Forms.Label UI_CustInfo_Lbl;
        private System.Windows.Forms.Label UI_Selected_Lbl;
        private System.Windows.Forms.Label UI_CustID_Lbl;
        private System.Windows.Forms.NumericUpDown UI_CustID_UpDown;
        private System.Windows.Forms.Label UI_MinAmt_Lbl;
        private System.Windows.Forms.NumericUpDown UI_MinAmt_UpDown;
        private System.Windows.Forms.Label UI_Sum_Lbl;
        private System.Windows.Forms.Label UI_MinSum_Lbl;
    }
}

