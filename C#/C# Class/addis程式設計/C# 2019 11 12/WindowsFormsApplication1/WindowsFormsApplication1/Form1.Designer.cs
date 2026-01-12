namespace WindowsFormsApplication1
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
            this.InputTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.InputButton = new System.Windows.Forms.Button();
            this.ConputeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ScoreListBox
            // 
            this.ScoreListBox.FormattingEnabled = true;
            this.ScoreListBox.ItemHeight = 20;
            this.ScoreListBox.Location = new System.Drawing.Point(53, 54);
            this.ScoreListBox.Name = "ScoreListBox";
            this.ScoreListBox.Size = new System.Drawing.Size(139, 104);
            this.ScoreListBox.TabIndex = 0;
            // 
            // InputTextBox
            // 
            this.InputTextBox.Location = new System.Drawing.Point(426, 51);
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(100, 29);
            this.InputTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(262, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "請輸入成績:";
            // 
            // InputButton
            // 
            this.InputButton.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.InputButton.Location = new System.Drawing.Point(616, 46);
            this.InputButton.Name = "InputButton";
            this.InputButton.Size = new System.Drawing.Size(92, 39);
            this.InputButton.TabIndex = 3;
            this.InputButton.Text = "確定";
            this.InputButton.UseVisualStyleBackColor = true;
            this.InputButton.Click += new System.EventHandler(this.InputButton_Click);
            // 
            // ConputeButton
            // 
            this.ConputeButton.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ConputeButton.Location = new System.Drawing.Point(410, 185);
            this.ConputeButton.Name = "ConputeButton";
            this.ConputeButton.Size = new System.Drawing.Size(116, 40);
            this.ConputeButton.TabIndex = 4;
            this.ConputeButton.Text = "計算成績";
            this.ConputeButton.UseVisualStyleBackColor = true;
            this.ConputeButton.Click += new System.EventHandler(this.ConputeButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.InputButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 402);
            this.Controls.Add(this.ConputeButton);
            this.Controls.Add(this.InputButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InputTextBox);
            this.Controls.Add(this.ScoreListBox);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "稱機輸入與統計";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ScoreListBox;
        private System.Windows.Forms.TextBox InputTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button InputButton;
        private System.Windows.Forms.Button ConputeButton;
    }
}

