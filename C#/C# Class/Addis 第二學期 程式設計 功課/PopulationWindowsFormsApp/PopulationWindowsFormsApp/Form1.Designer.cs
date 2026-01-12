namespace PopulationWindowsFormsApp
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
            this.PopulationListBox = new System.Windows.Forms.ListBox();
            this.ReadPopulationButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.AverageButton = new System.Windows.Forms.Button();
            this.BestButton = new System.Windows.Forms.Button();
            this.LowestButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PopulationListBox
            // 
            this.PopulationListBox.FormattingEnabled = true;
            this.PopulationListBox.ItemHeight = 15;
            this.PopulationListBox.Location = new System.Drawing.Point(454, 59);
            this.PopulationListBox.Name = "PopulationListBox";
            this.PopulationListBox.Size = new System.Drawing.Size(182, 274);
            this.PopulationListBox.TabIndex = 0;
            // 
            // ReadPopulationButton
            // 
            this.ReadPopulationButton.Location = new System.Drawing.Point(110, 47);
            this.ReadPopulationButton.Name = "ReadPopulationButton";
            this.ReadPopulationButton.Size = new System.Drawing.Size(125, 62);
            this.ReadPopulationButton.TabIndex = 1;
            this.ReadPopulationButton.Text = "讀取人口";
            this.ReadPopulationButton.UseVisualStyleBackColor = true;
            this.ReadPopulationButton.Click += new System.EventHandler(this.ReadPopulationButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // AverageButton
            // 
            this.AverageButton.Location = new System.Drawing.Point(110, 140);
            this.AverageButton.Name = "AverageButton";
            this.AverageButton.Size = new System.Drawing.Size(125, 62);
            this.AverageButton.TabIndex = 2;
            this.AverageButton.Text = "平均成長";
            this.AverageButton.UseVisualStyleBackColor = true;
            this.AverageButton.Click += new System.EventHandler(this.AverageButton_Click);
            // 
            // BestButton
            // 
            this.BestButton.Location = new System.Drawing.Point(110, 231);
            this.BestButton.Name = "BestButton";
            this.BestButton.Size = new System.Drawing.Size(125, 62);
            this.BestButton.TabIndex = 3;
            this.BestButton.Text = "最大成長";
            this.BestButton.UseVisualStyleBackColor = true;
            this.BestButton.Click += new System.EventHandler(this.BestButton_Click);
            // 
            // LowestButton
            // 
            this.LowestButton.Location = new System.Drawing.Point(110, 328);
            this.LowestButton.Name = "LowestButton";
            this.LowestButton.Size = new System.Drawing.Size(125, 62);
            this.LowestButton.TabIndex = 4;
            this.LowestButton.Text = "最低成長";
            this.LowestButton.UseVisualStyleBackColor = true;
            this.LowestButton.Click += new System.EventHandler(this.LowestButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LowestButton);
            this.Controls.Add(this.BestButton);
            this.Controls.Add(this.AverageButton);
            this.Controls.Add(this.ReadPopulationButton);
            this.Controls.Add(this.PopulationListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox PopulationListBox;
        private System.Windows.Forms.Button ReadPopulationButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button AverageButton;
        private System.Windows.Forms.Button BestButton;
        private System.Windows.Forms.Button LowestButton;
    }
}

