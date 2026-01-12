namespace NameWindowsFormsApp
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
            this.BoyNameListBox = new System.Windows.Forms.ListBox();
            this.GirlNameListBox = new System.Windows.Forms.ListBox();
            this.BoyNameButton = new System.Windows.Forms.Button();
            this.GirlNameButton = new System.Windows.Forms.Button();
            this.EnterButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.EndButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BoyNameListBox
            // 
            this.BoyNameListBox.FormattingEnabled = true;
            this.BoyNameListBox.ItemHeight = 15;
            this.BoyNameListBox.Location = new System.Drawing.Point(425, 47);
            this.BoyNameListBox.Name = "BoyNameListBox";
            this.BoyNameListBox.Size = new System.Drawing.Size(200, 289);
            this.BoyNameListBox.TabIndex = 0;
            // 
            // GirlNameListBox
            // 
            this.GirlNameListBox.FormattingEnabled = true;
            this.GirlNameListBox.ItemHeight = 15;
            this.GirlNameListBox.Location = new System.Drawing.Point(722, 47);
            this.GirlNameListBox.Name = "GirlNameListBox";
            this.GirlNameListBox.Size = new System.Drawing.Size(200, 289);
            this.GirlNameListBox.TabIndex = 1;
            // 
            // BoyNameButton
            // 
            this.BoyNameButton.Location = new System.Drawing.Point(81, 47);
            this.BoyNameButton.Name = "BoyNameButton";
            this.BoyNameButton.Size = new System.Drawing.Size(116, 52);
            this.BoyNameButton.TabIndex = 2;
            this.BoyNameButton.Text = "讀取男生名字";
            this.BoyNameButton.UseVisualStyleBackColor = true;
            this.BoyNameButton.Click += new System.EventHandler(this.BoyNameButton_Click);
            // 
            // GirlNameButton
            // 
            this.GirlNameButton.Location = new System.Drawing.Point(81, 139);
            this.GirlNameButton.Name = "GirlNameButton";
            this.GirlNameButton.Size = new System.Drawing.Size(116, 52);
            this.GirlNameButton.TabIndex = 3;
            this.GirlNameButton.Text = "讀取女生名字";
            this.GirlNameButton.UseVisualStyleBackColor = true;
            this.GirlNameButton.Click += new System.EventHandler(this.GirlNameButton_Click);
            // 
            // EnterButton
            // 
            this.EnterButton.Location = new System.Drawing.Point(81, 212);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(116, 52);
            this.EnterButton.TabIndex = 4;
            this.EnterButton.Text = "Enter";
            this.EnterButton.UseVisualStyleBackColor = true;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(81, 284);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(116, 52);
            this.ClearButton.TabIndex = 5;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            // 
            // EndButton
            // 
            this.EndButton.Location = new System.Drawing.Point(81, 366);
            this.EndButton.Name = "EndButton";
            this.EndButton.Size = new System.Drawing.Size(116, 52);
            this.EndButton.TabIndex = 6;
            this.EndButton.Text = "End";
            this.EndButton.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(248, 228);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(104, 25);
            this.NameTextBox.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 471);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.EndButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.EnterButton);
            this.Controls.Add(this.GirlNameButton);
            this.Controls.Add(this.BoyNameButton);
            this.Controls.Add(this.GirlNameListBox);
            this.Controls.Add(this.BoyNameListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox BoyNameListBox;
        private System.Windows.Forms.ListBox GirlNameListBox;
        private System.Windows.Forms.Button BoyNameButton;
        private System.Windows.Forms.Button GirlNameButton;
        private System.Windows.Forms.Button EnterButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button EndButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox NameTextBox;
    }
}

