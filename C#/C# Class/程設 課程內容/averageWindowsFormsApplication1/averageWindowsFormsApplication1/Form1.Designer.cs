namespace averageWindowsFormsApplication1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FirstscoreTextBox = new System.Windows.Forms.TextBox();
            this.SecondscoreTextBox = new System.Windows.Forms.TextBox();
            this.ThirdscoreTextBox = new System.Windows.Forms.TextBox();
            this.OKButton = new System.Windows.Forms.Button();
            this.Averagelabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "第一次";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "第二次";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "第三次";
            // 
            // FirstscoreTextBox
            // 
            this.FirstscoreTextBox.Location = new System.Drawing.Point(185, 52);
            this.FirstscoreTextBox.Name = "FirstscoreTextBox";
            this.FirstscoreTextBox.Size = new System.Drawing.Size(100, 25);
            this.FirstscoreTextBox.TabIndex = 3;
            // 
            // SecondscoreTextBox
            // 
            this.SecondscoreTextBox.Location = new System.Drawing.Point(185, 145);
            this.SecondscoreTextBox.Name = "SecondscoreTextBox";
            this.SecondscoreTextBox.Size = new System.Drawing.Size(100, 25);
            this.SecondscoreTextBox.TabIndex = 4;
            // 
            // ThirdscoreTextBox
            // 
            this.ThirdscoreTextBox.Location = new System.Drawing.Point(185, 229);
            this.ThirdscoreTextBox.Name = "ThirdscoreTextBox";
            this.ThirdscoreTextBox.Size = new System.Drawing.Size(100, 25);
            this.ThirdscoreTextBox.TabIndex = 5;
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(12, 339);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(122, 30);
            this.OKButton.TabIndex = 6;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Averagelabel
            // 
            this.Averagelabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Averagelabel.Location = new System.Drawing.Point(361, 131);
            this.Averagelabel.Name = "Averagelabel";
            this.Averagelabel.Size = new System.Drawing.Size(134, 65);
            this.Averagelabel.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(373, 339);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 29);
            this.button1.TabIndex = 8;
            this.button1.Text = "End";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(199, 339);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(110, 29);
            this.ClearButton.TabIndex = 9;
            this.ClearButton.Text = "清除";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(356, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 28);
            this.label4.TabIndex = 10;
            this.label4.Text = "平均成績";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 429);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Averagelabel);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.ThirdscoreTextBox);
            this.Controls.Add(this.SecondscoreTextBox);
            this.Controls.Add(this.FirstscoreTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "計算三次小考平均成績";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FirstscoreTextBox;
        private System.Windows.Forms.TextBox SecondscoreTextBox;
        private System.Windows.Forms.TextBox ThirdscoreTextBox;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Label Averagelabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Label label4;
    }
}

