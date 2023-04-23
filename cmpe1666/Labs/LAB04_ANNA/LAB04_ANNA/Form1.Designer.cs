namespace LAB04_ANNA
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
            this.UI_UndoLine_Btn = new System.Windows.Forms.Button();
            this.UI_UndoSeg_Btn = new System.Windows.Forms.Button();
            this.UI_Reduce_Btn = new System.Windows.Forms.Button();
            this.UI_Color_Btn = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.UI_Status_Label = new System.Windows.Forms.Label();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.UI_Thickness_Trkbar = new System.Windows.Forms.TrackBar();
            this.UI_Thickness_Lbl = new System.Windows.Forms.Label();
            this.UI_Opacity_Trckbar = new System.Windows.Forms.TrackBar();
            this.UI_Opacity_Lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UI_Thickness_Trkbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UI_Opacity_Trckbar)).BeginInit();
            this.SuspendLayout();
            // 
            // UI_UndoLine_Btn
            // 
            this.UI_UndoLine_Btn.Location = new System.Drawing.Point(12, 42);
            this.UI_UndoLine_Btn.Name = "UI_UndoLine_Btn";
            this.UI_UndoLine_Btn.Size = new System.Drawing.Size(409, 28);
            this.UI_UndoLine_Btn.TabIndex = 0;
            this.UI_UndoLine_Btn.Text = "Undo Line...";
            this.UI_UndoLine_Btn.UseVisualStyleBackColor = true;
            this.UI_UndoLine_Btn.Click += new System.EventHandler(this.UI_UndoLine_Btn_Click);
            // 
            // UI_UndoSeg_Btn
            // 
            this.UI_UndoSeg_Btn.Location = new System.Drawing.Point(12, 76);
            this.UI_UndoSeg_Btn.Name = "UI_UndoSeg_Btn";
            this.UI_UndoSeg_Btn.Size = new System.Drawing.Size(409, 28);
            this.UI_UndoSeg_Btn.TabIndex = 1;
            this.UI_UndoSeg_Btn.Text = "Undo Segment...";
            this.UI_UndoSeg_Btn.UseVisualStyleBackColor = true;
            this.UI_UndoSeg_Btn.Click += new System.EventHandler(this.UI_UndoSeg_Btn_Click);
            // 
            // UI_Reduce_Btn
            // 
            this.UI_Reduce_Btn.Location = new System.Drawing.Point(12, 110);
            this.UI_Reduce_Btn.Name = "UI_Reduce_Btn";
            this.UI_Reduce_Btn.Size = new System.Drawing.Size(409, 28);
            this.UI_Reduce_Btn.TabIndex = 2;
            this.UI_Reduce_Btn.Text = "Reduce Complexity...";
            this.UI_Reduce_Btn.UseVisualStyleBackColor = true;
            this.UI_Reduce_Btn.Click += new System.EventHandler(this.UI_Reduce_Btn_Click);
            // 
            // UI_Color_Btn
            // 
            this.UI_Color_Btn.Location = new System.Drawing.Point(12, 144);
            this.UI_Color_Btn.Name = "UI_Color_Btn";
            this.UI_Color_Btn.Size = new System.Drawing.Size(409, 28);
            this.UI_Color_Btn.TabIndex = 3;
            this.UI_Color_Btn.Text = "Color";
            this.UI_Color_Btn.UseVisualStyleBackColor = true;
            this.UI_Color_Btn.Click += new System.EventHandler(this.UI_Color_Btn_Click);
            // 
            // timer
            // 
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // UI_Status_Label
            // 
            this.UI_Status_Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UI_Status_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_Status_Label.Location = new System.Drawing.Point(12, 9);
            this.UI_Status_Label.Name = "UI_Status_Label";
            this.UI_Status_Label.Size = new System.Drawing.Size(409, 30);
            this.UI_Status_Label.TabIndex = 4;
            this.UI_Status_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UI_Thickness_Trkbar
            // 
            this.UI_Thickness_Trkbar.Location = new System.Drawing.Point(5, 178);
            this.UI_Thickness_Trkbar.Maximum = 255;
            this.UI_Thickness_Trkbar.Minimum = 1;
            this.UI_Thickness_Trkbar.Name = "UI_Thickness_Trkbar";
            this.UI_Thickness_Trkbar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.UI_Thickness_Trkbar.Size = new System.Drawing.Size(210, 56);
            this.UI_Thickness_Trkbar.TabIndex = 5;
            this.UI_Thickness_Trkbar.TickFrequency = 16;
            this.UI_Thickness_Trkbar.Value = 16;
            this.UI_Thickness_Trkbar.Scroll += new System.EventHandler(this.UI_Thickness_Trkbar_Scroll);
            // 
            // UI_Thickness_Lbl
            // 
            this.UI_Thickness_Lbl.AutoSize = true;
            this.UI_Thickness_Lbl.Location = new System.Drawing.Point(9, 218);
            this.UI_Thickness_Lbl.Name = "UI_Thickness_Lbl";
            this.UI_Thickness_Lbl.Size = new System.Drawing.Size(89, 16);
            this.UI_Thickness_Lbl.TabIndex = 6;
            this.UI_Thickness_Lbl.Text = "Thickness: 16";
            // 
            // UI_Opacity_Trckbar
            // 
            this.UI_Opacity_Trckbar.Location = new System.Drawing.Point(212, 178);
            this.UI_Opacity_Trckbar.Maximum = 255;
            this.UI_Opacity_Trckbar.Minimum = 1;
            this.UI_Opacity_Trckbar.Name = "UI_Opacity_Trckbar";
            this.UI_Opacity_Trckbar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.UI_Opacity_Trckbar.Size = new System.Drawing.Size(210, 56);
            this.UI_Opacity_Trckbar.TabIndex = 7;
            this.UI_Opacity_Trckbar.TickFrequency = 16;
            this.UI_Opacity_Trckbar.Value = 255;
            this.UI_Opacity_Trckbar.Scroll += new System.EventHandler(this.UI_Opacity_Trckbar_Scroll);
            // 
            // UI_Opacity_Lbl
            // 
            this.UI_Opacity_Lbl.AutoSize = true;
            this.UI_Opacity_Lbl.Location = new System.Drawing.Point(332, 221);
            this.UI_Opacity_Lbl.Name = "UI_Opacity_Lbl";
            this.UI_Opacity_Lbl.Size = new System.Drawing.Size(80, 16);
            this.UI_Opacity_Lbl.TabIndex = 8;
            this.UI_Opacity_Lbl.Text = "Opacity: 255";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 246);
            this.Controls.Add(this.UI_Opacity_Lbl);
            this.Controls.Add(this.UI_Opacity_Trckbar);
            this.Controls.Add(this.UI_Thickness_Lbl);
            this.Controls.Add(this.UI_Thickness_Trkbar);
            this.Controls.Add(this.UI_Status_Label);
            this.Controls.Add(this.UI_Color_Btn);
            this.Controls.Add(this.UI_Reduce_Btn);
            this.Controls.Add(this.UI_UndoSeg_Btn);
            this.Controls.Add(this.UI_UndoLine_Btn);
            this.Name = "Form1";
            this.Text = "StackyListDraw";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UI_Thickness_Trkbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UI_Opacity_Trckbar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UI_UndoLine_Btn;
        private System.Windows.Forms.Button UI_UndoSeg_Btn;
        private System.Windows.Forms.Button UI_Reduce_Btn;
        private System.Windows.Forms.Button UI_Color_Btn;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label UI_Status_Label;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.TrackBar UI_Thickness_Trkbar;
        private System.Windows.Forms.Label UI_Thickness_Lbl;
        private System.Windows.Forms.TrackBar UI_Opacity_Trckbar;
        private System.Windows.Forms.Label UI_Opacity_Lbl;
    }
}

