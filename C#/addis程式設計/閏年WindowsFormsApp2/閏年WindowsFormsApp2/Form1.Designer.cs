namespace 閏年WindowsFormsApp2
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
            this.EndButton = new System.Windows.Forms.Button();
            this.JudgeButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(137, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "請輸入年分:";
            // 
            // YearTextBox
            // 
            this.YearTextBox.Location = new System.Drawing.Point(411, 116);
            this.YearTextBox.Name = "YearTextBox";
            this.YearTextBox.Size = new System.Drawing.Size(138, 25);
            this.YearTextBox.TabIndex = 1;
            this.YearTextBox.TextChanged += new System.EventHandler(this.YearTextBox_TextChanged);
            // 
            // EndButton
            // 
            this.EndButton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.EndButton.Location = new System.Drawing.Point(527, 234);
            this.EndButton.Name = "EndButton";
            this.EndButton.Size = new System.Drawing.Size(90, 33);
            this.EndButton.TabIndex = 2;
            this.EndButton.Text = "結束";
            this.EndButton.UseVisualStyleBackColor = true;
            this.EndButton.Click += new System.EventHandler(this.EndButton_Click);
            // 
            // JudgeButton
            // 
            this.JudgeButton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.JudgeButton.Location = new System.Drawing.Point(170, 234);
            this.JudgeButton.Name = "JudgeButton";
            this.JudgeButton.Size = new System.Drawing.Size(88, 33);
            this.JudgeButton.TabIndex = 3;
            this.JudgeButton.Text = "判斷";
            this.JudgeButton.UseVisualStyleBackColor = true;
            this.JudgeButton.Click += new System.EventHandler(this.JudgeButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ClearButton.Location = new System.Drawing.Point(350, 234);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(85, 33);
            this.ClearButton.TabIndex = 4;
            this.ClearButton.Text = "清除";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.JudgeButton);
            this.Controls.Add(this.EndButton);
            this.Controls.Add(this.YearTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "判斷閏年為否";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox YearTextBox;
        private System.Windows.Forms.Button EndButton;
        private System.Windows.Forms.Button JudgeButton;
        private System.Windows.Forms.Button ClearButton;
    }
}

