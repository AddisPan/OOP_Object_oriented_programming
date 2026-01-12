namespace ScoreWindowsFormsApplication
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
            this.ScoreListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NumberTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LowestLabel = new System.Windows.Forms.Label();
            this.HighestScoreLabel = new System.Windows.Forms.Label();
            this.AverageScoreLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.EndButton = new System.Windows.Forms.Button();
            this.ComputeScoreButton = new System.Windows.Forms.Button();
            this.InputScoreButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ScoreListBox
            // 
            this.ScoreListBox.FormattingEnabled = true;
            this.ScoreListBox.ItemHeight = 33;
            this.ScoreListBox.Location = new System.Drawing.Point(39, 48);
            this.ScoreListBox.Name = "ScoreListBox";
            this.ScoreListBox.Size = new System.Drawing.Size(151, 103);
            this.ScoreListBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "請輸入班級人數:";
            // 
            // NumberTextBox
            // 
            this.NumberTextBox.Location = new System.Drawing.Point(448, 45);
            this.NumberTextBox.Name = "NumberTextBox";
            this.NumberTextBox.Size = new System.Drawing.Size(100, 42);
            this.NumberTextBox.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LowestLabel);
            this.groupBox1.Controls.Add(this.HighestScoreLabel);
            this.groupBox1.Controls.Add(this.AverageScoreLabel);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(26, 203);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 186);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "班級成績";
            // 
            // LowestLabel
            // 
            this.LowestLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LowestLabel.Location = new System.Drawing.Point(145, 144);
            this.LowestLabel.Name = "LowestLabel";
            this.LowestLabel.Size = new System.Drawing.Size(85, 26);
            this.LowestLabel.TabIndex = 5;
            // 
            // HighestScoreLabel
            // 
            this.HighestScoreLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HighestScoreLabel.Location = new System.Drawing.Point(145, 95);
            this.HighestScoreLabel.Name = "HighestScoreLabel";
            this.HighestScoreLabel.Size = new System.Drawing.Size(85, 26);
            this.HighestScoreLabel.TabIndex = 4;
            // 
            // AverageScoreLabel
            // 
            this.AverageScoreLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AverageScoreLabel.Location = new System.Drawing.Point(145, 52);
            this.AverageScoreLabel.Name = "AverageScoreLabel";
            this.AverageScoreLabel.Size = new System.Drawing.Size(85, 26);
            this.AverageScoreLabel.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 35);
            this.label4.TabIndex = 2;
            this.label4.Text = "最低分:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 35);
            this.label3.TabIndex = 1;
            this.label3.Text = "最高分:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 35);
            this.label2.TabIndex = 0;
            this.label2.Text = "平均成績:";
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(325, 320);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(104, 40);
            this.ClearButton.TabIndex = 4;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // EndButton
            // 
            this.EndButton.Location = new System.Drawing.Point(475, 320);
            this.EndButton.Name = "EndButton";
            this.EndButton.Size = new System.Drawing.Size(108, 40);
            this.EndButton.TabIndex = 5;
            this.EndButton.Text = "End";
            this.EndButton.UseVisualStyleBackColor = true;
            this.EndButton.Click += new System.EventHandler(this.EndButton_Click);
            // 
            // ComputeScoreButton
            // 
            this.ComputeScoreButton.Enabled = false;
            this.ComputeScoreButton.Location = new System.Drawing.Point(428, 124);
            this.ComputeScoreButton.Name = "ComputeScoreButton";
            this.ComputeScoreButton.Size = new System.Drawing.Size(187, 44);
            this.ComputeScoreButton.TabIndex = 6;
            this.ComputeScoreButton.Text = "計算統計成績";
            this.ComputeScoreButton.UseVisualStyleBackColor = true;
            this.ComputeScoreButton.Click += new System.EventHandler(this.ComputeScoreButton_Click);
            // 
            // InputScoreButton
            // 
            this.InputScoreButton.Location = new System.Drawing.Point(236, 124);
            this.InputScoreButton.Name = "InputScoreButton";
            this.InputScoreButton.Size = new System.Drawing.Size(173, 44);
            this.InputScoreButton.TabIndex = 7;
            this.InputScoreButton.Text = "輸入班級成績";
            this.InputScoreButton.UseVisualStyleBackColor = true;
            this.InputScoreButton.Click += new System.EventHandler(this.InputScoreButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 566);
            this.Controls.Add(this.InputScoreButton);
            this.Controls.Add(this.ComputeScoreButton);
            this.Controls.Add(this.EndButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.NumberTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ScoreListBox);
            this.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "Form1";
            this.Text = "班級成績統計";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ScoreListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NumberTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LowestLabel;
        private System.Windows.Forms.Label HighestScoreLabel;
        private System.Windows.Forms.Label AverageScoreLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button EndButton;
        private System.Windows.Forms.Button ComputeScoreButton;
        private System.Windows.Forms.Button InputScoreButton;
    }
}

