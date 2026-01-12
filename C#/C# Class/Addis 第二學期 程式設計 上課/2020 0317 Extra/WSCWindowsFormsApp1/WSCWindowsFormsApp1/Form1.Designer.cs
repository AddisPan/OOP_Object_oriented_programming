namespace WSCWindowsFormsApp1
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
            this.TeamListBox = new System.Windows.Forms.ListBox();
            this.ReadFileButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ClearButton = new System.Windows.Forms.Button();
            this.EndButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.WorldSerieslistBox = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TeamListBox
            // 
            this.TeamListBox.FormattingEnabled = true;
            this.TeamListBox.ItemHeight = 15;
            this.TeamListBox.Location = new System.Drawing.Point(289, 45);
            this.TeamListBox.Name = "TeamListBox";
            this.TeamListBox.Size = new System.Drawing.Size(253, 364);
            this.TeamListBox.TabIndex = 4;
            // 
            // ReadFileButton
            // 
            this.ReadFileButton.Location = new System.Drawing.Point(79, 25);
            this.ReadFileButton.Name = "ReadFileButton";
            this.ReadFileButton.Size = new System.Drawing.Size(144, 62);
            this.ReadFileButton.TabIndex = 5;
            this.ReadFileButton.Text = "讀取隊伍檔案";
            this.ReadFileButton.UseVisualStyleBackColor = true;
            this.ReadFileButton.Click += new System.EventHandler(this.ReadFileButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(79, 275);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(144, 62);
            this.ClearButton.TabIndex = 6;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // EndButton
            // 
            this.EndButton.Location = new System.Drawing.Point(79, 366);
            this.EndButton.Name = "EndButton";
            this.EndButton.Size = new System.Drawing.Size(144, 62);
            this.EndButton.TabIndex = 7;
            this.EndButton.Text = "End";
            this.EndButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(79, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 62);
            this.button1.TabIndex = 8;
            this.button1.Text = "Win";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // WorldSerieslistBox
            // 
            this.WorldSerieslistBox.FormattingEnabled = true;
            this.WorldSerieslistBox.ItemHeight = 15;
            this.WorldSerieslistBox.Location = new System.Drawing.Point(585, 45);
            this.WorldSerieslistBox.Name = "WorldSerieslistBox";
            this.WorldSerieslistBox.Size = new System.Drawing.Size(230, 364);
            this.WorldSerieslistBox.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(79, 116);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 62);
            this.button2.TabIndex = 11;
            this.button2.Text = "讀取冠軍檔案";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.WorldSerieslistBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.EndButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.ReadFileButton);
            this.Controls.Add(this.TeamListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox TeamListBox;
        private System.Windows.Forms.Button ReadFileButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button EndButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox WorldSerieslistBox;
        private System.Windows.Forms.Button button2;
    }
}

