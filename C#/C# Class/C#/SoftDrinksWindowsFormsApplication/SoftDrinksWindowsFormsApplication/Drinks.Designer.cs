namespace SoftDrinksWindowsFormsApplication
{
    partial class Drinks
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
            this.BlackTeaCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PearlMilkTeaTextBox = new System.Windows.Forms.TextBox();
            this.OrangeJuiceTextBox = new System.Windows.Forms.TextBox();
            this.GreenTeaTextBox = new System.Windows.Forms.TextBox();
            this.BlackTeaTextBox = new System.Windows.Forms.TextBox();
            this.PearlMilkTeaCheckBox = new System.Windows.Forms.CheckBox();
            this.OrangeJuiceCheckBox = new System.Windows.Forms.CheckBox();
            this.GreenTeaCheckBox = new System.Windows.Forms.CheckBox();
            this.MemberRadioButton = new System.Windows.Forms.RadioButton();
            this.VIPRadioButton = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PayTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AmountsPayLabel = new System.Windows.Forms.Label();
            this.ChangesLabel = new System.Windows.Forms.Label();
            this.CheckOutButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BlackTeaCheckBox
            // 
            this.BlackTeaCheckBox.AutoSize = true;
            this.BlackTeaCheckBox.Location = new System.Drawing.Point(17, 48);
            this.BlackTeaCheckBox.Name = "BlackTeaCheckBox";
            this.BlackTeaCheckBox.Size = new System.Drawing.Size(123, 29);
            this.BlackTeaCheckBox.TabIndex = 0;
            this.BlackTeaCheckBox.Text = "25元 紅茶";
            this.BlackTeaCheckBox.UseVisualStyleBackColor = true;
            this.BlackTeaCheckBox.CheckedChanged += new System.EventHandler(this.BlackTeaCheckBox_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.PearlMilkTeaTextBox);
            this.groupBox1.Controls.Add(this.OrangeJuiceTextBox);
            this.groupBox1.Controls.Add(this.GreenTeaTextBox);
            this.groupBox1.Controls.Add(this.BlackTeaTextBox);
            this.groupBox1.Controls.Add(this.PearlMilkTeaCheckBox);
            this.groupBox1.Controls.Add(this.OrangeJuiceCheckBox);
            this.groupBox1.Controls.Add(this.GreenTeaCheckBox);
            this.groupBox1.Controls.Add(this.BlackTeaCheckBox);
            this.groupBox1.Location = new System.Drawing.Point(22, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 266);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "飲料種類";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(237, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "數量";
            // 
            // PearlMilkTeaTextBox
            // 
            this.PearlMilkTeaTextBox.Location = new System.Drawing.Point(211, 185);
            this.PearlMilkTeaTextBox.Name = "PearlMilkTeaTextBox";
            this.PearlMilkTeaTextBox.Size = new System.Drawing.Size(100, 34);
            this.PearlMilkTeaTextBox.TabIndex = 7;
            this.PearlMilkTeaTextBox.Text = "0";
            this.PearlMilkTeaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // OrangeJuiceTextBox
            // 
            this.OrangeJuiceTextBox.Location = new System.Drawing.Point(211, 135);
            this.OrangeJuiceTextBox.Name = "OrangeJuiceTextBox";
            this.OrangeJuiceTextBox.Size = new System.Drawing.Size(100, 34);
            this.OrangeJuiceTextBox.TabIndex = 6;
            this.OrangeJuiceTextBox.Text = "0";
            this.OrangeJuiceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GreenTeaTextBox
            // 
            this.GreenTeaTextBox.Location = new System.Drawing.Point(211, 92);
            this.GreenTeaTextBox.Name = "GreenTeaTextBox";
            this.GreenTeaTextBox.Size = new System.Drawing.Size(100, 34);
            this.GreenTeaTextBox.TabIndex = 5;
            this.GreenTeaTextBox.Text = "0";
            this.GreenTeaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BlackTeaTextBox
            // 
            this.BlackTeaTextBox.Location = new System.Drawing.Point(211, 46);
            this.BlackTeaTextBox.Name = "BlackTeaTextBox";
            this.BlackTeaTextBox.Size = new System.Drawing.Size(100, 34);
            this.BlackTeaTextBox.TabIndex = 4;
            this.BlackTeaTextBox.Text = "0";
            this.BlackTeaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BlackTeaTextBox.TextChanged += new System.EventHandler(this.BlackTeaTextBox_TextChanged_1);
            // 
            // PearlMilkTeaCheckBox
            // 
            this.PearlMilkTeaCheckBox.AutoSize = true;
            this.PearlMilkTeaCheckBox.Location = new System.Drawing.Point(17, 189);
            this.PearlMilkTeaCheckBox.Name = "PearlMilkTeaCheckBox";
            this.PearlMilkTeaCheckBox.Size = new System.Drawing.Size(163, 29);
            this.PearlMilkTeaCheckBox.TabIndex = 3;
            this.PearlMilkTeaCheckBox.Text = "45元 珍珠奶茶";
            this.PearlMilkTeaCheckBox.UseVisualStyleBackColor = true;
            this.PearlMilkTeaCheckBox.CheckedChanged += new System.EventHandler(this.PearlMilkTeaCheckBox_CheckedChanged);
            // 
            // OrangeJuiceCheckBox
            // 
            this.OrangeJuiceCheckBox.AutoSize = true;
            this.OrangeJuiceCheckBox.Location = new System.Drawing.Point(17, 137);
            this.OrangeJuiceCheckBox.Name = "OrangeJuiceCheckBox";
            this.OrangeJuiceCheckBox.Size = new System.Drawing.Size(143, 29);
            this.OrangeJuiceCheckBox.TabIndex = 2;
            this.OrangeJuiceCheckBox.Text = "30元 柳橙汁";
            this.OrangeJuiceCheckBox.UseVisualStyleBackColor = true;
            this.OrangeJuiceCheckBox.CheckedChanged += new System.EventHandler(this.OrangeJuiceCheckBox_CheckedChanged);
            // 
            // GreenTeaCheckBox
            // 
            this.GreenTeaCheckBox.AutoSize = true;
            this.GreenTeaCheckBox.Location = new System.Drawing.Point(17, 94);
            this.GreenTeaCheckBox.Name = "GreenTeaCheckBox";
            this.GreenTeaCheckBox.Size = new System.Drawing.Size(123, 29);
            this.GreenTeaCheckBox.TabIndex = 1;
            this.GreenTeaCheckBox.Text = "25元 綠茶";
            this.GreenTeaCheckBox.UseVisualStyleBackColor = true;
            this.GreenTeaCheckBox.CheckedChanged += new System.EventHandler(this.GreenTeaCheckBox_CheckedChanged);
            // 
            // MemberRadioButton
            // 
            this.MemberRadioButton.AutoSize = true;
            this.MemberRadioButton.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MemberRadioButton.Location = new System.Drawing.Point(19, 28);
            this.MemberRadioButton.Name = "MemberRadioButton";
            this.MemberRadioButton.Size = new System.Drawing.Size(210, 39);
            this.MemberRadioButton.TabIndex = 9;
            this.MemberRadioButton.TabStop = true;
            this.MemberRadioButton.Text = "普通會員 95折";
            this.MemberRadioButton.UseVisualStyleBackColor = true;
            // 
            // VIPRadioButton
            // 
            this.VIPRadioButton.AutoSize = true;
            this.VIPRadioButton.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.VIPRadioButton.Location = new System.Drawing.Point(19, 78);
            this.VIPRadioButton.Name = "VIPRadioButton";
            this.VIPRadioButton.Size = new System.Drawing.Size(200, 39);
            this.VIPRadioButton.TabIndex = 10;
            this.VIPRadioButton.TabStop = true;
            this.VIPRadioButton.Text = "VIP會員 75折";
            this.VIPRadioButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.MemberRadioButton);
            this.panel1.Controls.Add(this.VIPRadioButton);
            this.panel1.Location = new System.Drawing.Point(12, 376);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 154);
            this.panel1.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 438);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "應付金額";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(245, 486);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "應找金額";
            // 
            // PayTextBox
            // 
            this.PayTextBox.Location = new System.Drawing.Point(359, 376);
            this.PayTextBox.Name = "PayTextBox";
            this.PayTextBox.Size = new System.Drawing.Size(100, 34);
            this.PayTextBox.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(245, 379);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "付款金額";
            // 
            // AmountsPayLabel
            // 
            this.AmountsPayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AmountsPayLabel.Location = new System.Drawing.Point(359, 437);
            this.AmountsPayLabel.Name = "AmountsPayLabel";
            this.AmountsPayLabel.Size = new System.Drawing.Size(99, 30);
            this.AmountsPayLabel.TabIndex = 17;
            // 
            // ChangesLabel
            // 
            this.ChangesLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ChangesLabel.Location = new System.Drawing.Point(359, 481);
            this.ChangesLabel.Name = "ChangesLabel";
            this.ChangesLabel.Size = new System.Drawing.Size(99, 30);
            this.ChangesLabel.TabIndex = 18;
            // 
            // CheckOutButton
            // 
            this.CheckOutButton.Location = new System.Drawing.Point(297, 541);
            this.CheckOutButton.Name = "CheckOutButton";
            this.CheckOutButton.Size = new System.Drawing.Size(101, 37);
            this.CheckOutButton.TabIndex = 19;
            this.CheckOutButton.Text = "結帳";
            this.CheckOutButton.UseVisualStyleBackColor = true;
            this.CheckOutButton.Click += new System.EventHandler(this.CheckOutButton_Click);
            // 
            // Drinks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 590);
            this.Controls.Add(this.CheckOutButton);
            this.Controls.Add(this.ChangesLabel);
            this.Controls.Add(this.AmountsPayLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PayTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Drinks";
            this.Text = "Addis 飲料店";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox BlackTeaCheckBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox PearlMilkTeaCheckBox;
        private System.Windows.Forms.CheckBox OrangeJuiceCheckBox;
        private System.Windows.Forms.CheckBox GreenTeaCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PearlMilkTeaTextBox;
        private System.Windows.Forms.TextBox OrangeJuiceTextBox;
        private System.Windows.Forms.TextBox GreenTeaTextBox;
        private System.Windows.Forms.TextBox BlackTeaTextBox;
        private System.Windows.Forms.RadioButton MemberRadioButton;
        private System.Windows.Forms.RadioButton VIPRadioButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PayTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label AmountsPayLabel;
        private System.Windows.Forms.Label ChangesLabel;
        private System.Windows.Forms.Button CheckOutButton;
    }
}

