namespace 成績等第ConsoleApplication1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FirstScoreTextBox = new System.Windows.Forms.TextBox();
            this.SecondScoreTextBox = new System.Windows.Forms.TextBox();
            this.ThirdScoreTextBox = new System.Windows.Forms.TextBox();
            this.ScoreLevel1Label = new System.Windows.Forms.Label();
            this.ScoreLevel2Label = new System.Windows.Forms.Label();
            this.ScoreLevel3Label = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.EndButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "第一次:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(13, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "第二次:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(13, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "第三次:";
            // 
            // FirstScoreTextBox
            // 
            this.FirstScoreTextBox.Location = new System.Drawing.Point(100, 20);
            this.FirstScoreTextBox.Name = "FirstScoreTextBox";
            this.FirstScoreTextBox.Size = new System.Drawing.Size(100, 34);
            this.FirstScoreTextBox.TabIndex = 3;
            // 
            // SecondScoreTextBox
            // 
            this.SecondScoreTextBox.Location = new System.Drawing.Point(100, 150);
            this.SecondScoreTextBox.Name = "SecondScoreTextBox";
            this.SecondScoreTextBox.Size = new System.Drawing.Size(100, 34);
            this.SecondScoreTextBox.TabIndex = 4;
            // 
            // ThirdScoreTextBox
            // 
            this.ThirdScoreTextBox.Location = new System.Drawing.Point(100, 262);
            this.ThirdScoreTextBox.Name = "ThirdScoreTextBox";
            this.ThirdScoreTextBox.Size = new System.Drawing.Size(100, 34);
            this.ThirdScoreTextBox.TabIndex = 5;
            // 
            // ScoreLevel1Label
            // 
            this.ScoreLevel1Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ScoreLevel1Label.Location = new System.Drawing.Point(26, 39);
            this.ScoreLevel1Label.Name = "ScoreLevel1Label";
            this.ScoreLevel1Label.Size = new System.Drawing.Size(74, 32);
            this.ScoreLevel1Label.TabIndex = 6;
            // 
            // ScoreLevel2Label
            // 
            this.ScoreLevel2Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ScoreLevel2Label.Location = new System.Drawing.Point(26, 154);
            this.ScoreLevel2Label.Name = "ScoreLevel2Label";
            this.ScoreLevel2Label.Size = new System.Drawing.Size(74, 33);
            this.ScoreLevel2Label.TabIndex = 7;
            // 
            // ScoreLevel3Label
            // 
            this.ScoreLevel3Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ScoreLevel3Label.Location = new System.Drawing.Point(26, 265);
            this.ScoreLevel3Label.Name = "ScoreLevel3Label";
            this.ScoreLevel3Label.Size = new System.Drawing.Size(74, 34);
            this.ScoreLevel3Label.TabIndex = 8;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(487, 74);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(102, 32);
            this.CalculateButton.TabIndex = 9;
            this.CalculateButton.Text = "Caculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(487, 192);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(102, 33);
            this.ClearButton.TabIndex = 10;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // EndButton
            // 
            this.EndButton.Location = new System.Drawing.Point(487, 304);
            this.EndButton.Name = "EndButton";
            this.EndButton.Size = new System.Drawing.Size(102, 34);
            this.EndButton.TabIndex = 11;
            this.EndButton.Text = "End";
            this.EndButton.UseVisualStyleBackColor = true;
            this.EndButton.Click += new System.EventHandler(this.EndButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ThirdScoreTextBox);
            this.groupBox1.Controls.Add(this.SecondScoreTextBox);
            this.groupBox1.Controls.Add(this.FirstScoreTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(43, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 311);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "成績";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ScoreLevel3Label);
            this.groupBox2.Controls.Add(this.ScoreLevel2Label);
            this.groupBox2.Controls.Add(this.ScoreLevel1Label);
            this.groupBox2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.Location = new System.Drawing.Point(302, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(164, 312);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "等第";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 394);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.EndButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.CalculateButton);
            this.Name = "Form1";
            this.Text = "成績等第計算";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FirstScoreTextBox;
        private System.Windows.Forms.TextBox SecondScoreTextBox;
        private System.Windows.Forms.TextBox ThirdScoreTextBox;
        private System.Windows.Forms.Label ScoreLevel1Label;
        private System.Windows.Forms.Label ScoreLevel2Label;
        private System.Windows.Forms.Label ScoreLevel3Label;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button EndButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

