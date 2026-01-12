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
            this.SaveFileButton = new System.Windows.Forms.Button();
            this.ReadFileButton = new System.Windows.Forms.Button();
            this.generateScoreButton = new System.Windows.Forms.Button();
            this.ScoreListBox = new System.Windows.Forms.ListBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.EndButton = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ComputeButton = new System.Windows.Forms.Button();
            this.FriendsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SaveFileButton
            // 
            this.SaveFileButton.Location = new System.Drawing.Point(91, 50);
            this.SaveFileButton.Name = "SaveFileButton";
            this.SaveFileButton.Size = new System.Drawing.Size(144, 62);
            this.SaveFileButton.TabIndex = 0;
            this.SaveFileButton.Text = "儲存檔案";
            this.SaveFileButton.UseVisualStyleBackColor = true;
            this.SaveFileButton.Click += new System.EventHandler(this.SaveFileButton_Click);
            // 
            // ReadFileButton
            // 
            this.ReadFileButton.Location = new System.Drawing.Point(91, 152);
            this.ReadFileButton.Name = "ReadFileButton";
            this.ReadFileButton.Size = new System.Drawing.Size(144, 62);
            this.ReadFileButton.TabIndex = 1;
            this.ReadFileButton.Text = "讀取檔案";
            this.ReadFileButton.UseVisualStyleBackColor = true;
            this.ReadFileButton.Click += new System.EventHandler(this.ReadFileButton_Click);
            // 
            // generateScoreButton
            // 
            this.generateScoreButton.Location = new System.Drawing.Point(615, 171);
            this.generateScoreButton.Name = "generateScoreButton";
            this.generateScoreButton.Size = new System.Drawing.Size(144, 62);
            this.generateScoreButton.TabIndex = 2;
            this.generateScoreButton.Text = "自動產生成績";
            this.generateScoreButton.UseVisualStyleBackColor = true;
            this.generateScoreButton.Click += new System.EventHandler(this.generateScoreButton_Click);
            // 
            // ScoreListBox
            // 
            this.ScoreListBox.FormattingEnabled = true;
            this.ScoreListBox.ItemHeight = 15;
            this.ScoreListBox.Location = new System.Drawing.Point(431, 50);
            this.ScoreListBox.Name = "ScoreListBox";
            this.ScoreListBox.Size = new System.Drawing.Size(162, 364);
            this.ScoreListBox.TabIndex = 3;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(91, 255);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(144, 62);
            this.ClearButton.TabIndex = 4;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // EndButton
            // 
            this.EndButton.Location = new System.Drawing.Point(91, 355);
            this.EndButton.Name = "EndButton";
            this.EndButton.Size = new System.Drawing.Size(144, 62);
            this.EndButton.TabIndex = 5;
            this.EndButton.Text = "End";
            this.EndButton.UseVisualStyleBackColor = true;
            this.EndButton.Click += new System.EventHandler(this.EndButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ComputeButton
            // 
            this.ComputeButton.Location = new System.Drawing.Point(260, 53);
            this.ComputeButton.Name = "ComputeButton";
            this.ComputeButton.Size = new System.Drawing.Size(144, 62);
            this.ComputeButton.TabIndex = 6;
            this.ComputeButton.Text = "計算成績";
            this.ComputeButton.UseVisualStyleBackColor = true;
            this.ComputeButton.Click += new System.EventHandler(this.ComputeButton_Click);
            // 
            // FriendsButton
            // 
            this.FriendsButton.Location = new System.Drawing.Point(260, 152);
            this.FriendsButton.Name = "FriendsButton";
            this.FriendsButton.Size = new System.Drawing.Size(144, 62);
            this.FriendsButton.TabIndex = 7;
            this.FriendsButton.Text = "好友";
            this.FriendsButton.UseVisualStyleBackColor = true;
            this.FriendsButton.Click += new System.EventHandler(this.FriendsButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FriendsButton);
            this.Controls.Add(this.ComputeButton);
            this.Controls.Add(this.EndButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.ScoreListBox);
            this.Controls.Add(this.generateScoreButton);
            this.Controls.Add(this.ReadFileButton);
            this.Controls.Add(this.SaveFileButton);
            this.Name = "Form1";
            this.Text = "A108222040";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SaveFileButton;
        private System.Windows.Forms.Button ReadFileButton;
        private System.Windows.Forms.Button generateScoreButton;
        private System.Windows.Forms.ListBox ScoreListBox;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button EndButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button ComputeButton;
        private System.Windows.Forms.Button FriendsButton;
    }
}

