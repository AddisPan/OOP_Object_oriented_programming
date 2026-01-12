namespace DateWindowsFormsApp1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MonthButton = new System.Windows.Forms.Button();
            this.DateButton = new System.Windows.Forms.Button();
            this.MonthTextBox = new System.Windows.Forms.TextBox();
            this.DateTextBox = new System.Windows.Forms.TextBox();
            this.AddTextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ShowListBox = new System.Windows.Forms.ListBox();
            this.Monthlabel = new System.Windows.Forms.Label();
            this.Daylabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(22, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "目前日期";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(233, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "月";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(377, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "日";
            // 
            // MonthButton
            // 
            this.MonthButton.Location = new System.Drawing.Point(28, 212);
            this.MonthButton.Name = "MonthButton";
            this.MonthButton.Size = new System.Drawing.Size(108, 52);
            this.MonthButton.TabIndex = 3;
            this.MonthButton.Text = "調整月份";
            this.MonthButton.UseVisualStyleBackColor = true;
            this.MonthButton.Click += new System.EventHandler(this.MonthButton_Click);
            // 
            // DateButton
            // 
            this.DateButton.Location = new System.Drawing.Point(28, 320);
            this.DateButton.Name = "DateButton";
            this.DateButton.Size = new System.Drawing.Size(108, 52);
            this.DateButton.TabIndex = 4;
            this.DateButton.Text = "調整日期";
            this.DateButton.UseVisualStyleBackColor = true;
            this.DateButton.Click += new System.EventHandler(this.DateButton_Click);
            // 
            // MonthTextBox
            // 
            this.MonthTextBox.Location = new System.Drawing.Point(213, 228);
            this.MonthTextBox.Name = "MonthTextBox";
            this.MonthTextBox.Size = new System.Drawing.Size(100, 25);
            this.MonthTextBox.TabIndex = 5;
            // 
            // DateTextBox
            // 
            this.DateTextBox.Location = new System.Drawing.Point(213, 336);
            this.DateTextBox.Name = "DateTextBox";
            this.DateTextBox.Size = new System.Drawing.Size(100, 25);
            this.DateTextBox.TabIndex = 6;
            // 
            // AddTextBox
            // 
            this.AddTextBox.Location = new System.Drawing.Point(39, 44);
            this.AddTextBox.Name = "AddTextBox";
            this.AddTextBox.Size = new System.Drawing.Size(100, 25);
            this.AddTextBox.TabIndex = 7;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(31, 110);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(108, 52);
            this.AddButton.TabIndex = 8;
            this.AddButton.Text = "增加日期";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AddButton);
            this.groupBox1.Controls.Add(this.AddTextBox);
            this.groupBox1.Location = new System.Drawing.Point(379, 374);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(187, 177);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "天數增加";
            // 
            // ShowListBox
            // 
            this.ShowListBox.FormattingEnabled = true;
            this.ShowListBox.ItemHeight = 15;
            this.ShowListBox.Location = new System.Drawing.Point(598, 87);
            this.ShowListBox.Name = "ShowListBox";
            this.ShowListBox.Size = new System.Drawing.Size(314, 274);
            this.ShowListBox.TabIndex = 10;
            // 
            // Monthlabel
            // 
            this.Monthlabel.AutoSize = true;
            this.Monthlabel.Location = new System.Drawing.Point(235, 111);
            this.Monthlabel.Name = "Monthlabel";
            this.Monthlabel.Size = new System.Drawing.Size(41, 15);
            this.Monthlabel.TabIndex = 11;
            this.Monthlabel.Text = "label4";
            // 
            // Daylabel
            // 
            this.Daylabel.AutoSize = true;
            this.Daylabel.Location = new System.Drawing.Point(376, 111);
            this.Daylabel.Name = "Daylabel";
            this.Daylabel.Size = new System.Drawing.Size(41, 15);
            this.Daylabel.TabIndex = 12;
            this.Daylabel.Text = "label5";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Daylabel);
            this.groupBox2.Controls.Add(this.Monthlabel);
            this.groupBox2.Controls.Add(this.ShowListBox);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.DateTextBox);
            this.groupBox2.Controls.Add(this.MonthTextBox);
            this.groupBox2.Controls.Add(this.DateButton);
            this.groupBox2.Controls.Add(this.MonthButton);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(30, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(990, 563);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 592);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button MonthButton;
        private System.Windows.Forms.Button DateButton;
        private System.Windows.Forms.TextBox MonthTextBox;
        private System.Windows.Forms.TextBox DateTextBox;
        private System.Windows.Forms.TextBox AddTextBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox ShowListBox;
        private System.Windows.Forms.Label Monthlabel;
        private System.Windows.Forms.Label Daylabel;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

