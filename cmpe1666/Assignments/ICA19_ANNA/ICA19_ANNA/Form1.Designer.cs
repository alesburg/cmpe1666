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
            this.UI_SortCriteria_Grpbx = new System.Windows.Forms.GroupBox();
            this.UI_SortOrder_Grpbx = new System.Windows.Forms.GroupBox();
            this.UI_SensorID_RadBtn = new System.Windows.Forms.RadioButton();
            this.UI_Temp_RadBtn = new System.Windows.Forms.RadioButton();
            this.UI_Asc_RadBtn = new System.Windows.Forms.RadioButton();
            this.UI_Desc_RadBtn = new System.Windows.Forms.RadioButton();
            this.UI_DisplaySorted_Btn = new System.Windows.Forms.Button();
            this.UI_TempVal_Tbx = new System.Windows.Forms.TextBox();
            this.UI_TempVal_Lbl = new System.Windows.Forms.Label();
            this.UI_SelectCriteria_Grpbx = new System.Windows.Forms.GroupBox();
            this.UI_Less_RadBtn = new System.Windows.Forms.RadioButton();
            this.UI_Greater_RadBtn = new System.Windows.Forms.RadioButton();
            this.UI_DisplaySelected_Btn = new System.Windows.Forms.Button();
            this.UI_SortCriteria_Grpbx.SuspendLayout();
            this.UI_SortOrder_Grpbx.SuspendLayout();
            this.UI_SelectCriteria_Grpbx.SuspendLayout();
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
            this.UI_Redisplay_Button.Location = new System.Drawing.Point(59, 543);
            this.UI_Redisplay_Button.Name = "UI_Redisplay_Button";
            this.UI_Redisplay_Button.Size = new System.Drawing.Size(168, 55);
            this.UI_Redisplay_Button.TabIndex = 9;
            this.UI_Redisplay_Button.Text = "Redisplay";
            this.UI_Redisplay_Button.UseVisualStyleBackColor = true;
            // 
            // UI_SortCriteria_Grpbx
            // 
            this.UI_SortCriteria_Grpbx.Controls.Add(this.UI_Temp_RadBtn);
            this.UI_SortCriteria_Grpbx.Controls.Add(this.UI_SensorID_RadBtn);
            this.UI_SortCriteria_Grpbx.Location = new System.Drawing.Point(370, 403);
            this.UI_SortCriteria_Grpbx.Name = "UI_SortCriteria_Grpbx";
            this.UI_SortCriteria_Grpbx.Size = new System.Drawing.Size(235, 67);
            this.UI_SortCriteria_Grpbx.TabIndex = 10;
            this.UI_SortCriteria_Grpbx.TabStop = false;
            this.UI_SortCriteria_Grpbx.Text = "Sort Criteria";
            // 
            // UI_SortOrder_Grpbx
            // 
            this.UI_SortOrder_Grpbx.Controls.Add(this.UI_Desc_RadBtn);
            this.UI_SortOrder_Grpbx.Controls.Add(this.UI_Asc_RadBtn);
            this.UI_SortOrder_Grpbx.Location = new System.Drawing.Point(370, 483);
            this.UI_SortOrder_Grpbx.Name = "UI_SortOrder_Grpbx";
            this.UI_SortOrder_Grpbx.Size = new System.Drawing.Size(235, 54);
            this.UI_SortOrder_Grpbx.TabIndex = 11;
            this.UI_SortOrder_Grpbx.TabStop = false;
            this.UI_SortOrder_Grpbx.Text = "Sort Order";
            // 
            // UI_SensorID_RadBtn
            // 
            this.UI_SensorID_RadBtn.AutoSize = true;
            this.UI_SensorID_RadBtn.Location = new System.Drawing.Point(6, 21);
            this.UI_SensorID_RadBtn.Name = "UI_SensorID_RadBtn";
            this.UI_SensorID_RadBtn.Size = new System.Drawing.Size(82, 20);
            this.UI_SensorID_RadBtn.TabIndex = 0;
            this.UI_SensorID_RadBtn.TabStop = true;
            this.UI_SensorID_RadBtn.Text = "SensorId";
            this.UI_SensorID_RadBtn.UseVisualStyleBackColor = true;
            // 
            // UI_Temp_RadBtn
            // 
            this.UI_Temp_RadBtn.AutoSize = true;
            this.UI_Temp_RadBtn.Location = new System.Drawing.Point(123, 21);
            this.UI_Temp_RadBtn.Name = "UI_Temp_RadBtn";
            this.UI_Temp_RadBtn.Size = new System.Drawing.Size(106, 20);
            this.UI_Temp_RadBtn.TabIndex = 1;
            this.UI_Temp_RadBtn.TabStop = true;
            this.UI_Temp_RadBtn.Text = "Temperature";
            this.UI_Temp_RadBtn.UseVisualStyleBackColor = true;
            // 
            // UI_Asc_RadBtn
            // 
            this.UI_Asc_RadBtn.AutoSize = true;
            this.UI_Asc_RadBtn.Location = new System.Drawing.Point(6, 21);
            this.UI_Asc_RadBtn.Name = "UI_Asc_RadBtn";
            this.UI_Asc_RadBtn.Size = new System.Drawing.Size(92, 20);
            this.UI_Asc_RadBtn.TabIndex = 2;
            this.UI_Asc_RadBtn.TabStop = true;
            this.UI_Asc_RadBtn.Text = "Ascending";
            this.UI_Asc_RadBtn.UseVisualStyleBackColor = true;
            // 
            // UI_Desc_RadBtn
            // 
            this.UI_Desc_RadBtn.AutoSize = true;
            this.UI_Desc_RadBtn.Location = new System.Drawing.Point(123, 21);
            this.UI_Desc_RadBtn.Name = "UI_Desc_RadBtn";
            this.UI_Desc_RadBtn.Size = new System.Drawing.Size(101, 20);
            this.UI_Desc_RadBtn.TabIndex = 3;
            this.UI_Desc_RadBtn.TabStop = true;
            this.UI_Desc_RadBtn.Text = "Descending";
            this.UI_Desc_RadBtn.UseVisualStyleBackColor = true;
            // 
            // UI_DisplaySorted_Btn
            // 
            this.UI_DisplaySorted_Btn.Location = new System.Drawing.Point(401, 543);
            this.UI_DisplaySorted_Btn.Name = "UI_DisplaySorted_Btn";
            this.UI_DisplaySorted_Btn.Size = new System.Drawing.Size(168, 55);
            this.UI_DisplaySorted_Btn.TabIndex = 12;
            this.UI_DisplaySorted_Btn.Text = "Display Sorted";
            this.UI_DisplaySorted_Btn.UseVisualStyleBackColor = true;
            // 
            // UI_TempVal_Tbx
            // 
            this.UI_TempVal_Tbx.Location = new System.Drawing.Point(820, 403);
            this.UI_TempVal_Tbx.Name = "UI_TempVal_Tbx";
            this.UI_TempVal_Tbx.Size = new System.Drawing.Size(125, 22);
            this.UI_TempVal_Tbx.TabIndex = 13;
            // 
            // UI_TempVal_Lbl
            // 
            this.UI_TempVal_Lbl.AutoSize = true;
            this.UI_TempVal_Lbl.Location = new System.Drawing.Point(686, 406);
            this.UI_TempVal_Lbl.Name = "UI_TempVal_Lbl";
            this.UI_TempVal_Lbl.Size = new System.Drawing.Size(129, 16);
            this.UI_TempVal_Lbl.TabIndex = 14;
            this.UI_TempVal_Lbl.Text = "Temperature Value: ";
            // 
            // UI_SelectCriteria_Grpbx
            // 
            this.UI_SelectCriteria_Grpbx.Controls.Add(this.UI_Less_RadBtn);
            this.UI_SelectCriteria_Grpbx.Controls.Add(this.UI_Greater_RadBtn);
            this.UI_SelectCriteria_Grpbx.Location = new System.Drawing.Point(688, 451);
            this.UI_SelectCriteria_Grpbx.Name = "UI_SelectCriteria_Grpbx";
            this.UI_SelectCriteria_Grpbx.Size = new System.Drawing.Size(275, 73);
            this.UI_SelectCriteria_Grpbx.TabIndex = 12;
            this.UI_SelectCriteria_Grpbx.TabStop = false;
            this.UI_SelectCriteria_Grpbx.Text = "Selection Criteria";
            // 
            // UI_Less_RadBtn
            // 
            this.UI_Less_RadBtn.AutoSize = true;
            this.UI_Less_RadBtn.Location = new System.Drawing.Point(10, 47);
            this.UI_Less_RadBtn.Name = "UI_Less_RadBtn";
            this.UI_Less_RadBtn.Size = new System.Drawing.Size(144, 20);
            this.UI_Less_RadBtn.TabIndex = 3;
            this.UI_Less_RadBtn.TabStop = true;
            this.UI_Less_RadBtn.Text = "Less Than or Equal";
            this.UI_Less_RadBtn.UseVisualStyleBackColor = true;
            // 
            // UI_Greater_RadBtn
            // 
            this.UI_Greater_RadBtn.AutoSize = true;
            this.UI_Greater_RadBtn.Location = new System.Drawing.Point(10, 21);
            this.UI_Greater_RadBtn.Name = "UI_Greater_RadBtn";
            this.UI_Greater_RadBtn.Size = new System.Drawing.Size(160, 20);
            this.UI_Greater_RadBtn.TabIndex = 2;
            this.UI_Greater_RadBtn.TabStop = true;
            this.UI_Greater_RadBtn.Text = "Greater Than or Equal";
            this.UI_Greater_RadBtn.UseVisualStyleBackColor = true;
            // 
            // UI_DisplaySelected_Btn
            // 
            this.UI_DisplaySelected_Btn.Location = new System.Drawing.Point(747, 543);
            this.UI_DisplaySelected_Btn.Name = "UI_DisplaySelected_Btn";
            this.UI_DisplaySelected_Btn.Size = new System.Drawing.Size(168, 55);
            this.UI_DisplaySelected_Btn.TabIndex = 15;
            this.UI_DisplaySelected_Btn.Text = "Display Selected";
            this.UI_DisplaySelected_Btn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 623);
            this.Controls.Add(this.UI_DisplaySelected_Btn);
            this.Controls.Add(this.UI_SelectCriteria_Grpbx);
            this.Controls.Add(this.UI_TempVal_Lbl);
            this.Controls.Add(this.UI_TempVal_Tbx);
            this.Controls.Add(this.UI_DisplaySorted_Btn);
            this.Controls.Add(this.UI_SortOrder_Grpbx);
            this.Controls.Add(this.UI_SortCriteria_Grpbx);
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
            this.UI_SortCriteria_Grpbx.ResumeLayout(false);
            this.UI_SortCriteria_Grpbx.PerformLayout();
            this.UI_SortOrder_Grpbx.ResumeLayout(false);
            this.UI_SortOrder_Grpbx.PerformLayout();
            this.UI_SelectCriteria_Grpbx.ResumeLayout(false);
            this.UI_SelectCriteria_Grpbx.PerformLayout();
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
        private System.Windows.Forms.GroupBox UI_SortCriteria_Grpbx;
        private System.Windows.Forms.RadioButton UI_Temp_RadBtn;
        private System.Windows.Forms.RadioButton UI_SensorID_RadBtn;
        private System.Windows.Forms.GroupBox UI_SortOrder_Grpbx;
        private System.Windows.Forms.RadioButton UI_Desc_RadBtn;
        private System.Windows.Forms.RadioButton UI_Asc_RadBtn;
        private System.Windows.Forms.Button UI_DisplaySorted_Btn;
        private System.Windows.Forms.TextBox UI_TempVal_Tbx;
        private System.Windows.Forms.Label UI_TempVal_Lbl;
        private System.Windows.Forms.GroupBox UI_SelectCriteria_Grpbx;
        private System.Windows.Forms.RadioButton UI_Less_RadBtn;
        private System.Windows.Forms.RadioButton UI_Greater_RadBtn;
        private System.Windows.Forms.Button UI_DisplaySelected_Btn;
    }
}

