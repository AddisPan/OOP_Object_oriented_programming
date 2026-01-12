namespace CoinWindowsFormsApp
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
            this.outputlistBox = new System.Windows.Forms.ListBox();
            this.TossButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // outputlistBox
            // 
            this.outputlistBox.FormattingEnabled = true;
            this.outputlistBox.ItemHeight = 15;
            this.outputlistBox.Location = new System.Drawing.Point(211, 45);
            this.outputlistBox.Name = "outputlistBox";
            this.outputlistBox.Size = new System.Drawing.Size(388, 184);
            this.outputlistBox.TabIndex = 0;
            // 
            // TossButton
            // 
            this.TossButton.Location = new System.Drawing.Point(211, 311);
            this.TossButton.Name = "TossButton";
            this.TossButton.Size = new System.Drawing.Size(123, 52);
            this.TossButton.TabIndex = 1;
            this.TossButton.Text = "Toss";
            this.TossButton.UseVisualStyleBackColor = true;
            this.TossButton.Click += new System.EventHandler(this.TossButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(476, 311);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(123, 52);
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
            this.Controls.Add(this.TossButton);
            this.Controls.Add(this.outputlistBox);
            this.Name = "Form1";
            this.Text = "Coin Toss";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox outputlistBox;
        private System.Windows.Forms.Button TossButton;
        private System.Windows.Forms.Button ExitButton;
    }
}

