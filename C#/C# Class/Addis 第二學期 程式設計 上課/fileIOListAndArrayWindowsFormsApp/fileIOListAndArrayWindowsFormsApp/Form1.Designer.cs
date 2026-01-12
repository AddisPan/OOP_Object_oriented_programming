namespace fileIOListAndArrayWindowsFormsApp
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
            this.InputButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.DisplayListBox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SundayTextBox = new System.Windows.Forms.TextBox();
            this.SaturdayTextBox = new System.Windows.Forms.TextBox();
            this.FridayTextBox = new System.Windows.Forms.TextBox();
            this.ThursdayTextBox = new System.Windows.Forms.TextBox();
            this.WednesdayTextBox = new System.Windows.Forms.TextBox();
            this.TuesdayTextBox = new System.Windows.Forms.TextBox();
            this.MondayTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SaveDataIntoFileButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.ReadDataButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // InputButton
            // 
            this.InputButton.Location = new System.Drawing.Point(753, 171);
            this.InputButton.Name = "InputButton";
            this.InputButton.Size = new System.Drawing.Size(135, 62);
            this.InputButton.TabIndex = 0;
            this.InputButton.Text = "確定";
            this.InputButton.UseVisualStyleBackColor = true;
            this.InputButton.Click += new System.EventHandler(this.InputButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(568, 171);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(135, 62);
            this.ClearButton.TabIndex = 1;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // DisplayListBox
            // 
            this.DisplayListBox.FormattingEnabled = true;
            this.DisplayListBox.ItemHeight = 25;
            this.DisplayListBox.Location = new System.Drawing.Point(27, 10);
            this.DisplayListBox.Name = "DisplayListBox";
            this.DisplayListBox.Size = new System.Drawing.Size(634, 229);
            this.DisplayListBox.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SundayTextBox);
            this.groupBox1.Controls.Add(this.SaturdayTextBox);
            this.groupBox1.Controls.Add(this.FridayTextBox);
            this.groupBox1.Controls.Add(this.ClearButton);
            this.groupBox1.Controls.Add(this.InputButton);
            this.groupBox1.Controls.Add(this.ThursdayTextBox);
            this.groupBox1.Controls.Add(this.WednesdayTextBox);
            this.groupBox1.Controls.Add(this.TuesdayTextBox);
            this.groupBox1.Controls.Add(this.MondayTextBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(26, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(963, 259);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "每日上網時間(分鐘)";
            // 
            // SundayTextBox
            // 
            this.SundayTextBox.Location = new System.Drawing.Point(776, 105);
            this.SundayTextBox.Name = "SundayTextBox";
            this.SundayTextBox.Size = new System.Drawing.Size(98, 34);
            this.SundayTextBox.TabIndex = 12;
            // 
            // SaturdayTextBox
            // 
            this.SaturdayTextBox.Location = new System.Drawing.Point(627, 105);
            this.SaturdayTextBox.Name = "SaturdayTextBox";
            this.SaturdayTextBox.Size = new System.Drawing.Size(101, 34);
            this.SaturdayTextBox.TabIndex = 11;
            // 
            // FridayTextBox
            // 
            this.FridayTextBox.Location = new System.Drawing.Point(494, 105);
            this.FridayTextBox.Name = "FridayTextBox";
            this.FridayTextBox.Size = new System.Drawing.Size(100, 34);
            this.FridayTextBox.TabIndex = 10;
            // 
            // ThursdayTextBox
            // 
            this.ThursdayTextBox.Location = new System.Drawing.Point(354, 105);
            this.ThursdayTextBox.Name = "ThursdayTextBox";
            this.ThursdayTextBox.Size = new System.Drawing.Size(94, 34);
            this.ThursdayTextBox.TabIndex = 9;
            // 
            // WednesdayTextBox
            // 
            this.WednesdayTextBox.Location = new System.Drawing.Point(241, 105);
            this.WednesdayTextBox.Name = "WednesdayTextBox";
            this.WednesdayTextBox.Size = new System.Drawing.Size(94, 34);
            this.WednesdayTextBox.TabIndex = 8;
            // 
            // TuesdayTextBox
            // 
            this.TuesdayTextBox.Location = new System.Drawing.Point(135, 105);
            this.TuesdayTextBox.Name = "TuesdayTextBox";
            this.TuesdayTextBox.Size = new System.Drawing.Size(85, 34);
            this.TuesdayTextBox.TabIndex = 7;
            // 
            // MondayTextBox
            // 
            this.MondayTextBox.Location = new System.Drawing.Point(20, 105);
            this.MondayTextBox.Name = "MondayTextBox";
            this.MondayTextBox.Size = new System.Drawing.Size(83, 34);
            this.MondayTextBox.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(786, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "星期日";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(642, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "星期六";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(507, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "星期五";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(366, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "星期四";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "星期三";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "星期二";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "星期一";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(723, 303);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(682, 229);
            this.listBox1.TabIndex = 4;
            // 
            // SaveDataIntoFileButton
            // 
            this.SaveDataIntoFileButton.Location = new System.Drawing.Point(233, 262);
            this.SaveDataIntoFileButton.Name = "SaveDataIntoFileButton";
            this.SaveDataIntoFileButton.Size = new System.Drawing.Size(160, 48);
            this.SaveDataIntoFileButton.TabIndex = 5;
            this.SaveDataIntoFileButton.Text = "將資料存入檔案";
            this.SaveDataIntoFileButton.UseVisualStyleBackColor = true;
            this.SaveDataIntoFileButton.Click += new System.EventHandler(this.SaveDataIntoFileButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SaveDataIntoFileButton);
            this.panel1.Controls.Add(this.DisplayListBox);
            this.panel1.Location = new System.Drawing.Point(19, 293);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(680, 316);
            this.panel1.TabIndex = 6;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ReadDataButton
            // 
            this.ReadDataButton.Location = new System.Drawing.Point(904, 602);
            this.ReadDataButton.Name = "ReadDataButton";
            this.ReadDataButton.Size = new System.Drawing.Size(278, 46);
            this.ReadDataButton.TabIndex = 7;
            this.ReadDataButton.Text = "讀取檔案資料";
            this.ReadDataButton.UseVisualStyleBackColor = true;
            this.ReadDataButton.Click += new System.EventHandler(this.ReadDataButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(904, 671);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(222, 59);
            this.button1.TabIndex = 8;
            this.button1.Text = "以二維陣列方式儲存";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1430, 811);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ReadDataButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "每周上網時間統計";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button InputButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.ListBox DisplayListBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox SundayTextBox;
        private System.Windows.Forms.TextBox SaturdayTextBox;
        private System.Windows.Forms.TextBox FridayTextBox;
        private System.Windows.Forms.TextBox ThursdayTextBox;
        private System.Windows.Forms.TextBox WednesdayTextBox;
        private System.Windows.Forms.TextBox TuesdayTextBox;
        private System.Windows.Forms.TextBox MondayTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button SaveDataIntoFileButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button ReadDataButton;
        private System.Windows.Forms.Button button1;
    }
}

