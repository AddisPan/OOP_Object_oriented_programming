namespace 三角形WindowsFormsApp2
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
            this.Number1Label = new System.Windows.Forms.Label();
            this.Number2Label = new System.Windows.Forms.Label();
            this.Number3Label = new System.Windows.Forms.Label();
            this.Number1TextBox = new System.Windows.Forms.TextBox();
            this.Number2TextBox = new System.Windows.Forms.TextBox();
            this.Number3TextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.JudgeButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.EndButton = new System.Windows.Forms.Button();
            this.RighttriangleradioButton1 = new System.Windows.Forms.RadioButton();
            this.ObtusetriangleradioButton3 = new System.Windows.Forms.RadioButton();
            this.AcutetriangleradioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Number1Label
            // 
            this.Number1Label.AutoSize = true;
            this.Number1Label.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Number1Label.Location = new System.Drawing.Point(14, 76);
            this.Number1Label.Name = "Number1Label";
            this.Number1Label.Size = new System.Drawing.Size(103, 38);
            this.Number1Label.TabIndex = 0;
            this.Number1Label.Text = "數字1:";
            // 
            // Number2Label
            // 
            this.Number2Label.AutoSize = true;
            this.Number2Label.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Number2Label.Location = new System.Drawing.Point(14, 156);
            this.Number2Label.Name = "Number2Label";
            this.Number2Label.Size = new System.Drawing.Size(103, 38);
            this.Number2Label.TabIndex = 1;
            this.Number2Label.Text = "數字2:";
            // 
            // Number3Label
            // 
            this.Number3Label.AutoSize = true;
            this.Number3Label.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Number3Label.Location = new System.Drawing.Point(14, 247);
            this.Number3Label.Name = "Number3Label";
            this.Number3Label.Size = new System.Drawing.Size(103, 38);
            this.Number3Label.TabIndex = 2;
            this.Number3Label.Text = "數字3:";
            // 
            // Number1TextBox
            // 
            this.Number1TextBox.Location = new System.Drawing.Point(150, 71);
            this.Number1TextBox.Name = "Number1TextBox";
            this.Number1TextBox.Size = new System.Drawing.Size(100, 43);
            this.Number1TextBox.TabIndex = 3;
            // 
            // Number2TextBox
            // 
            this.Number2TextBox.Location = new System.Drawing.Point(150, 151);
            this.Number2TextBox.Name = "Number2TextBox";
            this.Number2TextBox.Size = new System.Drawing.Size(100, 43);
            this.Number2TextBox.TabIndex = 4;
            // 
            // Number3TextBox
            // 
            this.Number3TextBox.Location = new System.Drawing.Point(150, 242);
            this.Number3TextBox.Name = "Number3TextBox";
            this.Number3TextBox.Size = new System.Drawing.Size(100, 43);
            this.Number3TextBox.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Number3TextBox);
            this.groupBox1.Controls.Add(this.Number2TextBox);
            this.groupBox1.Controls.Add(this.Number1TextBox);
            this.groupBox1.Controls.Add(this.Number3Label);
            this.groupBox1.Controls.Add(this.Number2Label);
            this.groupBox1.Controls.Add(this.Number1Label);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(560, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 321);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "三角形邊長";
            // 
            // JudgeButton
            // 
            this.JudgeButton.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.JudgeButton.Location = new System.Drawing.Point(560, 444);
            this.JudgeButton.Name = "JudgeButton";
            this.JudgeButton.Size = new System.Drawing.Size(96, 43);
            this.JudgeButton.TabIndex = 6;
            this.JudgeButton.Text = "判斷";
            this.JudgeButton.UseVisualStyleBackColor = true;
            this.JudgeButton.Click += new System.EventHandler(this.JudgeButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ClearButton.Location = new System.Drawing.Point(693, 444);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(96, 43);
            this.ClearButton.TabIndex = 7;
            this.ClearButton.Text = "清除";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // EndButton
            // 
            this.EndButton.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.EndButton.Location = new System.Drawing.Point(828, 444);
            this.EndButton.Name = "EndButton";
            this.EndButton.Size = new System.Drawing.Size(96, 43);
            this.EndButton.TabIndex = 8;
            this.EndButton.Text = "結束";
            this.EndButton.UseVisualStyleBackColor = true;
            // 
            // RighttriangleradioButton1
            // 
            this.RighttriangleradioButton1.AutoSize = true;
            this.RighttriangleradioButton1.Font = new System.Drawing.Font("新細明體", 14F);
            this.RighttriangleradioButton1.Location = new System.Drawing.Point(37, 34);
            this.RighttriangleradioButton1.Name = "RighttriangleradioButton1";
            this.RighttriangleradioButton1.Size = new System.Drawing.Size(151, 28);
            this.RighttriangleradioButton1.TabIndex = 9;
            this.RighttriangleradioButton1.TabStop = true;
            this.RighttriangleradioButton1.Text = "直角三角形";
            this.RighttriangleradioButton1.UseVisualStyleBackColor = true;
            // 
            // ObtusetriangleradioButton3
            // 
            this.ObtusetriangleradioButton3.AutoSize = true;
            this.ObtusetriangleradioButton3.Font = new System.Drawing.Font("新細明體", 14F);
            this.ObtusetriangleradioButton3.Location = new System.Drawing.Point(37, 228);
            this.ObtusetriangleradioButton3.Name = "ObtusetriangleradioButton3";
            this.ObtusetriangleradioButton3.Size = new System.Drawing.Size(151, 28);
            this.ObtusetriangleradioButton3.TabIndex = 10;
            this.ObtusetriangleradioButton3.TabStop = true;
            this.ObtusetriangleradioButton3.Text = "鈍角三角形";
            this.ObtusetriangleradioButton3.UseVisualStyleBackColor = true;
            // 
            // AcutetriangleradioButton2
            // 
            this.AcutetriangleradioButton2.AutoSize = true;
            this.AcutetriangleradioButton2.Font = new System.Drawing.Font("新細明體", 14F);
            this.AcutetriangleradioButton2.Location = new System.Drawing.Point(37, 125);
            this.AcutetriangleradioButton2.Name = "AcutetriangleradioButton2";
            this.AcutetriangleradioButton2.Size = new System.Drawing.Size(151, 28);
            this.AcutetriangleradioButton2.TabIndex = 11;
            this.AcutetriangleradioButton2.TabStop = true;
            this.AcutetriangleradioButton2.Text = "銳角三角形";
            this.AcutetriangleradioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ObtusetriangleradioButton3);
            this.groupBox2.Controls.Add(this.AcutetriangleradioButton2);
            this.groupBox2.Controls.Add(this.RighttriangleradioButton1);
            this.groupBox2.Location = new System.Drawing.Point(102, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(240, 288);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 510);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.EndButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.JudgeButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Number1Label;
        private System.Windows.Forms.Label Number2Label;
        private System.Windows.Forms.Label Number3Label;
        private System.Windows.Forms.TextBox Number1TextBox;
        private System.Windows.Forms.TextBox Number2TextBox;
        private System.Windows.Forms.TextBox Number3TextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button JudgeButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button EndButton;
        private System.Windows.Forms.RadioButton RighttriangleradioButton1;
        private System.Windows.Forms.RadioButton ObtusetriangleradioButton3;
        private System.Windows.Forms.RadioButton AcutetriangleradioButton2;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

