﻿namespace ICA06_Anna
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
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.UI_Generate_Btn = new System.Windows.Forms.Button();
            this.UI_Fill_Btn = new System.Windows.Forms.Button();
            this.UI_FillColor_Btn = new System.Windows.Forms.Button();
            this.UI_NumBlocks_Lbl = new System.Windows.Forms.Label();
            this.UI_FillClr_Lbl = new System.Windows.Forms.Label();
            this.UI_NumBlocks_Trckbar = new System.Windows.Forms.TrackBar();
            this.UI_Color_Picbx = new System.Windows.Forms.PictureBox();
            this.UI_Min_Lbl = new System.Windows.Forms.Label();
            this.UI_Max_Lbl = new System.Windows.Forms.Label();
            this.MouseClickTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.UI_NumBlocks_Trckbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UI_Color_Picbx)).BeginInit();
            this.SuspendLayout();
            // 
            // UI_Generate_Btn
            // 
            this.UI_Generate_Btn.Location = new System.Drawing.Point(9, 199);
            this.UI_Generate_Btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UI_Generate_Btn.Name = "UI_Generate_Btn";
            this.UI_Generate_Btn.Size = new System.Drawing.Size(80, 28);
            this.UI_Generate_Btn.TabIndex = 0;
            this.UI_Generate_Btn.Text = "Generate";
            this.UI_Generate_Btn.UseVisualStyleBackColor = true;
            this.UI_Generate_Btn.Click += new System.EventHandler(this.UI_Generate_Btn_Click);
            // 
            // UI_Fill_Btn
            // 
            this.UI_Fill_Btn.Location = new System.Drawing.Point(222, 199);
            this.UI_Fill_Btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UI_Fill_Btn.Name = "UI_Fill_Btn";
            this.UI_Fill_Btn.Size = new System.Drawing.Size(80, 28);
            this.UI_Fill_Btn.TabIndex = 1;
            this.UI_Fill_Btn.Text = "Fill";
            this.UI_Fill_Btn.UseVisualStyleBackColor = true;
            this.UI_Fill_Btn.Click += new System.EventHandler(this.UI_Fill_Btn_Click);
            // 
            // UI_FillColor_Btn
            // 
            this.UI_FillColor_Btn.Location = new System.Drawing.Point(116, 199);
            this.UI_FillColor_Btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UI_FillColor_Btn.Name = "UI_FillColor_Btn";
            this.UI_FillColor_Btn.Size = new System.Drawing.Size(80, 28);
            this.UI_FillColor_Btn.TabIndex = 2;
            this.UI_FillColor_Btn.Text = "Fill Color";
            this.UI_FillColor_Btn.UseVisualStyleBackColor = true;
            this.UI_FillColor_Btn.Click += new System.EventHandler(this.UI_FillColor_Btn_Click);
            // 
            // UI_NumBlocks_Lbl
            // 
            this.UI_NumBlocks_Lbl.AutoSize = true;
            this.UI_NumBlocks_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.UI_NumBlocks_Lbl.Location = new System.Drawing.Point(91, 22);
            this.UI_NumBlocks_Lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UI_NumBlocks_Lbl.Name = "UI_NumBlocks_Lbl";
            this.UI_NumBlocks_Lbl.Size = new System.Drawing.Size(134, 20);
            this.UI_NumBlocks_Lbl.TabIndex = 3;
            this.UI_NumBlocks_Lbl.Text = "Number of Blocks";
            this.UI_NumBlocks_Lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // UI_FillClr_Lbl
            // 
            this.UI_FillClr_Lbl.AutoSize = true;
            this.UI_FillClr_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.UI_FillClr_Lbl.Location = new System.Drawing.Point(74, 120);
            this.UI_FillClr_Lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UI_FillClr_Lbl.Name = "UI_FillClr_Lbl";
            this.UI_FillClr_Lbl.Size = new System.Drawing.Size(69, 20);
            this.UI_FillClr_Lbl.TabIndex = 4;
            this.UI_FillClr_Lbl.Text = "Fill Color";
            this.UI_FillClr_Lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // UI_NumBlocks_Trckbar
            // 
            this.UI_NumBlocks_Trckbar.Location = new System.Drawing.Point(25, 45);
            this.UI_NumBlocks_Trckbar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UI_NumBlocks_Trckbar.Maximum = 3000;
            this.UI_NumBlocks_Trckbar.Minimum = 100;
            this.UI_NumBlocks_Trckbar.Name = "UI_NumBlocks_Trckbar";
            this.UI_NumBlocks_Trckbar.Size = new System.Drawing.Size(262, 45);
            this.UI_NumBlocks_Trckbar.TabIndex = 5;
            this.UI_NumBlocks_Trckbar.TickFrequency = 100;
            this.UI_NumBlocks_Trckbar.Value = 100;
            // 
            // UI_Color_Picbx
            // 
            this.UI_Color_Picbx.BackColor = System.Drawing.Color.White;
            this.UI_Color_Picbx.ErrorImage = null;
            this.UI_Color_Picbx.Location = new System.Drawing.Point(145, 111);
            this.UI_Color_Picbx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UI_Color_Picbx.Name = "UI_Color_Picbx";
            this.UI_Color_Picbx.Size = new System.Drawing.Size(70, 39);
            this.UI_Color_Picbx.TabIndex = 6;
            this.UI_Color_Picbx.TabStop = false;
            // 
            // UI_Min_Lbl
            // 
            this.UI_Min_Lbl.AutoSize = true;
            this.UI_Min_Lbl.Location = new System.Drawing.Point(22, 77);
            this.UI_Min_Lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UI_Min_Lbl.Name = "UI_Min_Lbl";
            this.UI_Min_Lbl.Size = new System.Drawing.Size(25, 13);
            this.UI_Min_Lbl.TabIndex = 7;
            this.UI_Min_Lbl.Text = "100";
            // 
            // UI_Max_Lbl
            // 
            this.UI_Max_Lbl.AutoSize = true;
            this.UI_Max_Lbl.Location = new System.Drawing.Point(260, 77);
            this.UI_Max_Lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UI_Max_Lbl.Name = "UI_Max_Lbl";
            this.UI_Max_Lbl.Size = new System.Drawing.Size(31, 13);
            this.UI_Max_Lbl.TabIndex = 8;
            this.UI_Max_Lbl.Text = "3000";
            // 
            // MouseClickTimer
            // 
            this.MouseClickTimer.Interval = 1000;
            this.MouseClickTimer.Tick += new System.EventHandler(this.MouseClickTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 241);
            this.Controls.Add(this.UI_Max_Lbl);
            this.Controls.Add(this.UI_Min_Lbl);
            this.Controls.Add(this.UI_Color_Picbx);
            this.Controls.Add(this.UI_NumBlocks_Trckbar);
            this.Controls.Add(this.UI_FillClr_Lbl);
            this.Controls.Add(this.UI_NumBlocks_Lbl);
            this.Controls.Add(this.UI_FillColor_Btn);
            this.Controls.Add(this.UI_Fill_Btn);
            this.Controls.Add(this.UI_Generate_Btn);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(329, 280);
            this.MinimumSize = new System.Drawing.Size(329, 280);
            this.Name = "Form1";
            this.Text = "FloodFill";
            ((System.ComponentModel.ISupportInitialize)(this.UI_NumBlocks_Trckbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UI_Color_Picbx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button UI_Generate_Btn;
        private System.Windows.Forms.Button UI_Fill_Btn;
        private System.Windows.Forms.Button UI_FillColor_Btn;
        private System.Windows.Forms.Label UI_NumBlocks_Lbl;
        private System.Windows.Forms.Label UI_FillClr_Lbl;
        private System.Windows.Forms.TrackBar UI_NumBlocks_Trckbar;
        private System.Windows.Forms.PictureBox UI_Color_Picbx;
        private System.Windows.Forms.Label UI_Min_Lbl;
        private System.Windows.Forms.Label UI_Max_Lbl;
        private System.Windows.Forms.Timer MouseClickTimer;
    }
}

