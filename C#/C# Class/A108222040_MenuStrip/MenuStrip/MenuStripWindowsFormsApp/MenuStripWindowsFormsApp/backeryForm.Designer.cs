namespace MenuStripWindowsFormsApp
{
    partial class backeryForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.TimeTextBox = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SaveFilebutton = new System.Windows.Forms.Button();
            this.ReadFileButton = new System.Windows.Forms.Button();
            this.TimelistBox = new System.Windows.Forms.ListBox();
            this.Averagebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(49, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "輸入上網時間:";
            // 
            // TimeTextBox
            // 
            this.TimeTextBox.Location = new System.Drawing.Point(198, 67);
            this.TimeTextBox.Name = "TimeTextBox";
            this.TimeTextBox.Size = new System.Drawing.Size(100, 22);
            this.TimeTextBox.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // SaveFilebutton
            // 
            this.SaveFilebutton.Location = new System.Drawing.Point(63, 178);
            this.SaveFilebutton.Name = "SaveFilebutton";
            this.SaveFilebutton.Size = new System.Drawing.Size(109, 46);
            this.SaveFilebutton.TabIndex = 2;
            this.SaveFilebutton.Text = "存檔";
            this.SaveFilebutton.UseVisualStyleBackColor = true;
            this.SaveFilebutton.Click += new System.EventHandler(this.SaveFilebutton_Click);
            // 
            // ReadFileButton
            // 
            this.ReadFileButton.Location = new System.Drawing.Point(221, 178);
            this.ReadFileButton.Name = "ReadFileButton";
            this.ReadFileButton.Size = new System.Drawing.Size(109, 46);
            this.ReadFileButton.TabIndex = 3;
            this.ReadFileButton.Text = "讀檔";
            this.ReadFileButton.UseVisualStyleBackColor = true;
            this.ReadFileButton.Click += new System.EventHandler(this.ReadFileButton_Click);
            // 
            // TimelistBox
            // 
            this.TimelistBox.FormattingEnabled = true;
            this.TimelistBox.ItemHeight = 12;
            this.TimelistBox.Location = new System.Drawing.Point(408, 27);
            this.TimelistBox.Name = "TimelistBox";
            this.TimelistBox.Size = new System.Drawing.Size(227, 220);
            this.TimelistBox.TabIndex = 4;
            // 
            // Averagebutton
            // 
            this.Averagebutton.Location = new System.Drawing.Point(456, 303);
            this.Averagebutton.Name = "Averagebutton";
            this.Averagebutton.Size = new System.Drawing.Size(133, 49);
            this.Averagebutton.TabIndex = 5;
            this.Averagebutton.Text = "統計每日平均上網時間";
            this.Averagebutton.UseVisualStyleBackColor = true;
            this.Averagebutton.Click += new System.EventHandler(this.Averagebutton_Click);
            // 
            // backeryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Averagebutton);
            this.Controls.Add(this.TimelistBox);
            this.Controls.Add(this.ReadFileButton);
            this.Controls.Add(this.SaveFilebutton);
            this.Controls.Add(this.TimeTextBox);
            this.Controls.Add(this.label1);
            this.Name = "backeryForm";
            this.Text = "A108222040 潘凌徵";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TimeTextBox;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button SaveFilebutton;
        private System.Windows.Forms.Button ReadFileButton;
        private System.Windows.Forms.ListBox TimelistBox;
        private System.Windows.Forms.Button Averagebutton;
    }
}