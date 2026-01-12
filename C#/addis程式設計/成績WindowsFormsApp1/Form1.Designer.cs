namespace 成績WindowsFormsApp1
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
            this.ScoreListbox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.InputTextBox = new System.Windows.Forms.TextBox();
            this.InputButton = new System.Windows.Forms.Button();
            this.ComputeButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.EndButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ScoreListbox
            // 
            this.ScoreListbox.FormattingEnabled = true;
            this.ScoreListbox.ItemHeight = 15;
            this.ScoreListbox.Location = new System.Drawing.Point(65, 59);
            this.ScoreListbox.Name = "ScoreListbox";
            this.ScoreListbox.Size = new System.Drawing.Size(120, 94);
            this.ScoreListbox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(248, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "輸入成績:";
            // 
            // InputTextBox
            // 
            this.InputTextBox.Location = new System.Drawing.Point(447, 70);
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(100, 25);
            this.InputTextBox.TabIndex = 2;
            // 
            // InputButton
            // 
            this.InputButton.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.InputButton.Location = new System.Drawing.Point(636, 70);
            this.InputButton.Name = "InputButton";
            this.InputButton.Size = new System.Drawing.Size(90, 39);
            this.InputButton.TabIndex = 3;
            this.InputButton.Text = "確定";
            this.InputButton.UseVisualStyleBackColor = true;
            this.InputButton.Click += new System.EventHandler(this.InputButton_Click);
            // 
            // ComputeButton
            // 
            this.ComputeButton.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ComputeButton.Location = new System.Drawing.Point(241, 182);
            this.ComputeButton.Name = "ComputeButton";
            this.ComputeButton.Size = new System.Drawing.Size(155, 43);
            this.ComputeButton.TabIndex = 4;
            this.ComputeButton.Text = "計算成績";
            this.ComputeButton.UseVisualStyleBackColor = true;
            this.ComputeButton.Click += new System.EventHandler(this.ComputeButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ClearButton.Location = new System.Drawing.Point(431, 182);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(116, 43);
            this.ClearButton.TabIndex = 5;
            this.ClearButton.Text = "clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // EndButton
            // 
            this.EndButton.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.EndButton.Location = new System.Drawing.Point(609, 182);
            this.EndButton.Name = "EndButton";
            this.EndButton.Size = new System.Drawing.Size(117, 43);
            this.EndButton.TabIndex = 6;
            this.EndButton.Text = "End";
            this.EndButton.UseVisualStyleBackColor = true;
            this.EndButton.Click += new System.EventHandler(this.EndButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EndButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.ComputeButton);
            this.Controls.Add(this.InputButton);
            this.Controls.Add(this.InputTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ScoreListbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ScoreListbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox InputTextBox;
        private System.Windows.Forms.Button InputButton;
        private System.Windows.Forms.Button ComputeButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button EndButton;
    }
}

