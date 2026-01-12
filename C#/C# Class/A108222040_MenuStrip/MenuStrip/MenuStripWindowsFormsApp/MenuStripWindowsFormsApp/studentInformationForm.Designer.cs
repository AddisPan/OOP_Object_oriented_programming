namespace MenuStripWindowsFormsApp
{
    partial class studentInformationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CollegecomboBox1 = new System.Windows.Forms.ComboBox();
            this.DepartmentcomboBox1 = new System.Windows.Forms.ComboBox();
            this.SecondLanguagecomboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PlusButton = new System.Windows.Forms.Button();
            this.StudentDatalistBox = new System.Windows.Forms.ListBox();
            this.Listbutton = new System.Windows.Forms.Button();
            this.Countbutton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(171, 140);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "學號:";
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(317, 132);
            this.IDTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(132, 47);
            this.IDTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(171, 234);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 35);
            this.label2.TabIndex = 2;
            this.label2.Text = "學院:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(171, 314);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 35);
            this.label3.TabIndex = 3;
            this.label3.Text = "科系:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(59, 394);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 35);
            this.label4.TabIndex = 4;
            this.label4.Text = "二門外國語言:";
            // 
            // CollegecomboBox1
            // 
            this.CollegecomboBox1.FormattingEnabled = true;
            this.CollegecomboBox1.Location = new System.Drawing.Point(317, 226);
            this.CollegecomboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CollegecomboBox1.Name = "CollegecomboBox1";
            this.CollegecomboBox1.Size = new System.Drawing.Size(160, 46);
            this.CollegecomboBox1.TabIndex = 5;
            this.CollegecomboBox1.SelectedIndexChanged += new System.EventHandler(this.CollegecomboBox1_SelectedIndexChanged);
            // 
            // DepartmentcomboBox1
            // 
            this.DepartmentcomboBox1.FormattingEnabled = true;
            this.DepartmentcomboBox1.Location = new System.Drawing.Point(317, 306);
            this.DepartmentcomboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DepartmentcomboBox1.Name = "DepartmentcomboBox1";
            this.DepartmentcomboBox1.Size = new System.Drawing.Size(160, 46);
            this.DepartmentcomboBox1.TabIndex = 6;
            // 
            // SecondLanguagecomboBox1
            // 
            this.SecondLanguagecomboBox1.FormattingEnabled = true;
            this.SecondLanguagecomboBox1.Location = new System.Drawing.Point(317, 386);
            this.SecondLanguagecomboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SecondLanguagecomboBox1.Name = "SecondLanguagecomboBox1";
            this.SecondLanguagecomboBox1.Size = new System.Drawing.Size(160, 46);
            this.SecondLanguagecomboBox1.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SecondLanguagecomboBox1);
            this.groupBox1.Controls.Add(this.DepartmentcomboBox1);
            this.groupBox1.Controls.Add(this.CollegecomboBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.IDTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(32, 38);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(581, 478);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "學生資料:";
            // 
            // PlusButton
            // 
            this.PlusButton.Location = new System.Drawing.Point(221, 575);
            this.PlusButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PlusButton.Name = "PlusButton";
            this.PlusButton.Size = new System.Drawing.Size(193, 61);
            this.PlusButton.TabIndex = 9;
            this.PlusButton.Text = "新增";
            this.PlusButton.UseVisualStyleBackColor = true;
            this.PlusButton.Click += new System.EventHandler(this.PlusButton_Click);
            // 
            // StudentDatalistBox
            // 
            this.StudentDatalistBox.FormattingEnabled = true;
            this.StudentDatalistBox.ItemHeight = 15;
            this.StudentDatalistBox.Location = new System.Drawing.Point(651, 75);
            this.StudentDatalistBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StudentDatalistBox.Name = "StudentDatalistBox";
            this.StudentDatalistBox.Size = new System.Drawing.Size(351, 439);
            this.StudentDatalistBox.TabIndex = 10;
            // 
            // Listbutton
            // 
            this.Listbutton.Location = new System.Drawing.Point(751, 575);
            this.Listbutton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Listbutton.Name = "Listbutton";
            this.Listbutton.Size = new System.Drawing.Size(193, 61);
            this.Listbutton.TabIndex = 8;
            this.Listbutton.Text = "List";
            this.Listbutton.UseVisualStyleBackColor = true;
            this.Listbutton.Click += new System.EventHandler(this.Listbutton_Click);
            // 
            // Countbutton
            // 
            this.Countbutton.Location = new System.Drawing.Point(1121, 146);
            this.Countbutton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Countbutton.Name = "Countbutton";
            this.Countbutton.Size = new System.Drawing.Size(209, 99);
            this.Countbutton.TabIndex = 11;
            this.Countbutton.Text = "統計每個學院人數";
            this.Countbutton.UseVisualStyleBackColor = true;
            this.Countbutton.Click += new System.EventHandler(this.Countbutton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1121, 290);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 102);
            this.button1.TabIndex = 12;
            this.button1.Text = "統計每個語言人數";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // studentInformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1581, 832);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Countbutton);
            this.Controls.Add(this.Listbutton);
            this.Controls.Add(this.StudentDatalistBox);
            this.Controls.Add(this.PlusButton);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "studentInformationForm";
            this.Text = "A108222040 潘凌徵";
            this.Load += new System.EventHandler(this.studentInformationForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CollegecomboBox1;
        private System.Windows.Forms.ComboBox DepartmentcomboBox1;
        private System.Windows.Forms.ComboBox SecondLanguagecomboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button PlusButton;
        private System.Windows.Forms.ListBox StudentDatalistBox;
        private System.Windows.Forms.Button Listbutton;
        private System.Windows.Forms.Button Countbutton;
        private System.Windows.Forms.Button button1;
    }
}