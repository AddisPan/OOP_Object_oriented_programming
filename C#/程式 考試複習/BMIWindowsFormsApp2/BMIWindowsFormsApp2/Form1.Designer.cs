namespace BMIWindowsFormsApp2
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
            this.HightLabel = new System.Windows.Forms.Label();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.BMILabel = new System.Windows.Forms.Label();
            this.BMI2abel = new System.Windows.Forms.Label();
            this.WeightTextBox = new System.Windows.Forms.TextBox();
            this.HightTextBox = new System.Windows.Forms.TextBox();
            this.ThinRadioButton = new System.Windows.Forms.RadioButton();
            this.MiddleRadioButton = new System.Windows.Forms.RadioButton();
            this.OverweightRadioButton = new System.Windows.Forms.RadioButton();
            this.FatRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // HightLabel
            // 
            this.HightLabel.AutoSize = true;
            this.HightLabel.Location = new System.Drawing.Point(50, 93);
            this.HightLabel.Name = "HightLabel";
            this.HightLabel.Size = new System.Drawing.Size(37, 15);
            this.HightLabel.TabIndex = 0;
            this.HightLabel.Text = "身高";
            // 
            // WeightLabel
            // 
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Location = new System.Drawing.Point(50, 160);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(37, 15);
            this.WeightLabel.TabIndex = 1;
            this.WeightLabel.Text = "體重";
            // 
            // BMILabel
            // 
            this.BMILabel.AutoSize = true;
            this.BMILabel.Location = new System.Drawing.Point(50, 216);
            this.BMILabel.Name = "BMILabel";
            this.BMILabel.Size = new System.Drawing.Size(34, 15);
            this.BMILabel.TabIndex = 2;
            this.BMILabel.Text = "BMI";
            // 
            // BMI2abel
            // 
            this.BMI2abel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BMI2abel.Location = new System.Drawing.Point(147, 215);
            this.BMI2abel.Name = "BMI2abel";
            this.BMI2abel.Size = new System.Drawing.Size(100, 23);
            this.BMI2abel.TabIndex = 3;
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.Location = new System.Drawing.Point(147, 150);
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.Size = new System.Drawing.Size(100, 25);
            this.WeightTextBox.TabIndex = 4;
            // 
            // HightTextBox
            // 
            this.HightTextBox.Location = new System.Drawing.Point(147, 90);
            this.HightTextBox.Name = "HightTextBox";
            this.HightTextBox.Size = new System.Drawing.Size(100, 25);
            this.HightTextBox.TabIndex = 5;
            // 
            // ThinRadioButton
            // 
            this.ThinRadioButton.AutoSize = true;
            this.ThinRadioButton.Location = new System.Drawing.Point(34, 66);
            this.ThinRadioButton.Name = "ThinRadioButton";
            this.ThinRadioButton.Size = new System.Drawing.Size(130, 19);
            this.ThinRadioButton.TabIndex = 6;
            this.ThinRadioButton.TabStop = true;
            this.ThinRadioButton.Text = "BMI < 18.5 過輕";
            this.ThinRadioButton.UseVisualStyleBackColor = true;
            // 
            // MiddleRadioButton
            // 
            this.MiddleRadioButton.AutoSize = true;
            this.MiddleRadioButton.Location = new System.Drawing.Point(34, 127);
            this.MiddleRadioButton.Name = "MiddleRadioButton";
            this.MiddleRadioButton.Size = new System.Drawing.Size(160, 19);
            this.MiddleRadioButton.TabIndex = 7;
            this.MiddleRadioButton.TabStop = true;
            this.MiddleRadioButton.Text = " 18.5< BMI < 24 適中";
            this.MiddleRadioButton.UseVisualStyleBackColor = true;
            // 
            // OverweightRadioButton
            // 
            this.OverweightRadioButton.AutoSize = true;
            this.OverweightRadioButton.Location = new System.Drawing.Point(34, 189);
            this.OverweightRadioButton.Name = "OverweightRadioButton";
            this.OverweightRadioButton.Size = new System.Drawing.Size(149, 19);
            this.OverweightRadioButton.TabIndex = 8;
            this.OverweightRadioButton.TabStop = true;
            this.OverweightRadioButton.Text = "24 < BMI < 27 過胖";
            this.OverweightRadioButton.UseVisualStyleBackColor = true;
            // 
            // FatRadioButton
            // 
            this.FatRadioButton.AutoSize = true;
            this.FatRadioButton.Location = new System.Drawing.Point(34, 247);
            this.FatRadioButton.Name = "FatRadioButton";
            this.FatRadioButton.Size = new System.Drawing.Size(119, 19);
            this.FatRadioButton.TabIndex = 9;
            this.FatRadioButton.TabStop = true;
            this.FatRadioButton.Text = "BMI > 27 肥胖";
            this.FatRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FatRadioButton);
            this.groupBox1.Controls.Add(this.OverweightRadioButton);
            this.groupBox1.Controls.Add(this.MiddleRadioButton);
            this.groupBox1.Controls.Add(this.ThinRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(421, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 297);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "體重類別";
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(53, 316);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(97, 23);
            this.CalculateButton.TabIndex = 10;
            this.CalculateButton.Text = "calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.HightTextBox);
            this.Controls.Add(this.WeightTextBox);
            this.Controls.Add(this.BMI2abel);
            this.Controls.Add(this.BMILabel);
            this.Controls.Add(this.WeightLabel);
            this.Controls.Add(this.HightLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HightLabel;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.Label BMILabel;
        private System.Windows.Forms.Label BMI2abel;
        private System.Windows.Forms.TextBox WeightTextBox;
        private System.Windows.Forms.TextBox HightTextBox;
        private System.Windows.Forms.RadioButton ThinRadioButton;
        private System.Windows.Forms.RadioButton MiddleRadioButton;
        private System.Windows.Forms.RadioButton OverweightRadioButton;
        private System.Windows.Forms.RadioButton FatRadioButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button CalculateButton;
    }
}

