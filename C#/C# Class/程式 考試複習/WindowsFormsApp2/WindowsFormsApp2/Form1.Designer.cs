namespace WindowsFormsApp2
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
            this.FruitListBox = new System.Windows.Forms.ListBox();
            this.FruitLabel = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FruitListBox
            // 
            this.FruitListBox.FormattingEnabled = true;
            this.FruitListBox.ItemHeight = 15;
            this.FruitListBox.Items.AddRange(new object[] {
            "西瓜",
            "葡萄",
            "香蕉"});
            this.FruitListBox.Location = new System.Drawing.Point(82, 54);
            this.FruitListBox.Name = "FruitListBox";
            this.FruitListBox.Size = new System.Drawing.Size(185, 94);
            this.FruitListBox.TabIndex = 0;
            this.FruitListBox.SelectedIndexChanged += new System.EventHandler(this.FruitListBox_SelectedIndexChanged);
            // 
            // FruitLabel
            // 
            this.FruitLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FruitLabel.Location = new System.Drawing.Point(419, 54);
            this.FruitLabel.Name = "FruitLabel";
            this.FruitLabel.Size = new System.Drawing.Size(100, 23);
            this.FruitLabel.TabIndex = 1;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(431, 125);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(75, 23);
            this.CalculateButton.TabIndex = 2;
            this.CalculateButton.Text = "選取";
            this.CalculateButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.FruitLabel);
            this.Controls.Add(this.FruitListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox FruitListBox;
        private System.Windows.Forms.Label FruitLabel;
        private System.Windows.Forms.Button CalculateButton;
    }
}

