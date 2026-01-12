namespace scoreWindowsFormsApplication
{
    partial class 成績輸入統計
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
            this.scorelistBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.inputtextBox = new System.Windows.Forms.TextBox();
            this.inputkbutton = new System.Windows.Forms.Button();
            this.clearbutton = new System.Windows.Forms.Button();
            this.Lbutton = new System.Windows.Forms.Button();
            this.Rbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // scorelistBox
            // 
            this.scorelistBox.FormattingEnabled = true;
            this.scorelistBox.ItemHeight = 21;
            this.scorelistBox.Location = new System.Drawing.Point(113, 96);
            this.scorelistBox.Name = "scorelistBox";
            this.scorelistBox.Size = new System.Drawing.Size(145, 172);
            this.scorelistBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "請輸入成績:";
            // 
            // inputtextBox
            // 
            this.inputtextBox.Location = new System.Drawing.Point(235, 309);
            this.inputtextBox.Name = "inputtextBox";
            this.inputtextBox.Size = new System.Drawing.Size(100, 33);
            this.inputtextBox.TabIndex = 2;
            // 
            // inputkbutton
            // 
            this.inputkbutton.Location = new System.Drawing.Point(113, 371);
            this.inputkbutton.Name = "inputkbutton";
            this.inputkbutton.Size = new System.Drawing.Size(145, 53);
            this.inputkbutton.TabIndex = 3;
            this.inputkbutton.Text = "確定";
            this.inputkbutton.UseVisualStyleBackColor = true;
            this.inputkbutton.Click += new System.EventHandler(this.inputkbutton_Click);
            // 
            // clearbutton
            // 
            this.clearbutton.Location = new System.Drawing.Point(113, 555);
            this.clearbutton.Name = "clearbutton";
            this.clearbutton.Size = new System.Drawing.Size(145, 53);
            this.clearbutton.TabIndex = 4;
            this.clearbutton.Text = "清除";
            this.clearbutton.UseVisualStyleBackColor = true;
            // 
            // Lbutton
            // 
            this.Lbutton.Location = new System.Drawing.Point(875, 577);
            this.Lbutton.Name = "Lbutton";
            this.Lbutton.Size = new System.Drawing.Size(145, 53);
            this.Lbutton.TabIndex = 5;
            this.Lbutton.Text = "離開";
            this.Lbutton.UseVisualStyleBackColor = true;
            // 
            // Rbutton
            // 
            this.Rbutton.Location = new System.Drawing.Point(113, 437);
            this.Rbutton.Name = "Rbutton";
            this.Rbutton.Size = new System.Drawing.Size(145, 53);
            this.Rbutton.TabIndex = 6;
            this.Rbutton.Text = "計算成績";
            this.Rbutton.UseVisualStyleBackColor = true;
            this.Rbutton.Click += new System.EventHandler(this.Rbutton_Click);
            // 
            // 成績輸入統計
            // 
            this.AcceptButton = this.inputkbutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 642);
            this.Controls.Add(this.Rbutton);
            this.Controls.Add(this.Lbutton);
            this.Controls.Add(this.clearbutton);
            this.Controls.Add(this.inputkbutton);
            this.Controls.Add(this.inputtextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.scorelistBox);
            this.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "成績輸入統計";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox scorelistBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputtextBox;
        private System.Windows.Forms.Button inputkbutton;
        private System.Windows.Forms.Button clearbutton;
        private System.Windows.Forms.Button Lbutton;
        private System.Windows.Forms.Button Rbutton;
    }
}

