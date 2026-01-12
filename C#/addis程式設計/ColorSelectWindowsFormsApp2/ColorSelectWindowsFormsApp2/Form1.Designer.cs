namespace ColorSelectWindowsFormsApp2
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
            this.Red1RadioButton = new System.Windows.Forms.RadioButton();
            this.Blue1RadioButton = new System.Windows.Forms.RadioButton();
            this.Yellow1RadioButton = new System.Windows.Forms.RadioButton();
            this.Red2RadioButton = new System.Windows.Forms.RadioButton();
            this.Blue2RadioButton = new System.Windows.Forms.RadioButton();
            this.Yellow2RadioButton = new System.Windows.Forms.RadioButton();
            this.ColorSelect1GroupBox = new System.Windows.Forms.GroupBox();
            this.ColorSelect2GroupBox = new System.Windows.Forms.GroupBox();
            this.MixButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.EndButton = new System.Windows.Forms.Button();
            this.ColorSelect1GroupBox.SuspendLayout();
            this.ColorSelect2GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Red1RadioButton
            // 
            this.Red1RadioButton.AutoSize = true;
            this.Red1RadioButton.Location = new System.Drawing.Point(42, 37);
            this.Red1RadioButton.Name = "Red1RadioButton";
            this.Red1RadioButton.Size = new System.Drawing.Size(70, 29);
            this.Red1RadioButton.TabIndex = 0;
            this.Red1RadioButton.TabStop = true;
            this.Red1RadioButton.Text = "Red";
            this.Red1RadioButton.UseVisualStyleBackColor = true;
            // 
            // Blue1RadioButton
            // 
            this.Blue1RadioButton.AutoSize = true;
            this.Blue1RadioButton.Location = new System.Drawing.Point(42, 97);
            this.Blue1RadioButton.Name = "Blue1RadioButton";
            this.Blue1RadioButton.Size = new System.Drawing.Size(76, 29);
            this.Blue1RadioButton.TabIndex = 1;
            this.Blue1RadioButton.TabStop = true;
            this.Blue1RadioButton.Text = "Blue";
            this.Blue1RadioButton.UseVisualStyleBackColor = true;
            // 
            // Yellow1RadioButton
            // 
            this.Yellow1RadioButton.AutoSize = true;
            this.Yellow1RadioButton.Location = new System.Drawing.Point(42, 154);
            this.Yellow1RadioButton.Name = "Yellow1RadioButton";
            this.Yellow1RadioButton.Size = new System.Drawing.Size(97, 29);
            this.Yellow1RadioButton.TabIndex = 2;
            this.Yellow1RadioButton.TabStop = true;
            this.Yellow1RadioButton.Text = "Yellow";
            this.Yellow1RadioButton.UseVisualStyleBackColor = true;
            // 
            // Red2RadioButton
            // 
            this.Red2RadioButton.AutoSize = true;
            this.Red2RadioButton.Location = new System.Drawing.Point(38, 37);
            this.Red2RadioButton.Name = "Red2RadioButton";
            this.Red2RadioButton.Size = new System.Drawing.Size(70, 29);
            this.Red2RadioButton.TabIndex = 3;
            this.Red2RadioButton.TabStop = true;
            this.Red2RadioButton.Text = "Red";
            this.Red2RadioButton.UseVisualStyleBackColor = true;
            // 
            // Blue2RadioButton
            // 
            this.Blue2RadioButton.AutoSize = true;
            this.Blue2RadioButton.Location = new System.Drawing.Point(38, 97);
            this.Blue2RadioButton.Name = "Blue2RadioButton";
            this.Blue2RadioButton.Size = new System.Drawing.Size(76, 29);
            this.Blue2RadioButton.TabIndex = 4;
            this.Blue2RadioButton.TabStop = true;
            this.Blue2RadioButton.Text = "Blue";
            this.Blue2RadioButton.UseVisualStyleBackColor = true;
            // 
            // Yellow2RadioButton
            // 
            this.Yellow2RadioButton.AutoSize = true;
            this.Yellow2RadioButton.Location = new System.Drawing.Point(38, 154);
            this.Yellow2RadioButton.Name = "Yellow2RadioButton";
            this.Yellow2RadioButton.Size = new System.Drawing.Size(97, 29);
            this.Yellow2RadioButton.TabIndex = 5;
            this.Yellow2RadioButton.TabStop = true;
            this.Yellow2RadioButton.Text = "Yellow";
            this.Yellow2RadioButton.UseVisualStyleBackColor = true;
            // 
            // ColorSelect1GroupBox
            // 
            this.ColorSelect1GroupBox.Controls.Add(this.Yellow1RadioButton);
            this.ColorSelect1GroupBox.Controls.Add(this.Blue1RadioButton);
            this.ColorSelect1GroupBox.Controls.Add(this.Red1RadioButton);
            this.ColorSelect1GroupBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ColorSelect1GroupBox.Location = new System.Drawing.Point(106, 73);
            this.ColorSelect1GroupBox.Name = "ColorSelect1GroupBox";
            this.ColorSelect1GroupBox.Size = new System.Drawing.Size(271, 215);
            this.ColorSelect1GroupBox.TabIndex = 6;
            this.ColorSelect1GroupBox.TabStop = false;
            this.ColorSelect1GroupBox.Text = "Select the First Color";
            // 
            // ColorSelect2GroupBox
            // 
            this.ColorSelect2GroupBox.Controls.Add(this.Yellow2RadioButton);
            this.ColorSelect2GroupBox.Controls.Add(this.Blue2RadioButton);
            this.ColorSelect2GroupBox.Controls.Add(this.Red2RadioButton);
            this.ColorSelect2GroupBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ColorSelect2GroupBox.Location = new System.Drawing.Point(432, 73);
            this.ColorSelect2GroupBox.Name = "ColorSelect2GroupBox";
            this.ColorSelect2GroupBox.Size = new System.Drawing.Size(271, 215);
            this.ColorSelect2GroupBox.TabIndex = 7;
            this.ColorSelect2GroupBox.TabStop = false;
            this.ColorSelect2GroupBox.Text = "Select the Second Color";
            // 
            // MixButton
            // 
            this.MixButton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MixButton.Location = new System.Drawing.Point(106, 339);
            this.MixButton.Name = "MixButton";
            this.MixButton.Size = new System.Drawing.Size(100, 41);
            this.MixButton.TabIndex = 3;
            this.MixButton.Text = "Mix";
            this.MixButton.UseVisualStyleBackColor = true;
            this.MixButton.Click += new System.EventHandler(this.MixButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ClearButton.Location = new System.Drawing.Point(347, 339);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(100, 41);
            this.ClearButton.TabIndex = 8;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // EndButton
            // 
            this.EndButton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.EndButton.Location = new System.Drawing.Point(588, 339);
            this.EndButton.Name = "EndButton";
            this.EndButton.Size = new System.Drawing.Size(100, 41);
            this.EndButton.TabIndex = 9;
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
            this.Controls.Add(this.MixButton);
            this.Controls.Add(this.ColorSelect2GroupBox);
            this.Controls.Add(this.ColorSelect1GroupBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ColorSelect1GroupBox.ResumeLayout(false);
            this.ColorSelect1GroupBox.PerformLayout();
            this.ColorSelect2GroupBox.ResumeLayout(false);
            this.ColorSelect2GroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton Red1RadioButton;
        private System.Windows.Forms.RadioButton Blue1RadioButton;
        private System.Windows.Forms.RadioButton Yellow1RadioButton;
        private System.Windows.Forms.RadioButton Red2RadioButton;
        private System.Windows.Forms.RadioButton Blue2RadioButton;
        private System.Windows.Forms.RadioButton Yellow2RadioButton;
        private System.Windows.Forms.GroupBox ColorSelect1GroupBox;
        private System.Windows.Forms.GroupBox ColorSelect2GroupBox;
        private System.Windows.Forms.Button MixButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button EndButton;
    }
}

