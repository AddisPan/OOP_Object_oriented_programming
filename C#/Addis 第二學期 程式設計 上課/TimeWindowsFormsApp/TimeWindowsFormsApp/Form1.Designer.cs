namespace TimeWindowsFormsApp
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Minutelabel = new System.Windows.Forms.Label();
            this.Hourlabel = new System.Windows.Forms.Label();
            this.ShowListBox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.AddTextBox = new System.Windows.Forms.TextBox();
            this.MinuteTextBox = new System.Windows.Forms.TextBox();
            this.HourTextBox = new System.Windows.Forms.TextBox();
            this.MinuteButton = new System.Windows.Forms.Button();
            this.HourButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Secondlabel = new System.Windows.Forms.Label();
            this.SecondButton = new System.Windows.Forms.Button();
            this.SecondTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SecondTextBox);
            this.groupBox2.Controls.Add(this.SecondButton);
            this.groupBox2.Controls.Add(this.Secondlabel);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.Minutelabel);
            this.groupBox2.Controls.Add(this.Hourlabel);
            this.groupBox2.Controls.Add(this.ShowListBox);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.MinuteTextBox);
            this.groupBox2.Controls.Add(this.HourTextBox);
            this.groupBox2.Controls.Add(this.MinuteButton);
            this.groupBox2.Controls.Add(this.HourButton);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(81, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(990, 563);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "時間";
            // 
            // Minutelabel
            // 
            this.Minutelabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Minutelabel.Location = new System.Drawing.Point(348, 94);
            this.Minutelabel.Name = "Minutelabel";
            this.Minutelabel.Size = new System.Drawing.Size(79, 32);
            this.Minutelabel.TabIndex = 12;
            // 
            // Hourlabel
            // 
            this.Hourlabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Hourlabel.Location = new System.Drawing.Point(213, 94);
            this.Hourlabel.Name = "Hourlabel";
            this.Hourlabel.Size = new System.Drawing.Size(79, 32);
            this.Hourlabel.TabIndex = 11;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AddButton);
            this.groupBox1.Controls.Add(this.AddTextBox);
            this.groupBox1.Location = new System.Drawing.Point(379, 374);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(187, 177);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "秒數增加";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(39, 99);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(108, 52);
            this.AddButton.TabIndex = 8;
            this.AddButton.Text = "增加秒數";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AddTextBox
            // 
            this.AddTextBox.Location = new System.Drawing.Point(39, 44);
            this.AddTextBox.Name = "AddTextBox";
            this.AddTextBox.Size = new System.Drawing.Size(100, 25);
            this.AddTextBox.TabIndex = 7;
            // 
            // MinuteTextBox
            // 
            this.MinuteTextBox.Location = new System.Drawing.Point(213, 336);
            this.MinuteTextBox.Name = "MinuteTextBox";
            this.MinuteTextBox.Size = new System.Drawing.Size(100, 25);
            this.MinuteTextBox.TabIndex = 6;
            // 
            // HourTextBox
            // 
            this.HourTextBox.Location = new System.Drawing.Point(213, 217);
            this.HourTextBox.Name = "HourTextBox";
            this.HourTextBox.Size = new System.Drawing.Size(100, 25);
            this.HourTextBox.TabIndex = 5;
            // 
            // MinuteButton
            // 
            this.MinuteButton.Location = new System.Drawing.Point(28, 320);
            this.MinuteButton.Name = "MinuteButton";
            this.MinuteButton.Size = new System.Drawing.Size(108, 52);
            this.MinuteButton.TabIndex = 4;
            this.MinuteButton.Text = "調整分鐘";
            this.MinuteButton.UseVisualStyleBackColor = true;
            this.MinuteButton.Click += new System.EventHandler(this.MinuteButton_Click);
            // 
            // HourButton
            // 
            this.HourButton.Location = new System.Drawing.Point(28, 201);
            this.HourButton.Name = "HourButton";
            this.HourButton.Size = new System.Drawing.Size(108, 52);
            this.HourButton.TabIndex = 3;
            this.HourButton.Text = "調整小時";
            this.HourButton.UseVisualStyleBackColor = true;
            this.HourButton.Click += new System.EventHandler(this.HourButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(373, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "分";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(218, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "小時";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(22, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "目前時間";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(475, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 36);
            this.label4.TabIndex = 13;
            this.label4.Text = "秒";
            // 
            // Secondlabel
            // 
            this.Secondlabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Secondlabel.Location = new System.Drawing.Point(464, 94);
            this.Secondlabel.Name = "Secondlabel";
            this.Secondlabel.Size = new System.Drawing.Size(79, 32);
            this.Secondlabel.TabIndex = 14;
            // 
            // SecondButton
            // 
            this.SecondButton.Location = new System.Drawing.Point(28, 418);
            this.SecondButton.Name = "SecondButton";
            this.SecondButton.Size = new System.Drawing.Size(108, 52);
            this.SecondButton.TabIndex = 15;
            this.SecondButton.Text = "調整秒";
            this.SecondButton.UseVisualStyleBackColor = true;
            this.SecondButton.Click += new System.EventHandler(this.SecondButton_Click);
            // 
            // SecondTextBox
            // 
            this.SecondTextBox.Location = new System.Drawing.Point(213, 434);
            this.SecondTextBox.Name = "SecondTextBox";
            this.SecondTextBox.Size = new System.Drawing.Size(100, 25);
            this.SecondTextBox.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 626);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox SecondTextBox;
        private System.Windows.Forms.Button SecondButton;
        private System.Windows.Forms.Label Secondlabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Minutelabel;
        private System.Windows.Forms.Label Hourlabel;
        private System.Windows.Forms.ListBox ShowListBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox AddTextBox;
        private System.Windows.Forms.TextBox MinuteTextBox;
        private System.Windows.Forms.TextBox HourTextBox;
        private System.Windows.Forms.Button MinuteButton;
        private System.Windows.Forms.Button HourButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

