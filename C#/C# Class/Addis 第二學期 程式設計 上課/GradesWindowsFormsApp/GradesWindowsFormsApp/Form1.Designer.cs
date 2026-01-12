namespace GradesWindowsFormsApp
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
            this.getScoreButton = new System.Windows.Forms.Button();
            this.averagesListBox = new System.Windows.Forms.ListBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // getScoreButton
            // 
            this.getScoreButton.Location = new System.Drawing.Point(142, 248);
            this.getScoreButton.Name = "getScoreButton";
            this.getScoreButton.Size = new System.Drawing.Size(154, 57);
            this.getScoreButton.TabIndex = 0;
            this.getScoreButton.Text = "Get Scored";
            this.getScoreButton.UseVisualStyleBackColor = true;
            this.getScoreButton.Click += new System.EventHandler(this.getScoreButton_Click);
            // 
            // averagesListBox
            // 
            this.averagesListBox.FormattingEnabled = true;
            this.averagesListBox.ItemHeight = 15;
            this.averagesListBox.Location = new System.Drawing.Point(212, 46);
            this.averagesListBox.Name = "averagesListBox";
            this.averagesListBox.Size = new System.Drawing.Size(282, 154);
            this.averagesListBox.TabIndex = 1;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(392, 248);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(154, 57);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.averagesListBox);
            this.Controls.Add(this.getScoreButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button getScoreButton;
        private System.Windows.Forms.ListBox averagesListBox;
        private System.Windows.Forms.Button ExitButton;
    }
}

