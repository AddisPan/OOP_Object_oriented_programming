namespace CellphoneWindowsFormsApp
{
    partial class mainPhone
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SizeTextBox = new System.Windows.Forms.TextBox();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.ModelTextBox = new System.Windows.Forms.TextBox();
            this.BrandTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PhoneListBox = new System.Windows.Forms.ListBox();
            this.NewButton = new System.Windows.Forms.Button();
            this.DispalyButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SizeTextBox);
            this.groupBox1.Controls.Add(this.PriceTextBox);
            this.groupBox1.Controls.Add(this.ModelTextBox);
            this.groupBox1.Controls.Add(this.BrandTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(26, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(542, 365);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cellphone";
            // 
            // SizeTextBox
            // 
            this.SizeTextBox.Location = new System.Drawing.Point(190, 292);
            this.SizeTextBox.Name = "SizeTextBox";
            this.SizeTextBox.Size = new System.Drawing.Size(210, 43);
            this.SizeTextBox.TabIndex = 7;
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(190, 215);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(210, 43);
            this.PriceTextBox.TabIndex = 6;
            // 
            // ModelTextBox
            // 
            this.ModelTextBox.Location = new System.Drawing.Point(190, 137);
            this.ModelTextBox.Name = "ModelTextBox";
            this.ModelTextBox.Size = new System.Drawing.Size(210, 43);
            this.ModelTextBox.TabIndex = 5;
            // 
            // BrandTextBox
            // 
            this.BrandTextBox.Location = new System.Drawing.Point(190, 61);
            this.BrandTextBox.Name = "BrandTextBox";
            this.BrandTextBox.Size = new System.Drawing.Size(210, 43);
            this.BrandTextBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 36);
            this.label4.TabIndex = 3;
            this.label4.Text = "螢幕大小";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "價格";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "型號";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "品牌";
            // 
            // PhoneListBox
            // 
            this.PhoneListBox.FormattingEnabled = true;
            this.PhoneListBox.ItemHeight = 15;
            this.PhoneListBox.Location = new System.Drawing.Point(683, 65);
            this.PhoneListBox.Name = "PhoneListBox";
            this.PhoneListBox.Size = new System.Drawing.Size(376, 334);
            this.PhoneListBox.TabIndex = 8;
            // 
            // NewButton
            // 
            this.NewButton.Location = new System.Drawing.Point(143, 483);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(248, 62);
            this.NewButton.TabIndex = 9;
            this.NewButton.Text = "新增手機";
            this.NewButton.UseVisualStyleBackColor = true;
            this.NewButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // DispalyButton
            // 
            this.DispalyButton.Location = new System.Drawing.Point(739, 483);
            this.DispalyButton.Name = "DispalyButton";
            this.DispalyButton.Size = new System.Drawing.Size(248, 62);
            this.DispalyButton.TabIndex = 10;
            this.DispalyButton.Text = "列出手機清單";
            this.DispalyButton.UseVisualStyleBackColor = true;
            this.DispalyButton.Click += new System.EventHandler(this.DispalyButton_Click);
            // 
            // mainPhone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 617);
            this.Controls.Add(this.DispalyButton);
            this.Controls.Add(this.NewButton);
            this.Controls.Add(this.PhoneListBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "mainPhone";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox SizeTextBox;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.TextBox ModelTextBox;
        private System.Windows.Forms.TextBox BrandTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox PhoneListBox;
        private System.Windows.Forms.Button NewButton;
        private System.Windows.Forms.Button DispalyButton;
    }
}

