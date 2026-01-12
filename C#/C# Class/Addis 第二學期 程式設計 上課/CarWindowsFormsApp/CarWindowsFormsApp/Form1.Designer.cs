namespace CarWindowsFormsApp
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
            this.AccelerateButton = new System.Windows.Forms.Button();
            this.BreakButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.YearLabel = new System.Windows.Forms.Label();
            this.SpeedLabel = new System.Windows.Forms.Label();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.SeeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AccelerateButton
            // 
            this.AccelerateButton.Location = new System.Drawing.Point(132, 266);
            this.AccelerateButton.Name = "AccelerateButton";
            this.AccelerateButton.Size = new System.Drawing.Size(192, 72);
            this.AccelerateButton.TabIndex = 0;
            this.AccelerateButton.Text = "加速";
            this.AccelerateButton.UseVisualStyleBackColor = true;
            this.AccelerateButton.Click += new System.EventHandler(this.AccelerateButton_Click);
            // 
            // BreakButton
            // 
            this.BreakButton.Location = new System.Drawing.Point(424, 266);
            this.BreakButton.Name = "BreakButton";
            this.BreakButton.Size = new System.Drawing.Size(192, 72);
            this.BreakButton.TabIndex = 1;
            this.BreakButton.Text = "減速";
            this.BreakButton.UseVisualStyleBackColor = true;
            this.BreakButton.Click += new System.EventHandler(this.BreakButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(175, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "年分：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(175, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 36);
            this.label2.TabIndex = 3;
            this.label2.Text = "車型：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(175, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 36);
            this.label3.TabIndex = 4;
            this.label3.Text = "速度：";
            // 
            // YearLabel
            // 
            this.YearLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.YearLabel.Location = new System.Drawing.Point(335, 67);
            this.YearLabel.Name = "YearLabel";
            this.YearLabel.Size = new System.Drawing.Size(137, 23);
            this.YearLabel.TabIndex = 5;
            // 
            // SpeedLabel
            // 
            this.SpeedLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SpeedLabel.Location = new System.Drawing.Point(335, 191);
            this.SpeedLabel.Name = "SpeedLabel";
            this.SpeedLabel.Size = new System.Drawing.Size(137, 23);
            this.SpeedLabel.TabIndex = 6;
            // 
            // ModelLabel
            // 
            this.ModelLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ModelLabel.Location = new System.Drawing.Point(335, 135);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(137, 23);
            this.ModelLabel.TabIndex = 7;
            // 
            // SeeButton
            // 
            this.SeeButton.Location = new System.Drawing.Point(280, 366);
            this.SeeButton.Name = "SeeButton";
            this.SeeButton.Size = new System.Drawing.Size(192, 72);
            this.SeeButton.TabIndex = 8;
            this.SeeButton.Text = "定速";
            this.SeeButton.UseVisualStyleBackColor = true;
            this.SeeButton.Click += new System.EventHandler(this.SeeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SeeButton);
            this.Controls.Add(this.ModelLabel);
            this.Controls.Add(this.SpeedLabel);
            this.Controls.Add(this.YearLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BreakButton);
            this.Controls.Add(this.AccelerateButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AccelerateButton;
        private System.Windows.Forms.Button BreakButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label YearLabel;
        private System.Windows.Forms.Label SpeedLabel;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.Button SeeButton;
    }
}

