namespace MenuStripWindowsFormsApp
{
    partial class surfingLoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TimetextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ComputeButton = new System.Windows.Forms.Button();
            this.TimeListBox = new System.Windows.Forms.ListBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // TimetextBox
            // 
            this.TimetextBox.Location = new System.Drawing.Point(273, 87);
            this.TimetextBox.Name = "TimetextBox";
            this.TimetextBox.Size = new System.Drawing.Size(100, 25);
            this.TimetextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(30, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "請輸入上網時間:";
            // 
            // ComputeButton
            // 
            this.ComputeButton.Location = new System.Drawing.Point(476, 76);
            this.ComputeButton.Name = "ComputeButton";
            this.ComputeButton.Size = new System.Drawing.Size(135, 48);
            this.ComputeButton.TabIndex = 2;
            this.ComputeButton.Text = "確定";
            this.ComputeButton.UseVisualStyleBackColor = true;
            this.ComputeButton.Click += new System.EventHandler(this.ComputeButton_Click);
            // 
            // TimeListBox
            // 
            this.TimeListBox.FormattingEnabled = true;
            this.TimeListBox.ItemHeight = 15;
            this.TimeListBox.Location = new System.Drawing.Point(128, 173);
            this.TimeListBox.Name = "TimeListBox";
            this.TimeListBox.Size = new System.Drawing.Size(559, 154);
            this.TimeListBox.TabIndex = 3;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(319, 357);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(189, 65);
            this.SaveButton.TabIndex = 4;
            this.SaveButton.Text = "將資料存入檔案";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // surfingLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.TimeListBox);
            this.Controls.Add(this.ComputeButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TimetextBox);
            this.Name = "surfingLoginForm";
            this.Text = "surfingLoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TimetextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ComputeButton;
        private System.Windows.Forms.ListBox TimeListBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}