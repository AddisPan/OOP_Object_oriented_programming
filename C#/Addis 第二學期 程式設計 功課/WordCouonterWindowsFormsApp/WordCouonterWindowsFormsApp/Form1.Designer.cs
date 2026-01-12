namespace WordCouonterWindowsFormsApp
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
            this.WordTextBox = new System.Windows.Forms.TextBox();
            this.ComputeButton = new System.Windows.Forms.Button();
            this.WordListBox = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // WordTextBox
            // 
            this.WordTextBox.Location = new System.Drawing.Point(95, 68);
            this.WordTextBox.Name = "WordTextBox";
            this.WordTextBox.Size = new System.Drawing.Size(100, 25);
            this.WordTextBox.TabIndex = 0;
            // 
            // ComputeButton
            // 
            this.ComputeButton.Location = new System.Drawing.Point(560, 49);
            this.ComputeButton.Name = "ComputeButton";
            this.ComputeButton.Size = new System.Drawing.Size(159, 58);
            this.ComputeButton.TabIndex = 1;
            this.ComputeButton.Text = "判斷";
            this.ComputeButton.UseVisualStyleBackColor = true;
            this.ComputeButton.Click += new System.EventHandler(this.ComputeButton_Click);
            // 
            // WordListBox
            // 
            this.WordListBox.FormattingEnabled = true;
            this.WordListBox.ItemHeight = 15;
            this.WordListBox.Location = new System.Drawing.Point(95, 188);
            this.WordListBox.Name = "WordListBox";
            this.WordListBox.Size = new System.Drawing.Size(409, 214);
            this.WordListBox.TabIndex = 2;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 464);
            this.Controls.Add(this.WordListBox);
            this.Controls.Add(this.ComputeButton);
            this.Controls.Add(this.WordTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox WordTextBox;
        private System.Windows.Forms.Button ComputeButton;
        private System.Windows.Forms.ListBox WordListBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

