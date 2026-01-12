namespace 氣候WindowsFormsApp
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.YearTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MonthTextBox = new System.Windows.Forms.TextBox();
            this.InputButton = new System.Windows.Forms.Button();
            this.ComputeButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AverageLabel = new System.Windows.Forms.Label();
            this.HighestLabel = new System.Windows.Forms.Label();
            this.LowestLabel = new System.Windows.Forms.Label();
            this.Day1Label = new System.Windows.Forms.Label();
            this.Day2Label = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.EndButton = new System.Windows.Forms.Button();
            this.WeatherListBox = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(29, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "請輸入年分:";
            // 
            // YearTextBox
            // 
            this.YearTextBox.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.YearTextBox.Location = new System.Drawing.Point(225, 55);
            this.YearTextBox.Name = "YearTextBox";
            this.YearTextBox.Size = new System.Drawing.Size(100, 31);
            this.YearTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(29, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "請輸入月份:";
            // 
            // MonthTextBox
            // 
            this.MonthTextBox.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MonthTextBox.Location = new System.Drawing.Point(225, 130);
            this.MonthTextBox.Name = "MonthTextBox";
            this.MonthTextBox.Size = new System.Drawing.Size(100, 31);
            this.MonthTextBox.TabIndex = 3;
            // 
            // InputButton
            // 
            this.InputButton.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.InputButton.Location = new System.Drawing.Point(420, 55);
            this.InputButton.Name = "InputButton";
            this.InputButton.Size = new System.Drawing.Size(184, 36);
            this.InputButton.TabIndex = 4;
            this.InputButton.Text = "輸入氣候資料";
            this.InputButton.UseVisualStyleBackColor = true;
            this.InputButton.Click += new System.EventHandler(this.InputButton_Click);
            // 
            // ComputeButton
            // 
            this.ComputeButton.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ComputeButton.Location = new System.Drawing.Point(420, 125);
            this.ComputeButton.Name = "ComputeButton";
            this.ComputeButton.Size = new System.Drawing.Size(184, 36);
            this.ComputeButton.TabIndex = 5;
            this.ComputeButton.Text = "統計氣候資料";
            this.ComputeButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.Day2Label);
            this.groupBox1.Controls.Add(this.Day1Label);
            this.groupBox1.Controls.Add(this.LowestLabel);
            this.groupBox1.Controls.Add(this.HighestLabel);
            this.groupBox1.Controls.Add(this.AverageLabel);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(36, 225);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(468, 230);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "統計結果";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 31);
            this.label3.TabIndex = 0;
            this.label3.Text = "平均溫度:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 31);
            this.label4.TabIndex = 1;
            this.label4.Text = "最高溫:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 31);
            this.label5.TabIndex = 2;
            this.label5.Text = "最低溫:";
            // 
            // AverageLabel
            // 
            this.AverageLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AverageLabel.Location = new System.Drawing.Point(159, 50);
            this.AverageLabel.Name = "AverageLabel";
            this.AverageLabel.Size = new System.Drawing.Size(97, 31);
            this.AverageLabel.TabIndex = 3;
            // 
            // HighestLabel
            // 
            this.HighestLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HighestLabel.Location = new System.Drawing.Point(159, 104);
            this.HighestLabel.Name = "HighestLabel";
            this.HighestLabel.Size = new System.Drawing.Size(97, 31);
            this.HighestLabel.TabIndex = 4;
            // 
            // LowestLabel
            // 
            this.LowestLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LowestLabel.Location = new System.Drawing.Point(159, 169);
            this.LowestLabel.Name = "LowestLabel";
            this.LowestLabel.Size = new System.Drawing.Size(97, 31);
            this.LowestLabel.TabIndex = 5;
            // 
            // Day1Label
            // 
            this.Day1Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Day1Label.Location = new System.Drawing.Point(365, 105);
            this.Day1Label.Name = "Day1Label";
            this.Day1Label.Size = new System.Drawing.Size(97, 31);
            this.Day1Label.TabIndex = 6;
            // 
            // Day2Label
            // 
            this.Day2Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Day2Label.Location = new System.Drawing.Point(365, 169);
            this.Day2Label.Name = "Day2Label";
            this.Day2Label.Size = new System.Drawing.Size(97, 31);
            this.Day2Label.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(282, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 31);
            this.label6.TabIndex = 8;
            this.label6.Text = "哪天:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(282, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 31);
            this.label7.TabIndex = 9;
            this.label7.Text = "哪天:";
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ClearButton.Location = new System.Drawing.Point(598, 296);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(112, 44);
            this.ClearButton.TabIndex = 7;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            // 
            // EndButton
            // 
            this.EndButton.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.EndButton.Location = new System.Drawing.Point(598, 381);
            this.EndButton.Name = "EndButton";
            this.EndButton.Size = new System.Drawing.Size(112, 44);
            this.EndButton.TabIndex = 8;
            this.EndButton.Text = "End";
            this.EndButton.UseVisualStyleBackColor = true;
            // 
            // WeatherListBox
            // 
            this.WeatherListBox.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.WeatherListBox.FormattingEnabled = true;
            this.WeatherListBox.ItemHeight = 29;
            this.WeatherListBox.Location = new System.Drawing.Point(775, 55);
            this.WeatherListBox.Name = "WeatherListBox";
            this.WeatherListBox.Size = new System.Drawing.Size(197, 207);
            this.WeatherListBox.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 532);
            this.Controls.Add(this.WeatherListBox);
            this.Controls.Add(this.EndButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ComputeButton);
            this.Controls.Add(this.InputButton);
            this.Controls.Add(this.MonthTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.YearTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "氣候統計資料";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox YearTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MonthTextBox;
        private System.Windows.Forms.Button InputButton;
        private System.Windows.Forms.Button ComputeButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Day2Label;
        private System.Windows.Forms.Label Day1Label;
        private System.Windows.Forms.Label LowestLabel;
        private System.Windows.Forms.Label HighestLabel;
        private System.Windows.Forms.Label AverageLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button EndButton;
        private System.Windows.Forms.ListBox WeatherListBox;
    }
}

