namespace Lec3_Ex1
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
            this.UI_Value_Lbl = new System.Windows.Forms.Label();
            this.UI_Result_Lbl = new System.Windows.Forms.Label();
            this.UI_Value_Txtbx = new System.Windows.Forms.TextBox();
            this.UI_Result_Txtbx = new System.Windows.Forms.TextBox();
            this.UI_Calc_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UI_Value_Lbl
            // 
            this.UI_Value_Lbl.AutoSize = true;
            this.UI_Value_Lbl.Location = new System.Drawing.Point(180, 145);
            this.UI_Value_Lbl.Name = "UI_Value_Lbl";
            this.UI_Value_Lbl.Size = new System.Drawing.Size(43, 16);
            this.UI_Value_Lbl.TabIndex = 0;
            this.UI_Value_Lbl.Text = "value:";
            // 
            // UI_Result_Lbl
            // 
            this.UI_Result_Lbl.AutoSize = true;
            this.UI_Result_Lbl.Location = new System.Drawing.Point(180, 283);
            this.UI_Result_Lbl.Name = "UI_Result_Lbl";
            this.UI_Result_Lbl.Size = new System.Drawing.Size(42, 16);
            this.UI_Result_Lbl.TabIndex = 1;
            this.UI_Result_Lbl.Text = "result:";
            // 
            // UI_Value_Txtbx
            // 
            this.UI_Value_Txtbx.Location = new System.Drawing.Point(229, 145);
            this.UI_Value_Txtbx.Name = "UI_Value_Txtbx";
            this.UI_Value_Txtbx.Size = new System.Drawing.Size(188, 22);
            this.UI_Value_Txtbx.TabIndex = 2;
            // 
            // UI_Result_Txtbx
            // 
            this.UI_Result_Txtbx.Location = new System.Drawing.Point(229, 283);
            this.UI_Result_Txtbx.Name = "UI_Result_Txtbx";
            this.UI_Result_Txtbx.ReadOnly = true;
            this.UI_Result_Txtbx.Size = new System.Drawing.Size(188, 22);
            this.UI_Result_Txtbx.TabIndex = 3;
            // 
            // UI_Calc_Btn
            // 
            this.UI_Calc_Btn.Location = new System.Drawing.Point(229, 190);
            this.UI_Calc_Btn.Name = "UI_Calc_Btn";
            this.UI_Calc_Btn.Size = new System.Drawing.Size(171, 66);
            this.UI_Calc_Btn.TabIndex = 4;
            this.UI_Calc_Btn.Text = "Calculate Factorial";
            this.UI_Calc_Btn.UseVisualStyleBackColor = true;
            this.UI_Calc_Btn.Click += new System.EventHandler(this.UI_Calc_Btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UI_Calc_Btn);
            this.Controls.Add(this.UI_Result_Txtbx);
            this.Controls.Add(this.UI_Value_Txtbx);
            this.Controls.Add(this.UI_Result_Lbl);
            this.Controls.Add(this.UI_Value_Lbl);
            this.Name = "Form1";
            this.Text = "Calculating Factorial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UI_Value_Lbl;
        private System.Windows.Forms.Label UI_Result_Lbl;
        private System.Windows.Forms.TextBox UI_Value_Txtbx;
        private System.Windows.Forms.TextBox UI_Result_Txtbx;
        private System.Windows.Forms.Button UI_Calc_Btn;
    }
}

