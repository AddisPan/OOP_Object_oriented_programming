namespace StudentScoreWindowsFormsApp
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
            this.GradeComboBox = new System.Windows.Forms.ComboBox();
            this.DepartmentComboBox = new System.Windows.Forms.ComboBox();
            this.IDListBox = new System.Windows.Forms.ListBox();
            this.PlusButton = new System.Windows.Forms.Button();
            this.ListButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ChineseTextBox = new System.Windows.Forms.TextBox();
            this.MathTextBox = new System.Windows.Forms.TextBox();
            this.EnglishTextBox = new System.Windows.Forms.TextBox();
            this.PhysicalTextBox = new System.Windows.Forms.TextBox();
            this.HistoryTextBox = new System.Windows.Forms.TextBox();
            this.PETextBox = new System.Windows.Forms.TextBox();
            this.StudentNumberButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(19, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "年級：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(19, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "科系：";
            // 
            // GradeComboBox
            // 
            this.GradeComboBox.FormattingEnabled = true;
            this.GradeComboBox.Location = new System.Drawing.Point(124, 103);
            this.GradeComboBox.Name = "GradeComboBox";
            this.GradeComboBox.Size = new System.Drawing.Size(121, 23);
            this.GradeComboBox.TabIndex = 2;
            // 
            // DepartmentComboBox
            // 
            this.DepartmentComboBox.FormattingEnabled = true;
            this.DepartmentComboBox.Location = new System.Drawing.Point(124, 161);
            this.DepartmentComboBox.Name = "DepartmentComboBox";
            this.DepartmentComboBox.Size = new System.Drawing.Size(121, 23);
            this.DepartmentComboBox.TabIndex = 3;
            // 
            // IDListBox
            // 
            this.IDListBox.FormattingEnabled = true;
            this.IDListBox.ItemHeight = 15;
            this.IDListBox.Location = new System.Drawing.Point(756, 33);
            this.IDListBox.Name = "IDListBox";
            this.IDListBox.Size = new System.Drawing.Size(173, 259);
            this.IDListBox.TabIndex = 4;
            // 
            // PlusButton
            // 
            this.PlusButton.Location = new System.Drawing.Point(90, 286);
            this.PlusButton.Name = "PlusButton";
            this.PlusButton.Size = new System.Drawing.Size(160, 54);
            this.PlusButton.TabIndex = 5;
            this.PlusButton.Text = "增加";
            this.PlusButton.UseVisualStyleBackColor = true;
            this.PlusButton.Click += new System.EventHandler(this.PlusButton_Click);
            // 
            // ListButton
            // 
            this.ListButton.Location = new System.Drawing.Point(756, 357);
            this.ListButton.Name = "ListButton";
            this.ListButton.Size = new System.Drawing.Size(173, 54);
            this.ListButton.TabIndex = 6;
            this.ListButton.Text = "查詢";
            this.ListButton.UseVisualStyleBackColor = true;
            this.ListButton.Click += new System.EventHandler(this.ListButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(50, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 36);
            this.label3.TabIndex = 7;
            this.label3.Text = "數學：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(19, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 36);
            this.label4.TabIndex = 8;
            this.label4.Text = "學號：";
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(124, 51);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(121, 25);
            this.IDTextBox.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.IDTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.DepartmentComboBox);
            this.groupBox1.Controls.Add(this.GradeComboBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(26, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 203);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "學生資料";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(50, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 36);
            this.label5.TabIndex = 11;
            this.label5.Text = "國文：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(50, 341);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 36);
            this.label6.TabIndex = 12;
            this.label6.Text = "體育：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(50, 288);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 36);
            this.label7.TabIndex = 13;
            this.label7.Text = "歷史：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(50, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 36);
            this.label8.TabIndex = 14;
            this.label8.Text = "物理：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(50, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 36);
            this.label9.TabIndex = 15;
            this.label9.Text = "英文：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ChineseTextBox);
            this.groupBox2.Controls.Add(this.MathTextBox);
            this.groupBox2.Controls.Add(this.EnglishTextBox);
            this.groupBox2.Controls.Add(this.PhysicalTextBox);
            this.groupBox2.Controls.Add(this.HistoryTextBox);
            this.groupBox2.Controls.Add(this.PETextBox);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(365, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(361, 404);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "各科成績：";
            // 
            // ChineseTextBox
            // 
            this.ChineseTextBox.Location = new System.Drawing.Point(155, 47);
            this.ChineseTextBox.Name = "ChineseTextBox";
            this.ChineseTextBox.Size = new System.Drawing.Size(121, 25);
            this.ChineseTextBox.TabIndex = 10;
            // 
            // MathTextBox
            // 
            this.MathTextBox.Location = new System.Drawing.Point(155, 111);
            this.MathTextBox.Name = "MathTextBox";
            this.MathTextBox.Size = new System.Drawing.Size(121, 25);
            this.MathTextBox.TabIndex = 11;
            // 
            // EnglishTextBox
            // 
            this.EnglishTextBox.Location = new System.Drawing.Point(155, 175);
            this.EnglishTextBox.Name = "EnglishTextBox";
            this.EnglishTextBox.Size = new System.Drawing.Size(121, 25);
            this.EnglishTextBox.TabIndex = 12;
            // 
            // PhysicalTextBox
            // 
            this.PhysicalTextBox.Location = new System.Drawing.Point(155, 236);
            this.PhysicalTextBox.Name = "PhysicalTextBox";
            this.PhysicalTextBox.Size = new System.Drawing.Size(121, 25);
            this.PhysicalTextBox.TabIndex = 13;
            // 
            // HistoryTextBox
            // 
            this.HistoryTextBox.Location = new System.Drawing.Point(155, 299);
            this.HistoryTextBox.Name = "HistoryTextBox";
            this.HistoryTextBox.Size = new System.Drawing.Size(121, 25);
            this.HistoryTextBox.TabIndex = 14;
            // 
            // PETextBox
            // 
            this.PETextBox.Location = new System.Drawing.Point(155, 351);
            this.PETextBox.Name = "PETextBox";
            this.PETextBox.Size = new System.Drawing.Size(121, 25);
            this.PETextBox.TabIndex = 15;
            // 
            // StudentNumberButton
            // 
            this.StudentNumberButton.Location = new System.Drawing.Point(756, 460);
            this.StudentNumberButton.Name = "StudentNumberButton";
            this.StudentNumberButton.Size = new System.Drawing.Size(173, 59);
            this.StudentNumberButton.TabIndex = 10;
            this.StudentNumberButton.Text = "統計各科學系的人數";
            this.StudentNumberButton.UseVisualStyleBackColor = true;
            this.StudentNumberButton.Click += new System.EventHandler(this.StudentNumberButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(986, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 54);
            this.button1.TabIndex = 17;
            this.button1.Text = "查詢分數";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(972, 33);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(170, 304);
            this.listBox1.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Location = new System.Drawing.Point(471, 460);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(170, 59);
            this.label10.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Location = new System.Drawing.Point(300, 467);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 36);
            this.label11.TabIndex = 20;
            this.label11.Text = "平均成績";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 765);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.StudentNumberButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ListButton);
            this.Controls.Add(this.PlusButton);
            this.Controls.Add(this.IDListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox GradeComboBox;
        private System.Windows.Forms.ComboBox DepartmentComboBox;
        private System.Windows.Forms.ListBox IDListBox;
        private System.Windows.Forms.Button PlusButton;
        private System.Windows.Forms.Button ListButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox ChineseTextBox;
        private System.Windows.Forms.TextBox MathTextBox;
        private System.Windows.Forms.TextBox EnglishTextBox;
        private System.Windows.Forms.TextBox PhysicalTextBox;
        private System.Windows.Forms.TextBox HistoryTextBox;
        private System.Windows.Forms.TextBox PETextBox;
        private System.Windows.Forms.Button StudentNumberButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}

