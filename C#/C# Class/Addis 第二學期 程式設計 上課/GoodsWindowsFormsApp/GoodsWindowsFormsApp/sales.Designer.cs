namespace GoodsWindowsFormsApp
{
    partial class sales
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
            this.saleslistBox = new System.Windows.Forms.ListBox();
            this.showArraylistBox = new System.Windows.Forms.ListBox();
            this.ReadDataButton = new System.Windows.Forms.Button();
            this.ComputeButton = new System.Windows.Forms.Button();
            this.EndButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // saleslistBox
            // 
            this.saleslistBox.FormattingEnabled = true;
            this.saleslistBox.ItemHeight = 15;
            this.saleslistBox.Location = new System.Drawing.Point(12, 25);
            this.saleslistBox.Name = "saleslistBox";
            this.saleslistBox.Size = new System.Drawing.Size(713, 244);
            this.saleslistBox.TabIndex = 0;
            // 
            // showArraylistBox
            // 
            this.showArraylistBox.FormattingEnabled = true;
            this.showArraylistBox.ItemHeight = 15;
            this.showArraylistBox.Location = new System.Drawing.Point(12, 303);
            this.showArraylistBox.Name = "showArraylistBox";
            this.showArraylistBox.Size = new System.Drawing.Size(713, 214);
            this.showArraylistBox.TabIndex = 1;
            // 
            // ReadDataButton
            // 
            this.ReadDataButton.Location = new System.Drawing.Point(792, 79);
            this.ReadDataButton.Name = "ReadDataButton";
            this.ReadDataButton.Size = new System.Drawing.Size(272, 68);
            this.ReadDataButton.TabIndex = 2;
            this.ReadDataButton.Text = "從檔案讀取資料放入列表中";
            this.ReadDataButton.UseVisualStyleBackColor = true;
            this.ReadDataButton.Click += new System.EventHandler(this.ReadDataButton_Click);
            // 
            // ComputeButton
            // 
            this.ComputeButton.Location = new System.Drawing.Point(792, 214);
            this.ComputeButton.Name = "ComputeButton";
            this.ComputeButton.Size = new System.Drawing.Size(272, 55);
            this.ComputeButton.TabIndex = 3;
            this.ComputeButton.Text = "從listbox中讀取相關資料存入二維陣列";
            this.ComputeButton.UseVisualStyleBackColor = true;
            this.ComputeButton.Click += new System.EventHandler(this.ComputeButton_Click);
            // 
            // EndButton
            // 
            this.EndButton.Location = new System.Drawing.Point(792, 348);
            this.EndButton.Name = "EndButton";
            this.EndButton.Size = new System.Drawing.Size(272, 55);
            this.EndButton.TabIndex = 4;
            this.EndButton.Text = "Exit";
            this.EndButton.UseVisualStyleBackColor = true;
            this.EndButton.Click += new System.EventHandler(this.EndButton_Click);
            // 
            // sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 603);
            this.Controls.Add(this.EndButton);
            this.Controls.Add(this.ComputeButton);
            this.Controls.Add(this.ReadDataButton);
            this.Controls.Add(this.showArraylistBox);
            this.Controls.Add(this.saleslistBox);
            this.Name = "sales";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox saleslistBox;
        private System.Windows.Forms.ListBox showArraylistBox;
        private System.Windows.Forms.Button ReadDataButton;
        private System.Windows.Forms.Button ComputeButton;
        private System.Windows.Forms.Button EndButton;
    }
}

