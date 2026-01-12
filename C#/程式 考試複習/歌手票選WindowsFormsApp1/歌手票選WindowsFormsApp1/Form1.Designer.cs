namespace 歌手票選WindowsFormsApp1
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
            this.ChickenRadioButton = new System.Windows.Forms.RadioButton();
            this.HamburgerRadioButton = new System.Windows.Forms.RadioButton();
            this.VoteButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CheckoutButton = new System.Windows.Forms.Button();
            this.NextseasonButton = new System.Windows.Forms.Button();
            this.EndButton = new System.Windows.Forms.Button();
            this.HighestFoodLabel = new System.Windows.Forms.Label();
            this.HighestScoreLabel = new System.Windows.Forms.Label();
            this.SecondFoodLabel = new System.Windows.Forms.Label();
            this.SecondScoreLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChickenRadioButton
            // 
            this.ChickenRadioButton.AutoSize = true;
            this.ChickenRadioButton.Location = new System.Drawing.Point(31, 23);
            this.ChickenRadioButton.Name = "ChickenRadioButton";
            this.ChickenRadioButton.Size = new System.Drawing.Size(73, 19);
            this.ChickenRadioButton.TabIndex = 0;
            this.ChickenRadioButton.TabStop = true;
            this.ChickenRadioButton.Text = "雞蛋仔";
            this.ChickenRadioButton.UseVisualStyleBackColor = true;
            // 
            // HamburgerRadioButton
            // 
            this.HamburgerRadioButton.AutoSize = true;
            this.HamburgerRadioButton.Location = new System.Drawing.Point(31, 66);
            this.HamburgerRadioButton.Name = "HamburgerRadioButton";
            this.HamburgerRadioButton.Size = new System.Drawing.Size(58, 19);
            this.HamburgerRadioButton.TabIndex = 1;
            this.HamburgerRadioButton.TabStop = true;
            this.HamburgerRadioButton.Text = "漢堡";
            this.HamburgerRadioButton.UseVisualStyleBackColor = true;
            // 
            // VoteButton
            // 
            this.VoteButton.Location = new System.Drawing.Point(31, 154);
            this.VoteButton.Name = "VoteButton";
            this.VoteButton.Size = new System.Drawing.Size(75, 23);
            this.VoteButton.TabIndex = 3;
            this.VoteButton.Text = "Vote";
            this.VoteButton.UseVisualStyleBackColor = true;
            this.VoteButton.Click += new System.EventHandler(this.VoteButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.VoteButton);
            this.groupBox1.Controls.Add(this.HamburgerRadioButton);
            this.groupBox1.Controls.Add(this.ChickenRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(14, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 194);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "美食";
            // 
            // CheckoutButton
            // 
            this.CheckoutButton.Location = new System.Drawing.Point(335, 254);
            this.CheckoutButton.Name = "CheckoutButton";
            this.CheckoutButton.Size = new System.Drawing.Size(75, 23);
            this.CheckoutButton.TabIndex = 5;
            this.CheckoutButton.Text = "顯示";
            this.CheckoutButton.UseVisualStyleBackColor = true;
            this.CheckoutButton.Click += new System.EventHandler(this.CheckoutButton_Click);
            // 
            // NextseasonButton
            // 
            this.NextseasonButton.Location = new System.Drawing.Point(471, 254);
            this.NextseasonButton.Name = "NextseasonButton";
            this.NextseasonButton.Size = new System.Drawing.Size(93, 23);
            this.NextseasonButton.TabIndex = 6;
            this.NextseasonButton.Text = "Nextseason";
            this.NextseasonButton.UseVisualStyleBackColor = true;
            this.NextseasonButton.Click += new System.EventHandler(this.NextseasonButton_Click);
            // 
            // EndButton
            // 
            this.EndButton.Location = new System.Drawing.Point(618, 254);
            this.EndButton.Name = "EndButton";
            this.EndButton.Size = new System.Drawing.Size(75, 23);
            this.EndButton.TabIndex = 7;
            this.EndButton.Text = "End";
            this.EndButton.UseVisualStyleBackColor = true;
            this.EndButton.Click += new System.EventHandler(this.EndButton_Click);
            // 
            // HighestFoodLabel
            // 
            this.HighestFoodLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HighestFoodLabel.Location = new System.Drawing.Point(400, 48);
            this.HighestFoodLabel.Name = "HighestFoodLabel";
            this.HighestFoodLabel.Size = new System.Drawing.Size(78, 29);
            this.HighestFoodLabel.TabIndex = 8;
            // 
            // HighestScoreLabel
            // 
            this.HighestScoreLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HighestScoreLabel.Location = new System.Drawing.Point(512, 49);
            this.HighestScoreLabel.Name = "HighestScoreLabel";
            this.HighestScoreLabel.Size = new System.Drawing.Size(69, 29);
            this.HighestScoreLabel.TabIndex = 9;
            // 
            // SecondFoodLabel
            // 
            this.SecondFoodLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SecondFoodLabel.Location = new System.Drawing.Point(400, 128);
            this.SecondFoodLabel.Name = "SecondFoodLabel";
            this.SecondFoodLabel.Size = new System.Drawing.Size(78, 29);
            this.SecondFoodLabel.TabIndex = 10;
            // 
            // SecondScoreLabel
            // 
            this.SecondScoreLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SecondScoreLabel.Location = new System.Drawing.Point(512, 128);
            this.SecondScoreLabel.Name = "SecondScoreLabel";
            this.SecondScoreLabel.Size = new System.Drawing.Size(69, 29);
            this.SecondScoreLabel.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(316, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "第一名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(316, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "第二名";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SecondScoreLabel);
            this.Controls.Add(this.SecondFoodLabel);
            this.Controls.Add(this.HighestScoreLabel);
            this.Controls.Add(this.HighestFoodLabel);
            this.Controls.Add(this.EndButton);
            this.Controls.Add(this.NextseasonButton);
            this.Controls.Add(this.CheckoutButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton ChickenRadioButton;
        private System.Windows.Forms.RadioButton HamburgerRadioButton;
        private System.Windows.Forms.Button VoteButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button CheckoutButton;
        private System.Windows.Forms.Button NextseasonButton;
        private System.Windows.Forms.Button EndButton;
        private System.Windows.Forms.Label HighestFoodLabel;
        private System.Windows.Forms.Label HighestScoreLabel;
        private System.Windows.Forms.Label SecondFoodLabel;
        private System.Windows.Forms.Label SecondScoreLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

