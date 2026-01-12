namespace BMIWindowsFormsApplication1
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
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
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
            this.label2 = new System.Windows.Forms.Label();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.WeightTextBox = new System.Windows.Forms.TextBox();
            this.TooThinRadioButton = new System.Windows.Forms.RadioButton();
            this.NormalRadioButton = new System.Windows.Forms.RadioButton();
            this.OverWeightRadioButton = new System.Windows.Forms.RadioButton();
            this.MildobesiteRadioButton = new System.Windows.Forms.RadioButton();
            this.ModerateobesityradioButton = new System.Windows.Forms.RadioButton();
            this.ExtreneobesityradioButton = new System.Windows.Forms.RadioButton();
            this.BMIGroupBox = new System.Windows.Forms.GroupBox();
            this.CaculateButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.EndButton = new System.Windows.Forms.Button();
            this.BMIGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(34, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "身高(公尺):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(34, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "體重(公斤):";
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.Location = new System.Drawing.Point(208, 63);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(100, 22);
            this.HeightTextBox.TabIndex = 0;
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.Location = new System.Drawing.Point(208, 144);
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.Size = new System.Drawing.Size(100, 22);
            this.WeightTextBox.TabIndex = 1;
            // 
            // TooThinRadioButton
            // 
            this.TooThinRadioButton.AutoSize = true;
            this.TooThinRadioButton.Location = new System.Drawing.Point(42, 32);
            this.TooThinRadioButton.Name = "TooThinRadioButton";
            this.TooThinRadioButton.Size = new System.Drawing.Size(184, 28);
            this.TooThinRadioButton.TabIndex = 4;
            this.TooThinRadioButton.TabStop = true;
            this.TooThinRadioButton.Text = "BMI =< 18.5 過輕";
            this.TooThinRadioButton.UseVisualStyleBackColor = true;
            // 
            // NormalRadioButton
            // 
            this.NormalRadioButton.AutoSize = true;
            this.NormalRadioButton.Location = new System.Drawing.Point(42, 77);
            this.NormalRadioButton.Name = "NormalRadioButton";
            this.NormalRadioButton.Size = new System.Drawing.Size(216, 28);
            this.NormalRadioButton.TabIndex = 5;
            this.NormalRadioButton.TabStop = true;
            this.NormalRadioButton.Text = "18.5 < BMI < 24 適中";
            this.NormalRadioButton.UseVisualStyleBackColor = true;
            // 
            // OverWeightRadioButton
            // 
            this.OverWeightRadioButton.AutoSize = true;
            this.OverWeightRadioButton.Location = new System.Drawing.Point(42, 127);
            this.OverWeightRadioButton.Name = "OverWeightRadioButton";
            this.OverWeightRadioButton.Size = new System.Drawing.Size(200, 28);
            this.OverWeightRadioButton.TabIndex = 6;
            this.OverWeightRadioButton.TabStop = true;
            this.OverWeightRadioButton.Text = "24 < BMI < 27 過重";
            this.OverWeightRadioButton.UseVisualStyleBackColor = true;
            // 
            // MildobesiteRadioButton
            // 
            this.MildobesiteRadioButton.AutoSize = true;
            this.MildobesiteRadioButton.Location = new System.Drawing.Point(42, 177);
            this.MildobesiteRadioButton.Name = "MildobesiteRadioButton";
            this.MildobesiteRadioButton.Size = new System.Drawing.Size(238, 28);
            this.MildobesiteRadioButton.TabIndex = 7;
            this.MildobesiteRadioButton.TabStop = true;
            this.MildobesiteRadioButton.Text = "27 < BMI < 30 輕度肥胖";
            this.MildobesiteRadioButton.UseVisualStyleBackColor = true;
            // 
            // ModerateobesityradioButton
            // 
            this.ModerateobesityradioButton.AutoSize = true;
            this.ModerateobesityradioButton.Location = new System.Drawing.Point(42, 228);
            this.ModerateobesityradioButton.Name = "ModerateobesityradioButton";
            this.ModerateobesityradioButton.Size = new System.Drawing.Size(238, 28);
            this.ModerateobesityradioButton.TabIndex = 8;
            this.ModerateobesityradioButton.TabStop = true;
            this.ModerateobesityradioButton.Text = "30 < BMI < 35 中度肥胖";
            this.ModerateobesityradioButton.UseVisualStyleBackColor = true;
            // 
            // ExtreneobesityradioButton
            // 
            this.ExtreneobesityradioButton.AutoSize = true;
            this.ExtreneobesityradioButton.Location = new System.Drawing.Point(42, 281);
            this.ExtreneobesityradioButton.Name = "ExtreneobesityradioButton";
            this.ExtreneobesityradioButton.Size = new System.Drawing.Size(206, 28);
            this.ExtreneobesityradioButton.TabIndex = 9;
            this.ExtreneobesityradioButton.TabStop = true;
            this.ExtreneobesityradioButton.Text = "BMI >= 35 重度肥胖";
            this.ExtreneobesityradioButton.UseVisualStyleBackColor = true;
            // 
            // BMIGroupBox
            // 
            this.BMIGroupBox.Controls.Add(this.ExtreneobesityradioButton);
            this.BMIGroupBox.Controls.Add(this.ModerateobesityradioButton);
            this.BMIGroupBox.Controls.Add(this.MildobesiteRadioButton);
            this.BMIGroupBox.Controls.Add(this.OverWeightRadioButton);
            this.BMIGroupBox.Controls.Add(this.NormalRadioButton);
            this.BMIGroupBox.Controls.Add(this.TooThinRadioButton);
            this.BMIGroupBox.Enabled = false;
            this.BMIGroupBox.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BMIGroupBox.Location = new System.Drawing.Point(408, 42);
            this.BMIGroupBox.Name = "BMIGroupBox";
            this.BMIGroupBox.Size = new System.Drawing.Size(285, 329);
            this.BMIGroupBox.TabIndex = 10;
            this.BMIGroupBox.TabStop = false;
            this.BMIGroupBox.Text = "BMI判定";
            // 
            // CaculateButton
            // 
            this.CaculateButton.Location = new System.Drawing.Point(39, 288);
            this.CaculateButton.Name = "CaculateButton";
            this.CaculateButton.Size = new System.Drawing.Size(95, 41);
            this.CaculateButton.TabIndex = 2;
            this.CaculateButton.Text = "計算BMI";
            this.CaculateButton.UseVisualStyleBackColor = true;
            this.CaculateButton.Click += new System.EventHandler(this.CaculateButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(165, 288);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(89, 41);
            this.ClearButton.TabIndex = 3;
            this.ClearButton.Text = "CLEAR";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // EndButton
            // 
            this.EndButton.Location = new System.Drawing.Point(286, 288);
            this.EndButton.Name = "EndButton";
            this.EndButton.Size = new System.Drawing.Size(89, 41);
            this.EndButton.TabIndex = 13;
            this.EndButton.Text = "END";
            this.EndButton.UseVisualStyleBackColor = true;
            this.EndButton.Click += new System.EventHandler(this.EndButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.CaculateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.EndButton;
            this.ClientSize = new System.Drawing.Size(750, 440);
            this.Controls.Add(this.EndButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.CaculateButton);
            this.Controls.Add(this.BMIGroupBox);
            this.Controls.Add(this.WeightTextBox);
            this.Controls.Add(this.HeightTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "計算BMI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.BMIGroupBox.ResumeLayout(false);
            this.BMIGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox HeightTextBox;
        private System.Windows.Forms.TextBox WeightTextBox;
        private System.Windows.Forms.RadioButton TooThinRadioButton;
        private System.Windows.Forms.RadioButton NormalRadioButton;
        private System.Windows.Forms.RadioButton OverWeightRadioButton;
        private System.Windows.Forms.RadioButton MildobesiteRadioButton;
        private System.Windows.Forms.RadioButton ModerateobesityradioButton;
        private System.Windows.Forms.RadioButton ExtreneobesityradioButton;
        private System.Windows.Forms.GroupBox BMIGroupBox;
        private System.Windows.Forms.Button CaculateButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button EndButton;
    }
}

