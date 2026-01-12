namespace WindowsFormsApp1
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
            this.TimesalaryLabel = new System.Windows.Forms.Label();
            this.TimesalaryTextBox = new System.Windows.Forms.TextBox();
            this.HourLabel = new System.Windows.Forms.Label();
            this.TotalSalary2Label = new System.Windows.Forms.Label();
            this.HoursTextBox = new System.Windows.Forms.TextBox();
            this.TotalSalaryLabel = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.EndButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TimesalaryLabel
            // 
            this.TimesalaryLabel.AutoSize = true;
            this.TimesalaryLabel.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TimesalaryLabel.Location = new System.Drawing.Point(94, 74);
            this.TimesalaryLabel.Name = "TimesalaryLabel";
            this.TimesalaryLabel.Size = new System.Drawing.Size(68, 31);
            this.TimesalaryLabel.TabIndex = 0;
            this.TimesalaryLabel.Text = "時薪:";
            // 
            // TimesalaryTextBox
            // 
            this.TimesalaryTextBox.Location = new System.Drawing.Point(247, 74);
            this.TimesalaryTextBox.Name = "TimesalaryTextBox";
            this.TimesalaryTextBox.Size = new System.Drawing.Size(100, 25);
            this.TimesalaryTextBox.TabIndex = 1;
            // 
            // HourLabel
            // 
            this.HourLabel.AutoSize = true;
            this.HourLabel.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.HourLabel.Location = new System.Drawing.Point(94, 144);
            this.HourLabel.Name = "HourLabel";
            this.HourLabel.Size = new System.Drawing.Size(68, 31);
            this.HourLabel.TabIndex = 2;
            this.HourLabel.Text = "時數:";
            // 
            // TotalSalary2Label
            // 
            this.TotalSalary2Label.AutoSize = true;
            this.TotalSalary2Label.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TotalSalary2Label.Location = new System.Drawing.Point(94, 235);
            this.TotalSalary2Label.Name = "TotalSalary2Label";
            this.TotalSalary2Label.Size = new System.Drawing.Size(92, 31);
            this.TotalSalary2Label.TabIndex = 3;
            this.TotalSalary2Label.Text = "總薪水:";
            // 
            // HoursTextBox
            // 
            this.HoursTextBox.Location = new System.Drawing.Point(247, 144);
            this.HoursTextBox.Name = "HoursTextBox";
            this.HoursTextBox.Size = new System.Drawing.Size(100, 25);
            this.HoursTextBox.TabIndex = 4;
            // 
            // TotalSalaryLabel
            // 
            this.TotalSalaryLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TotalSalaryLabel.Location = new System.Drawing.Point(247, 245);
            this.TotalSalaryLabel.Name = "TotalSalaryLabel";
            this.TotalSalaryLabel.Size = new System.Drawing.Size(100, 23);
            this.TotalSalaryLabel.TabIndex = 5;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CalculateButton.Location = new System.Drawing.Point(513, 82);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(145, 49);
            this.CalculateButton.TabIndex = 6;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // EndButton
            // 
            this.EndButton.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.EndButton.Location = new System.Drawing.Point(513, 225);
            this.EndButton.Name = "EndButton";
            this.EndButton.Size = new System.Drawing.Size(145, 41);
            this.EndButton.TabIndex = 7;
            this.EndButton.Text = "End";
            this.EndButton.UseVisualStyleBackColor = true;
            this.EndButton.Click += new System.EventHandler(this.EndButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ClearButton.Location = new System.Drawing.Point(513, 164);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(145, 40);
            this.ClearButton.TabIndex = 8;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.EndButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.TotalSalaryLabel);
            this.Controls.Add(this.HoursTextBox);
            this.Controls.Add(this.TotalSalary2Label);
            this.Controls.Add(this.HourLabel);
            this.Controls.Add(this.TimesalaryTextBox);
            this.Controls.Add(this.TimesalaryLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TimesalaryLabel;
        private System.Windows.Forms.TextBox TimesalaryTextBox;
        private System.Windows.Forms.Label HourLabel;
        private System.Windows.Forms.Label TotalSalary2Label;
        private System.Windows.Forms.TextBox HoursTextBox;
        private System.Windows.Forms.Label TotalSalaryLabel;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button EndButton;
        private System.Windows.Forms.Button ClearButton;
    }
}

