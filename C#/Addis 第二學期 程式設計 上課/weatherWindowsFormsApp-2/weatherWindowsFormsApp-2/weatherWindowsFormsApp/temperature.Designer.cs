namespace weatherWindowsFormsApp
{
    partial class temperature
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.inputMonthMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.inputYearMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TemperatureListBox = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.averageTemperatureLabel = new System.Windows.Forms.Label();
            this.theLowestTemperatureLabel = new System.Windows.Forms.Label();
            this.theHighestTemperatureLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.ComputeButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.inputMonthMaskedTextBox);
            this.panel1.Controls.Add(this.inputYearMaskedTextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(38, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(319, 130);
            this.panel1.TabIndex = 1;
            // 
            // inputMonthMaskedTextBox
            // 
            this.inputMonthMaskedTextBox.Location = new System.Drawing.Point(183, 80);
            this.inputMonthMaskedTextBox.Name = "inputMonthMaskedTextBox";
            this.inputMonthMaskedTextBox.Size = new System.Drawing.Size(100, 35);
            this.inputMonthMaskedTextBox.TabIndex = 4;
            // 
            // inputYearMaskedTextBox
            // 
            this.inputYearMaskedTextBox.Location = new System.Drawing.Point(183, 21);
            this.inputYearMaskedTextBox.Name = "inputYearMaskedTextBox";
            this.inputYearMaskedTextBox.Size = new System.Drawing.Size(100, 35);
            this.inputYearMaskedTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "輸入查詢月份: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "輸入查詢年份: ";
            // 
            // TemperatureListBox
            // 
            this.TemperatureListBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TemperatureListBox.FormattingEnabled = true;
            this.TemperatureListBox.ItemHeight = 21;
            this.TemperatureListBox.Location = new System.Drawing.Point(501, 46);
            this.TemperatureListBox.Name = "TemperatureListBox";
            this.TemperatureListBox.Size = new System.Drawing.Size(218, 466);
            this.TemperatureListBox.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(234, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 44);
            this.button1.TabIndex = 3;
            this.button1.Text = "查詢";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "當月最高温度";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.averageTemperatureLabel);
            this.panel2.Controls.Add(this.theLowestTemperatureLabel);
            this.panel2.Controls.Add(this.theHighestTemperatureLabel);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(12, 269);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(470, 299);
            this.panel2.TabIndex = 5;
            // 
            // averageTemperatureLabel
            // 
            this.averageTemperatureLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.averageTemperatureLabel.Location = new System.Drawing.Point(209, 215);
            this.averageTemperatureLabel.Name = "averageTemperatureLabel";
            this.averageTemperatureLabel.Size = new System.Drawing.Size(100, 28);
            this.averageTemperatureLabel.TabIndex = 9;
            this.averageTemperatureLabel.Text = "   ";
            this.averageTemperatureLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // theLowestTemperatureLabel
            // 
            this.theLowestTemperatureLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.theLowestTemperatureLabel.Location = new System.Drawing.Point(186, 139);
            this.theLowestTemperatureLabel.Name = "theLowestTemperatureLabel";
            this.theLowestTemperatureLabel.Size = new System.Drawing.Size(157, 34);
            this.theLowestTemperatureLabel.TabIndex = 8;
            this.theLowestTemperatureLabel.Text = "   ";
            this.theLowestTemperatureLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // theHighestTemperatureLabel
            // 
            this.theHighestTemperatureLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.theHighestTemperatureLabel.Location = new System.Drawing.Point(163, 27);
            this.theHighestTemperatureLabel.Name = "theHighestTemperatureLabel";
            this.theHighestTemperatureLabel.Size = new System.Drawing.Size(300, 78);
            this.theHighestTemperatureLabel.TabIndex = 7;
            this.theHighestTemperatureLabel.Text = "   ";
            this.theHighestTemperatureLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 26);
            this.label5.TabIndex = 6;
            this.label5.Text = "當月平均温度";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 26);
            this.label4.TabIndex = 5;
            this.label4.Text = "當月最低温度";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(496, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 26);
            this.label6.TabIndex = 6;
            this.label6.Text = "每日温度列表";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(820, 335);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 41);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "清除";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(820, 429);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 38);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "結束";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // ComputeButton
            // 
            this.ComputeButton.Location = new System.Drawing.Point(112, 194);
            this.ComputeButton.Name = "ComputeButton";
            this.ComputeButton.Size = new System.Drawing.Size(75, 44);
            this.ComputeButton.TabIndex = 9;
            this.ComputeButton.Text = "統計";
            this.ComputeButton.UseVisualStyleBackColor = true;
            this.ComputeButton.Click += new System.EventHandler(this.ComputeButton_Click);
            // 
            // temperature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(947, 600);
            this.Controls.Add(this.ComputeButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TemperatureListBox);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "temperature";
            this.Text = "歷史温度查詢系統";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox inputMonthMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox inputYearMaskedTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox TemperatureListBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label theHighestTemperatureLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label averageTemperatureLabel;
        private System.Windows.Forms.Label theLowestTemperatureLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button ComputeButton;
    }
}

