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
            this.UI_Sensor_Lbl = new System.Windows.Forms.Label();
            this.UI_RawData_Lstbx = new System.Windows.Forms.ListBox();
            this.UI_SortedData_Lstbx = new System.Windows.Forms.ListBox();
            this.UI_Sensor_Lstbx = new System.Windows.Forms.ListBox();
            this.UI_GenSensors_Btn = new System.Windows.Forms.Button();
            this.UI_SensorNum_Tbx = new System.Windows.Forms.TextBox();
            this.UI_NumSensors_Lbl = new System.Windows.Forms.Label();
            this.UI_Redisplay_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UI_RawData_Lbl
            // 
            this.UI_RawData_Lbl.AutoSize = true;
            this.UI_RawData_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_RawData_Lbl.Location = new System.Drawing.Point(80, 9);
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
            this.UI_DataSorted_Lbl.Location = new System.Drawing.Point(417, 9);
            this.UI_DataSorted_Lbl.Name = "UI_DataSorted_Lbl";
            this.UI_DataSorted_Lbl.Size = new System.Drawing.Size(140, 20);
            this.UI_DataSorted_Lbl.TabIndex = 1;
            this.UI_DataSorted_Lbl.Text = "Data Sorted On";
            this.UI_DataSorted_Lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // UI_Sensor_Lbl
            // 
            this.UI_Sensor_Lbl.AutoSize = true;
            this.UI_Sensor_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_Sensor_Lbl.Location = new System.Drawing.Point(710, 9);
            this.UI_Sensor_Lbl.Name = "UI_Sensor_Lbl";
            this.UI_Sensor_Lbl.Size = new System.Drawing.Size(235, 20);
            this.UI_Sensor_Lbl.TabIndex = 2;
            this.UI_Sensor_Lbl.Text = "Sensors with temperatures";
            this.UI_Sensor_Lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // UI_RawData_Lstbx
            // 
            this.UI_RawData_Lstbx.FormattingEnabled = true;
            this.UI_RawData_Lstbx.ItemHeight = 16;
            this.UI_RawData_Lstbx.Location = new System.Drawing.Point(12, 32);
            this.UI_RawData_Lstbx.Name = "UI_RawData_Lstbx";
            this.UI_RawData_Lstbx.Size = new System.Drawing.Size(265, 356);
            this.UI_RawData_Lstbx.TabIndex = 3;
            // 
            // UI_SortedData_Lstbx
            // 
            this.UI_SortedData_Lstbx.FormattingEnabled = true;
            this.UI_SortedData_Lstbx.ItemHeight = 16;
            this.UI_SortedData_Lstbx.Location = new System.Drawing.Point(355, 32);
            this.UI_SortedData_Lstbx.Name = "UI_SortedData_Lstbx";
            this.UI_SortedData_Lstbx.Size = new System.Drawing.Size(265, 356);
            this.UI_SortedData_Lstbx.TabIndex = 4;
            // 
            // UI_Sensor_Lstbx
            // 
            this.UI_Sensor_Lstbx.FormattingEnabled = true;
            this.UI_Sensor_Lstbx.ItemHeight = 16;
            this.UI_Sensor_Lstbx.Location = new System.Drawing.Point(698, 32);
            this.UI_Sensor_Lstbx.Name = "UI_Sensor_Lstbx";
            this.UI_Sensor_Lstbx.Size = new System.Drawing.Size(265, 356);
            this.UI_Sensor_Lstbx.TabIndex = 5;
            // 
            // UI_GenSensors_Btn
            // 
            this.UI_GenSensors_Btn.Location = new System.Drawing.Point(60, 403);
            this.UI_GenSensors_Btn.Name = "UI_GenSensors_Btn";
            this.UI_GenSensors_Btn.Size = new System.Drawing.Size(168, 55);
            this.UI_GenSensors_Btn.TabIndex = 6;
            this.UI_GenSensors_Btn.Text = "Generate Sensors";
            this.UI_GenSensors_Btn.UseVisualStyleBackColor = true;
            // 
            // UI_SensorNum_Tbx
            // 
            this.UI_SensorNum_Tbx.Location = new System.Drawing.Point(152, 483);
            this.UI_SensorNum_Tbx.Name = "UI_SensorNum_Tbx";
            this.UI_SensorNum_Tbx.Size = new System.Drawing.Size(125, 22);
            this.UI_SensorNum_Tbx.TabIndex = 7;
            // 
            // UI_NumSensors_Lbl
            // 
            this.UI_NumSensors_Lbl.AutoSize = true;
            this.UI_NumSensors_Lbl.Location = new System.Drawing.Point(18, 486);
            this.UI_NumSensors_Lbl.Name = "UI_NumSensors_Lbl";
            this.UI_NumSensors_Lbl.Size = new System.Drawing.Size(128, 16);
            this.UI_NumSensors_Lbl.TabIndex = 8;
            this.UI_NumSensors_Lbl.Text = "Number of Sensors: ";
            // 
            // UI_Redisplay_Button
            // 
            this.UI_Redisplay_Button.Location = new System.Drawing.Point(60, 535);
            this.UI_Redisplay_Button.Name = "UI_Redisplay_Button";
            this.UI_Redisplay_Button.Size = new System.Drawing.Size(168, 55);
            this.UI_Redisplay_Button.TabIndex = 9;
            this.UI_Redisplay_Button.Text = "Redisplay";
            this.UI_Redisplay_Button.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 623);
            this.Controls.Add(this.UI_Redisplay_Button);
            this.Controls.Add(this.UI_NumSensors_Lbl);
            this.Controls.Add(this.UI_SensorNum_Tbx);
            this.Controls.Add(this.UI_GenSensors_Btn);
            this.Controls.Add(this.UI_Sensor_Lstbx);
            this.Controls.Add(this.UI_SortedData_Lstbx);
            this.Controls.Add(this.UI_RawData_Lstbx);
            this.Controls.Add(this.UI_Sensor_Lbl);
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
        private System.Windows.Forms.Label UI_Sensor_Lbl;
        private System.Windows.Forms.ListBox UI_RawData_Lstbx;
        private System.Windows.Forms.ListBox UI_SortedData_Lstbx;
        private System.Windows.Forms.ListBox UI_Sensor_Lstbx;
        private System.Windows.Forms.Button UI_GenSensors_Btn;
        private System.Windows.Forms.TextBox UI_SensorNum_Tbx;
        private System.Windows.Forms.Label UI_NumSensors_Lbl;
        private System.Windows.Forms.Button UI_Redisplay_Button;
    }
}

