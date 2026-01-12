namespace ColorsWindowsFormsApp
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
            this.ColorListBox = new System.Windows.Forms.ListBox();
            this.ColorTextBox = new System.Windows.Forms.TextBox();
            this.ComputeButton = new System.Windows.Forms.Button();
            this.ShowButton = new System.Windows.Forms.Button();
            this.ShowColorListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // ColorListBox
            // 
            this.ColorListBox.FormattingEnabled = true;
            this.ColorListBox.ItemHeight = 15;
            this.ColorListBox.Location = new System.Drawing.Point(12, 35);
            this.ColorListBox.Name = "ColorListBox";
            this.ColorListBox.Size = new System.Drawing.Size(465, 184);
            this.ColorListBox.TabIndex = 0;
            // 
            // ColorTextBox
            // 
            this.ColorTextBox.Location = new System.Drawing.Point(582, 78);
            this.ColorTextBox.Name = "ColorTextBox";
            this.ColorTextBox.Size = new System.Drawing.Size(175, 25);
            this.ColorTextBox.TabIndex = 1;
            // 
            // ComputeButton
            // 
            this.ComputeButton.Location = new System.Drawing.Point(582, 177);
            this.ComputeButton.Name = "ComputeButton";
            this.ComputeButton.Size = new System.Drawing.Size(175, 69);
            this.ComputeButton.TabIndex = 2;
            this.ComputeButton.Text = "確定";
            this.ComputeButton.UseVisualStyleBackColor = true;
            this.ComputeButton.Click += new System.EventHandler(this.ComputeButton_Click);
            // 
            // ShowButton
            // 
            this.ShowButton.Location = new System.Drawing.Point(582, 282);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(175, 69);
            this.ShowButton.TabIndex = 3;
            this.ShowButton.Text = "判斷";
            this.ShowButton.UseVisualStyleBackColor = true;
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // ShowColorListBox
            // 
            this.ShowColorListBox.FormattingEnabled = true;
            this.ShowColorListBox.ItemHeight = 15;
            this.ShowColorListBox.Location = new System.Drawing.Point(12, 282);
            this.ShowColorListBox.Name = "ShowColorListBox";
            this.ShowColorListBox.Size = new System.Drawing.Size(465, 124);
            this.ShowColorListBox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ShowColorListBox);
            this.Controls.Add(this.ShowButton);
            this.Controls.Add(this.ComputeButton);
            this.Controls.Add(this.ColorTextBox);
            this.Controls.Add(this.ColorListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ColorListBox;
        private System.Windows.Forms.TextBox ColorTextBox;
        private System.Windows.Forms.Button ComputeButton;
        private System.Windows.Forms.Button ShowButton;
        private System.Windows.Forms.ListBox ShowColorListBox;
    }
}

