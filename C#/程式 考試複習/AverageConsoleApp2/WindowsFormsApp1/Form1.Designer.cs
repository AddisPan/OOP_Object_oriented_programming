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
            this.SandwitchCheckBox = new System.Windows.Forms.CheckBox();
            this.CheeseHotDogCheckBox = new System.Windows.Forms.CheckBox();
            this.SandwitchTextBox = new System.Windows.Forms.TextBox();
            this.CheeseHotdogTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MumberRadioButton = new System.Windows.Forms.RadioButton();
            this.VIPRadioButton = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PayLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PayTextBox = new System.Windows.Forms.TextBox();
            this.AmountsPayLabel = new System.Windows.Forms.Label();
            this.HundredChangesLabel = new System.Windows.Forms.Label();
            this.CheckOutButton = new System.Windows.Forms.Button();
            this.TenChangesLabel = new System.Windows.Forms.Label();
            this.OneChangesLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SandwitchCheckBox
            // 
            this.SandwitchCheckBox.AutoSize = true;
            this.SandwitchCheckBox.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.SandwitchCheckBox.Location = new System.Drawing.Point(28, 37);
            this.SandwitchCheckBox.Name = "SandwitchCheckBox";
            this.SandwitchCheckBox.Size = new System.Drawing.Size(166, 35);
            this.SandwitchCheckBox.TabIndex = 0;
            this.SandwitchCheckBox.Text = "60元 三明治";
            this.SandwitchCheckBox.UseVisualStyleBackColor = true;
            this.SandwitchCheckBox.CheckedChanged += new System.EventHandler(this.SandwitchCheckBox_CheckedChanged);
            // 
            // CheeseHotDogCheckBox
            // 
            this.CheeseHotDogCheckBox.AutoSize = true;
            this.CheeseHotDogCheckBox.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CheeseHotDogCheckBox.Location = new System.Drawing.Point(28, 108);
            this.CheeseHotDogCheckBox.Name = "CheeseHotDogCheckBox";
            this.CheeseHotDogCheckBox.Size = new System.Drawing.Size(190, 35);
            this.CheeseHotDogCheckBox.TabIndex = 1;
            this.CheeseHotDogCheckBox.Text = "35元 起司熱狗";
            this.CheeseHotDogCheckBox.UseVisualStyleBackColor = true;
            this.CheeseHotDogCheckBox.CheckedChanged += new System.EventHandler(this.CheeseHotDogCheckBox_CheckedChanged);
            // 
            // SandwitchTextBox
            // 
            this.SandwitchTextBox.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.SandwitchTextBox.Location = new System.Drawing.Point(273, 37);
            this.SandwitchTextBox.Name = "SandwitchTextBox";
            this.SandwitchTextBox.Size = new System.Drawing.Size(100, 38);
            this.SandwitchTextBox.TabIndex = 2;
            this.SandwitchTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SandwitchTextBox.TextChanged += new System.EventHandler(this.SandwitchTextBox_TextChanged);
            // 
            // CheeseHotdogTextBox
            // 
            this.CheeseHotdogTextBox.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CheeseHotdogTextBox.Location = new System.Drawing.Point(273, 105);
            this.CheeseHotdogTextBox.Name = "CheeseHotdogTextBox";
            this.CheeseHotdogTextBox.Size = new System.Drawing.Size(100, 38);
            this.CheeseHotdogTextBox.TabIndex = 3;
            this.CheeseHotdogTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CheeseHotdogTextBox);
            this.groupBox1.Controls.Add(this.SandwitchTextBox);
            this.groupBox1.Controls.Add(this.CheeseHotDogCheckBox);
            this.groupBox1.Controls.Add(this.SandwitchCheckBox);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(12, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(435, 176);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(297, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "數量";
            // 
            // MumberRadioButton
            // 
            this.MumberRadioButton.AutoSize = true;
            this.MumberRadioButton.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MumberRadioButton.Location = new System.Drawing.Point(19, 21);
            this.MumberRadioButton.Name = "MumberRadioButton";
            this.MumberRadioButton.Size = new System.Drawing.Size(175, 35);
            this.MumberRadioButton.TabIndex = 5;
            this.MumberRadioButton.TabStop = true;
            this.MumberRadioButton.Text = "普通會員 9折";
            this.MumberRadioButton.UseVisualStyleBackColor = true;
            // 
            // VIPRadioButton
            // 
            this.VIPRadioButton.AutoSize = true;
            this.VIPRadioButton.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.VIPRadioButton.Location = new System.Drawing.Point(19, 89);
            this.VIPRadioButton.Name = "VIPRadioButton";
            this.VIPRadioButton.Size = new System.Drawing.Size(166, 35);
            this.VIPRadioButton.TabIndex = 6;
            this.VIPRadioButton.TabStop = true;
            this.VIPRadioButton.Text = "VIP會員 7折";
            this.VIPRadioButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.VIPRadioButton);
            this.panel1.Controls.Add(this.MumberRadioButton);
            this.panel1.Location = new System.Drawing.Point(21, 282);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 158);
            this.panel1.TabIndex = 7;
            // 
            // PayLabel
            // 
            this.PayLabel.AutoSize = true;
            this.PayLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.PayLabel.Location = new System.Drawing.Point(514, 80);
            this.PayLabel.Name = "PayLabel";
            this.PayLabel.Size = new System.Drawing.Size(92, 25);
            this.PayLabel.TabIndex = 8;
            this.PayLabel.Text = "付款金額";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(514, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "應付金額";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(514, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "應找金額";
            // 
            // PayTextBox
            // 
            this.PayTextBox.Location = new System.Drawing.Point(658, 75);
            this.PayTextBox.Name = "PayTextBox";
            this.PayTextBox.Size = new System.Drawing.Size(100, 25);
            this.PayTextBox.TabIndex = 11;
            // 
            // AmountsPayLabel
            // 
            this.AmountsPayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AmountsPayLabel.Location = new System.Drawing.Point(658, 153);
            this.AmountsPayLabel.Name = "AmountsPayLabel";
            this.AmountsPayLabel.Size = new System.Drawing.Size(100, 23);
            this.AmountsPayLabel.TabIndex = 12;
            // 
            // HundredChangesLabel
            // 
            this.HundredChangesLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HundredChangesLabel.Location = new System.Drawing.Point(750, 229);
            this.HundredChangesLabel.Name = "HundredChangesLabel";
            this.HundredChangesLabel.Size = new System.Drawing.Size(100, 23);
            this.HundredChangesLabel.TabIndex = 13;
            // 
            // CheckOutButton
            // 
            this.CheckOutButton.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CheckOutButton.Location = new System.Drawing.Point(536, 421);
            this.CheckOutButton.Name = "CheckOutButton";
            this.CheckOutButton.Size = new System.Drawing.Size(114, 41);
            this.CheckOutButton.TabIndex = 14;
            this.CheckOutButton.Text = "結帳";
            this.CheckOutButton.UseVisualStyleBackColor = true;
            this.CheckOutButton.Click += new System.EventHandler(this.CheckOutButton_Click);
            // 
            // TenChangesLabel
            // 
            this.TenChangesLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TenChangesLabel.Location = new System.Drawing.Point(750, 282);
            this.TenChangesLabel.Name = "TenChangesLabel";
            this.TenChangesLabel.Size = new System.Drawing.Size(100, 23);
            this.TenChangesLabel.TabIndex = 15;
            // 
            // OneChangesLabel
            // 
            this.OneChangesLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.OneChangesLabel.Location = new System.Drawing.Point(750, 339);
            this.OneChangesLabel.Name = "OneChangesLabel";
            this.OneChangesLabel.Size = new System.Drawing.Size(100, 23);
            this.OneChangesLabel.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(659, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "百元";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(659, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "十元";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(659, 347);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 19;
            this.label6.Text = "一元";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 508);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OneChangesLabel);
            this.Controls.Add(this.TenChangesLabel);
            this.Controls.Add(this.CheckOutButton);
            this.Controls.Add(this.HundredChangesLabel);
            this.Controls.Add(this.AmountsPayLabel);
            this.Controls.Add(this.PayTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PayLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox SandwitchCheckBox;
        private System.Windows.Forms.CheckBox CheeseHotDogCheckBox;
        private System.Windows.Forms.TextBox SandwitchTextBox;
        private System.Windows.Forms.TextBox CheeseHotdogTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton MumberRadioButton;
        private System.Windows.Forms.RadioButton VIPRadioButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label PayLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PayTextBox;
        private System.Windows.Forms.Label AmountsPayLabel;
        private System.Windows.Forms.Label HundredChangesLabel;
        private System.Windows.Forms.Button CheckOutButton;
        private System.Windows.Forms.Label TenChangesLabel;
        private System.Windows.Forms.Label OneChangesLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

